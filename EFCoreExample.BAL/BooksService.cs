using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EFCoreExample.BAL.Models;
using EFCoreExample.BAL.OutputModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.BAL
{
    public class BooksService : IBooksService
    {
        private readonly EfCoreContext _efCoreContext;
        private readonly IMapper _mapper;

        public BooksService(EfCoreContext efCoreContext, IMapper mapper)
        {
            _efCoreContext = efCoreContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var books = await _efCoreContext.Books.ToListAsync();

            return _mapper.Map<IEnumerable<Book>>(books);
        }

        public async Task AddBook(Book book)
        {
            await _efCoreContext.Books.AddAsync(_mapper.Map<DbBook>(book));

            await _efCoreContext.SaveChangesAsync();
        }
    }
}
