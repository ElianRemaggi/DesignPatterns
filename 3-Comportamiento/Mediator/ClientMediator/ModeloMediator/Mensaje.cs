using System;

namespace ModeloMediator
{
    public class Mensaje
    {
        private DateTime _fecha;
        
        public Mensaje()
        {
            _fecha = DateTime.Now;
        }

        public Usuario De { get; set; }
        public Usuario Para { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get { return _fecha; } }

        public override string ToString()
        {
            return $"Mensaje a las {this.Fecha.ToShortTimeString()} de {De.Nombre} para {Para.Nombre} ---> {Texto}";

        }


    }
}