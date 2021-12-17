using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director();
            Encargado encargado = new Encargado(director);
            Vendedor vendedor = new Vendedor(encargado);

            Compra compra = new Compra();

            do
            {
                Console.WriteLine("Ingrese el importe de la compra");
                compra.Importe = double.Parse(Console.ReadLine());

                vendedor.ProcesarCompra(compra);

            } while (compra.Importe > 0);

        }
    }
}
