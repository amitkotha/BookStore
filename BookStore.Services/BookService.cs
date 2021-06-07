using BookStore.Services.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;
        public BookService(IDbClient dbClient)
        {
            _books = dbClient.GetBooksCollection();
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            await _books.InsertOneAsync(book);
            return book;
        }

        public async Task<IEnumerable<Book>> GetBookAsync()
        {

            return await _books.Find(book => true).ToListAsync();
           
        }

        public async Task<Book> GetBookAsync(string id)
        {
            return await _books.Find(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task DeleteBookAsync(string id)
        {
            await _books.DeleteOneAsync(m => m.Id == id);
        }
    }
}
