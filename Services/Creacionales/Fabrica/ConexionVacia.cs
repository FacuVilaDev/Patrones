using Patrones_GOF.Services.Creacionales.Fabrica.Interfaces;

namespace Patrones_GOF.Services.Creacionales.Fabrica;

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
