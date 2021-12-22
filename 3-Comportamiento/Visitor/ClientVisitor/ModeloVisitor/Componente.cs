using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVisitor
{
    public abstract class Componente
    {

        private int _serial;

        protected Componente(int serial)
        {
            this.Serial = serial;
        }

        public int Serial { get => _serial; set => _serial = value; }

        public abstract void Aceptar(IVisitor IV);
    }

}
