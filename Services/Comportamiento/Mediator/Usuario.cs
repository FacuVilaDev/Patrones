namespace Patrones_GOF.Services.Comportamiento.Mediator
{
    public abstract class Usuario
    {

        List<Mensaje> _mensajes;
        string _nombre;

        public Usuario(string nombre) 
        {
            _nombre = nombre;
            _mensajes= new List<Mensaje>();
        }


        public Mensaje[] mensajes { get=> _mensajes.ToArray(); }
        public string Nombre { get=> _nombre; }


        public override string ToString()
        {
            return _nombre;
        }

        public Chat Chat { get; set; }
        public void Enviar(string _mensaje, Usuario _para)
        {
            Chat.Enviar(_mensaje, _para, this);
        }
        public void Recibir(Mensaje msg)
        {
            _mensajes.Add(msg);
        }
    }
}
