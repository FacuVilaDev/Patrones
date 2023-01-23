namespace Patrones_GOF.Services.Composite
{
    public class Archivo : Component
    {
        public Archivo(string nombre, int tamaño) : base(nombre)
        {
            _tamaño = tamaño;
        }

        private int _tamaño;
        public int Tamaño { get { return _tamaño; } }
        public override int ObtenerTamaño
        {
            get 
            {
                return _tamaño;
            }
        }

        public override void AgregarHijo(Component c)
        {
        }

        public override IList<Component> ObtenerHijos()
        {
            return null;
        }
    }
}
