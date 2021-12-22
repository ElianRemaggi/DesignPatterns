using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario ljr = new Usuario("Leandro Jose", "Raggio");
            Usuario jmu = new Usuario("Juan Manuel", "Urdangarin");
            Usuario efr = new Usuario("Elian Federico", "Remaggi");

            Servicio fibertel = new Servicio("Fibertel", 2000);
            Servicio coperativa = new Servicio("Coop", 1500);

            fibertel.Agregar(jmu);
            fibertel.Agregar(ljr);
            coperativa.Agregar(efr);

            fibertel.Precio = 2500;
            fibertel.Quitar(jmu);
            fibertel.Precio = 2600;
            coperativa.Precio = 1750;

            Console.ReadKey();


        }
    }

}
