namespace Patrones_GOF.Services.FabricaAbstracta;

public class ConexionRESTVentas : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Conectándose a Ventas:" + url);
    }
}
