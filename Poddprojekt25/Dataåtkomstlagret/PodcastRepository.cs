using MongoDB.Driver;
using Models;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IPodcastRepository???
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;

        public PodcastRepository(string connectionString)
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:<db_password>@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Podprojekt25");
            podcastKollektion = databas.GetCollection<Podcast>("Podcasts");
        }

        public async Task AddAsync(Podcast podcast)
        {
            await podcastKollektion.InsertOneAsync(podcast);
        }
    }
}
