using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
    public class Podcast
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }         
        public string FeedUrl { get; set; }       
        public string Category { get; set; } 
        public DateTime CreatedAt { get; set; }
        public List<Avsnitt> Episodes { get; set; } = new();
    }
}
