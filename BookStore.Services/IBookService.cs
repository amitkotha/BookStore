using BookStore.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
  public interface IBookService
    {
        Task<IEnumerable<Book>> GetBookAsync();
        Task<Book> AddBookAsync(Book book);
        Task<Book> GetBookAsync(string id);
        Task DeleteBookAsync(string id);
    }
}
