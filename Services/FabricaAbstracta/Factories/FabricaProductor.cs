namespace Patrones_GOF.Services.FabricaAbstracta.Factories;

public static class FabricaProductor
{
    public static IFabricaAbstracta GetFactory(string tipo)
    {
        if (tipo == "BD")
            return new ConexionBDFabrica();
        else if (tipo == "REST")
            return new ConexionRESTFabrica();
        else
            return null;
    }
}
