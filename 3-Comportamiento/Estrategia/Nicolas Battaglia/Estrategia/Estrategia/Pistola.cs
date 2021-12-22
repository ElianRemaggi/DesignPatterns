using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implementacion de la estrategia

namespace Estrategia
{
    class Pistola : IArma
    {
        public string atacar()
        {
            return "pum";
        }
    }
}
