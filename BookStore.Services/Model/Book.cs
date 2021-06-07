﻿using MongoDB.Bson.Serialization.Attributes;

namespace BookStore.Services.Model
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
