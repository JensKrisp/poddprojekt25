using Dataåtkomstlagret;
using MongoDB.Driver;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public class KategoriService : IKategoriService
    {
        private readonly RssKlient rssKlient;
        private readonly KategoriRepository kategoriRepo;
        private readonly PodcastRepository podcastRepo;
        private readonly IMongoClient mongoKlient;

        public KategoriService(RssKlient rssKlient, KategoriRepository kategoriRepo, PodcastRepository podcastRepo, IMongoClient mongoKlient)
        {
            this.rssKlient = rssKlient;
            this.kategoriRepo = kategoriRepo;
            this.podcastRepo = podcastRepo;
            this.mongoKlient = mongoKlient;
        }

        // Hämta alla kategorier
        public async Task<List<Kategori>> HämtaAllaKategorierAsync()
        {
            return await kategoriRepo.HämtaAllaAsync();
        }

        // Skapa kategorier
        public async Task<Kategori> SkapaKategoriAsync(string namn)
        {
            var kategori = new Kategori();
            {
                kategori.Namn = namn;
                kategori.PodcastIds = new List<string>();
            };

            await kategoriRepo.LäggTillAsync(kategori);

            return kategori;
        }

        // Byt namn på katgori
        public async Task ÄndraNamnPåKategoriAsync(string kategoriId, string nyttNamn)
        {
            var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);
            if (kategori == null)
                throw new Exception("Kategorin hittades inte.");

            kategori.Namn = nyttNamn;

            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Radera kategori
        public async Task RaderaKategoriAsync(string kategoriId)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriRepo.TaBortAsync(kategoriId);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Lägg till podcast i kategori
        public async Task LäggTillPodcastIKategoriAsync(string kategoriId, string podcastId)
        {
            var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);

            if (kategori == null)
                throw new Exception("Kategorin finns inte.");

            if (!kategori.PodcastIds.Contains(podcastId))
                kategori.PodcastIds.Add(podcastId);

            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Ta bort podcast från kategori
        public async Task TaBortPodcastFrånKategoriAsync(string kategoriId, string podcastId)
        {
            var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);

            if (kategori == null)
                throw new Exception("Kategorin finns inte.");

            kategori.PodcastIds.Remove(podcastId);

            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Hämta podcasts i en kategori
        public async Task<List<Podcast>> HämtaPodcastsFörKategoriAsync(string kategoriId)
        {
            var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);

            if (kategori == null)
                return new List<Podcast>();

            var allaPodcasts = await podcastRepo.HämtaAllaAsync();
            return allaPodcasts
                .Where(p => kategori.PodcastIds.Contains(p.Id))
                .ToList();
        }

    }
}
