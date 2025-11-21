using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public interface IPodcastService : IService<Podcast>
    {
        Task<Podcast> LäsPodcastFrånUrl(string url);

        Task SparaPodcastMedAvsnitt(Podcast podcast);

        Task<List<Podcast>> HämtaAllaPodcast();

        Task UppdateraPodcastTitel(string podcastId, string nyTitel);

        Task UppdateraPodcastKategori(string podcastId, string nyKategori); // ska kanske ligga i KategoriService

        Task RaderaPodcast(string podcastId);
    }
}
