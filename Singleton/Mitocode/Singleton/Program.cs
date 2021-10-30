using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //Codigo Cliente, consume del singleton directamente el metodo de clase.

            Conexion c = Conexion.getInstancia();
            c.conectar();
            c.desconectar();


            if (c.GetType() == typeof(Conexion))
            {
                Console.WriteLine("Es una instancia de Conexion");
            }
            else
            {
                Console.WriteLine("No es una intancia de Conexion");
            }

            Console.ReadKey();

            
        }
    }
}
