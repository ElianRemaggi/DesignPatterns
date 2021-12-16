namespace Modelo
{
    public abstract class IMotoBuilder : IMoto
    {
        private string _descripcion;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        protected abstract Motor buildMotor();
        protected abstract Estilo buildEstilo();
        protected abstract Cubiertas buildCubiertas();

        
    }
}
