using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMediator
{
    public abstract class Usuario
    {
        private List<Mensaje> _mensajes;
        private string _nombre;

        public Usuario(string nombre)
        {
            this._nombre = nombre;
            _mensajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public override string ToString()
        {
            return _nombre; 
        }

        public Chat chat { get; set; }

        public void Enviar(string _mensaje, Usuario _para)
        {
            chat.Enviar(_mensaje, _para, this);
        }

        public void Recibir(Mensaje msg)
        {
            this._mensajes.Add(msg);
        }
    }
}
