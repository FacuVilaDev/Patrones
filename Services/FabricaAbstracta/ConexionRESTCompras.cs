namespace Patrones_GOF.Services.FabricaAbstracta;

public class ConexionRESTCompras : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Conectándose a Compras:" + url);
    }
}
