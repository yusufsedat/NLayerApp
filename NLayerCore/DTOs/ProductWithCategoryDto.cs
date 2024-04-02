﻿using NLayerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.DTOs
{
    public class ProductWithCategoryDto :ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}