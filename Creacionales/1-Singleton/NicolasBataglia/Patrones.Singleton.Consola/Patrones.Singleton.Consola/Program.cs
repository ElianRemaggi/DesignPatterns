using Patrones.Singleton.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.username = "Elian";
            usuario.pasword = "admin123";

            try
            {
                SessionManager.Login(usuario);
                SessionManager sm = SessionManager.getInstance; // devuelve la instancia que se utiliza en la linea superior
                SessionManager.Logout();
                //SessionManager.Logout(); //Si esta linea no esta comentada dara error de exepcion por session no iniciadas
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
