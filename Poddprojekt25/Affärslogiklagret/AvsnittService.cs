using Dataåtkomstlagret;
using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public class AvsnittService : IAvsnittService
    {
        private readonly IAvsnittRepository avsnittRepo;
        private readonly RssKlient rssKlient;
        private readonly IMongoClient mongoKlient;

        public AvsnittService(IAvsnittRepository avsnittRepo, RssKlient rssKlient, IMongoClient mongoKlient)
        {
            this.avsnittRepo = avsnittRepo;
            this.rssKlient = rssKlient;
            this.mongoKlient = mongoKlient;
        }


        public async Task<List<Avsnitt>> HämtaAvsnittFörPodcast(string podcastId)
        {
            var alla = await avsnittRepo.HämtaAllaAsync();
            return alla.Where(a => a.PodcastId == podcastId).ToList();
        }


        public async Task<List<Avsnitt>> HämtaAvsnittMellanDatum(DateTime datum1, DateTime datum2, Podcast podcast)
        {
            var alla = await avsnittRepo.HämtaAllaAsync();


            if (datum1 > datum2)
            {
                (datum1, datum2) = (datum2, datum1);
            }

            return alla
              .Where(a =>
                  a.Publiceringsdatum.HasValue &&
                  a.Publiceringsdatum.Value.Date >= datum1.Date &&
                  a.Publiceringsdatum.Value.Date <= datum2.Date
                    && a.PodcastId == podcast.Id
              )
              .ToList();
        }



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
