using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.Definiciones
{
    public interface IVisualizadorDeRegistros
    {
        public void Visualizar(List<Persona> DatosPorVisualizar);
    }
}
