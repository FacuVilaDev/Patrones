namespace Patrones_GOF.Services.Estructurales.Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new();
        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }

        public override void CargarCombustible()
        {
            motorElectrico.Enchufar();
        }

        public override void Detener()
        {
            motorElectrico.Desactivar();
            motorElectrico.Parar();
        }
    }
}
