using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CustomerRepositoryProxy : IRepository
    {
        CustomerRepository real;

        public CustomerRepositoryProxy(CustomerRepository cp)
        {
            this.real = cp;
        }

        public IList<Customer> GetAll()
        {
            return real.GetAll();
        }

        public void Save(Customer customer)
        {
            customer.Name = customer.Name + " Proxy";  
            this.real.Save(customer);
        }
    }
}
