namespace Patrones_GOF.Services.Comportamiento.State
{
    public class Encendido : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Apagado());
        }

        public override string Describir()
        {
            return "Switch encendido";
        }
    }
}
