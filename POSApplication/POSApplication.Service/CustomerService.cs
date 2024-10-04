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
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;


        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAll().ToList();


        }
            
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerRepository.GetAll().FirstOrDefaultAsync(x => x.Customerid == id);
        }

        public async Task<Customer> AddCustomer(Customer newCustomer)
        {
            return await _customerRepository.AddAsync(newCustomer);
        }
    }
}
