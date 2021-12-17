using System;

namespace Modelo
{
    public class Director : IAprobador
    {
        public void ProcesarCompra(Compra c)
        {
            Console.WriteLine("Compra aprobada por" + this.GetType().ToString());
        }
    }
}
