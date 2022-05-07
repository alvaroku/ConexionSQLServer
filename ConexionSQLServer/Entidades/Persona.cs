using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionSQLServer.Entidades
{
    public class Persona
    {
        public Persona(int id, string nombre, string apellido, int edad) =>(Id, Nombre, Apellido, Edad) 
            = (id, nombre, apellido, edad);

        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tNombre: {Nombre}\tApellido: {Apellido}\tEdad: {Edad}";
        }
    }
}
