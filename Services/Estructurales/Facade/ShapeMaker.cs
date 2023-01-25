namespace Patrones_GOF.Services.Estructurales.Facade
{
    public class ShapeMaker
    {
        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();

        public void DrawSquare()
        {
            square.Draw();
        }
        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
