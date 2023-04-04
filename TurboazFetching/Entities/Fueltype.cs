using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Fueltype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Fueltype() { }

        public Fueltype(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
