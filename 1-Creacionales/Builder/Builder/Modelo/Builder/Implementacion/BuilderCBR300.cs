namespace Modelo
{
    public class BuilderCBR300 : IMotoBuilder

    {
        public BuilderCBR300()
        {
            this.Cubiertas = this.buildCubiertas();
            this.Estilo = this.buildEstilo();
            this.Motor = this.buildMotor();
        }

        protected override Cubiertas buildCubiertas()
        {
            return new Cubierta120_90_17();
        }

        protected override Estilo buildEstilo()
        {
            return new EstiloDeportivo();
        }

        protected override Motor buildMotor()
        {
            return new Motor300();
        }
    }
}
