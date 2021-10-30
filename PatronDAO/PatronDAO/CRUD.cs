using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDAO
{
    interface CRUD<T>
    {
        List<T> listarTodos();
        T leerPorId(int id);
        void registrar(T t);
        void Actualizar(T t);
        void eliminar(int id);
    }
}
