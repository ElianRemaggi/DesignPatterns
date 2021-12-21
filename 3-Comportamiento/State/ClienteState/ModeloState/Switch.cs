using System;

namespace ModeloState
{
    public class Switch 
    {
        private IEstado estado;

        public Switch()
        {
            this.estado = new Apagado();
        }

        public void DefinirEstado(IEstado estado)
        {
            this.estado = estado;
        }

        public void Presionar()
        {
            estado.CambiarEstado(this);
            Console.WriteLine(estado.Describir());
        }
      
    }
}
