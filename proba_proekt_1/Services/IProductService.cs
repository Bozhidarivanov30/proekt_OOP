using proba_proekt_1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proba_proekt_1.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
