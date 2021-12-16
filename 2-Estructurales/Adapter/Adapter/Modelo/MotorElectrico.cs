using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class MotorElectrico
    {

        private bool _activo;
        private bool _encendido;
        private bool _moviendo;

        public bool Activo { get => _activo; set => _activo = value; }
        public bool Encendido { get => _encendido; set => _encendido = value; }
        public bool Moviendo { get => _moviendo; set => _moviendo = value; }

        public string Activar()
        {
            return "Motor electrico activado";
        }

        public string Conectar()
        {
            return "Motor electrico conectado";
        }

        public string Desconectar()
        {
            return "Motor electrico desconectado";
        }

        public string Enchufar()
        {
            return "Motor electrico enchufado";
        }

        public string Mover()
        {
            return "Motor electrico moviendose";
        }

        public string Parar()
        {
            return "Motor electrico parado";
        }
    }
}
