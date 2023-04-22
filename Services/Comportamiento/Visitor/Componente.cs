namespace Patrones_GOF.Services.Comportamiento.Visitor
{
    public abstract class Componente
    {
        protected Componente(string serial)
        {
            Serial = serial;
        }

        public string Serial { get; set; }

        public abstract void Aceptar(IVisitor visitor);
    }
}
