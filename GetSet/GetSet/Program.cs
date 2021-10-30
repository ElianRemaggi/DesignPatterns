using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Java metod");
            JavaGetSet javagetset = new JavaGetSet();

            javagetset.seti(1);
            javagetset.sets("String java");

            Console.WriteLine(javagetset.toString());



            Console.WriteLine("c# metod");
            CGetSet cgetset = new CGetSet();

            //public 
            cgetset.i = 10;

            //private
            cgetset.S= "Private C#";

            Console.WriteLine("C# private String =" + cgetset.S);

            Console.WriteLine(cgetset.toString());
            
            Console.ReadKey();
        }
    }
}
