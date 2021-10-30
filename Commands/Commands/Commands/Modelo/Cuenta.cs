using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    //Reciver/Request 
    //Modelo basico cuenta
    public class Cuenta
    {
        private int _id;
        private double _saldo;

        public Cuenta(int id, double saldo)
        {
            _id = id;
            _saldo = saldo;
        }

        public int Id { get => _id; set => _id = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        public void retirar(double monto)
        {
            this.Saldo -= monto;
            Console.WriteLine("[Comando retirar] Cuenta: " + this.Id + " Saldo: " + this.Saldo);
        }

        public void depositar(double monto)
        {
            this.Saldo += monto;
            Console.WriteLine("[Comando depositar] Cuenta: " + this.Id + " Saldo: " + this.Saldo);
        }

    } 
}
