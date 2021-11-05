using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HotelAPI
    {
        public void buscarHoteles(String fechaIda, String fechaVuelta)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hoteles encontrados");
            Console.WriteLine("Fecha de entrada " + fechaIda + " Fecha de salida " + fechaVuelta);
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("----------------------------------------");
        }
    }
}
