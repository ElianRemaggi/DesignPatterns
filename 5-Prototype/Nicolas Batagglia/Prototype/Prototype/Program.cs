using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype fiatPrototype = new FiatPrototype();
            AutoPrototype dsPrototype = new DSPrototype();
            AutoPrototype alfaRomeoPrototype = new AlfaRomeoPrototype();

            AutoPrototype fiatUno = fiatPrototype.Clonar();
            fiatUno.Color = "Rojo";
            fiatUno.Modelo = "Uno";
            Console.WriteLine(fiatUno.verAuto());

            AutoPrototype fiatPalio = fiatPrototype.Clonar();
            fiatPalio.Color = "Blanco";
            fiatPalio.Modelo = "Palio";
            Console.WriteLine(fiatPalio.verAuto());

            AutoPrototype ds3 = dsPrototype.Clonar();
            ds3.Color = "blanco";
            ds3.Modelo = "Chico";
            Console.WriteLine(ds3.verAuto());

            AutoPrototype ds4 = dsPrototype.Clonar();
            ds4.Color = "Negro";
            ds4.Modelo = "Sport";
            Console.WriteLine(ds4.verAuto());

            AutoPrototype alfa145 = alfaRomeoPrototype.Clonar();
            alfa145.Color = "Blanco";
            alfa145.Modelo = "145";
            Console.WriteLine(alfa145.verAuto());

            AutoPrototype alfa146 = alfaRomeoPrototype.Clonar();
            alfa146.Color = "Negro";
            alfa146.Modelo = "146";
            Console.WriteLine(alfa146.verAuto());

            Console.ReadKey();
        }
    }
}
