using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepositories _customerRepositor;
        public CustomerService(ICustomerRepositories customerRepositor)
        {
            _customerRepositor = customerRepositor;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepositor.AddCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepositor.DeleteCustomer(id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepositor.GetCustomers();
        }

        public Customer GetByTz(string tz)
        {
            return _customerRepositor.GetByTz(tz);
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            _customerRepositor.UpdateCustomer(id, customer);
        }
    }
}
