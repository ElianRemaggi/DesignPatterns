using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductoReceiver producto = new ProductoReceiver();
            EmpresaInvoker empresa = new EmpresaInvoker();
            
            empresa.TomarORden(new AltaStockCommand(producto, 500));
            empresa.ProcesarOrdenes();
            Console.WriteLine($"Primer ejecucion, total de stock :{producto.Cantidad}");

            empresa.TomarORden(new AltaStockCommand(producto, 500));
            empresa.TomarORden(new AltaStockCommand(producto, 500));
            empresa.ProcesarOrdenes();
            Console.WriteLine($"Segunda ejecucion, total de stock :{producto.Cantidad}");

            empresa.TomarORden(new BajaStockCommand(producto, 250));
            empresa.ProcesarOrdenes();
            Console.WriteLine($"Tercera ejecucion, total de stock :{producto.Cantidad}");

            Console.ReadKey();
        }
    }
}
