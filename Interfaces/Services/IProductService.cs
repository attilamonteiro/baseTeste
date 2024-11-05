using System.Collections.Generic;
using System.Threading.Tasks;
using MyCrudApi.Models;
using MyCrudApi.Request;

namespace MyCrudApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task AddProduct(BaseRequest product);
        Task UpdateProduct(int id, BaseRequest product);
        Task DeleteProduct(Product product);
    }
}
