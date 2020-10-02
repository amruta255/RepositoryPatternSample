using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSApplication.Data.Models;
using POSApplication.Service;

namespace POSApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<ActionResult<Products>> PostProduct(Products product)
        {
            return await this._productService.AddProduct(product);
        }
        [HttpGet]
        public ActionResult<List<Products>> GetCustomer()
        {
            return _productService.GetAllProducts();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetCustomer(int id)
        {
            return await _productService.GetProductById(id);
        }

    }
}
