using BookStore.Services.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Services
{
    public class DbClient:IDbClient
    {
        private readonly IMongoCollection<Book> _books;
        public DbClient(IOptions<MongoDbConfig> bookStoreDbConfig)
        {
            var client = new MongoClient(bookStoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookStoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookStoreDbConfig.Value.Collection_Name);
        }

        public IMongoCollection<Book> GetBooksCollection()
        {
            return _books;
        }
    }
}
