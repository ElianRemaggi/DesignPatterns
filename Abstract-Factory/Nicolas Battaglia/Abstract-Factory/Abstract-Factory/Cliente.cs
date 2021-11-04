using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Cliente
    {
        static void Main(string[] args)
        {

            IPizzeria pizzeria;
            Pizza pizza;
            Empanada empanada;

            pizzeria = new PizzeriaArgentina();
            pizza = pizzeria.CrearPizza();
            empanada = pizzeria.CrearEmpanada();
            Console.WriteLine($"Pizzeria Argentina: {pizza.Descripcion} y {empanada.Descripcion}");

            pizzeria = new PizzeriaItaliana();
            pizza = new PizzaNapolitana();
            empanada = pizzeria.CrearEmpanada();
            Console.WriteLine($"Pizzeria Italiana: {pizza.Descripcion} y {empanada.Descripcion}");

            pizzeria = new PizzeriaEstadounidense();
            pizza = new PizzaPeperoni();
            empanada = new TacoMexicano();
            Console.WriteLine($"Pizzeria Estadounidense: {pizza.Descripcion} y {empanada.Descripcion}");

            Console.ReadKey();
        }
    }
}
