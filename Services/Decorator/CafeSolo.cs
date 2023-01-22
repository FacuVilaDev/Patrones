namespace Patrones_GOF.Services.Decorator
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;
        public override string Descripcion => "Café solo";
    }
}
