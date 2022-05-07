using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Definiciones
{
    public interface ILectorDeDatosBD
    {
        public List<Persona> LeerDatos();
    }
}
