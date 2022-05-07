using ConexionSQLServer.Definiciones;
using ConexionSQLServer.Entidades;
using ConexionSQLServer.Implementaciones;
using ConexionSQLServer.OperacionesBD.Definiciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConexionSQLServer.OperacionesBD.Implementaciones
{
    public class InsertadorDeDatosBD:IInsertadorDeDatosBD
    {
        private IConexion _ConexionMSSQLServer { get; set; }

        public InsertadorDeDatosBD(IConexion conexion) => (_ConexionMSSQLServer) = (conexion);

        public void Insertar(Persona persona)
        {
            _ConexionMSSQLServer.Conectar();
            
            string query = "INSERT INTO users (first_name,last_name,edad) " +
                "VALUES(@nombre,@apellido,@edad)";
            SqlCommand command = new SqlCommand(query, _ConexionMSSQLServer.ObtenerConexion());

            command.Parameters.AddWithValue("@nombre", persona.Nombre);
            command.Parameters.AddWithValue("@apellido", persona.Apellido);
            command.Parameters.AddWithValue("@edad", persona.Edad);

            _ConexionMSSQLServer.ObtenerConexion().Open();
            command.ExecuteNonQuery();
            _ConexionMSSQLServer.ObtenerConexion().Close();
        }
    }
}
