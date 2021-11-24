using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Sujeto en observacion, posee una lista de observadores que reaccionan a un cambio de esteado de esta clase

    class Subject
    {

        private List<Observador> observadores = new List<Observador>();
        private int estado;

        public int getEstado(){
            return estado;   
        }
        public void setEstado(int valor)
        {
            this.estado = valor;
            notificarObservadores();
        }

        public void notificarObservadores()
        {
            foreach (Observador o in this.observadores)
            {
                o.actualizar();
            }
        }

        public void agregar(Observador o)
        {
            this.observadores.Add(o);
        }

        
    }
}
