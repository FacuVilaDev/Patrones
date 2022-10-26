namespace Patrones_GOF.Services.FabricaAbstracta.Factories;

public class ConexionRESTFabrica : IFabricaAbstracta
{
    public IConexion GetConexion(string motor)
    {
        return null;
    }

    public IConexionREST GetREST(string area)
    {
        return area switch
        {
            "COMPRAS" => new ConexionRESTCompras(),
            "VENTAS" => new ConexionRESTVentas(),
            _ => new ConexionRESTNoArea(),
        };
    }
}
