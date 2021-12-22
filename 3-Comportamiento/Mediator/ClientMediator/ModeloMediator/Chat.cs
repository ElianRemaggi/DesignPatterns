using System;
using System.Collections.Generic;

namespace ModeloMediator
{
    public abstract class Chat
    {
        protected List<Mensaje> _mensajes;

        protected Chat()
        {
            _mensajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }

        public abstract void Enviar(string mensaje, Usuario para, Usuario de);
        public abstract void Registrar(Usuario _usuario);
        
    }
}