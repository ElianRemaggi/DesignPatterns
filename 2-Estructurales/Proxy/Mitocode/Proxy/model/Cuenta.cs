using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //Modelo que se utilizara para implementar posteriormente una interfaz
    public class Cuenta 
    {
        private int _idCuenta;
        private string _usuario;
        private double _saldoInicial;

        public int IdCuenta { get => _idCuenta; set => _idCuenta = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public double SaldoInicial { get => _saldoInicial; set => _saldoInicial = value; }

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {
            _idCuenta = idCuenta;
            _usuario = usuario;
            _saldoInicial = saldoInicial;
        }
    }
}
