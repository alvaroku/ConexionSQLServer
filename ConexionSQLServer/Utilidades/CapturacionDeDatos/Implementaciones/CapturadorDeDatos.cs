using ConexionSQLServer.Utilidades.CapturacionDeDatos.Definiciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.CapturacionDeDatos.Implementaciones
{
    public class CapturadorDeDatos : ICapturadorDeDatos
    {
        public char CapturarCaracter()
        {
            string dato = Console.ReadLine();
            return char.Parse(dato);
        }

        public int CapturarEntero()
        {
            string dato = Console.ReadLine();
            return Convert.ToInt32(dato);
        }

        public string CapturarString()
        {
            string dato = Console.ReadLine();
            return dato;
        }
    }
}
