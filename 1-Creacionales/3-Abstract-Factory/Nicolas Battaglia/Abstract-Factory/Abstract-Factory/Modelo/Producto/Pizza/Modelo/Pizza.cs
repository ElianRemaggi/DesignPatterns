using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class Pizza
    {
        protected string descripcion;

        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
