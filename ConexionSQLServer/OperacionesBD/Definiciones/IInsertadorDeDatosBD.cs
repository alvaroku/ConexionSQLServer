using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.OperacionesBD.Definiciones
{
    public interface IInsertadorDeDatosBD
    {
        public void Insertar(Persona persona);
    }
}
