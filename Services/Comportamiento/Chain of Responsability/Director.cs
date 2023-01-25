namespace Patrones_GOF.Services.Comportamiento.Chain_of_Responsability
{
    public class Director : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
        }
    }
}
