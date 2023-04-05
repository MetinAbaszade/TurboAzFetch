using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Region() {}

        public Region(string name)
        {
            Name = name;
        }
    }
}
