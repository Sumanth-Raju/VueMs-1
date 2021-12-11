using System;
using System.Collections.Generic;

namespace Api.Repositories{

    public class CustomerRepository : ICustomerRepository
    {

        private List<Customer> Customers = new List<Customer>();

        public CustomerRepository(){
            Customers.Add(new Customer{
                Id = 1,
                Name = "Sumanth"
            });
            Customers.Add(new Customer{
                Id = 2,
                Name = "Anu"
            });
        }

        public Customer AddCustomer(Customer user)
        {
            if(user == null){
                throw new ArgumentNullException("user");
            }
            Customers.Add(user);
            return user;
        }

        public IEnumerable<Customer> GetAll()
        {
            return Customers;
        }
    }
}
