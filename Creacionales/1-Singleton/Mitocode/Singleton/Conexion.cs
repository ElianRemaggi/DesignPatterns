using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Conexion
    {
        //Declaracion variables

        private static Conexion instancia;

        //----------------------------------------

        //Constructor
        //Para evitar instancia mediante operador "new", crearemos un constructor privado
        private Conexion()
        {

        }

        //----------------------------------------
        //Metodos

        //Fundamental que el metodo sea static, para ser accesible por la clase.
        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        //----------------------------------------
        //Metodos de prueba

        public void conectar()
        {
            Console.WriteLine("Conexion establecida");
        }

        public void desconectar()
        {
            Console.WriteLine("Conexion finalizada");
        }
    }
}
