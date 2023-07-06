using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class FeatureLocale
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public Feature Feature { get; set; }
        public Language Language { get; set; }

        public FeatureLocale() { }
    }
}
