namespace Patrones_GOF.Services.Fabrica;

public class ConexionSQLServer : IConexion
{
    private string Host;
    private string Puerto;
    private string Usuario;
    private string Contraseña;

    public ConexionSQLServer()
    {
        Host = "localhost";
        Puerto = "1433";
        Usuario = "admin";
        Contraseña = "123";
    }
    public void Conectar()
    {
        Console.WriteLine("Se Conectó al SQLServer");
    }

    public void Desconectar()
    {
        Console.WriteLine("Se Desconectó al SQLServer");
    }
}
