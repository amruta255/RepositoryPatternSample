using System;
using System.Collections.Generic;

namespace POSApplication.Data.Models
{
    public partial class Products
    {
        public int Productid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal CostPrice { get; set; }
    }
}
