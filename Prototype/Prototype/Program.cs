using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAHImpl cuentaAhorro = new CuentaAHImpl();
            cuentaAhorro.Monto = 250.0;
            Console.WriteLine(cuentaAhorro.toString());
            CuentaAHImpl cuentaClonada = (CuentaAHImpl)cuentaAhorro.Clone();

            if (cuentaClonada != null)
            {
                Console.WriteLine(cuentaClonada);
            }
            
            Console.WriteLine("---------------------");
            Console.WriteLine(cuentaClonada == cuentaAhorro);

            
            Console.ReadKey();
        }
    }
}
