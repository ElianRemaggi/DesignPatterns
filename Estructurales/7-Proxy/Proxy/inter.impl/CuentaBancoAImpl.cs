using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //Implementacion de ICuenta, definicion del cuerpo de los metodos
    class CuentaBancoAImpl : ICuenta
    {
        public CuentaBancoAImpl()
        {
        }

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            cuenta.SaldoInicial += monto;
            return cuenta;
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("Saldo de la cuenta $"+cuenta.SaldoInicial);
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            cuenta.SaldoInicial -= monto;
            return cuenta;
        }
    }
}
