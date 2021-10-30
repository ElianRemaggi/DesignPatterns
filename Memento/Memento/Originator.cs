using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{

    /* Esta clase sabe como guardar el objeto */
    class Originator
    {
        private Juego estado; 

        internal Juego Estado { get => estado; set => estado = value; }

        public Memento guardar()
        {
            return new Memento(estado); //crea una nueva instancia con el modelo que se busca guardar
        }

        public void restaurar(Memento m)
        {
            this.estado = m.Estado;
        }
    }
}
