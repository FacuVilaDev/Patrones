namespace Patrones_GOF.Services.Estructurales.Decorator
{
    public class CafeSinCafeina : BebidaComponent
    {
        public override double Costo => 15;
        public override string Descripcion => "Café descafeinado";
    }
}
