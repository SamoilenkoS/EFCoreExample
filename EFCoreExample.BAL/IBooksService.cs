using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreExample.BAL.Models;

namespace EFCoreExample.BAL
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task AddBook(Book book);
    }
}
