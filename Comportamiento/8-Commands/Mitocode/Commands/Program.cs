using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        /*Patron de Commands
        Encapsula la petición de alguna operación bajo algún método.
        Objetivo del patron: enfoque orientado a comandos
        Ampliamente utilizado en interfaces de usuario
        para tener varios botones y que segun quien llame execute() 
        se modifique la implementacion en cada boton
        */

        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);

            DepositarImpl opDepositar = new DepositarImpl(cuenta, 100);
            RetirarImpl opRetirar = new RetirarImpl(cuenta, 50);

            Invoker invoker = new Invoker();
            invoker.recibirOperaciones(opDepositar);
            invoker.recibirOperaciones(opRetirar);

            invoker.realizarOperaciones();

            Console.ReadKey();
        }
    }
}
