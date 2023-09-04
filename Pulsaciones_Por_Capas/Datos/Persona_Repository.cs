using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class Persona_Repository
    {
        private readonly string FileName = "Perona.txt";
        public void Guardar(Personas persona)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsaciones} ");
            writer.Close();
            file.Close();

        }
        public Personas Buscar(string identificacion)
        {
            List<Personas> personas = ConsultarTodos();
            foreach (var item in personas)
            {
                if (EsEncontrado(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public List<Personas> ConsultarTodos()
        {
            List<Personas> personas = new List<Personas>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                Personas persona = Map(linea);
                personas.Add(persona);
            }
            reader.Close();
            file.Close();
            return personas;
        }
        private Personas Map(string linea)
        {
            Personas persona = new Personas();
            char delimiter = ';';
            string[] matrizPersona = linea.Split(delimiter);
            persona.Identificacion = matrizPersona[0];
            persona.Nombre = matrizPersona[1];
            persona.Edad = int.Parse(matrizPersona[2]);
            persona.Sexo = matrizPersona[3];
            persona.Pulsaciones = Convert.ToDecimal(matrizPersona[4]);
            return persona;
        }
        public void Eliminar(string identificacion)
        {
            List<Personas> personas = new List<Personas>();
            personas = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!EsEncontrado(item.Identificacion, identificacion))
                {
                    Guardar(item);
                }

            }

        }
        public void Modificar(Personas personaOld, Personas personaNew)
        {
            List<Personas> personas = new List<Personas>();
            personas = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!EsEncontrado(item.Identificacion, personaOld.Identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNew);
                }

            }

        }
        public List<Personas> FiltrarSexo(string sexo)
        {
            return ConsultarTodos().Where(p => p.Sexo.Equals(sexo)).ToList();
        }

        public List<Personas> FiltrarPorHombres()
        {

            List<Personas> personas = ConsultarTodos();
            List<Personas> personasFiltradas =
                (from persona in personas
                 where persona.Sexo.Equals("M")
                 select persona).ToList();
            return personasFiltradas;
        }

        public List<Personas> FiltrarPorMujeres()
        {

            List<Personas> personas = ConsultarTodos();
            return personas.Where(p => p.Edad > 5 && p.Edad < 10).ToList();
        }

        public int ContarSexo(string sexo)
        {
            return ConsultarTodos().Count(p => p.Sexo.Equals(sexo));
        }

        public List<Personas> FiltroPorNombre(string nombre)
        {
            return ConsultarTodos().Where(p => p.Nombre.Contains(nombre)).ToList();
        }
    }
}
