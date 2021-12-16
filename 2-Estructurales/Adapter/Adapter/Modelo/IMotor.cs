using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IMotor
    {
        string acelerar();
        string apagar();
        string arrancar();
        string cargarCombustible();

    }
}
