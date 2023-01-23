using Patrones_GOF.Services.Creacionales.Fabrica.Interfaces;

namespace Patrones_GOF.Services.Creacionales.Fabrica;

public class ConexionPostgre : IConexion
{
    private string Host;
    private string Puerto;
    private string Usuario;
    private string Contraseña;

    public ConexionPostgre()
    {
        Host = "localhost";
        Puerto = "5433";
        Usuario = "postgres";
        Contraseña = "123";
    }
    public void Conectar()
    {
        Console.WriteLine("Se Conectó al PostgreSQL");
    }

    public void Desconectar()
    {
        Console.WriteLine("Se Desconectó al PostgreSQL");
    }
}
