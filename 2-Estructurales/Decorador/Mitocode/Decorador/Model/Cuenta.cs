using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class Cuenta
    {
        private int id;
        private String cliente;

        public Cuenta(int id, string cliente)
        {
            this.id = id;
            this.cliente = cliente;
        }

        public string Cliente { get => cliente; set => cliente = value; }
        public int Id { get => id; set => id = value; }

    }
}
