using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        private static string identificacion;
        private static PersonaService personaService = new PersonaService();
        public static void Registrar()
        {
            int edad;
            string nombre;
            string sexo;



            Console.WriteLine("Digite la identificacion");
            identificacion = Console.ReadLine();

            Console.WriteLine("Digite el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite el sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite la edad");
            edad = int.Parse(Console.ReadLine());

            Personas persona = new Personas(identificacion, nombre, sexo, edad);


            persona.CalcularPulsacion();
            string message = personaService.Guardar(persona);
            Console.WriteLine($"Su Pulsaciones {persona.Pulsaciones} " + message);

            PersonaResponse personaResponse = personaService.BuscarPorIdentificacion("1");
            if (personaResponse.Encontrado == true)
                Console.WriteLine(personaResponse.Persona.ToString());
            else
            {
                Console.WriteLine(personaResponse.Message);
            }

            Consultar(personaService);
        }
        static void Main(string[] args)
        {
            char SON = 'S';
            int OP = 0;
            while (SON == 'S')
            {

                Console.Clear();
                Console.WriteLine("CENTRAL DE PROPIETARIOS DE AUTOS\n"
                                + "     MENU DE OPCIONES:\n"
                                + "1. REGISTRAR\n"
                                + "2. INFORME\n"
                                + "3. ELIMINAR\n"
                                + "4. BUSCAR\n"
                                + "5. SALIR\n");
                OP = int.Parse(Console.ReadLine());
                switch (OP)
                {
                    case 1:
                        int edad;
                        string nombre;
                        string sexo;



                        Console.WriteLine("Digite la identificacion");
                        identificacion = Console.ReadLine();

                        Console.WriteLine("Digite el nombre");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Digite el sexo");
                        sexo = Console.ReadLine();

                        Console.WriteLine("Digite la edad");
                        edad = int.Parse(Console.ReadLine());

                        Personas persona = new Personas(identificacion, nombre, sexo, edad);


                        persona.CalcularPulsacion();
                        string message = personaService.Guardar(persona);
                        Console.WriteLine($"Su Pulsaciones {persona.Pulsaciones} " + message);
                        PersonaResponse personaResponse = personaService.BuscarPorIdentificacion("1");
                        if (personaResponse.Encontrado == true)
                            Console.WriteLine(personaResponse.Persona.ToString());
                        else
                        {
                            Console.WriteLine(personaResponse.Message);
                        }

                        Consultar(personaService);
                        Console.ReadKey();
                        break;
                    case 2:
                        Consultar(personaService);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Eliminar Personas");
                        Console.WriteLine("Digite la identificacion");
                        identificacion = Console.ReadLine();
                        string messageEliminacion = personaService.Eliminar(identificacion);
                        Console.WriteLine(messageEliminacion);

                        Consultar(personaService);


                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("FUNCION NO DISPONIBLE AUN");
                        break;
                    case 5:
                        SON = 'N';
                        Console.WriteLine("Saliendo...\npulse una tecla para salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("VALOR FUERA DE PARAMETROS");
                        Console.ReadKey();
                        break;

                }
            }


        }

        private static void Consultar(PersonaService personaService)
        {
            ConsultaPersonaResponse consultaPersonaResponse = personaService.ConsultarTodos();
            if (consultaPersonaResponse.Encontrado == true)
            {
                Console.WriteLine("Lista de Personas");
                foreach (var item in consultaPersonaResponse.Personas)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(consultaPersonaResponse.Message);
            }
        }
    }

}
