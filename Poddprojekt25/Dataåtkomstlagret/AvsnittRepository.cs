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

        public AvsnittRepository(string connectionString)
        {
            var klient = new MongoClient(connectionString);
            var databas = klient.GetDatabase("Podprojekt25");
            avsnittKollektion = databas.GetCollection<Avsnitt>("Avsnitt");
        }

        public async Task<Avsnitt> HämtaMedIdAsync(string id)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, id);
            return await avsnittKollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<List<Avsnitt>> HämtaAllaAsync()
        {
            var filter = Builders<Avsnitt>.Filter.Empty;
            return await avsnittKollektion.Find(filter).ToListAsync();
        }

        public async Task LäggTillAsync(Avsnitt avsnitt)
        {
            await avsnittKollektion.InsertOneAsync(avsnitt);
        }

        public async Task UppdateraAsync(Avsnitt uppdateradAvsnitt)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, uppdateradAvsnitt.Id);
            var updateResult = await avsnittKollektion.ReplaceOneAsync(filter, uppdateradAvsnitt);
        }

        public async Task TaBortAsync(string id)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(p => p.Id, id);
            await avsnittKollektion.DeleteOneAsync(filter);
        }

    }
}
