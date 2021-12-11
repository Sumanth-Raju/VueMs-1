
using System.Collections.Generic;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

        
    [ApiController]   
    public class CustomerController : ControllerBase
    {
        static readonly ICustomerRepository repo = new CustomerRepository();

        public CustomerController(){

        }


        [HttpGet]
        [Route("api/customer")]
        public IEnumerable<Customer> GetCustomers(){
            return repo.GetAll();
        }

        [HttpPost]
        [Route("api/customer")]
        public Customer AddCustomer( Customer user){
                return repo.AddCustomer(user);
        }
    }

}