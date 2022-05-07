

using System.Data.SqlClient;

namespace ConexionSQLServer.Definiciones
{
    public interface IConexion
    {
        public void Conectar();
        public SqlConnection ObtenerConexion();
    }
}
