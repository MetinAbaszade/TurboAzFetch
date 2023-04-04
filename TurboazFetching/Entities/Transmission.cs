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
        public string Name { get; set; }

        public Transmission() { }

        public Transmission(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
