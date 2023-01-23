using Patrones_GOF.Services.Creacionales.FabricaAbstracta.Interfaces;

namespace Patrones_GOF.Services.Creacionales.FabricaAbstracta;

public class ConexionRESTVentas : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Conectándose a Ventas:" + url);
    }
}
