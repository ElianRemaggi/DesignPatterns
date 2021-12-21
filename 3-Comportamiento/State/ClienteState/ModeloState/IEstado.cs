using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloState
{
    public interface IEstado
    {
        void CambiarEstado(Switch sw);
        string Describir();
    }
}
