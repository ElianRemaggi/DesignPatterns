using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CustomerRepository : IRepository
    {

        private IList<Customer> _CustomersList;

        public CustomerRepository()
        {
            _CustomersList = new List<Customer>();
        }

        public IList<Customer> GetAll()
        {
            return this._CustomersList;
        }

        public void Save(Customer customer)
        {
            this._CustomersList.Add(customer);
        }
    }
}
