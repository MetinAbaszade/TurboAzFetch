﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Fueltype
    {
        public int Id { get; set; }
        public List<FueltypeLocale> FueltypeLocales { get; set; } = new();

        public Fueltype() { }
    }
}
