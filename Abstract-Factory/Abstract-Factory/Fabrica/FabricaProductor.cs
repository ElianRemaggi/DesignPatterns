using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class FabricaProductor
    {
        public static FabricaAbstracta GetFabrica(String TipoFabrica) {
            if (TipoFabrica.Equals("BD"))
            {
                return new ConexionBDFabrica();
            } else if (TipoFabrica.Equals("REST"))
            {
                return new ConexionRESTFabrica();
            }
            else
            {
                return null;
            }
        }

    }
}
