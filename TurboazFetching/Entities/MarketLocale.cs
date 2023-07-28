using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class MarketLocale
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Market Market { get; set; }
        public Language Language { get; set; }

        public MarketLocale()
        {
            
        }
    }
}
