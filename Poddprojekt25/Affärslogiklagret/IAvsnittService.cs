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
        Task<List<Avsnitt>> HämtaAvsnittMellanDatum(DateTime datum1, DateTime datum2,Podcast podcast);
          
      

    }
}
