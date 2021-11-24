using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class PizzeriaEstadounidense : IPizzeria
    {
        public Empanada CrearEmpanada()
        {
            return new TacoMexicano();
        }
        public Pizza CrearPizza()
        {
            return new PizzaPeperoni();
        }
    }
}
