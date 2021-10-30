using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionFabrica fabrica = new ConexionFabrica();

            IConexion cx1 = fabrica.getConexion("MYSQL");
            cx1.conectar();
            cx1.desconectar();

            IConexion cx2 = fabrica.getConexion("ORACLE");
            cx2.conectar();
            cx2.desconectar();

            IConexion cx3 = fabrica.getConexion("POSTGRE");
            cx3.conectar();
            cx3.desconectar();

            IConexion cx4 = fabrica.getConexion("");
            cx4.conectar();
            cx4.desconectar();

            Console.ReadKey();
        }
    }
}
