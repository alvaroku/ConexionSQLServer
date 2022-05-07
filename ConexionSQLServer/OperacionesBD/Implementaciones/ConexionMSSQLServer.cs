using ConexionSQLServer.Definiciones;
using System.Data.SqlClient;
using System;
namespace ConexionSQLServer.Implementaciones
{
    public class ConexionMSSQLServer : IConexion
    {
        private string Servidor {  get; set; }
        private string BaseDeDatos { get; set; }

        public SqlConnection SQLConexion { get; set; }
        public ConexionMSSQLServer(string servidor= "LAPTOP-MO1HC59V", string baseDeDatos= "registro") => (Servidor, BaseDeDatos) = (servidor, baseDeDatos);

        public void Conectar()
        {
            SQLConexion = new SqlConnection($"server={Servidor} ; database={BaseDeDatos} ; integrated security = true");
        }

        public SqlConnection ObtenerConexion()
        {
            return SQLConexion;
        }
    }
}
