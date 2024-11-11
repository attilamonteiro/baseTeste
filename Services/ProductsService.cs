using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyCrudApi.Data;
using MyCrudApi.Interfaces.Repositories;
using MyCrudApi.Models;
using MyCrudApi.Repositories;
using MyCrudApi.Request;

namespace MyCrudApi.Services
{
    public class ProductsService: IProductService
    {
        public IProductRepository _productRepository { get; set; }

        public ProductsService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _productRepository.GetProduct(id);
        }

        public async Task AddProduct(BaseRequest product)
        {
            await _productRepository.AddProduct(product);
        }


        public async Task UpdateProduct(int id, BaseRequest productRequest)
        {
            await _productRepository.UpdateProduct(id, productRequest);
        }

        public async Task DeleteProduct(Product product)
        {

            await _productRepository.DeleteProduct(product);
        }
    }
}
