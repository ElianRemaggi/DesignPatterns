using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CheckFacade cliente1 = new CheckFacade();
            cliente1.buscar("03/01/2022", "31/01/2022", "Mar del Plata", "Cancun");

            Console.WriteLine("--------------------------------------");

            CheckFacade cliente2 = new CheckFacade();
            cliente2.buscar("03/01/2022", "31/01/2022", "Pinamar", "Cancun");

            Console.ReadKey();
        }
    }
}
