using Dataåtkomstlagret;
using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Affärslogiklagret
{
    public class KategoriService : IKategoriService
    {
        private readonly RssKlient rssKlient;
        private readonly IKategoriRepository kategoriRepo;
        private readonly IRepository<Podcast> podcastRepo;
        private readonly IMongoClient mongoKlient;

        public KategoriService(RssKlient rssKlient, IKategoriRepository kategoriRepo, IPodcastRepository podcastRepo, IMongoClient mongoKlient)
        {
            this.rssKlient = rssKlient;
            this.kategoriRepo = kategoriRepo;
            this.podcastRepo = podcastRepo;
            this.mongoKlient = mongoKlient;
        }


        public async Task<List<Kategori>> HämtaAllaKategorierAsync()
        {
            try
            {
                return await kategoriRepo.HämtaAllaAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Kunde inte hämta kategorier.", ex);
            }
        }



        public async Task<Kategori> SkapaKategoriAsync(string namn)
        {
            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new Exception("Kategorin måste ha ett namn.");
            }
            var befintligKategori = await kategoriRepo.HämtaMedNamnAsync(namn);
            if (befintligKategori != null)
            {
                throw new Exception("En kategori med detta namn finns redan.");
            }
            try
            {
                var kategori = new Kategori
                {
                    Namn = namn,
                    PodcastIds = new List<string>()
                };

                await kategoriRepo.LäggTillAsync(kategori);

                return kategori;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Kunde inte skapa kategori.", ex);
            }
        }


        public async Task ÄndraNamnPåKategoriAsync(string kategoriId, string nyttNamn)
        {
            if (string.IsNullOrWhiteSpace(nyttNamn))
            {
                throw new ArgumentException("Nytt kategorinamn får inte vara tomt.");
            }

            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);
                if (kategori == null)
                    throw new Exception("Kategorin hittades inte.");

                kategori.Namn = nyttNamn;

                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                throw new InvalidOperationException("Kunde inte uppdatera kategori.", ex);
            }
        }


        public async Task RaderaKategoriAsync(string kategoriId)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriRepo.TaBortAsync(kategoriId);
                await session.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                throw new InvalidOperationException("Kunde inte radera kategori.", ex);
            }
        }


        public async Task LäggTillPodcastIKategoriAsync(string kategoriId, string podcastId)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);
                if (kategori == null)
                    throw new Exception("Kategorin finns inte.");

                if (!kategori.PodcastIds.Contains(podcastId))
                    kategori.PodcastIds.Add(podcastId);

                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                throw new InvalidOperationException("Kunde inte lägga till podcast i kategori.", ex);
            }
        }


        public async Task TaBortPodcastFrånKategoriAsync(string kategoriId, string podcastId)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);

                if (kategori == null)
                    throw new InvalidOperationException("Kategorin finns inte.");

                kategori.PodcastIds.Remove(podcastId);

                await kategoriRepo.UppdateraAsync(kategori, session);
                await session.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }


        public async Task<List<Podcast>> HämtaPodcastsFörKategoriAsync(string kategoriId)
        {
            try
            {
                var kategori = await kategoriRepo.HämtaMedIdAsync(kategoriId);

                if (kategori == null)
                    return new List<Podcast>();

                var allaPodcasts = await podcastRepo.HämtaAllaAsync();

                return allaPodcasts
                                .Where(p => kategori.PodcastIds.Contains(p.Id))
                                .ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Kunde inte hämta podcasts för kategorin.", ex);
            }

        }



        public async Task<List<Kategori>> HämtaKategorierFörPodcastAsync(string podcastId)
        {
            if (string.IsNullOrWhiteSpace(podcastId))
            { return new List<Kategori>(); }

            var allaKategorier = await kategoriRepo.HämtaAllaAsync();
            var kategorierFörPodcast = allaKategorier.FindAll(k =>
                k.PodcastIds != null && k.PodcastIds.Contains(podcastId));

            return kategorierFörPodcast;
        }
    }
}
