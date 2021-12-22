
using System;
using System.Collections.Generic;

namespace ModeloTemplateMethod
{
    public class PrestamoHipotecario : Prestamo
    {
        public PrestamoHipotecario(Cliente c) : base(c)
        {
        }

        public override void Verificar()
        {
            List<string> verificaciones = new List<string>();

            verificaciones.Add(this.VerificarAcciones());
            verificaciones.Add(this.VerificarBalance());
            verificaciones.Add(this.VerificarCreditos());
            verificaciones.Add(this.VerificarIngresos());

            foreach(var v in verificaciones)
            {
                Console.WriteLine(v);
            }
        }

        public override string VerificarAcciones()
        {
            return $"Verficiacion de Acciones realizada con exito";
        }

        public override string VerificarBalance()
        {
            return $"Verficiacion de Balance realizada con exito";
        }

        public override string VerificarCreditos()
        {
            return $"Verficiacion de Creditos realizada con exito";
        }

        public override string VerificarIngresos()
        {
            return $"Verficiacion de Ingresos realizada con exito";
        }
    }
}
