using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    /* Clase que da uso de IEstrategia, independiente de que clase hija se le envie  */
    class Contexto
    {
        private IEstrategia estrategia;

        public Contexto(IEstrategia e)
        {
            this.estrategia = e;
        }

        public void ejecutar()
        {
            this.estrategia.analizar();
        }
    }
}
