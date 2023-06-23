﻿using System;
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
        public int? BaseModelId { get; set; }

        public Model() { }

        public bool IsBaseModel()
        {
            return !BaseModelId.HasValue;
        }
    }
}
