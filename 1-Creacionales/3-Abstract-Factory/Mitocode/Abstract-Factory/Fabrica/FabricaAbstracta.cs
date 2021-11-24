using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface FabricaAbstracta
    {
        IConexionBD GetBD(String motor);
        IConexionREST GetREST(String area);
    }
}
