using ConexionSQLServer.Definiciones;
using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionSQLServer.Implementaciones
{
    public class LectorDeDatosBD : ILectorDeDatosBD
    {
        private  IConexion _ConexionMSSQLServer { get; set; }

        public LectorDeDatosBD(IConexion conexion) => (_ConexionMSSQLServer) = (conexion);

        public List<Persona> LeerDatos()
        {
            _ConexionMSSQLServer.Conectar();
            
            //Formar la sentencia SQL, un SELECT en este caso
            SqlDataReader myReader = null;
            string strCadSQL = "SELECT * FROM users";
            SqlCommand myCommand = new SqlCommand(strCadSQL, _ConexionMSSQLServer.ObtenerConexion());

            _ConexionMSSQLServer.ObtenerConexion().Open();
            //Ejecutar el comando SQL
            myReader = myCommand.ExecuteReader();
           
            //Almacenar en un list los datos
            List<Persona> DatosLeidos = new List<Persona>();
            while (myReader.Read())
            {
                int id = Convert.ToInt32(myReader["id"].ToString());
                string nombre = myReader["first_name"].ToString();
                string apellido = myReader["last_name"].ToString();
                int edad = Convert.ToInt32(myReader["edad"].ToString());

                DatosLeidos.Add(new Persona(id, nombre, apellido, edad));
            }
            _ConexionMSSQLServer.ObtenerConexion().Close();

            return DatosLeidos;
        }
    }
}
