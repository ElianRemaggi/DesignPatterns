using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public abstract class OrdenCommand
    {
        public abstract void Ejecutar();

        protected ProductoReceiver _producto;
        protected double _cantidad;

        protected OrdenCommand(ProductoReceiver producto, double cantidad)
        {
            this._producto = producto;
            this._cantidad = cantidad;
        }
    }
}
