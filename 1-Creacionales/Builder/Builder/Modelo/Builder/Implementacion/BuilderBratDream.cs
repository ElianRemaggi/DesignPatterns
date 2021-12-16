namespace Modelo
{
    public class BuilderBratDream : IMotoBuilder
    {
        public BuilderBratDream()
        {
            this.Cubiertas = this.buildCubiertas();
            this.Estilo = this.buildEstilo();
            this.Motor = this.buildMotor();
        }

        protected override Cubiertas buildCubiertas()
        {
            return new Cubierta130_90_17();
        }

        protected override Estilo buildEstilo()
        {
            return new EstiloBrat();
        }

        protected override Motor buildMotor()
        {
            return new Motor600();
        }
    }
}
