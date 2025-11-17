//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
using System.Xml;
//using System.Xml.Linq;
using Models;
using System.ServiceModel.Syndication;

namespace Dataåtkomstlagret
{
    public class RssKlient
    {
        private readonly HttpClient enHttpKlient;

        public RssKlient(HttpClient httpKlient)
        {
            enHttpKlient = httpKlient;
        }
        //public async Task<Podcast> HämtaPodcast(string rssUrl)
        //{
        //    Stream dataStröm = await enHttpKlient.GetStreamAsync(rssUrl);
        //    XmlReader xmlLäsare = XmlReader.Create(dataStröm);
        //    SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

        //    xmlLäsare.Dispose();
        //    dataStröm.Dispose();

        //    Podcast podcast = new Podcast
        //    {
        //        Titel = dataFlöde.Title?.Text ?? "Okänd titel",
        //        URL = rssUrl,
        //        Kategori = "", // användaren väljer kategori senare
        //        Avsnitt = new List<Avsnitt>()
        //    };

        //    foreach (SyndicationItem item in dataFlöde.Items)
        //    {
        //        Avsnitt avsnitt = new Avsnitt
        //        {
        //            RssId = item.Id, // Hämtar det id RSS-flödet den givit podcasten
        //            Titel = item.Title?.Text ?? "Okänd titel",
        //            Beskrivning = item.Summary?.Text ?? "",
        //            Publiceringsdatum = item.PublishDate.UtcDateTime,
        //        };


        //        podcast.Avsnitt.Add(avsnitt);
        //    }

        //    return podcast;
        //}


        public async Task<List<Avsnitt>> HämtaAvsnitt(string rssUrl)
        {
            Stream dataStröm = await enHttpKlient.GetStreamAsync(rssUrl);
            XmlReader xmlLäsare = XmlReader.Create(dataStröm);
            SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

            xmlLäsare.Dispose();
            dataStröm.Dispose();

            List<Avsnitt> avsnittsLista = new List<Avsnitt>();
            foreach (SyndicationItem item in dataFlöde.Items)
            {
                Avsnitt avsnitt = new Avsnitt
                {
                    RssId = item.Id, // Hämtar det id RSS-flödet den givit podcasten
                    Titel = item.Title?.Text ?? "Okänd titel",
                    Beskrivning = item.Summary?.Text ?? "",
                    Publiceringsdatum = item.PublishDate.UtcDateTime,
                };


                avsnittsLista.Add(avsnitt);
            }

            return avsnittsLista;
        }
    }
}

