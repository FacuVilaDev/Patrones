namespace Patrones_GOF.Services.Comportamiento.Observer
{
    public class Usuario : IObserverUsuario
    {
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
        public void Actualizar(Producto p)
        {
            Console.WriteLine($"El usuario {this} recibió la notificación del producto {p}");
        }
    }
}
