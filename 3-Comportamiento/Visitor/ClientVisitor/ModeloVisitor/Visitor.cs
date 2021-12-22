using System;

namespace ModeloVisitor
{
    public class Visitor : IVisitor
    {
        public void Visitar(DiscoRigido DR)
        {
            Console.WriteLine("El componente seleccionado es "+DR.GetType().ToString() +" y su numero de serie"+ DR.Serial);
        }

        public void Visitar(Procesador P)
        {
            Console.WriteLine("El componente seleccionado es "+ P.GetType().ToString() +" y su numero de serie"+ P.Serial);
        }

        public void Visitar(PlacaBase PB)
        {
            Console.WriteLine("El componente seleccionado es "+ PB.GetType().ToString() +" y su numero de serie"+ PB.Serial);
        }
    }
}
