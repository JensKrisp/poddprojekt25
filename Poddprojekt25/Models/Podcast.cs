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
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Titel")]
        public string Titel { get; set; }

        [BsonElement("URL")]
        public string URL { get; set; }

        [BsonElement("Kategori")]
        public string Kategori { get; set; }

        [BsonElement("Avsnitt")]
        public List<Avsnitt>? Avsnitt { get; set; }
    }
}
