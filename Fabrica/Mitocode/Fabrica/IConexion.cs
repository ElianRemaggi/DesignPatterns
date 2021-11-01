using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    // Interface para las clases hermanas que seran fabricadas

    public interface IConexion
    {

        void conectar();
        void desconectar();

    }
}
