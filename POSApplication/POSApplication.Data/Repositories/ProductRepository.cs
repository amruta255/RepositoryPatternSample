using POSApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSApplication.Data.Repositories
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private readonly PORTPOSContext _portPOSContextContext;
        public ProductRepository(PORTPOSContext portPOSContextContext) : base(portPOSContextContext)
        {
            _portPOSContextContext = portPOSContextContext;
        }
    }
}
