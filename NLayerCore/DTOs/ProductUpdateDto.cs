﻿namespace NLayerCore.DTOs
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
