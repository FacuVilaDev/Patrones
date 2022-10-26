namespace Patrones_GOF.Services.FabricaAbstracta.Factories;

public class ConexionBDFabrica : IFabricaAbstracta
{
    public IConexion GetConexion(string motor)
    {
        return motor switch
        {
            "MYSQL" => new ConexionMySql(),
            "ORACLE" => new ConexionOracle(),
            "POSTGRE" => new ConexionPostgre(),
            "SQL" => new ConexionSQLServer(),
            _ => new ConexionVacia(),
        };
    }

    public IConexionREST GetREST(string area)
    {
        return null;
    }
}
