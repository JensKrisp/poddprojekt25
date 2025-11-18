//using System;
//using System.Net.Http;
using System.Xml;
//using System.Xml.Linq;
using Models;
using System.ServiceModel.Syndication;

namespace Dataåtkomstlagret
{
    public class RssKlient
    {
        private readonly HttpClient enHttpKlient;

        public RssKlient(HttpClient enHttpKlient)
        {
            this.enHttpKlient = enHttpKlient;
        }
        public async Task<Podcast> HämtaPodcast(string rssUrl)
        {
            try
            {
                using Stream dataStröm = await enHttpKlient.GetStreamAsync(rssUrl);
                using XmlReader xmlLäsare = XmlReader.Create(dataStröm);
                SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

                if (dataFlöde == null)
                    throw new Exception("Kunde inte läsa RSS-flödet.");

                Podcast podcast = new Podcast
                {
                    Titel = dataFlöde.Title?.Text ?? "Okänd titel",
                    URL = rssUrl,
                    Kategori = "", // användaren väljer kategori senare
                    Avsnitt = new List<Avsnitt>()
                };

                foreach (SyndicationItem item in dataFlöde.Items)
                {
                    Avsnitt avsnitt = new Avsnitt
                    {
                        RssId = item.Id, // Hämtar det id RSS-flödet den givit podcasten
                        Titel = item.Title?.Text ?? "Okänd titel",
                        Beskrivning = item.Summary?.Text ?? "",
                        Publiceringsdatum = item.PublishDate.UtcDateTime,
                    };


                    podcast.Avsnitt.Add(avsnitt);
                }

                return podcast;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Kunde inte kontakta servern. Kontrollera din internetanslutning eller URL", ex);
            }
            catch (XmlException ex)
            {
                throw new Exception("RSS-flödet är ogiltigt eller skadat.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ett oväntat fel inträffade när RSS-flödet hämtades.", ex);
            }
        }


        public async Task<List<Avsnitt>> HämtaAvsnitt(string rssUrl)
        {
            try
            {
                using Stream dataStröm = await enHttpKlient.GetStreamAsync(rssUrl);
                using XmlReader xmlLäsare = XmlReader.Create(dataStröm);
                SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

                if (dataFlöde == null)
                    throw new Exception("Kunde inte läsa RSS-flöde.");

                
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
            catch (HttpRequestException ex)
            {
                throw new Exception("Kunde inte hämta avsnitt från servern. Kontrollera internetanslutning eller URL.", ex);
            }
            catch (XmlException ex)
            {
                throw new Exception("RSS-flödet är skadat eller ogiltigt.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ett oväntat fel inträffade när avsnitt lästes.", ex);
            }

        }
    }
}

