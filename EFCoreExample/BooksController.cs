using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreExample.BAL.Models;

namespace EFCoreExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _booksService.GetAllBooks();
        }

        [HttpPost]
        public async Task AddBook(Book book)
        {
            book.Id = Guid.NewGuid();
            await _booksService.AddBook(book);
        }
    }
}
