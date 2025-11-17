using Dataåtkomstlagret;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public class PodcastAppService
    {
        private RssKlient rssKlient;

        public PodcastAppService(RssKlient rssKlient)
        {
            this.rssKlient = rssKlient;
        }

        public async Task<List<Avsnitt>> LäsInAllaAvsnitt(Podcast enPodcast)
        {
            var allaAvsnitt = await rssKlient.HämtaAvsnitt(enPodcast.URL);

            foreach (var ettAvsnitt in allaAvsnitt)
            {
                ettAvsnitt.PodcastId = enPodcast.Id;
                ettAvsnitt.Id = enPodcast.Id + "-->" + ettAvsnitt.Id;
            }

            return allaAvsnitt;
        }
    }
}
