namespace Patrones_GOF.Services.Comportamiento.Visitor
{
    public class VisitanteConcreto : IVisitor
    {
        public void Visitar(Procesador componente)
        {
            Console.WriteLine(String.Format($"Procesador s/n {componente.Serial}"));
        }

        public void Visitar(PlacaBase componente)
        {
            Console.WriteLine(String.Format($"Procesador s/n {componente.Serial}"));
        }

        public void Visitar(DiscoRigido componente)
        {
            Console.WriteLine(String.Format($"Procesador s/n {componente.Serial}"));
        }
    }
}
