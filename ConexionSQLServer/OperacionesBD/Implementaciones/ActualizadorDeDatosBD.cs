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
    public class ActualizadorDeDatosBD:IActualizadorDeDatosBD
    {
        private IConexion _ConexionMSSQLServer { get; set; }

        public ActualizadorDeDatosBD(IConexion conexion) => (_ConexionMSSQLServer) = (conexion);
        
        public void Actualizar(int id,Persona nuevosDatos)
        {
            _ConexionMSSQLServer.Conectar();

            string query = "UPDATE users set first_name = @nuevoNombre, last_name = @nuevoApellido" +
                ", edad = @nuevaEdad  WHERE id = @Id";
            SqlCommand command = new SqlCommand(query, _ConexionMSSQLServer.ObtenerConexion());

            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@nuevoNombre", nuevosDatos.Nombre);
            command.Parameters.AddWithValue("@nuevoApellido", nuevosDatos.Apellido);
            command.Parameters.AddWithValue("@nuevaEdad", nuevosDatos.Edad);

            _ConexionMSSQLServer.ObtenerConexion().Open();
            command.ExecuteNonQuery();
            _ConexionMSSQLServer.ObtenerConexion().Close();
        }
    }
}
