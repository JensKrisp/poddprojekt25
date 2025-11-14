using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Titel")]
        public string Titel { get; set; }

        [BsonElement("Beskrivning")]
        public string Beskrivning { get; set; }

        [BsonElement("Publiceringsdatum")]
        public DateTime? Publiceringsdatum { get; set; }

        //[BsonElement("URL")]
        //public string URL { get; set; }

        [BsonElement("PodcastId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? PodcastId { get; set; }
    }

}
