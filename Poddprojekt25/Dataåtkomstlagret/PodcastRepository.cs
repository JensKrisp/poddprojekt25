using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IPodcastRepository
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;

        public PodcastRepository(string connectionString)
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:<Hejsanhoppsan123!>@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Podprojekt25");
            podcastKollektion = databas.GetCollection<Podcast>("Podcasts");
        }

        public async Task AddAsync(Podcast podcast)
        {
            await podcastKollektion.InsertOneAsync(podcast);
        }

        public async Task<IEnumerable<Podcast>> GetAllAsync()
        {
            return await podcastKollektion.Find(_ => true).ToListAsync();
        }

        public async Task DeleteAsync(string id)
        {
            await podcastKollektion.DeleteOneAsync(p => p.Id == MongoDB.Bson.ObjectId.Parse(id));
        }

        public async Task<Podcast> GetByIdAsync(string id)
        {
            return await podcastKollektion.Find(p => p.Id == MongoDB.Bson.ObjectId.Parse(id)).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Podcast podcast)
        {
            await podcastKollektion.ReplaceOneAsync(p => p.Id == podcast.Id, podcast);
        }
    }
}
