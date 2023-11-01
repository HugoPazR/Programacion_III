using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona { 

        // Propiedades de la clase persona
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string FechaRegistro { get; set; }
        public string TipoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, string correo, string celular, string fechaRegistro, string tipoUsuario, string usuario, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Celular = celular;
            FechaRegistro = fechaRegistro;
            TipoUsuario = tipoUsuario;
            Usuario = usuario;
            Contraseña = contraseña;
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellido};{Correo};{Celular};{FechaRegistro};{TipoUsuario};{Usuario};{Contraseña}";
        }

    }
}
