using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderBratDream bbd = new BuilderBratDream();
            BuilderCBR300 bcbr300 = new BuilderCBR300();
            BuilderCeccato bcc = new BuilderCeccato();
                    
                        
            Console.WriteLine(bbd.ToString());
            Console.WriteLine(bcbr300.ToString());
            Console.WriteLine(bcc.ToString());

            Console.ReadKey();
        }
    }
}
