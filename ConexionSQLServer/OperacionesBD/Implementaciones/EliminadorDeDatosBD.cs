using ConexionSQLServer.Definiciones;
using ConexionSQLServer.Implementaciones;
using ConexionSQLServer.OperacionesBD.Definiciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConexionSQLServer.OperacionesBD.Implementaciones
{
    public class EliminadorDeDatosBD : IEliminadorDeDatosBD
    {
        private IConexion _ConexionMSSQLServer { get; set; }

        public EliminadorDeDatosBD(IConexion conexion) => (_ConexionMSSQLServer) = (conexion);

        public void Eliminar(int id)
        {
            _ConexionMSSQLServer.Conectar();

            string query = "DELETE FROM  users WHERE id = @Id";
            SqlCommand command = new SqlCommand(query, _ConexionMSSQLServer.ObtenerConexion());

            command.Parameters.AddWithValue("@Id", id);

            _ConexionMSSQLServer.ObtenerConexion().Open();
            command.ExecuteNonQuery();
            _ConexionMSSQLServer.ObtenerConexion().Close();
        }
    }
}
