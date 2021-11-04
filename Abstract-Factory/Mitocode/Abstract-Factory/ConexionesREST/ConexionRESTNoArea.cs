using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ConexionRESTNoArea : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("ConexionRESTNoArea no especifica el area");
        }
    }
}
