namespace Patrones_GOF.Services.Estructurales.Decorator
{
    public abstract class AgregadoDecorator : BebidaComponent
    {
        protected BebidaComponent _bebida;

        protected AgregadoDecorator(BebidaComponent bebida)
        {
            _bebida = bebida;
        }
    }
}
