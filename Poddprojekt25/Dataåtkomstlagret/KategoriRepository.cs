using MongoDB.Driver;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dataåtkomstlagret
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly IMongoCollection<Kategori> kategoriKollektion;

        public KategoriRepository()
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("opponering");
            kategoriKollektion = databas.GetCollection<Kategori>("Kategorier");
        }

        
        public async Task<Kategori> HämtaMedIdAsync(string id)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
            return await kategoriKollektion.Find(filter).FirstOrDefaultAsync();
        }

        
        public async Task<List<Kategori>> HämtaAllaAsync()
        {
            var filter = Builders<Kategori>.Filter.Empty;
            return await kategoriKollektion.Find(filter).ToListAsync();
        }

        
        public async Task LäggTillAsync(Kategori kategori)
        {
            await kategoriKollektion.InsertOneAsync(kategori);
        }

        
        public async Task UppdateraAsync(Kategori uppdateradKategori, IClientSessionHandle session)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, uppdateradKategori.Id);
            await kategoriKollektion.ReplaceOneAsync(session, filter, uppdateradKategori);
        }

        
        public async Task TaBortAsync(string id)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
            await kategoriKollektion.DeleteOneAsync(filter);
        }
        public async Task<Kategori> HämtaMedNamnAsync(string namn)
        {
            try
            {
                var filter = Builders<Kategori>.Filter.Eq(k => k.Namn, namn);
                return await kategoriKollektion.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw new Exception("Kategorin finns redan sparad i databasen");
            }
        }
    }
}
