using POSApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Service
{
    public interface IProductService
    {
        List<Products> GetAllProducts();
        Task<Products> GetProductById(int id);
        Task<Products> AddProduct(Products newProduct);
    }
}
