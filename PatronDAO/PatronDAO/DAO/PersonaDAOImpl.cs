using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDAO
{
    class PersonaDAOImpl : IPersonaDao
    {
        public void Actualizar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.Nombre + " actualizada");
        }

        public void eliminar(int id)
        {
            //logica 
            
        }

        public Persona leerPorId(int id)
        {
            //logica
            return null;
        }

        public List<Persona> listarTodos()
        {
            List<Persona> lista = new List<Persona>();
            Persona per = new Persona();
            per.Id = 1;
            per.Nombre = "Elian";

            lista.Add(per);

            per = new Persona();
            per.Id = 2;
            per.Nombre = "Federico";

            lista.Add(per);

            return lista;
        }

        public void registrar(Persona persona)
        {
            Console.WriteLine("Persona "+persona.Nombre+" registrada");
          
        }
    }
}
