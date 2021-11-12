using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoModelo
{
    public class Caretaker
    {
      private List<Memento> _Mementos;

       
      public Caretaker()
        {
            this._Mementos = new List<Memento>();
        }



        public void addMemento(Memento m)
        {
            _Mementos.Add(m);
        }

        public Memento getMemento(int index)
        {
            return _Mementos[index]; 
        }

    }
}
