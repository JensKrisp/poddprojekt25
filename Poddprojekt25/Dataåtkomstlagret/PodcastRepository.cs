using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IRepository<Podcast>
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;

        public PodcastRepository(string connectionString)
        {

            var klient = new MongoClient(connectionString);
            var databas = klient.GetDatabase("Podprojekt25");
            podcastKollektion = databas.GetCollection<Podcast>("Podcasts");

        }
        public async Task<Podcast> HämtaMedIdAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            return await podcastKollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<List<Podcast>> HämtaAllaAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;
            return await podcastKollektion.Find(filter).ToListAsync();
        }

        public async Task LäggTillAsync(Podcast podcast)
        {
            await podcastKollektion.InsertOneAsync(podcast);
        }

        public async Task UppdateraAsync(Podcast uppdateradPodcast)
        {
            var filter= Builders<Podcast>.Filter.Eq(p => p.Id, uppdateradPodcast.Id);
            var updateResult= await podcastKollektion.ReplaceOneAsync(filter, uppdateradPodcast);
        }

        public async Task TaBortAsync(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            await podcastKollektion.DeleteOneAsync(filter);
        } 
    }
}
