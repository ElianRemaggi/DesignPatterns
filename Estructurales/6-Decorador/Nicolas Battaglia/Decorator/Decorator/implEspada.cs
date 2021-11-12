using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class implEspada : Espada
    {
        public implEspada()
        {
            this._filo = 1;
        }

        public override string danio()
        {
            return this._filo.ToString();
        }
    }
}
