using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoModelo
{
    public class Memento
    {
        private string _estado;

        public Memento(string estado)
        {
            this._estado = estado;
        }

        public string Estado { get => _estado; set => _estado = value; }

        public Memento getSavedMemento()
        {
            return this;
        }
    }
}
