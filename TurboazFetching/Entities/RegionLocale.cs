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
        public int LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;

        public Region? Region { get; set; }
        public Language? Language { get; set; }

        public RegionLocale() { }

    }
}
