using ConexionSQLServer.Definiciones;
using ConexionSQLServer.Entidades;
using ConexionSQLServer.Implementaciones;
using ConexionSQLServer.OperacionesBD.Definiciones;
using ConexionSQLServer.OperacionesBD.Implementaciones;
using ConexionSQLServer.Utilidades.CapturacionDeDatos.Definiciones;
using ConexionSQLServer.Utilidades.CapturacionDeDatos.Implementaciones;
using ConexionSQLServer.Utilidades.Definiciones;
using ConexionSQLServer.Utilidades.Implementaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.App
{
    public class Aplicacion
    {
        private IConexion _Conexion {  set; get; }
   
        private IImpresorDeTexto _ImpresorDeTexto { set; get; } 
        private IVisualizadorDeRegistros _VisualizadorDeRegistros { set; get; }

        private ICapturadorDeDatos _CapturadorDeDatos { set; get; }

        private IInsertadorDeDatosBD _InsertadorDeDatosBD { set; get; }
        private ILectorDeDatosBD _LectorDeDatosBD {  set; get; }
        private IActualizadorDeDatosBD _ActualizadorDeDatosBD { set; get; }
        private IEliminadorDeDatosBD _EliminadorDeDatosBD { set; get; }

        public Aplicacion()
        {

        }
        public void Inicializar()
        {
            _Conexion = new ConexionMSSQLServer();

            _ImpresorDeTexto = new ImpresorDeTexto();
            _VisualizadorDeRegistros = new VisualizadorDeRegistros();

            _CapturadorDeDatos = new CapturadorDeDatos();

            _InsertadorDeDatosBD = new InsertadorDeDatosBD(_Conexion);
            _LectorDeDatosBD = new LectorDeDatosBD(_Conexion);
            _ActualizadorDeDatosBD = new ActualizadorDeDatosBD(_Conexion);
            _EliminadorDeDatosBD = new EliminadorDeDatosBD(_Conexion);
        }
        public void LanzarMenu()
        {
            _ImpresorDeTexto.ImprimirTitulo("Crud con conexión a MS SqlServer");

            bool bandera = true;
            while (bandera)
            {
                _ImpresorDeTexto.ImprimirTitulo("Menú", '-');

                _ImpresorDeTexto.ImprimirTexto("1.Agregar nuevo registro\n2.Ver registros" +
                    "\n3.Actualizar registro\n4.Eliminar registro\n5.Salir");

                _ImpresorDeTexto.ImprimirTexto("-------------------------");

                _ImpresorDeTexto.ImprimirTexto("Ingrese una opción");

                char Opcion = _CapturadorDeDatos.CapturarCaracter();
                switch (Opcion)
                {
                    case '1':
                        _ImpresorDeTexto.ImprimirTexto("Ingrese el nombre del usuario");
                        string NombreUsuario = _CapturadorDeDatos.CapturarString();
                        _ImpresorDeTexto.ImprimirTexto("Ingrese el apellido del usuario");
                        string ApellidoUsuario = _CapturadorDeDatos.CapturarString();
                        _ImpresorDeTexto.ImprimirTexto("Ingrese la edad del usuario");
                        int EdadUsuario = _CapturadorDeDatos.CapturarEntero();

                        _InsertadorDeDatosBD.Insertar(new Persona(0, NombreUsuario, ApellidoUsuario, EdadUsuario));
                        break;
                    case '2':
                        _ImpresorDeTexto.ImprimirTitulo("Datos Leídos", '-');

                        _VisualizadorDeRegistros.Visualizar(_LectorDeDatosBD.LeerDatos());
                        break;
                    case '3':
                        _ImpresorDeTexto.ImprimirTexto("Id del usuario para actualizar");
                        int IdUsuario = _CapturadorDeDatos.CapturarEntero();
                        _ImpresorDeTexto.ImprimirTexto("Ingrese el nombre nuevo del usuario");
                        NombreUsuario = _CapturadorDeDatos.CapturarString();
                        _ImpresorDeTexto.ImprimirTexto("Ingrese el apellido nuevo del usuario");
                        ApellidoUsuario = _CapturadorDeDatos.CapturarString();
                        _ImpresorDeTexto.ImprimirTexto("Ingrese la edad nueva del usuario");
                        EdadUsuario = _CapturadorDeDatos.CapturarEntero();

                        _ActualizadorDeDatosBD.Actualizar(IdUsuario, new Persona(0, NombreUsuario, ApellidoUsuario, EdadUsuario));
                        break;
                    case '4':
                        _ImpresorDeTexto.ImprimirTexto("Id del usuario para eliminar");
                        IdUsuario = _CapturadorDeDatos.CapturarEntero();
                        _EliminadorDeDatosBD.Eliminar(IdUsuario);
                        break;
                    case '5':
                        bandera = false;
                        break;
                    default:
                        _ImpresorDeTexto.ImprimirTexto("Opcion no válida");
                        break;
                }
            }
        }
    }
}
