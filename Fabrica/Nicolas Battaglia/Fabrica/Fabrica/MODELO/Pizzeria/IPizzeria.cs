using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.MODELO.Pizzeria
{
    interface IPizzeria
    {
        IPizza crearPizza(string tipo);

    }
}
