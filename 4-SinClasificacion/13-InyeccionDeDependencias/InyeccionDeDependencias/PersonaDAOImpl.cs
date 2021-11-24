using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    class PersonaDAOImpl : IPersonaDao
    {
        
        private Conexion conexion;
        //Inyeccion de conexion de forma dinamica, no acopla a una instancia en particular
        //Gracias inyeccion de dependencias se puede desacoplar el codigo, no depender de una instancia en particular
        public PersonaDAOImpl(Conexion conexion)
        {
            this.Conexion = conexion;
        }

        internal Conexion Conexion { get => Conexion; set => Conexion = value; }

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
            this.Conexion1.conectar();
            return null;
        }

        public void registrar(Persona persona)
        {
            Console.WriteLine("Persona "+persona.Nombre+" registrada");
          
        }
    }
}
