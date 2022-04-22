using Bogus;

namespace ProductAPI.Models
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public static Faker<Category> CategoryFaker = new Faker<Category>()
            .RuleFor(c => c.Description, f => f.Lorem.Sentence())
            .RuleFor(c => c.Name, f => f.Commerce.Categories(1)[0]);

        public static Faker<CreateProductModel> FakeData {get; } = new Faker<CreateProductModel>()
            .RuleFor(s => s.Name, f => f.Commerce.Product())
            .RuleFor(s => s.Stock, f => f.Random.Int(0, 100))
            .RuleFor(s => s.Price, f => f.Random.Int(10, 100))
            .RuleFor(c => c.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.Category, f => CategoryFaker.Generate());   
    }
}
