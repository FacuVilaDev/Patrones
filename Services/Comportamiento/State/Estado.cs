namespace Patrones_GOF.Services.Comportamiento.State
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Switch sw);
        public abstract string Describir();
    }
}
