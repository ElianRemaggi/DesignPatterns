using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoModelo
{
    public class Persona
    {
        private string _nombre;

        public string Nombre { 
            
                get => _nombre;
           
                set => _nombre = value;
        }

        public void restoreFromMemento(Memento memento)
        {
            this._nombre = memento.Estado;
        }

        public Memento SaveToMemento( )
        {
            Console.WriteLine("Originator: Guardando memento para "+ Nombre);
            return new Memento(Nombre);
        }
    }
}
