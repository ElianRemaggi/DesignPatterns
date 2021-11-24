using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        /*
            El patrón observador se utilizará para notificar cambios de estado a un objeto.
            Consta de un objeto observable y sus observadores.
            El objeto observable tiene dentro a sus observadores, en algún tipo de estructura de dato, con el fin de acceder a los observadores desde dentro de los observables.

            El observable posee funciones para añadir observadores y notificarlos.
            El observador posee funciones para recibir las notificaciones del observable
        */
        static void Main(string[] args)
        {
            Subject sujeto = new Subject();

            new SolObservador(sujeto);
            new PesoARGObservador(sujeto);
            new PesoMXObservador(sujeto);

            Console.WriteLine("Si desea cambiar 10 dolares obtendra:");
            sujeto.setEstado(10);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Si deasea cambiar 100 dolares obtendra");
            sujeto.setEstado(100);

            Console.ReadKey();
        }
    }
}
