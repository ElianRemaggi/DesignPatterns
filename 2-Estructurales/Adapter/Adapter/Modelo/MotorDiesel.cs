namespace Modelo
{
    public class MotorDiesel : IMotor
    {
        public string acelerar()
        {
            return "Acelerando motor Diesel";
        }

        public string apagar()
        {
            return "Apagando motor Diesel";
        }

        public string arrancar()
        {
            return "Arrancando motor Diesel";
        }

        public string cargarCombustible()
        {
            return "Cargando combustible";
        }
    }
}
