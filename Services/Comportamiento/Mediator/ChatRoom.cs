namespace Patrones_GOF.Services.Comportamiento.Mediator
{
    public class ChatRoom : Chat
    {
        IDictionary<string, Usuario> _participantes;
        
        public ChatRoom() 
        {
            _participantes= new Dictionary<string, Usuario>();
        }

        public override void Enviar(string _mensaje, Usuario _para, Usuario _de)
        {
            Mensaje msg = new Mensaje();
            msg.De = _de;
            msg.Para = _para;
            msg.Texto = _mensaje;

            if (_participantes.ContainsKey(_para.Nombre))
            {
                _participantes[_para.Nombre].Recibir(msg);
                _mensajes.Add(msg);
            }
        }
        public override void Registrar(Usuario _usuario)
        {
            if (!_participantes.ContainsKey(_usuario.Nombre))
                _participantes.Add(_usuario.Nombre, _usuario);
        }

    }
}
