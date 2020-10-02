using POSApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSApplication.Data.Repositories
{
   public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly PORTPOSContext _portPOSContextContext;
        public CustomerRepository(PORTPOSContext portPOSContextContext) : base(portPOSContextContext)
        {
            _portPOSContextContext = portPOSContextContext;
        }
    }
}
