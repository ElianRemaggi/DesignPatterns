using System;

namespace Modelo
{
    public class Encargado : IAprobador
    {
        private IAprobador _siguiente;

        public Encargado(IAprobador IA)
        {
            this._siguiente = IA;
        }

        public void ProcesarCompra(Compra c)
        {
            if (c.Importe < 1000)
            {
                Console.WriteLine("Compra aprobada por" + this.GetType().ToString());
            }
            else
            {
                _siguiente.ProcesarCompra(c);
            }
        }
    }
}
