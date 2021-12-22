using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EspadaFuego : AgregadorDecorador
    {        
        //Agrega 3 puntos de danio
        public EspadaFuego(Espada espada) : base(espada)
        {
        }

        public override string danio()
        {
            return (this._espada._filo + 3).ToString();
        }
    }
}
