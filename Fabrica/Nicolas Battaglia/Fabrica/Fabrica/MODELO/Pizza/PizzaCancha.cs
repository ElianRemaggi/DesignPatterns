using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class PizzaCancha : IPizza
    {
        private string _origen;
        private string _descripcion;

        public PizzaCancha(string origen)
        {
            this._origen = origen;
            this._descripcion = "Cancha";
        }

        public void render()
        {
            Console.WriteLine("Pizza de tipo " + this._descripcion + " echa en " + this._origen);
        }
    }
}
