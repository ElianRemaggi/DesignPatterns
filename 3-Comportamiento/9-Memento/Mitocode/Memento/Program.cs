using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {   /*
            Patron Memento, guarda el estado de una operacion en un momento determinado
            Se utiliza para restablecer el estado de un objeto, como un rollback
           
        */
        static void Main(string[] args)
        {
            String nombreJuego = "DayZ";

            Juego juego = new Juego();
            juego.Nombre(nombreJuego);
            juego.Checkopint(1);

        }
    }
}
