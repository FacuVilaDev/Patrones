namespace Patrones_GOF.Services.Comportamiento.Iterator
{
    public class ConcreteCollection: Collection
    {
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion;

        public override void Agregar(Item _item)
        {
            _listaItems.Add(_item);
        }

        public override int Count()
        {
            return _listaItems.Count;
        }

        public override IteratorEjemplo CreateIterator()
        {
            return new ConcreteIteratorEjemplo(this);
        }

        public override Item Index(int index)
        {
            _item = _listaItems[index];
            _posicion = index;
            return _item;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}
