using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PesoARGObservador : Observador
    {
        private double valorCambio = 98.99;
        public PesoARGObservador(Subject subject)
        {
            this.sujeto = subject;
            this.sujeto.agregar(this);
        }
        public override void actualizar()
        {
            Console.WriteLine("PESO: " + this.sujeto.getEstado() * valorCambio);
        }
    }
}
