using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Models;
using Affärslogiklagret;
using Dataåtkomstlagret;

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

            var connectionString = konfiguration.GetConnectionString("Podprojekt25");

            // Skapa repositories
            var podcastRepository = new PodcastRepository();
            var avsnittRepository = new AvsnittRepository();
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(new PodcastAppService(klient)));

            
        }
    }
}