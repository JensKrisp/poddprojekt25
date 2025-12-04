using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataåtkomstlagret
{
    public interface IAvsnittRepository : IRepository<Avsnitt>
    {
    }
}
