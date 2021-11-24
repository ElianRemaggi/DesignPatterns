using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class ProductoReceiver
    {
        private double _cantidad;
        private string _nombre;

        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        public void RestarStock(double resta)
        {
            this._cantidad -= resta;
            
        }
        public void SumarStock(double suma)
        {
            this._cantidad += suma;
        }
    }
}
