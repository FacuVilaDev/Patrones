namespace Patrones_GOF.Services.Estructurales.Composite
{
    public abstract class Component
    {
        private string _nombre;
        protected Component(string nombre)
        {
            _nombre = nombre;
        }
        public string Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(Component c);
        public abstract IList<Component> ObtenerHijos();
        public abstract int ObtenerTamaño { get; }
    }
}
