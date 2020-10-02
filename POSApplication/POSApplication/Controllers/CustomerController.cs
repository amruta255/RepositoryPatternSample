using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSApplication.Data.Models;
using POSApplication.Service;

namespace POSApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {  
            return await _customerService.AddCustomer(customer);
        }
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomer()
        {
            return _customerService.GetAllCustomer();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            return await _customerService.GetCustomerById(id);
        }        
    }
}
