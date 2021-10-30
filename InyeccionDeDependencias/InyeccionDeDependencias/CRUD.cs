using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    interface CRUD<T>
    {
        List<T> listarTodos();
        T leerPorId();
        void registrar(T t);
        void modificar(T t);
        void eliminar(int id);
    }
}
