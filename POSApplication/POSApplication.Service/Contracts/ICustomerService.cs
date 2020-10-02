using POSApplication.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSApplication.Service
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> AddCustomer(Customer newCustomer);
    }
}
