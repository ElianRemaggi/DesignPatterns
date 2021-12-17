using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Component
    {
        private string _nombre;

        protected Component(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public abstract void AgregarHijo(Component c);

        public abstract IList<Component> ObtenerHijos();

        public abstract int ObtenerTamano();
    }
}
