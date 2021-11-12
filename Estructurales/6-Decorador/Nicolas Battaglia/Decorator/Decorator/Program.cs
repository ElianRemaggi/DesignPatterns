using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Espada espada = new implEspada();
            Console.WriteLine("El danio de la espada es de "+espada.danio());

            EspadaFuego espadaFuego = new EspadaFuego(espada);
            Console.WriteLine("El danio de la espada de fuego es de "+espadaFuego.danio());

            Console.ReadKey();
        }
    }
}
