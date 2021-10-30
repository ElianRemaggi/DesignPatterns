using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    class AntivirusComplejo : AnalisisComplejo
    {
        public override void AnalizarKeyLoggers()
        {
            Console.WriteLine("Analizando en busqueda de KeyLoggers");
        }

        public override void AnalizarMemoria()
        {
            Console.WriteLine("Analizando Memoria");
        }

        public override void AnalizarRootKits()
        {
            Console.WriteLine("Analizando Root Kits");
        }

        public override void descomprimirZip()
        {
            Console.WriteLine("Descomprimiendo ZIP");
        }

        public override void detener()
        {
            Console.WriteLine("Deteniendo Analisis");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando Analisis Complejo");
        }
    }
}
