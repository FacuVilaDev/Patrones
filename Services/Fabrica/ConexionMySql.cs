namespace Patrones_GOF.Services.Fabrica;

public class ConexionMySql : IConexion
{
    private string Host;
    private string Puerto;
    private string Usuario;
    private string Contraseña;

    public ConexionMySql()
    {
        Host = "localhost";
        Puerto = "3306";
        Usuario = "root";
        Contraseña = "123";
    }
    public void Conectar()
    {
        Console.WriteLine("Se Conectó al MySQL");
    }

    public void Desconectar()
    {
        Console.WriteLine("Se Desconectó al MySQL");
    }
}
