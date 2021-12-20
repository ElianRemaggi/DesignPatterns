using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Palabra palabra = new Palabra("Hola mundo");

            foreach(var letra in palabra)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();
        }
    }
}
