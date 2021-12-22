using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IServicio
    {
        void Agregar(IObserverUsuario iou);
        void notificar();
        void Quitar(IObserverUsuario iou);
    }
}
