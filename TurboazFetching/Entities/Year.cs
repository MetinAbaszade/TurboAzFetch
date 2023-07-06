using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Year
    {
        public int Id { get; set; }
        public ushort Value { get; set; }

        public Year() { }

        public Year(ushort value)
        { 
            Value = value;
        }
    }
}
