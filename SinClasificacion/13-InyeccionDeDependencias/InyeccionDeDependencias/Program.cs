using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{

    /*Patron de diseño orientado a objetos, en el que se suministran objetos a una clase, en lugar de que la propia clase cree estos objetos */
    class Program
    {
        static void Main(string[] args)
        {
            Conexion cx1 = new Conexion("Elian", "1234", "localhost");
            Conexion cx2 = new Conexion("Elian", "1234", "192.168.1.1");

            IPersonaDao dao = new PersonaDAOImpl(cx1);

            dao.listarTodos();

            Console.ReadKey();
        }
    }
}
