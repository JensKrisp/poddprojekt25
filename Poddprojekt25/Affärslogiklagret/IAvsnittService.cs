using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslogiklagret
{
    public interface IAvsnittService
    {
        Task<List<Avsnitt>> HämtaAvsnittFörPodcast(string podcastId);
        Task<List<Avsnitt>> LäsInAllaAvsnitt(Podcast enPodcast);
    }
}
