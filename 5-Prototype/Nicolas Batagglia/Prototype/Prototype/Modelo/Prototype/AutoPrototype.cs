using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AutoPrototype
    {
        private string modelo;
        private string color;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }

        public abstract AutoPrototype Clonar();
        public abstract String verAuto();

    }


}
