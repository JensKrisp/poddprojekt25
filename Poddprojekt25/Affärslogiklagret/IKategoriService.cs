using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public interface IKategoriService
    {
        Task<List<Kategori>> HämtaAllaKategorierAsync();
        Task<Kategori> SkapaKategoriAsync(string namn);
        Task ÄndraNamnPåKategoriAsync(string kategoriId, string nyttNamn);
        Task RaderaKategoriAsync(string kategoriId);
        Task LäggTillPodcastIKategoriAsync(string kategoriId, string podcastId);
        Task TaBortPodcastFrånKategoriAsync(string kateg, string podcastId);
        Task<List<Podcast>> HämtaPodcastsFörKategoriAsync(string kategoriId);
    }
}
