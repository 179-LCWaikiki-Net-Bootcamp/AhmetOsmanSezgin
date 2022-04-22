using System.Collections.Generic;
using ProductAPI.Models;

namespace ProductAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
