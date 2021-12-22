using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class PizzeriaArgentina : IPizzeria
    {
        public Empanada CrearEmpanada()
        {
            return new EmpanadaCarne();
        }

        public Pizza CrearPizza()
        {
            return new PizzaCancha();
        }
    }
}
