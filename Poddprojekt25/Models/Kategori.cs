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

        // Lista med podcast-ID:n som hör till denna kategori
        [BsonElement("PodcastIds")]
        public List<string>? PodcastIds { get; set; }
    }
}
