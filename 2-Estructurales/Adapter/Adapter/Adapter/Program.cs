using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorDiesel md = new MotorDiesel();
            ElectricoAdapter ea = new ElectricoAdapter();

            List<IMotor> motores = new List<IMotor>();

            motores.Add(md);
            motores.Add(ea);
            
            foreach(IMotor motor in motores)
            {
                Console.WriteLine(motor.arrancar());
                Console.WriteLine(motor.acelerar());
                Console.WriteLine(motor.apagar());
                Console.WriteLine(motor.cargarCombustible());
            }

            Console.ReadKey();
        }
    }
}
