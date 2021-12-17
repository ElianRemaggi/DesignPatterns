using System.Collections.Generic;

namespace Modelo
{
    public class Directorio : Component
    {

        private IList<Component> _hijos;

        public Directorio(string nombre) : base(nombre)
        {
            this._hijos = new List<Component>();
        }

        public override void AgregarHijo(Component c)
        {
            this._hijos.Add(c);
        }

        public override IList<Component> ObtenerHijos()
        {
            return this._hijos;
        }

        public override int ObtenerTamano()
        {

            int t = 0;

            foreach (Component hijo in this.ObtenerHijos())
            {
                t += hijo.ObtenerTamano();
            }

            return t;
        }
    }
}
