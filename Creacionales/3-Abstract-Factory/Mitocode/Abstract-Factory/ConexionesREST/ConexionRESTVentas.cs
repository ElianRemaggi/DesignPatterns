using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Factory
{
    class ConexionRESTVentas : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("Conectandose a ConexionRESTVentas");
        }
    }
}
