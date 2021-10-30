using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    /*
        Estrategia es un patrón de comportamiento, sirve para encapsular lógica.

        El objetivo es poder tener diferentes algoritmos, diferentes lógicas encapsuladas.

        Se pueden definir familias de algoritmos, encapsularlos y hacerlos intercambiables.
        Los algoritmos serán independientes de los clientes que los están utilizando.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new AntivirusSimple());
            contexto.ejecutar();

            Console.WriteLine("---------------");

            contexto = new Contexto(new AntivirusComplejo());
            contexto.ejecutar();


            Console.ReadKey();
        }
    }
}
