using Patrones_GOF.Services.Creacionales.Fabrica.Interfaces;

namespace Patrones_GOF.Services.Creacionales.Fabrica;

public class ConexionFabrica
{
    public IConexion GetConexion(string motor)
    {
        if (motor == null)
            return new ConexionVacia();
        switch (motor)
        {
            case "MYSQL":
                return new ConexionMySql();
            case "ORACLE":
                return new ConexionOracle();
            case "POSTGRE":
                return new ConexionPostgre();
            case "SQL":
                return new ConexionSQLServer();
            default:
                return new ConexionVacia();
        }
    }
}
