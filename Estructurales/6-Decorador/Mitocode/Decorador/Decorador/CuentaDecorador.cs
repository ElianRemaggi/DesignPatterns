using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        protected CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            this.cuentaDecorada = cuentaDecorada;
        }

        public void abrirCuentaBancaria(Cuenta c)
        {
            this.cuentaDecorada.abrirCuentaBancaria(c);
        }
    }
}
