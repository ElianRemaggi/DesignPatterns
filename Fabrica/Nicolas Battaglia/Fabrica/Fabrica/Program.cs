using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica.MODELO.Pizzeria;




namespace Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = null;
            IPizzeria pizzeria = null;

            //fabrica de pizzas argentinas 

            pizzeria = new PizzeriaArgentina();
            
            pizza = pizzeria.crearPizza("cancha");
            pizza.render();

            pizza = pizzeria.crearPizza("napolitana");
            pizza.render();

            //fabrica de pizzas italiana

            pizzeria = new PizzeriaItaliana();

            pizza = pizzeria.crearPizza("cancha");
            pizza.render();

            pizza = pizzeria.crearPizza("napolitana");
            pizza.render();

            Console.ReadKey();
        }
    }
}
