using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Published { get; set; }
        public string Link { get; set; }
        public string Guid { get; set; }
    }

}
