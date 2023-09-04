using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System;

namespace Logica
{
    public class PersonaService
    {
        private readonly Persona_Repository personaRepository;
        public PersonaService()
        {
            personaRepository = new Persona_Repository();
        }
        public string Guardar(Personas persona)
        {
            try
            {

                if (personaRepository.Buscar(persona.Identificacion) == null)
                {
                    personaRepository.Guardar(persona);
                    return $"se han guardado Satisfactoriamente los datos de: {persona.Nombre} ";
                }
                else
                {
                    return $"Lo sentimos, con la Identificación {persona.Identificacion} ya se encuentra registrada";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                if (personaRepository.Buscar(identificacion) != null)
                {
                    personaRepository.Eliminar(identificacion);
                    return ($"se han Eliminado Satisfactoriamente los datos de la persona con Identificación: {identificacion} ");
                }
                else
                {
                    return ($"Lo sentimos, no se encuentra registrada una persona con Identificacion {identificacion}");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }

        }
        public PersonaResponse BuscarPorIdentificacion(string identificacion)
        {

            try
            {
                Personas persona = personaRepository.Buscar(identificacion);
                if (persona != null)
                {
                    return new PersonaResponse(persona);
                }
                else
                {
                    return new PersonaResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new PersonaResponse("Error de Aplicacion: " + e.Message);
            }

        }
        public ConsultaPersonaResponse ConsultarTodos()
        {

            try
            {
                List<Personas> personas = personaRepository.ConsultarTodos();
                if (personas != null)
                {
                    return new ConsultaPersonaResponse(personas);
                }
                else
                {
                    return new ConsultaPersonaResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new ConsultaPersonaResponse("Error de Aplicacion: " + e.Message);
            }
        }
        public ConsultaPersonaResponse ConsultarPorSexo(string sexo)
        {

            try
            {
                List<Personas> personas = personaRepository.FiltrarSexo(sexo);
                if (personas != null)
                {
                    return new ConsultaPersonaResponse(personas);
                }
                else
                {
                    return new ConsultaPersonaResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return new ConsultaPersonaResponse("Error de Aplicacion: " + e.Message);
            }
        }
    }

    public class PersonaResponse
    {
        public Personas Persona { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public PersonaResponse(Personas persona)
        {
            Persona = new Personas();
            Persona = persona;
            Encontrado = true;
        }
        public PersonaResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
    public class ConsultaPersonaResponse
    {
        public List<Personas> Personas { get; set; }
        public string Message { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaPersonaResponse(List<Personas> personas)
        {
            Personas = new List<Personas>();
            Personas = personas;
            Encontrado = true;
        }
        public ConsultaPersonaResponse(string message)
        {
            Message = message;
            Encontrado = false;
        }
    }
}
