using Patrones_GOF.Services.Creacionales.FabricaAbstracta.Interfaces;

namespace Patrones_GOF.Services.Creacionales.FabricaAbstracta;

public class ConexionRESTNoArea : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Area no especificada");
    }
}
