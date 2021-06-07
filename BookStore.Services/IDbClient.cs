using BookStore.Services.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}
