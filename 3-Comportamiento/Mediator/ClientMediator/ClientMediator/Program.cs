using System;
using ModeloMediator;

namespace ClientMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat _chat = new Chatroom();
            Usuario u1 = new Usuario1("Elian");
            Usuario u2 = new Usuario2("Claudio");

            _chat.Registrar(u1);
            _chat.Registrar(u2);

            _chat.Enviar("Hola", u1, u2);
            _chat.Enviar("Buenas", u2, u1);
            _chat.Enviar("Prueba de chat", u1, u2);
            _chat.Enviar("Prueba recibida.", u2, u1);


            foreach(var mensaje in _chat.Mensajes)
            {
                Console.WriteLine(mensaje);
            }

            Console.ReadKey();


        }
    }
}
