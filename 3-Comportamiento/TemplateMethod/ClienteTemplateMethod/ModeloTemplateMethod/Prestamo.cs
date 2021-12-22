
namespace ModeloTemplateMethod
{
    public abstract class Prestamo : Verificaciones
    {
        private Cliente _cliente;
        protected Prestamo(Cliente c)
        {
            this._cliente = c;
        }

        public abstract void Verificar();
        public abstract string VerificarAcciones();
        public abstract string VerificarBalance();
        public abstract string VerificarCreditos();
        public abstract string VerificarIngresos();

    }
}
