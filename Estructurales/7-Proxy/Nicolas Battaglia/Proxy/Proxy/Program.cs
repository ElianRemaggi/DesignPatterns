using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Elian");
            Customer c2 = new Customer("Pablo");

            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.Save(c1);

            CustomerRepositoryProxy customerRepositoryProxy = new CustomerRepositoryProxy(customerRepository);
            customerRepositoryProxy.Save(c2);

            Console.WriteLine("CustomerRepositoryProxy data");

            foreach(var p in customerRepositoryProxy.GetAll())
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("/////////////////////////////////////");

            Console.WriteLine("CustomerRepository Data");
            foreach(var p in customerRepository.GetAll())
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadKey();
        }
    }
}
