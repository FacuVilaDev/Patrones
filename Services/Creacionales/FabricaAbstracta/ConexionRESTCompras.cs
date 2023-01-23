using Patrones_GOF.Services.Creacionales.FabricaAbstracta.Interfaces;

namespace Patrones_GOF.Services.Creacionales.FabricaAbstracta;

public class ConexionRESTCompras : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Conectándose a Compras:" + url);
    }
}
