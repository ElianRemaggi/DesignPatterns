using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDAO
{

    /*
     Se puede abstraer la logica de acceso de un conjunto de operaciones.
     Se utilizara para acceder a operaciones de bases de datos.     
    */
    class Program
    {
        static void Main(string[] args)
        {
            CRUD<Persona> dao = new PersonaDAOImpl();
            List<Persona> lista = dao.listarTodos();
            foreach(Persona p in lista)
            {
                Console.WriteLine(p.Nombre);
            }

            Console.ReadKey();
        }
    }
}
