using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fabrica
{
    public class ConexionOracle : IConexion
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionOracle()
        {
            this.host = "localhost";
            this.puerto = "1521";
            this.usuario = "admin";
            this.contrasena = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conecto a Oracle");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconecto de Oracle");
        }
    }
}
