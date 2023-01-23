namespace Patrones_GOF.Services.Estructurales.Builder
{
    public class Pizza
    {
        Masa _masa;
        Salsa _salsa;
        Agregado _agregado;
        string _tipo;

        public Pizza(Masa masa, Salsa salsa, Agregado agregado, string tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _tipo = tipo;
        }

        public override string ToString()
        {
            return $"{_tipo}, Masa: {_masa.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }

    }
}
