namespace Patrones_GOF.Services.Comportamiento.Memento
{
    public class CareTaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void Add (Memento m)
        {
            _mementos.Add(m);  
        }

        public Memento GetMemento(int index) 
        {
            return _mementos[index];
        }

    }
}
