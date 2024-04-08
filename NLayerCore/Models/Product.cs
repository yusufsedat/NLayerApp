namespace NLayerCore.Models
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }

        public int Stock { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
