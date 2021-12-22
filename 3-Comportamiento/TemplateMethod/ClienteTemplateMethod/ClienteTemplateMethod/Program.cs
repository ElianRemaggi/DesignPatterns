using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloTemplateMethod;

namespace ClienteTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente elian = new Cliente("Elian Remaggi");
            Prestamo PrestamoHipotecario = new PrestamoHipotecario(elian);

            PrestamoHipotecario.Verificar();

            Console.ReadKey();
        }
    }
}
