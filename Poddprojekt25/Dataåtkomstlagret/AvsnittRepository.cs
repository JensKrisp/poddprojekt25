using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace Dataåtkomstlagret
{
    public class AvsnittRepository : IRepository<Avsnitt>
    {
        private readonly IMongoCollection<Avsnitt> avsnittKollektion;

        public AvsnittRepository()
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123!@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Poddprojekt25");
            avsnittKollektion = databas.GetCollection<Avsnitt>("Avsnitt");
        }

        public async Task<Avsnitt> HämtaMedIdAsync(string id)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, id);
                return await avsnittKollektion.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte hämta avsnitt från databasen.", ex);
            }
        }

        public async Task<List<Avsnitt>> HämtaAllaAsync()
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Empty;
                return await avsnittKollektion.Find(filter).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte hämta avsnitt från databasen.", ex);
            }
        }

        public async Task LäggTillAsync(Avsnitt avsnitt)
        {
            try
            {
                await avsnittKollektion.InsertOneAsync(avsnitt);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte spara avsnitt i databasen.", ex);
            }
        }

        public async Task UppdateraAsync(Avsnitt uppdateradAvsnitt, IClientSessionHandle session)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, uppdateradAvsnitt.Id);
                var updateResult = await avsnittKollektion.ReplaceOneAsync(session, filter, uppdateradAvsnitt);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte uppdatera avsnitt i databasen.", ex);
            }
        }

        public async Task TaBortAsync(string id)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, id);
                await avsnittKollektion.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Kunde inte radera avsnitt från databasen.", ex);
            }
        }
    }
}
