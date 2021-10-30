using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    //Implementacion de la interfaz IOperacion
    //Toma una cuenta pre instanciada y asigna un monton a la operacion
    class DepositarImpl : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public DepositarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }
        
        public void execute()
        {
            this.cuenta.depositar(this.monto);
        }
    }
}
