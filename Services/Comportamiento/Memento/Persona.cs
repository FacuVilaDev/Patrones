namespace Patrones_GOF.Services.Comportamiento.Memento
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Memento saveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
        }


        public void restoreToMemento(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Originator: Recuperando memento " + Nombre);
        }
    }
}
