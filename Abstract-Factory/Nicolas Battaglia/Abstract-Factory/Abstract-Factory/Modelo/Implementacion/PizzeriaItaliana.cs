using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Factory
{
    class PizzeriaItaliana : IPizzeria
    {
        public Empanada CrearEmpanada()
        {
            return new EmpanadaCaprese();
        }

        public Pizza CrearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}
