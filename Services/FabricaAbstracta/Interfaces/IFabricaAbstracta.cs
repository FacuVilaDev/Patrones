namespace Patrones_GOF.Services.FabricaAbstracta.Interfaces;

public interface IFabricaAbstracta
{
    IConexion GetConexion(string motor);
    IConexionREST GetREST(string area);
}
