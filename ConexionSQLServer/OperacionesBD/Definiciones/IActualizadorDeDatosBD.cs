using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.OperacionesBD.Definiciones
{
    public interface IActualizadorDeDatosBD
    {
        public void Actualizar(int id,Persona nuevaPersona);
    }
}
