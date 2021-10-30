using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    interface IPersonaDao
    {
        List<Persona> listarTodos();
        Persona leerPorId(int id);
        void registrar(Persona persona);
        void Actualizar(Persona persona);
        void eliminar(int id);
    }
}
