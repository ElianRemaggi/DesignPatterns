using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDAO
{
    class Medico
    {
        private int id;
        private string nombre;

        public Medico()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
