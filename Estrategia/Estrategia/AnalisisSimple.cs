using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    abstract class AnalisisSimple : IEstrategia
    {
        public void analizar()
        {
            this.iniciar();
            this.saltarZip();
            this.detener();
        }

        public abstract void iniciar();
        public abstract void saltarZip();
        public abstract void detener();
    }
}
