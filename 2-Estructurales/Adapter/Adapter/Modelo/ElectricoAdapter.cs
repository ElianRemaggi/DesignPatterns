namespace Modelo
{
    public class ElectricoAdapter : IMotor
    {

        MotorElectrico me = new MotorElectrico();

        public string acelerar()
        {
          return me.Mover();
        }

        public string apagar()
        {
          return me.Parar();
        }

        public string arrancar()
        {
          return me.Activar();
        }

        public string cargarCombustible()
        {
          return me.Conectar();
        }
    }
}
