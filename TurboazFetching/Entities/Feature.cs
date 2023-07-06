using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public List<Car> Cars { get; set; } = new();
        public List<FeatureLocale> FeatureLocales { get; set; }

        public Feature() { }
    }
}
