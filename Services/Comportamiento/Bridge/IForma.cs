namespace Patrones_GOF.Services.Comportamiento.Bridge
{
    public interface IForma
    {
        void Dibujar();
    }
    public class Cuadrado : IForma
    {
        private readonly Color _color;

        public Cuadrado(Color color)
        {
            _color = color;
        }

        public void Dibujar()
        {
            Console.Write("Dibujando un cuadrado. ");
            _color.AplicarColor();
        }
    }

    public class Circulo : IForma
    {
        private readonly Color _color;

        public Circulo(Color color)
        {
            _color = color;
        }

        public void Dibujar()
        {
            Console.Write("Dibujando un círculo. ");
            _color.AplicarColor();
        }
    }
}
