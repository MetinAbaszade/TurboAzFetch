using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Transmission
    {
        public int Id { get; set; }
        public List<TransmissionLocale> TransmissionLocales { get; set; } = new();

        public Transmission() { }
    }
}
