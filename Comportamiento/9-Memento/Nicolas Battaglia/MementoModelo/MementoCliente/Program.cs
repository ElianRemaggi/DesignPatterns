using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MementoModelo;

namespace MementoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Persona persona = new Persona();

            persona.Nombre = "Elian";
            caretaker.addMemento(persona.SaveToMemento());
            persona.Nombre = "Elian1";
            caretaker.addMemento(persona.SaveToMemento());
            persona.Nombre = "Elian2";
            caretaker.addMemento(persona.SaveToMemento());

            persona.restoreFromMemento(caretaker.getMemento(1));
            Console.WriteLine("Memnto 1 = "+persona.Nombre);
            Console.ReadKey();




        }
    }
}
