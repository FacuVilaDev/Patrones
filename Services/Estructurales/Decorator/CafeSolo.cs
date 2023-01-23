namespace Patrones_GOF.Services.Estructurales.Decorator
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;
        public override string Descripcion => "Café solo";
    }
}
