using System.Collections.Generic;

namespace ModeloMediator
{
    public class Chatroom : Chat
    {
        IDictionary<string, Usuario> _participantes;

        public Chatroom()
        {
            _participantes = new Dictionary<string, Usuario>();
        }

        public override void Registrar(Usuario _usuario)
        {
            if (!_participantes.ContainsKey(_usuario.Nombre))
            {
                _participantes.Add(_usuario.Nombre, _usuario);
            }
        }

        public override void Enviar(string mensaje, Usuario para, Usuario de)
        {
            Mensaje msg = new Mensaje();
            msg.De = de;
            msg.Para = para;
            msg.Texto = mensaje;

            if (_participantes.ContainsKey(para.Nombre))
            {
                _participantes[para.Nombre].Recibir(msg);
                _mensajes.Add(msg);
            }
        }

    }
}