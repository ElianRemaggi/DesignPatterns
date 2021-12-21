using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloState;

namespace ClienteState
{
    class Program
    {
        static void Main(string[] args)
        {

            Switch MiSwitch = new Switch();

            MiSwitch.Presionar();
            MiSwitch.Presionar();
            MiSwitch.Presionar();
            MiSwitch.Presionar();
            MiSwitch.Presionar();

            Console.ReadKey();
        }
    }
}
