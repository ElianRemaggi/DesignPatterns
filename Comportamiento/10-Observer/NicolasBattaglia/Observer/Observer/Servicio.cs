using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Servicio : IServicio
    {

        public List<IObserverUsuario> _usuarios;
        private string _nombre;
        private double _precio;

        public Servicio(string producto, double precio)
        {
            this._precio = precio;
            this.Nombre = producto;
            this._usuarios = new List<IObserverUsuario>();
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio {
            get { return _precio; }
            set {
                _precio = value;
                this.notificar(); // Accion del observer
            }
        }

        public void Agregar(IObserverUsuario iou)
        {
            this._usuarios.Add(iou);
        }
        public void Quitar(IObserverUsuario iou)
        {
            this._usuarios.Remove(iou);
        }
        public void notificar()
        {
            foreach(var u in _usuarios)
            {
                u.actualizar(this);
            }
        }

        
    }
}
