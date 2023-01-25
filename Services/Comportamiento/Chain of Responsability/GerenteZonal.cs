namespace Patrones_GOF.Services.Comportamiento.Chain_of_Responsability
{
    public class GerenteZonal : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe < 1000)
            {
                Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
            }
            else
            {
                _siguiente.Procesar(c);
            }
        }
    }
}
