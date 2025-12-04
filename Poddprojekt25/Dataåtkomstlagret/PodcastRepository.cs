using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IPodcastRepository
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;
        public IMongoCollection<Podcast> PodcastCollection => podcastKollektion;


        public PodcastRepository()
        {

            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("opponering");
            podcastKollektion = databas.GetCollection<Podcast>("Podcasts");

        }

        
        public async Task<Podcast> HämtaMedIdAsync(string id)
        {
            try
            {
                var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
                return await podcastKollektion.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte hämta podcast från databasen.", ex);
            }
        }

        
        public async Task<Podcast> HämtaMedURLAsync(string url)
        {
                var filter = Builders<Podcast>.Filter.Eq(p => p.URL, url);
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

        
        public async Task UppdateraAsync(Podcast uppdateradPodcast, IClientSessionHandle session)
        {
                var filter = Builders<Podcast>.Filter.Eq(p => p.Id, uppdateradPodcast.Id);
                var updateResult = await podcastKollektion.ReplaceOneAsync(session, filter, uppdateradPodcast);
        }

        
        public async Task TaBortAsync(string id)
        {
                var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
                await podcastKollektion.DeleteOneAsync(filter);
           
        }
    }
}
