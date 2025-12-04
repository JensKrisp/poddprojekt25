using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Models
{
    public class Kategori
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Namn")]
        public string? Namn { get; set; }


        [BsonElement("PodcastIds")]
        public List<string>? PodcastIds { get; set; }
    }
}
