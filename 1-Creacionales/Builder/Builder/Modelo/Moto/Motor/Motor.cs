using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Motor
    {
        private string _descripcion;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
