using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class PodcastRepository : IRepository<Podcast>
    {
        private readonly IMongoCollection<Podcast> podcastKollektion;
        public IMongoCollection<Podcast> PodcastCollection => podcastKollektion;


        public PodcastRepository()
        {

            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Poddprojekt25");
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

        public async Task<List<Podcast>> HämtaAllaAsync()
        {
            try
            {
                var filter = Builders<Podcast>.Filter.Empty;
                return await podcastKollektion.Find(filter).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte hämta podcasts från databasen.", ex);
            }
        }

        public async Task LäggTillAsync(Podcast podcast)
        {
            try
            {
                await podcastKollektion.InsertOneAsync(podcast);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte spara podcasts i databasen.", ex);
            }
        }

        public async Task UppdateraAsync(Podcast uppdateradPodcast, IClientSessionHandle session)
        {
            try
            {
                var filter = Builders<Podcast>.Filter.Eq(p => p.Id, uppdateradPodcast.Id);
                var updateResult = await podcastKollektion.ReplaceOneAsync(session, filter, uppdateradPodcast);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte uppdatera podcast i databasen.", ex);
            }
        }

        public async Task TaBortAsync(string id)
        {
            try
            {
                var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
                await podcastKollektion.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte radera podcast från databasen.", ex);
            }
        }
    }
}
