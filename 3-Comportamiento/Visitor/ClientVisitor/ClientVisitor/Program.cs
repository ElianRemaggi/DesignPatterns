using System;
using ModeloVisitor;
namespace ClientVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Componente DR = new DiscoRigido(1);
            Componente PB = new PlacaBase(2);
            Componente P = new Procesador(3);

            IVisitor Visitor = new Visitor();

            DR.Aceptar(Visitor);
            PB.Aceptar(Visitor);
            P.Aceptar(Visitor); 

            Console.ReadKey();
        }
    }
}
