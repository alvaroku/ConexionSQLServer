using ConexionSQLServer.App;

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
