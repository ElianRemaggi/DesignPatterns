using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class CuentaAHImpl : ICuenta
    {
        String tipo = "AHORRO";
        private double monto;

        public double Monto
        {
            get
            {
                return monto;
            }
            set
            {
                monto = value;
            }
        }

        public object Clone()
        {
           return (CuentaAHImpl) MemberwiseClone();
        }

        public String toString()
        {
            return "CuentaAHImpl: Tipo: "+this.tipo+" // Monto: "+this.monto;
        }

    }
}
