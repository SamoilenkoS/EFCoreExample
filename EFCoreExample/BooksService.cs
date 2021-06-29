using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreExample.BAL;
using EFCoreExample.BAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    public class BooksService
    {
        private readonly EfCoreContext _efCoreContext;

        public BooksService(EfCoreContext efCoreContext)
        {
            _efCoreContext = efCoreContext;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _efCoreContext.Books.ToListAsync();
        }

        public async Task AddBook(Book book)
        {
            await _efCoreContext.Books.AddAsync(book);
            await _efCoreContext.SaveChangesAsync();
        }
    }
}
