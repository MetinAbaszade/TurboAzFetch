using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }

        public Category() {}

        public Category(int id, string name, Image image)
        {
            Id = id;
            Name = name;
            Image = image;
        }
    }
}
