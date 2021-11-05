using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    class Conexion : IConexion
    {
        private string usuario;
        private string clave;
        private string host;

        public Conexion(string usuario, string clave, string host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }

        // implementando metodo de itnerfaz IConectar
        public void conectar()
        {
            Console.WriteLine("conectar, gracias a IConexion");
        }
    }
}
