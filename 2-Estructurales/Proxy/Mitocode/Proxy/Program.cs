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
            //Se crea una cuenta 
            Cuenta c = new Cuenta(1, "Elian", 0.0); 
            //Se crea una instancia del proxy
            ICuenta cuentaProxy = new CuentaProxy(new CuentaBancoAImpl());

            cuentaProxy.depositarDinero(c, 150000.0);
            cuentaProxy.mostrarSaldo(c);
            cuentaProxy.depositarDinero(c, 155000.0);
            cuentaProxy.mostrarSaldo(c);

            Console.ReadKey();
        }
    }
}
5