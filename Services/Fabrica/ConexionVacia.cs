namespace Patrones_GOF.Services.Fabrica;

public class ConexionVacia : IConexion
{
    public void Conectar()
    {
        Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
    }

    public void Desconectar()
    {
        Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
    }
}
