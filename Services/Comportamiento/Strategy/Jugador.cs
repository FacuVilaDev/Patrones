namespace Patrones_GOF.Services.Comportamiento.Strategy
{
    public class Jugador
    {
        Arma _estrategia;

        public Jugador(Arma estrategia, string nombre)
        {
            _estrategia = estrategia;
            Nombre = nombre;
        }

        public void CambiarEstrategia(Arma estrategia)
        {
            if (estrategia == null)
                throw new Exception("La estrategia de disparo no es válida");
            _estrategia = estrategia;
        }

        public string Nombre { get; set; }

        public string Disparar()
        {
            if (_estrategia == null) return "Arma no disponible";
            return _estrategia.Disparar();
        }
    }
}
