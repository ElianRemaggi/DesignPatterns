namespace ModeloVisitor
{
    public interface IVisitor
    {
         void Visitar(DiscoRigido DR);
         void Visitar(Procesador P);
         void Visitar(PlacaBase PB);
    }
}
