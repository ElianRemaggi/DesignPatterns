using System;

namespace Modelo
{
    public class Vendedor : IAprobador
    {
        private IAprobador _siguiente;

        public Vendedor(IAprobador  IA)
        {
            this._siguiente = IA;
        }

        public void ProcesarCompra(Compra c)
        {
            if (c.Importe < 100) {
                Console.WriteLine("Compra aprobada por"+this.GetType().ToString());
            }
            else
            {
                _siguiente.ProcesarCompra(c);
            }
        }
    }
}
