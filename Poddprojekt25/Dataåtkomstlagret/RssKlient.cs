using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Models;
using System.ServiceModel.Syndication;

namespace Dataåtkomstlagret
{
    public class RssKlient
    {
        private HttpClient enHttpKlient;

        public RssKlient(HttpClient enHttpKlient)
        {
            this.enHttpKlient = enHttpKlient;
        }
        public async Task<Podcast> HämtaPodcast(string rssUrl)
        {
            Stream dataStröm = await this.enHttpKlient.GetStreamAsync(rssUrl);
            XmlReader xmlLäsare = XmlReader.Create(dataStröm);
            SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

            xmlLäsare.Dispose();
            dataStröm.Dispose();

            List<Podcast> podcastLista = new List<Podcast>();

            foreach (SyndicationItem item in dataFlöde.Items)
            {
                Podcast enPodcast = new Podcast(); // Här skapas nyhetsobjekten
                enPodcast.Id = item.Id.ToString(); // Hämtar det id RSS-flödet den givit podcasten
                enPodcast.Titel = item.Title.Text();
                enPodcast.URL = item.Link.First().Uri.ToString();

                podcastLista.Add(enPodcast);
            }

            return podcastLista;
        }
    }
}
