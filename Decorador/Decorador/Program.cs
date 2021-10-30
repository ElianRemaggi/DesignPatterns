using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Elian");
            ICuentaBancaria cuenta = new CuentaCorriente();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

            cuentaBlindada.abrirCuenta(c);

            Console.ReadKey();
        }
    }
}
