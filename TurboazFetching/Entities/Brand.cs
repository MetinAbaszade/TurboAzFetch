using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }

        public Brand() {}

        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
