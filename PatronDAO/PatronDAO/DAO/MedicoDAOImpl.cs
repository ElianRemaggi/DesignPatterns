using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDAO
{
    class MedicoDAOImpl : IMedicoDAO
    {
        public void Actualizar(Medico medico)
        {
            Console.WriteLine("Medico " + medico.Nombre + " actualizada");
        }

        public void eliminar(int id)
        {
            //logica 

        }

        public Medico leerPorId(int id)
        {
            //logica
            return null;
        }

        public List<Medico> listarTodos()
        {
            List<Medico> lista = new List<Medico>();
            Medico per = new Medico();
            per.Id = 1;
            per.Nombre = "Elian";

            lista.Add(per);

            per = new Medico();
            per.Id = 2;
            per.Nombre = "Federico";

            lista.Add(per);

            return lista;
        }

        public void registrar(Medico medico)
        {
            Console.WriteLine("Medico " + medico.Nombre + " registrada");

        }
    }
}
