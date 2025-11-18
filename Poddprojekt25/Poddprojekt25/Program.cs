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
            HttpClient http = new HttpClient();
            var klient = new RssKlient(http);
            var konfiguration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = konfiguration.GetConnectionString("Poddprojekt25");

            var MongoClient = new MongoClient(connectionString);

            
            // Skapa repositories
            var podcastRepository = new PodcastRepository();
            var avsnittRepository = new AvsnittRepository();

            var service = new PodcastAppService(klient, podcastRepository, avsnittRepository, MongoClient);

           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(service));

            
        }
    }
}