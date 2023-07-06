using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class FueltypeLocale
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Language Language { get; set; }
        public Fueltype Fueltype { get; set; }

        public FueltypeLocale() { }
    }
}
