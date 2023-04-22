namespace Patrones_GOF.Services.Comportamiento.Iterator
{
    public abstract class Collection
    {
        public abstract IteratorEjemplo CreateIterator();
        public abstract void Agregar(Item item);
        public abstract Item Index(int index);
        public abstract int Count();
        public abstract int Posicion();
    }
}
