using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SolObservador : Observador
    {
        private double valorCambio = 3.25;

        public SolObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }
        public override void actualizar()
        {
            Console.WriteLine("PEN: " + this.sujeto.getEstado() * valorCambio);
        }
    }
}
