using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    //Invoker responsable de apilar las oepraciones y ejecutarlas
    class Invoker
    {
        private List<IOperacion> operaciones = new List<IOperacion>();

        /*Se recibe una operacion por parametro
            Se almacena en la lista
        */
        public void recibirOperaciones(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }

        /* Por cada operacion en la lista
               Se ejecutan segun tipo de operacion
           Al finalizar se limpia la lsita
        */
        public void realizarOperaciones()
        {
            
            foreach (IOperacion operacion in operaciones) 
            {
                operacion.execute();     
            }
            this.operaciones.Clear();
        }
    }
}
