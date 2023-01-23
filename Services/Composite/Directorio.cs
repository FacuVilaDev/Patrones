namespace Patrones_GOF.Services.Composite
{
    public class Directorio : Component
    {
        public List<Component> _hijos;

        public Directorio(string nombre): base(nombre)
        {
            _hijos = new List<Component>();
        }

        public override int ObtenerTamaño { 
            get 
            {
                int t = 0;

                foreach (var item in _hijos)
                {
                    t += item.ObtenerTamaño;
                }
                return t;
            } 
        }

        public override void AgregarHijo(Component C)
        { 
            _hijos.Add(C);
        }

        public override IList<Component> ObtenerHijos()
        {
            return _hijos.ToArray();
        }
    }
}
