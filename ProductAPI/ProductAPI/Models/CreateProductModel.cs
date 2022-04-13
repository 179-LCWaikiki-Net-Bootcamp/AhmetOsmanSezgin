namespace ProductAPI.Models
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
