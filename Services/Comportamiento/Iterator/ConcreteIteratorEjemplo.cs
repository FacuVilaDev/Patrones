namespace Patrones_GOF.Services.Comportamiento.Iterator
{
    public class ConcreteIteratorEjemplo : IteratorEjemplo
    {
        private Collection _aggregate = new ConcreteCollection();
        private Item _item;
        public ConcreteIteratorEjemplo(Collection _agregado)
        {
            _aggregate = _agregado;
        }

        public override Item CurrentItem()
        {
            return _item;
        }

        public override void First()
        {
            _item = _aggregate.Index(0);
        }

        public override bool IsDone()
        {
            if (_aggregate.Count() == _aggregate.Posicion() + 1)
                return true;
            else
                return false;
        }

        public override void Siguiente()
        {
            _item = _aggregate.Index(_aggregate.Posicion() + 1);
        }
    }
}
