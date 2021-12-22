using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada)
        {

        }

        public void abrirCuenta(Cuenta c)
        {
            cuentaDecorada.abrirCuentaBancaria(c);
            agregarBlindaje(c);
        }

        public void agregarBlindaje(Cuenta c)
        {
            Console.WriteLine("Se agrego blindaje a la cuenta del cliente" + c.Cliente);
        }
    }
}
