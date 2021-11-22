using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Codigo cliente 

namespace Estrategia
{
    class Jugador
    {
        //Nuevo objeto estrategico. 
        IArma arma;

        public void PistolaPreparar()
        {
            //Seleccion de la estrategia a utilizar
            this.arma = new Pistola();
        }

        public void AmetralladoraPreparar()
        {
            //Seleccion de la estrategia a utilizar
            this.arma = new Ametralladora();
        }

        public string disparar()
        {
            //Funcionamiento del principio de liskov. Independencia de la clase, dependiente de su padre.
            return this.arma.atacar();
        }
    }
}
