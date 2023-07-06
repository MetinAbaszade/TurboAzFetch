using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class RegionLocale
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Region Region { get; set; }
        public Language Language { get; set; }

        public RegionLocale() { }

    }
}
