using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class PizzaNapolitana : IPizza
    {
        
        private string _origen;
        private string _descripcion;

        public PizzaNapolitana(string origen)
        {
            this._origen = origen;
            this._descripcion = "Napolitana";
        }

        public void render()
        {
            Console.WriteLine("Pizza de tipo " + this._descripcion + " echa en " + this._origen);
        }
    }
}
