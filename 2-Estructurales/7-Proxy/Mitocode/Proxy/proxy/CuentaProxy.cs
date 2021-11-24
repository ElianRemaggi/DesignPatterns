using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{

    /* Implementa la interfaz ICuenta con el objetivo de
        manipular el objeto real 
        Se encapsula la logica y se utiliza el proxy como intermediario
        para llegar al objeto final
        
        Se pueden agregar nuevas funcionalidades utilizadas por el proxy
        que afectan el funcionamiento final del objeto real
     
     */
    class CuentaProxy : ICuenta
    {
        private ICuenta cuentaReal;

        public CuentaProxy(ICuenta cuentareal)
        {
            this.cuentaReal = cuentareal;
        }

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            if(cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);
            } else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            if(cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }

        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.mostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.mostrarSaldo(cuenta);
            }
        }

    }
}
