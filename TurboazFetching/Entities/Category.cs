﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Category
    {
        public int Id { get; set; } 
        public List<CategoryLocale> CategoryLocales { get; set; } = new();

        public Category() {}
    }
}
