using ConexionSQLServer.App;
using ConexionSQLServer.Entidades;
using System;
using System.Collections.Generic;

namespace ConexionSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacion _Aplicacion = new Aplicacion();
            _Aplicacion.Inicializar();
            _Aplicacion.LanzarMenu();
        }
    }
}
