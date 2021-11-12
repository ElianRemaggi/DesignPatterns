using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Espada
    {
        public int _filo { get; set; }
        public string _descripcion { get;  }

        public abstract string danio();
    }
}
