using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    //Clase producto de la fabrica, hereda de IConexion

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
