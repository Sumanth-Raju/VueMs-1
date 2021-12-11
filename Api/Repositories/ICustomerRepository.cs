using System;
using System.Collections.Generic;

namespace Api.Repositories{
    public interface ICustomerRepository{
        IEnumerable<Customer> GetAll();

        Customer AddCustomer(Customer user);
    }
}