namespace Patrones_GOF.Services.Decorator
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
