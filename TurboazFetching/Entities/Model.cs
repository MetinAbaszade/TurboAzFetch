using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Model() {}

        public Model(int id, string name, int brandId)
        {
            Id = id;
            Name = name;
            BrandId = brandId;
        }
    }
}
