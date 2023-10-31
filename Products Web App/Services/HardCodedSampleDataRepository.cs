using Bogus;
using Products_Web_App.Models;

namespace Products_Web_App.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A piece of plastic to protect your desk." });
                productsList.Add(new ProductModel { Id = 2, Name = "Angron", Price = 72.50m, Description = "Primarch of the World Eaters Legion." });
                productsList.Add(new ProductModel { Id = 3, Name = "Coke Zero", Price = 1.09m, Description = "Multipack Can. Not to be sold seperately." });
                productsList.Add(new ProductModel { Id = 4, Name = "Alien (1979) - DVD", Price = 7.99m, Description = "In space no one can hear you scream." });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review()));
                }
            }
            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
