using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class CuentaCorriente : ICuentaBancaria
    {
        public void abrirCuentaBancaria(Cuenta c)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Se abrio una cuenta Corriente");
            Console.WriteLine("Cliente: "+c.Cliente);
        }
    }
}
