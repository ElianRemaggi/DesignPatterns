namespace ModeloState
{
    public class Apagado : IEstado
    {
        public void CambiarEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public string Describir()
        {
            return "Estado Apagado";
        }
    }
}
