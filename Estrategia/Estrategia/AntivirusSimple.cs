using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    class AntivirusSimple : AnalisisSimple
    {
        public override void detener()
        {
            Console.WriteLine("Deteniendo el analisis");
        }

        public override void iniciar()
        {
            Console.WriteLine("Iniciando el analisis simple");
        }

        public override void saltarZip()
        {
            Console.WriteLine("Saltando ZIP");
        }
    }
}
