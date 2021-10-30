using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class AvionAPI
    {
        public void buscarVuelos(String fechaIda, String fechaVuelta, String origen, String destino) {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Vuelos encontrados para " + destino + " desde " + origen);
            Console.WriteLine("Fecha de ida " + fechaIda + " Fecha de regreso " + fechaVuelta);
            Console.WriteLine("----------------------------------------");

        }

    }
}
