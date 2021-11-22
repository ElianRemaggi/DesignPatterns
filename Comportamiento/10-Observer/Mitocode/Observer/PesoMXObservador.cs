using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PesoMXObservador : Observador
    {
        private double valorCambio = 19.07;

        public PesoMXObservador(Subject subject)
        {
            this.sujeto = subject;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            Console.WriteLine("Mx: " + this.sujeto.getEstado() * valorCambio);
        }
    }
}
