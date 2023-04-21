namespace Patrones_GOF.Services.Comportamiento.Command
{
    public abstract class OrdenCommand
    {
        public abstract void Ejecutar();
        protected ProductoReceiver _producto;
        protected double _cantidad;

        protected OrdenCommand(ProductoReceiver producto, double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }
    }
}
