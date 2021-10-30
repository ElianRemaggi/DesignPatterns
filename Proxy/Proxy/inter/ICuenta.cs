using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /* Se necesitara una implementacion que de cuerpo a los metodos (CuentaBancoAImpl) */
    public interface ICuenta
    {
        Cuenta retirarDinero(Cuenta cuenta, double monto);
        Cuenta depositarDinero(Cuenta cuenta, double monto);
        void mostrarSaldo(Cuenta cuenta);
    }
}
