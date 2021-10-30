using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class ConexionFabrica
    {
       public IConexion getConexion(String motor)
        {
            if(motor == null)
            {
                return new ConexionVacia();
            }

            if(motor.Equals("MYSQL"))
            {
                return new ConexionMySQL();
            } else if (motor.Equals("ORACLE"))
            {
                return new ConexionOracle();
            } else if (motor.Equals("POSTGRE"))
            {
                return new ConexionPostgreSQL();
            }


            return new ConexionVacia();
        }
    }
}
