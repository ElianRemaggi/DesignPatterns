using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class IMoto
    {
        private Estilo estilo;
        private Motor motor;
        private Cubiertas cubiertas;

        protected Estilo Estilo { get => estilo; set => estilo = value; }
        protected Motor Motor { get => motor; set => motor = value; }
        protected Cubiertas Cubiertas { get => cubiertas; set => cubiertas = value; }

        public override string ToString()
        {
            return $"Estilo = {this.Estilo.Descripcion}, Motor = {this.Motor.Descripcion}, Cubiertas = {this.Cubiertas.Descripcion}";
        }
    }
}
