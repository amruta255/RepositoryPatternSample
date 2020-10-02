using Microsoft.EntityFrameworkCore;
using POSApplication.Data.Models;
using POSApplication.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Service
{
   public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }        

        public List<Products> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public async Task<Products> GetProductById(int id)
        {
            return await _productRepository.GetAll().FirstOrDefaultAsync(x => x.Productid == id);
        }

        public async Task<Products> AddProduct(Products newProduct)
        {
            return await _productRepository.AddAsync(newProduct);
        }
    }
}
