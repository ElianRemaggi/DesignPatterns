using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.MODELO.Pizzeria
{
    class PizzeriaArgentina : IPizzeria
    {
        //codigo que no respeta SOLID open close, el ultimo return esta horrible
        public IPizza crearPizza(string tipo)
        {
            string origen = "Argentina";
            if(tipo == "napolitana")
            {
                return new PizzaNapolitana(origen);
            }
            else if(tipo == "cancha")
            {
                return new PizzaCancha(origen);
            }
            else
            {
                return null;
            }
        }
    }
}
