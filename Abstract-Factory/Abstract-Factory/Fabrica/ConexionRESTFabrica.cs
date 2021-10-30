using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ConexionRESTFabrica : FabricaAbstracta
    {
        public IConexionBD GetBD(string motor)
        {
            //Lo correcto es que FabricaAbstracta este dividida en dos interfaces diferentes
            return null;
        }

        public IConexionREST GetREST(string area)
        {
            
            if(area == null)
            {
                return new ConexionRESTNoArea();
            }

            if(area == "COMPRAS")
            {
                return new ConexionRESTCompras();
            }else if (area == "VENTAS")
            {
                return new ConexionRESTVentas();
            }
            else
            {
                return new ConexionRESTNoArea();
            }
        }
    }
}
