using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.Definiciones
{
    public interface IImpresorDeTexto
    {
        public void ImprimirTitulo(string titulo,char caracter = '=');
        public void ImprimirTexto(string mensaje);
        public void DibujarLineaDeCaracter(int tam, char caracter='=');
    }
}
