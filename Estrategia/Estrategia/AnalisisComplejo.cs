using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    abstract class AnalisisComplejo : IEstrategia
    {
        public void analizar()
        {
            this.Iniciar();
            this.AnalizarMemoria();
            this.AnalizarKeyLoggers();
            this.AnalizarRootKits();
            this.descomprimirZip();
            this.detener();
        }

        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyLoggers();
        public abstract void AnalizarRootKits();
        public abstract void descomprimirZip();
        public abstract void detener();
    }
}
