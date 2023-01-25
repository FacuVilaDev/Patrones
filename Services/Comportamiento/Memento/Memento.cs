using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;

namespace Patrones_GOF.Services.Comportamiento.Memento
{
    public class Memento
    {
        private string _estado;
        public string Estado
        {
            get
            {
                return _estado;
            }
        }
        public Memento()
        {
        }

        public Memento(string estado)
        {
            _estado = estado;
        }
    }
}
