using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class CustomersRepository:ICustomerRepositories
    {
        private readonly DataContext _context;

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer cust)
        {
            _context.Customers.Add(cust);
            return cust;
        }

        public void DeleteCustomer(int id)
        {
            var temp = _context.Customers.ToList().Find(x => x.Id == id);
            _context.Customers.Remove(temp);
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetByTz(string tz)
        {
            return _context.Customers.ToList().Find(u => u.Tz == tz);
        }

        public Customer UpdateCustomer(int id, Customer cust)
        {
            var temp = _context.Customers.ToList().Find(u => u.Id == id);
            if(temp != null)
            {
               temp.Id = cust.Id;
                temp.Name= cust.Name;
                temp.Tz = cust.Tz;
            }

            return temp;
        }
    }
}
