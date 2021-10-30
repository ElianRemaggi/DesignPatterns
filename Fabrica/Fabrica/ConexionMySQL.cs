using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fabrica
{
    public class ConexionMySQL : IConexion
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionMySQL()
        {
            this.host = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.contrasena = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conecto a MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconecto de MySQL");
        }
    }
}
