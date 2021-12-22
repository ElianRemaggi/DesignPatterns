
namespace ModeloTemplateMethod
{
    public class Cliente
    {
        private string _nombre;

        public Cliente(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
