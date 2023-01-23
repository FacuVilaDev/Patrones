namespace Patrones_GOF.Services.Comportamiento.Observer
{
    public class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> _usuarios;

        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            Precio = precio;
        }
        public string Nombre { get; set; }
        private double _precio;
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                Notificar();
            }
        }
        public override string ToString()
        {
            return $"{Nombre} (${_precio})";
        }
        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((Usuario)usuario).Nombre}");
            }
        }
        public void Notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }

            if (_usuarios.Count == 0)
            {
                Console.WriteLine("No hay suscripciones");
            }
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------");
        }
        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripción para {(Usuario)usuario}");
            }
        }
    }
}
