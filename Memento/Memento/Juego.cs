using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //Modelo
    class Juego
    {
        private String nombre;
        private int checkopint;

        public Juego()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Checkopint { get => checkopint; set => checkopint = value; }

        public String toString()
        {
            return "Juego " + this.nombre + ", checkpoint = " + this.Checkopint;
        }
    }
}
