namespace Patrones_GOF.Services.Comportamiento.Strategy
{
    public abstract class Arma
    {

        public override string ToString()
        {
            return this.GetType().Name;
        }
        public abstract string Disparar();
    }
}
