namespace ModeloVisitor
{
    public class Procesador : Componente
    {
        public Procesador(int serial) : base(serial)
        {
        }

        public override void Aceptar(IVisitor IV)
        {
            IV.Visitar(this);
        }
    }
}
