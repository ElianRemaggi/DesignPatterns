﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaController pc = new PersonaController();
            Console.WriteLine(pc.toString());
            Console.ReadKey();
        }
    }
}
