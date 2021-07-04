using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreExample.BAL.Models;
using EFCoreExample.BAL;

namespace EFCoreExample
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
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
            await _booksService.AddBook(book);
        }
    }
}