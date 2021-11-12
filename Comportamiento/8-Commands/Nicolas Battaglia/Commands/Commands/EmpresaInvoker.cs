using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class EmpresaInvoker
    {

        private List<OrdenCommand> Peticiones = new List<OrdenCommand>();  

        public void ProcesarOrdenes()
        {
           foreach(var i in this.Peticiones)
            {
                i.Ejecutar();
            }
            this.Peticiones.Clear();
        }

        public void TomarORden(OrdenCommand cmd)
        {
            this.Peticiones.Add(cmd);
        }
    }
}
