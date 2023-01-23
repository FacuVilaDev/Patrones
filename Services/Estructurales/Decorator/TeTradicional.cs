namespace Patrones_GOF.Services.Estructurales.Decorator
{
    public class TeTradicional : BebidaComponent
    {
        public override double Costo => 8;
        public override string Descripcion => "Té tradicional";
    }
}
