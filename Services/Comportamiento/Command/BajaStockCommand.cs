using Patrones_GOF.Services.Comportamiento.Observer;

namespace Patrones_GOF.Services.Comportamiento.Command
{
    public class BajaStockCommand: OrdenCommand
    {
        public BajaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
