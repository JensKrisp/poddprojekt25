using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataåtkomstlagret
{
    public interface IRepository<T>
    {
        Task<T> HämtaMedIdAsync(string id);
        Task<List<T>> HämtaAllaAsync();
        Task LäggTillAsync(T entitet);
        Task UppdateraAsync(T uppdatering);
        Task TaBortAsync(string id);
    }
}
