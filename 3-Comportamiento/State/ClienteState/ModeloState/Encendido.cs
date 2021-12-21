namespace ModeloState
{
    public class Encendido : IEstado
    {
        public void CambiarEstado(Switch sw)
        {
            sw.DefinirEstado(new Apagado());
        }

        public string Describir()
        {
            return "Estado Encendido";
        }
    }
}
