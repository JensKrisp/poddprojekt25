using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IPodcastRepository
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;

        public PodcastRepository(string connectionString)
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123!@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Podprojekt25");
            podcastKollektion = databas.GetCollection<Podcast>("Podcasts");
        }

        public async Task AddAsync(Podcast podcast)
        {
            await podcastKollektion.InsertOneAsync(podcast);
        }

        public async Task<List<Podcast>> GetAllAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;
            return await podcastKollektion.Find(filter).ToListAsync();
        }


        public async Task DeleteAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
                await podcastKollektion.DeleteOneAsync(filter);
            
           
        }

        public async Task<Podcast> GetByIdAsync(string id)
        {
            var filter=Builders<Podcast>.Filter.Eq(p => p.Id, id);
            return await podcastKollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Podcast podcast)

        {
            var filter= Builders<Podcast>.Filter.Eq(p => p.Id, podcast.Id);
            var updateResult= await podcastKollektion.ReplaceOneAsync(filter, podcast);
        }
    }
}
