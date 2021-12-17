using System.Collections.Generic;

namespace Modelo
{
    public class Archivo : Component
    {
        private int _tamano;

        public Archivo(int tamano, string nombre) : base(nombre)
        {
            _tamano = tamano;
        }

        public override int ObtenerTamano()
        {
            return this._tamano;
        }

        public override void AgregarHijo(Component c)
        {
            throw new System.NotImplementedException();
        }

        public override IList<Component> ObtenerHijos()
        {
            throw new System.NotImplementedException();
        }
    }
}
