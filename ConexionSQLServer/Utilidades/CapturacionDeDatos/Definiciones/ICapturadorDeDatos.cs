using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.CapturacionDeDatos.Definiciones
{
    public interface ICapturadorDeDatos
    {
        public string CapturarString();
        public int CapturarEntero();
        char CapturarCaracter();
    }
}
