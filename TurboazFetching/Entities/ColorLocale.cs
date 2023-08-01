using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class ColorLocale
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; } = string.Empty;

        public Color? Color { get; set; }
        public Language? Language { get; set; }

        public ColorLocale() { }
    }
}
