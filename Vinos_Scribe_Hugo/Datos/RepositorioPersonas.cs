using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPersonas : Archivo
    {
        public RepositorioPersonas(string fileName) : base(fileName)
        {
        }

        public List<Persona> ConsultarTodos()
        {
            try
            {
                List<Persona> lista = new List<Persona>();

                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Persona Mapear(string datos)
        {
            var linea = datos.Split(';');
            Persona persona = new Persona
            {
                Nombre = linea[0],
                Apellido = linea[1],
                Correo = linea[2],
                Celular = linea[3],
                FechaRegistro = linea[4],
                TipoUsuario = linea[5],
                Usuario = linea[6],
                Contraseña = linea[7]
            };
            return persona;
        }

        public Persona BuscarUsuario(string usuario)
        {
            var lista = ConsultarTodos();
            foreach (var item in lista)
            {
                if (item.Usuario == usuario)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
