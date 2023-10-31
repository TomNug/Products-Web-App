using Products_Web_App.Models;

namespace Products_Web_App.Services
{
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel model);
        int Delete(ProductModel model);
        int Update(ProductModel model);

    }
}
