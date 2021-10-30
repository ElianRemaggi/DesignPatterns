using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaAbstracta fabricaBD = FabricaProductor.GetFabrica("BD");
            IConexionBD cbd1 = fabricaBD.GetBD("MYSQL");

            cbd1.conectar();
            cbd1.desconectar();


            FabricaAbstracta fabricaREST = FabricaProductor.GetFabrica("REST");
            IConexionREST crest1 = fabricaREST.GetREST("COMPRAS");

            crest1.leerURL("????");

            Console.ReadKey();
            
        }
    }
}
