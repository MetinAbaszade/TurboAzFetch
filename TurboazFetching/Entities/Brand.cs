using Microsoft.EntityFrameworkCore;
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
        public string Name { get; set; } = string.Empty;
        public List<Model> Models { get; set; } = new();

        public Brand() {}

        public Brand(string name)
        { 
            Name = name;
        }
    }
}
