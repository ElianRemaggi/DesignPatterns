using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        private Juego estado;

        public Memento(Juego estado)
        {
            this.Estado = estado; //Recibe el objeto para ser almacenado
        }

        internal Juego Estado { get => estado; set => estado = value; }
    }
}
