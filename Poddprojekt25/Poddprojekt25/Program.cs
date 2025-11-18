using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Models;
using Affärslogiklagret;
using Dataåtkomstlagret;
using MongoDB.Driver;

namespace Poddprojekt25
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            HttpClient http = new HttpClient();
            var klient = new RssKlient(http);
            var konfiguration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = konfiguration.GetConnectionString("PodcastDatabase");

            var MongoClient = new MongoClient(connectionString);
            try { 
                MongoClient.ListDatabaseNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ansluta till databasen. Kontrollera att MongoDB är igång och att anslutningssträngen är korrekt.\nFelmeddelande: " + ex.Message, "Databasanslutningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Skapa repositories
            var podcastRepository = new PodcastRepository(MongoClient);
            var avsnittRepository = new AvsnittRepository(MongoClient);

           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
         
            var service = new PodcastAppService(klient, podcastRepository, avsnittRepository, MongoClient);

            Application.Run(new Form1(service));

            
        }
    }
}