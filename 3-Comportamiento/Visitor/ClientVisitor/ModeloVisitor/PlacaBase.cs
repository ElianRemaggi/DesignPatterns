namespace ModeloVisitor
{
    public class PlacaBase : Componente
    {
        public PlacaBase(int serial) : base(serial)
        {
        }

        public override void Aceptar(IVisitor IV)
        {
            IV.Visitar(this);
        }
    }
}
