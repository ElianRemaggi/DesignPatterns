using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nodo raiz
            Directorio raiz = new Directorio("root");

            //Nodos 
            Directorio directorio = new Directorio("Directorio");
            Directorio directorio1 = new Directorio("Directorio1");
            Directorio directorio2 = new Directorio("Directorio2");
            Directorio directorio3 = new Directorio("Directorio3");
            Directorio directorio4 = new Directorio("Directorio4");

            //hojas
            Archivo archivoRoot = new Archivo(2, "archivo");
            Archivo archivo = new Archivo(2, "archivo");
            Archivo archivo1 = new Archivo(2, "archivo");
            Archivo archivo2 = new Archivo(2, "archivo");
            Archivo archivo3 = new Archivo(2, "archivo");
            Archivo archivo4 = new Archivo(2, "archivo");

            raiz.AgregarHijo(directorio);
            directorio.AgregarHijo(directorio1);
            directorio.AgregarHijo(directorio2);
            directorio.AgregarHijo(directorio3);
            directorio3.AgregarHijo(directorio4);

            raiz.AgregarHijo(archivoRoot);
            directorio.AgregarHijo(archivo);
            directorio1.AgregarHijo(archivo1);
            directorio2.AgregarHijo(archivo2);
            directorio3.AgregarHijo(archivo3);
            directorio3.AgregarHijo(archivo4);

            Console.WriteLine("Tamano total");
            Console.WriteLine(raiz.ObtenerTamano());

            Console.WriteLine("Tamano directorio 3");
            Console.WriteLine(directorio3.ObtenerTamano());

            Console.WriteLine("Tamano directorio 4");
            Console.WriteLine(directorio4.ObtenerTamano());

            Console.ReadKey();
        }
    }
}
