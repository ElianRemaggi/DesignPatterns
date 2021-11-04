using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class TacoMexicano : Empanada
    {
        public TacoMexicano()
        {
            this.descripcion = "Tacos Mexicanos";
        }
    }
}
