using MyCrudApi.Models;
using MyCrudApi.Request;

namespace MyCrudApi.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(BaseRequest product);
        Task UpdateProduct(int id, BaseRequest product);
        Task DeleteProduct(Product product);
    }
}
