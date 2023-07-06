using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class AutoSalonLocale
    {
        public int Id { get; set; }
        public string Slogan { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Language Language { get; set; }
        public AutoSalon AutoSalon { get; set; }

        public AutoSalonLocale() { }
    }
}
