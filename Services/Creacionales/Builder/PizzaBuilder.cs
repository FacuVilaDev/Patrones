namespace Patrones_GOF.Services.Estructurales.Builder
{
    public abstract class PizzaBuilder
    {
        protected string _descripcion;
        public abstract Agregado BuildAgregado();
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();

        public override string ToString()
        {
            return _descripcion;
        }
        public Pizza BuildPizza() 
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            Agregado agregado = BuildAgregado();

            return new Pizza(masa,salsa,agregado,_descripcion );
        }
    }
}
