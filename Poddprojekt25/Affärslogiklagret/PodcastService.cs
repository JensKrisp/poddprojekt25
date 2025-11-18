using Dataåtkomstlagret;
using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public class PodcastService : IPodcastService
    {
        private readonly RssKlient rssKlient;
        private readonly PodcastRepository podcastRepo;
        private readonly AvsnittRepository avsnittRepo;
        private readonly IMongoClient mongoKlient;

        public PodcastService(RssKlient rssKlient, PodcastRepository podcastRepo, AvsnittRepository avsnittRepo, IMongoClient mongoKlient)
        {
            this.rssKlient = rssKlient;
            this.podcastRepo = podcastRepo;
            this.avsnittRepo = avsnittRepo;
            this.mongoKlient = mongoKlient;
        }

        //Hämta RSS-flöde och skapa podcast-objekt
        public async Task<Podcast> LäsPodcastFrånUrl(string url)
        {
            return await rssKlient.HämtaPodcast(url);
        }

        // Spara podcast och avsnitt i transaktion 
        public async Task SparaPodcastMedAvsnitt(Podcast podcast)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await podcastRepo.LäggTillAsync(podcast);

                foreach (var avsnitt in podcast.Avsnitt)
                {
                    avsnitt.PodcastId = podcast.Id;

                    avsnitt.Id = null; // MongoDB skapar id
                    await avsnittRepo.LäggTillAsync(avsnitt);
                }

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Hämta alla podcasts
        public async Task<List<Podcast>> HämtaAllaPodcast()
        {
            return await podcastRepo.HämtaAllaAsync();
        }

        // Uppdatera podcastnamn med transaktion
        public async Task UppdateraPodcastTitel(string podcastId, string nyTitel)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var podcast = await podcastRepo.HämtaMedIdAsync(podcastId);

                if (podcast == null)
                    throw new Exception("Podcast hittades inte.");

                podcast.Titel = nyTitel;

                await podcastRepo.UppdateraAsync(podcast, session);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // Uppdatera podcast-kategori med transaktion
        public async Task UppdateraPodcastKategori(string podcastId, string nyKategori)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var podcast = await podcastRepo.HämtaMedIdAsync(podcastId);
                if (podcast == null)
                    throw new Exception("Podcast hittades inte.");

                podcast.Kategori = nyKategori;

                await podcastRepo.UppdateraAsync(podcast, session);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }

        }

        // Radera podcast och avsnitt (transaktion)
        public async Task RaderaPodcast(string podcastId)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var allaAvsnitt = await avsnittRepo.HämtaAllaAsync();
                foreach (var a in allaAvsnitt.Where(a => a.PodcastId == podcastId))
                {
                    await avsnittRepo.TaBortAsync(a.Id);
                }

                await podcastRepo.TaBortAsync(podcastId);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }

        }
    }
}
