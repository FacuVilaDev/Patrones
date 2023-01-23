namespace Patrones_GOF.Services.Creacionales.Singleton;

public class Conexion
{
    private static Conexion Instancia;

    private Conexion()
    {

    }
    public static Conexion GetConexion()
    {
        if (Instancia == null)
        {
            Instancia = new Conexion();
        }
        return Instancia;
    }
    public void Conectar()
    {
        Console.WriteLine("Me conecté a la BD");
    }
    public void Desconectar()
    {
        Console.WriteLine("Me deconecté de la BD");
    }
}
