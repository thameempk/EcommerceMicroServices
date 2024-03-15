using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using ProductManagement.Repository;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            return Ok(await _productServices.GetProducts());
        }

        [HttpGet("product-by-id")]
        public async Task<ActionResult> GetProductById(int id)
        {
            return Ok(await _productServices.GetProductById(id));
        }

        [HttpPost]

        public async Task<ActionResult> AddUsers(Products products)
        {
            if (products == null)
            {
                return BadRequest();
            }

            return Ok(await _productServices.AddProducts(products));
        }
    }
}
