namespace Patrones_GOF.Services.FabricaAbstracta;

public class ConexionRESTNoArea : IConexionREST
{
    public void LeerUrl(string url)
    {
        Console.WriteLine("Area no especificada");
    }
}
