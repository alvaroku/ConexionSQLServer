using ConexionSQLServer.Entidades;
using ConexionSQLServer.Utilidades.Definiciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.Implementaciones
{
    public class VisualizadorDeRegistros : IVisualizadorDeRegistros
    {
        ImpresorDeTexto _VisualizadorDeTextos;

        public VisualizadorDeRegistros()
        {
            _VisualizadorDeTextos = new ImpresorDeTexto();
        }
        public void Visualizar(List<Persona> DatosPorVisualizar)
        {
            foreach(Persona persona in DatosPorVisualizar)
            {
                _VisualizadorDeTextos.ImprimirTexto(persona.ToString());
            }
        }
    }
}
