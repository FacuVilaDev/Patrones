namespace Patrones_GOF.Services.Comportamiento.Mediator
{
    public abstract class Chat
    {

        protected List<Mensaje> _mensajes;

        public Chat()
        {
            _mensajes= new List<Mensaje>();
        }

        public Mensaje[] Mensajes { get=>  _mensajes.ToArray(); }

        public abstract void Enviar(string _mensaje, Usuario _para, Usuario _de);
        public abstract void Registrar(Usuario _usuario);
    }
}
