using ConexionSQLServer.Utilidades.Definiciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Utilidades.Implementaciones
{
    public class ImpresorDeTexto : IImpresorDeTexto
    {
        public void ImprimirTitulo(string mensaje, char caracter = '=')
        {
            int tam = mensaje.Length+4;

            DibujarLineaDeCaracter(tam,caracter);
            ImprimirTexto($"| {mensaje} |");
            DibujarLineaDeCaracter(tam,caracter);

        }
        public void ImprimirTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public void DibujarLineaDeCaracter(int tam, char caracter = '=')
        {
            Console.WriteLine("".PadLeft(tam, caracter));
        }
    }
}
