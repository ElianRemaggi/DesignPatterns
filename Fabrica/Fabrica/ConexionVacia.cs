using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class ConexionVacia : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("No se especifico proveedor");
        }

        public void desconectar()
        {
            Console.WriteLine("No se especifico proveedor");
        }
    }
}
