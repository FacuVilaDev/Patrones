namespace Patrones_GOF.Services.Estructurales.Builder
{
    public class PizzaMuzzaBuilder : PizzaBuilder
    {
        public PizzaMuzzaBuilder()
        {
            _descripcion = "Pizza de Muzzarella";
        }

        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
