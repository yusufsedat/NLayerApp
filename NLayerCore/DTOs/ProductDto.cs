namespace NLayerCore.DTOs
{
    public class ProductDto : BaseDto
    {

        public string Name { get; set; }

        public int Stock { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }
    }
}
