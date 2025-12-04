using System.Xml;
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

   

                Podcast podcast = new Podcast
                {
                    Titel = dataFlöde.Title?.Text ?? "Okänd titel",
                    URL = rssUrl,
                    Kategori = "", 
                    Avsnitt = new List<Avsnitt>()
                };

                foreach (SyndicationItem item in dataFlöde.Items)
                {
                    Avsnitt avsnitt = new Avsnitt
                    {
                        RssId = item.Id, 
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
                throw new Exception(". Kunde inte kontakta servern. Kontrollera din internetanslutning eller URL.", ex);
            }
            catch (XmlException ex)
            {
                throw new Exception(". RSS-flödet är ogiltigt eller skadat.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(". Kunde inte hämta podcast eftersom URL inte kunde läsas.", ex);
            }
        }


        
        public async Task<List<Avsnitt>> HämtaAvsnitt(string rssUrl)
        {
            try
            {
                using Stream dataStröm = await enHttpKlient.GetStreamAsync(rssUrl);
                using XmlReader xmlLäsare = XmlReader.Create(dataStröm);
                SyndicationFeed dataFlöde = SyndicationFeed.Load(xmlLäsare);

                
                List<Avsnitt> avsnittsLista = new List<Avsnitt>();

                foreach (SyndicationItem item in dataFlöde.Items)
                {
                    Avsnitt avsnitt = new Avsnitt
                    {
                        RssId = item.Id, 
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
                throw new Exception(". Kunde inte hämta avsnitt från servern. Kontrollera internetanslutning eller URL.", ex);
            }
            catch (XmlException ex)
            {
                throw new Exception(". RSS-flödet är ogiltigt.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(". Kunde inte hämta avsnitt eftersom URL inte kunde läsas.", ex);
            }

        }
    }
}

