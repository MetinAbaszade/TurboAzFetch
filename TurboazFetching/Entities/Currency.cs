using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Currency() { }

        public Currency(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
