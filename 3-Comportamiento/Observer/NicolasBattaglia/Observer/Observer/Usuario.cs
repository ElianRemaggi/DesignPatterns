using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Usuario : IObserverUsuario
    {

        private string _apellido;
        private string _nombre;

        public Usuario(string apellido, string nombre)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public void actualizar(Servicio servicio)
        {
            Console.WriteLine(this._nombre + " " + this._apellido + " su servicio " + servicio.Nombre + "posee un nuevo precio de " + servicio.Precio);
        }
    }
}
