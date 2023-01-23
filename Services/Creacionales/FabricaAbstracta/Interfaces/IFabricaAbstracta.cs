using Patrones_GOF.Services.Creacionales.Fabrica.Interfaces;

namespace Patrones_GOF.Services.Creacionales.FabricaAbstracta.Interfaces;

public interface IFabricaAbstracta
{
    IConexion GetConexion(string motor);
    IConexionREST GetREST(string area);
}
