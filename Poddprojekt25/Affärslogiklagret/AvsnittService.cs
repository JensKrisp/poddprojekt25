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
    public class AvsnittService : IAvsnittService
    {
        private readonly AvsnittRepository avsnittRepo;
        private readonly RssKlient rssKlient;
        private readonly IMongoClient mongoKlient;

        public AvsnittService(AvsnittRepository avsnittRepo, RssKlient rssKlient, IMongoClient mongoKlient)
        {
            this.avsnittRepo = avsnittRepo;
            this.rssKlient = rssKlient;
            this.mongoKlient = mongoKlient;
        }

        // Hämta avsnitt för en podcast 
        public async Task<List<Avsnitt>> HämtaAvsnittFörPodcast(string podcastId)
        {
            var alla = await avsnittRepo.HämtaAllaAsync();
            return alla.Where(a => a.PodcastId == podcastId).ToList();
        }

        // Läs in alla avsnitt från RSS-flöde för en podcast
        public async Task<List<Avsnitt>> LäsInAllaAvsnitt(Podcast enPodcast)
        {
            try
            {
                var allaAvsnitt = await rssKlient.HämtaAvsnitt(enPodcast.URL);
                foreach (var ettAvsnitt in allaAvsnitt)
                {
                    ettAvsnitt.PodcastId = enPodcast.Id;
                    ettAvsnitt.Id = null; 
                }
                return allaAvsnitt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Kunde inte läsa in avsnitt från podcast: {enPodcast.Titel}, URL: {enPodcast.URL}", ex);
            }
        }

    }
}
