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
        private readonly IPodcastRepository podcastRepo;
        private readonly IRepository<Avsnitt> avsnittRepo;
        private readonly IMongoClient mongoKlient;

        public PodcastService(RssKlient rssKlient, IPodcastRepository podcastRepo, IAvsnittRepository avsnittRepo, IMongoClient mongoKlient)
        {
            this.rssKlient = rssKlient;
            this.podcastRepo = podcastRepo;
            this.avsnittRepo = avsnittRepo;
            this.mongoKlient = mongoKlient;
        }


        public async Task<Podcast> LäsPodcastFrånUrl(string url)
        {
            return await rssKlient.HämtaPodcast(url);
        }


        public async Task SparaPodcastMedAvsnitt(Podcast podcast)
        {
            using var session = await mongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {

                var befintligPodcast = await podcastRepo.HämtaMedURLAsync(podcast.URL);
                if (befintligPodcast != null)
                {
                    throw new InvalidOperationException(" Podcasten finns redan sparad i databasen.");
                }

                await podcastRepo.LäggTillAsync(podcast);

                foreach (var avsnitt in podcast.Avsnitt)
                {
                    avsnitt.PodcastId = podcast.Id;

                    avsnitt.Id = null;
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


        public async Task<List<Podcast>> HämtaAllaPodcast()
        {
            return await podcastRepo.HämtaAllaAsync();
        }


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
