using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class PersonaService
    {
        private string fileName = "usuarios.txt";
        RepositorioPersonas repositorio;

        private List<Persona> personas;
        public PersonaService()
        {
            repositorio = new RepositorioPersonas(fileName);
            RefrescarLista();
        }

        void RefrescarLista()
        {
            personas = repositorio.ConsultarTodos();
        }

        public string Guardar(Persona personas)
        {
            var msg = repositorio.Guardar(personas.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Persona> Consultar()
        {
            return personas;
        }

        public Persona BuscarUsuario(string usuario)
        {
            foreach (var item in personas)
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
