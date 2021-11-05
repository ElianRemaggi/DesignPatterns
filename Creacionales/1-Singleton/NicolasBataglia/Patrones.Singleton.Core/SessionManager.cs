using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Core
{
    public class SessionManager
    {
        // Codigo del patron Singleton


        private static SessionManager _session; //Variable session que sera devuelta por los getInstance

        private SessionManager() { //Constructor privado solo accesible desde la misma clase

        }

        public static SessionManager getInstance
        {
            get
            {
                if (_session == null) //Si session esta vasio
                {
                    _session = new SessionManager(); //Se crea uno nuevo
                }
                return _session; //Siempre se devuelve una instancia de session
            }
        }

        //Fin Singleton
        //----------------------------------------------------------------------



        //Codigo de contexto, pruebas. complemento de una session comun 
        Usuario usuario { get; set; }
        public DateTime FechaDeInicio { get; set; }

        //si se crean dos instancias por algun multi hilo o otro problema se podria ejecutar este codigo
        public static object _lock = new Object();

        public static void Login(Usuario usuario)
        {

            lock (_lock) // blockea el fragmenta de codigo, para que se ejecute completo en cada hilo
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.usuario = usuario;
                    _session.FechaDeInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Session ya iniciada");
                }
            }

        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Session no iniciada");
                }
            }
        }

        

        
    }
}
