using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class AutoSalon
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public string CoverUrl { get; set; } = string.Empty;
        public string? LocationUrl { get; set; }
        public List<AutoSalonLocale> AutoSalonLocales { get; set; } = new();

        public AutoSalon() { }

        public ICollection<Car>? Cars { get; set; }
    }
}
