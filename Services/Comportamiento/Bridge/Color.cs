namespace Patrones_GOF.Services.Comportamiento.Bridge
{
    public abstract class Color
    {
        public abstract void AplicarColor();
    }

    public class ColorRojo : Color
    {
        public override void AplicarColor()
        {
            Console.WriteLine("Aplicando color rojo");
        }
    }

}
