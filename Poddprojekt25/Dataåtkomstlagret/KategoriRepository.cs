using MongoDB.Driver;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dataåtkomstlagret
{
    public class KategoriRepository : IRepository<Kategori>
    {
        private readonly IMongoCollection<Kategori> kategoriKollektion;

        public KategoriRepository()
        {
            var klient = new MongoClient("mongodb+srv://minnaseger_db_user:Hejsanhoppsan123@cluster0.n1t8w3b.mongodb.net/?appName=Cluster0");
            var databas = klient.GetDatabase("Poddprojekt25");
            kategoriKollektion = databas.GetCollection<Kategori>("Kategorier");
        }

        // Hämta kategori med Id
        public async Task<Kategori> HämtaMedIdAsync(string id)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
            return await kategoriKollektion.Find(filter).FirstOrDefaultAsync();
        }

        // Hämta alla kategorier
        public async Task<List<Kategori>> HämtaAllaAsync()
        {
            var filter = Builders<Kategori>.Filter.Empty;
            return await kategoriKollektion.Find(filter).ToListAsync();
        }

        // Lägg till ny kategori
        public async Task LäggTillAsync(Kategori kategori)
        {
            await kategoriKollektion.InsertOneAsync(kategori);
        }

        // Uppdatera kategori
        public async Task UppdateraAsync(Kategori uppdateradKategori, IClientSessionHandle session)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, uppdateradKategori.Id);
            await kategoriKollektion.ReplaceOneAsync(session, filter, uppdateradKategori);
        }

        // Ta bort kategori med Id
        public async Task TaBortAsync(string id)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
            await kategoriKollektion.DeleteOneAsync(filter);
        }
    }
}
