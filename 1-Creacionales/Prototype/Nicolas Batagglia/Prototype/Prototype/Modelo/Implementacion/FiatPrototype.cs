using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string verAuto()
        {
            return $"Auto : {this.Modelo} de color {this.Color}";
        }
    }
}
