using ProductManagement.Models;

namespace ProductManagement.Repository
{
    public interface IProductServices
    {
        Task<List<Products>> GetProducts();
        Task<Products> GetProductById(int productId);
        Task<bool> AddProducts(Products products);
    }
}
