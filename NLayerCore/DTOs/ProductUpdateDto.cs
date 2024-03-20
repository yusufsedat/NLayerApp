﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.DTOs
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }
    }
}
