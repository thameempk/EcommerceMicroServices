using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;
using ProductManagement.ProductsDbContext;


namespace ProductManagement.Repository
{
    public class ProductServices : IProductServices
    {
        private readonly ProductDbContext _dbContext;
        public ProductServices(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Products>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
        public async Task<Products> GetProductById(int productId)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(p => p.Id ==  productId);
        }
        public async Task<bool> AddProducts(Products products)
        {
            await _dbContext.Products.AddAsync(products);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
