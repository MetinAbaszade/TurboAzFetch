using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class TransmissionLocale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Language Language { get; set; }
        public Transmission Transmission { get; set; }

        public TransmissionLocale() { }
    }
}
