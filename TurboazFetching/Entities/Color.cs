using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public List<ColorLocale> ColorLocales { get; set; } = new();

        public Color() {}
    }
}
