namespace Modelo
{
    public class BuilderCeccato : IMotoBuilder
    {
        public BuilderCeccato()
        {
            this.Cubiertas = this.buildCubiertas();
            this.Estilo = this.buildEstilo();
            this.Motor = this.buildMotor();
        }

        protected override Cubiertas buildCubiertas()
        {
            return new Cubierta110_90_17();
        }

        protected override Estilo buildEstilo()
        {
            return new EstiloVintage();
        }

        protected override Motor buildMotor()
        {
            return new Motor150();
        }
    }
}
