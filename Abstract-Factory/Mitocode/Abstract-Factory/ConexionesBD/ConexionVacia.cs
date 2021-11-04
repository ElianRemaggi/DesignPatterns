using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ConexionVacia : IConexionBD
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
