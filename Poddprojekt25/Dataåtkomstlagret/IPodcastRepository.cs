using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataåtkomstlagret
{
     public interface IPodcastRepository : IRepository<Podcast>

    {
        Task<Podcast> HämtaMedURLAsync(string url);
    }
}
