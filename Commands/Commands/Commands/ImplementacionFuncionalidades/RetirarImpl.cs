using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    //Implementacion de la interfaz IOperacion
    //Toma una cuenta pre instanciada y asigna un monton a la operacion
    class RetirarImpl : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public RetirarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.retirar(this.monto);
        }
    }
}
