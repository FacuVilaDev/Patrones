namespace Patrones_GOF.Services.Comportamiento.Command
{
    public class ProductoReceiver
    {

        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        public void RestarStock(double cant)
        {
            Cantidad = Cantidad - cant;
            Console.WriteLine($"Quitando {cant} unidades");
        }

        public void SumarStock(double cant)
        {
            Cantidad = Cantidad + cant;
            Console.WriteLine($"Agregando {cant} unidades");
        }
    }
}
