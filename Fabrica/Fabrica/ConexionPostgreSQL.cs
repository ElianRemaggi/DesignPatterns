using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fabrica
{
    public class ConexionPostgreSQL : IConexion
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionPostgreSQL()
        {
            this.host = "localhost";
            this.puerto = "5433";
            this.usuario = "postrges";
            this.contrasena = "123";
        }

        public void conectar()
        {
            Console.WriteLine("Se conecto a PostgreSQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconecto de PostgreSQL");
        }
    }
}
