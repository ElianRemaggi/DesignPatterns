namespace ModeloVisitor
{
    public class DiscoRigido : Componente
    {
        public DiscoRigido(int serial) : base(serial)
        {
        }

        public override void Aceptar(IVisitor IV)
        {
            IV.Visitar(this);
        }
    }
}
