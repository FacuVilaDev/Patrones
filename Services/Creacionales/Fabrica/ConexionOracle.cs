using Patrones_GOF.Services.Creacionales.Fabrica.Interfaces;

namespace Patrones_GOF.Services.Creacionales.Fabrica;

public class ConexionOracle : IConexion
{
    private string Host;
    private string Puerto;
    private string Usuario;
    private string Contraseña;

    public ConexionOracle()
    {
        Host = "localhost";
        Puerto = "1521";
        Usuario = "admin";
        Contraseña = "123";
    }
    public void Conectar()
    {
        Console.WriteLine("Se Conectó al Oracle");
    }

    public void Desconectar()
    {
        Console.WriteLine("Se Desconectó al Oracle");
    }
}
