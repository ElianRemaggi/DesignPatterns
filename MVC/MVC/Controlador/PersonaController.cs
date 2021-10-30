using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class PersonaController
    {
        private Persona persona = new Persona();

        public PersonaController()
        {
            this.persona.Id = 1;
            this.persona.Nombre = "Elian";
        }

        public String toString()
        {
            return ("Persona id: "+this.persona.Id+" Nombre: "+this.persona.Nombre);
        }
    }
}
