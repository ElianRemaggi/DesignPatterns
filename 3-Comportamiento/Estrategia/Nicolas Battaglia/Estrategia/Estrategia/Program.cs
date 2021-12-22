using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    //Codigo Cliente
    class Program
    {
        static void Main(string[] args)
        {
            
            Jugador jugador = new Jugador();

            jugador.PistolaPreparar();
            Console.WriteLine(jugador.disparar());

            jugador.AmetralladoraPreparar();
            Console.WriteLine(jugador.disparar());
            Console.WriteLine(jugador.disparar());

            Console.ReadKey();

        }
    }
}
