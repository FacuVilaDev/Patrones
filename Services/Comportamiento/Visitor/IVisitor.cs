namespace Patrones_GOF.Services.Comportamiento.Visitor
{
    public interface IVisitor
    {
        void Visitar(Procesador procesador);
        void Visitar(PlacaBase placaBase);
        void Visitar(DiscoRigido discoRigido);
    }
}
