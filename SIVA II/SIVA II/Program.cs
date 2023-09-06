using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIVA_II
{

    struct SIVA
    {
        public String PLACA;
        public int NUMBUS;
        public string RUTA;
        public string FECHARECORRIDO;
        public double VALORENTREGADO;
        public int SECUENCIARECORRIDO;

    }


    
    internal class Program
    {
        

        SIVA[] RESIVA = new SIVA[100];
        
        int Opcion, Princ, numBus;
        int Nel = 0, Pos;
        char Mas, Encontro, Seguro;
        String Password = "Hugo2004";
        String Placa, REPassword;


        public void Registrar_Datos()
        {
            
            char Mas = 'S';

            while ((Mas == 'S') && (Nel < 100))
            {
                Console.Clear();
                Console.WriteLine("**Registro De Informacion");
                Nel = Nel + 1;

                Console.WriteLine("Digite el numero del bus: ");
                RESIVA[Nel].NUMBUS = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la placa del bus: ");
                RESIVA[Nel].PLACA = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite la ruta");
                RESIVA[Nel].RUTA = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite el valor entregado: ");
                RESIVA[Nel].VALORENTREGADO = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el numero de recorridos: ");
                RESIVA[Nel].SECUENCIARECORRIDO = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la fecha de recorido: ");
                RESIVA[Nel].FECHARECORRIDO = Console.ReadLine();

                Console.WriteLine("¿Desea ingresar ingresar informacion de otro bus? [S/N]");
                Mas = char.ToUpper(Console.ReadLine()[0]);

            }

            if (Nel > 100)
            {
                Console.WriteLine("ERROR SISTEMAS DE DATOS LLENO");
            }
            else
            {
                Console.WriteLine("DATOS CARGADOS CORRECTAMENTE");
            }
        
        }

        public void Consultar_Datos()
        {
            int consultaOpcion;

            Console.Clear();
            Console.WriteLine("**Consulta De Informacion");

            Console.WriteLine("1. Consultar por NUMBUS");
            Console.WriteLine("2. Consultar por PLACA");
            Console.WriteLine("3. Regresar al menú principal");
            Console.WriteLine("Seleccione una opción...\n");

            do
            {
                
                consultaOpcion = int.Parse(Console.ReadLine());
                if (consultaOpcion <1 || consultaOpcion >3)
                {
                    Console.WriteLine("Valor fuera de parametros, digite una opcion valida...\n");
                }
            } while (consultaOpcion<1 || consultaOpcion>3);
            

            switch (consultaOpcion)
            {
                case 1:
                    Console.Write("Ingrese el NUMBUS a consultar: ");
                    int numBusConsultar = int.Parse(Console.ReadLine());
                    ConsultarPorNUMBUS(numBusConsultar);
                    break;

                case 2:
                    Console.Write("Ingrese la PLACA a consultar: ");
                    string placaConsultar = Console.ReadLine().ToUpper();
                    ConsultarPorPLACA(placaConsultar);
                    break;

                case 3:
                    return; // Regresar al menú principal

                    /*default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;*/
                    Console.ReadKey();
            }
        }

        public void ConsultarPorNUMBUS(int numBus)
        {
            int pos = -1;

            for (int i = 1; i <= Nel; i++)
            {
                if (RESIVA[i].NUMBUS == numBus)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                MostrarInformacion(pos);
            }
            else
            {
                Console.WriteLine("No se encontró información para el NUMBUS ingresado.");
            }
            Console.ReadKey();
        }

        public void ConsultarPorPLACA(string placa)
        {
            int pos = -1;

            for (int i = 1; i <= Nel; i++)
            {
                if (RESIVA[i].PLACA == placa)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                MostrarInformacion(pos);
            }
            else
            {
                Console.WriteLine("No se encontró información para la PLACA ingresada.");
            }
            Console.ReadKey();
        }

        public void MostrarInformacion(int pos)
        {
            Console.WriteLine("\nInformacion de bus: \n");
            Console.WriteLine($"Número de bus: {RESIVA[pos].NUMBUS}");
            Console.WriteLine($"Placa: {RESIVA[pos].PLACA}");
            Console.WriteLine($"Ruta: {RESIVA[pos].RUTA}");
            Console.WriteLine($"Valor entregado: {RESIVA[pos].VALORENTREGADO}");
            Console.WriteLine($"Número de recorridos: {RESIVA[pos].SECUENCIARECORRIDO}");
            Console.WriteLine($"Fecha de recorrido: {RESIVA[pos].FECHARECORRIDO}");
        }
        int Menu()
        {
            Console.Clear();
            Console.WriteLine("////////////////SISTEMA INTEGRADO DE TRANSPORTE\\\\\\\\\\\\\\\\\\\\\n");
            Console.WriteLine("                MENU   DE   OPCIONES                   \n");
            Console.WriteLine("1. REGISTRAR DATOS");
            Console.WriteLine("2. CONSULTAR DATOS");
            Console.WriteLine("3. MODIFICAR DATOS");
            Console.WriteLine("4. BORRAR DATOS");
            Console.WriteLine("5. INFORME");
            Console.WriteLine("6. SALIR");
            Console.WriteLine("SELECCIONE UNA OPCION...");

            //do
            //{
                Opcion = int.Parse(Console.ReadLine());
            //} while (Opcion<0 || Opcion>3);
            return Opcion;

        }

        public void Modificar()
        {
            Console.WriteLine("Ingrese la contraseña para continuar\n");
            REPassword = Console.ReadLine();

            if (REPassword != Password)
            {
                Console.WriteLine("Contraseña incorrecta");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("****MODIFICAR INFORMACION***");
                Console.WriteLine("¿Que Desea Modificar?");
                Console.WriteLine("1. Ruta del bus\n" +
                                  "2. Secuencia de recorrido\n");
                Console.WriteLine("Seleccione una opcion...");
                int Opcion_Mod = int.Parse(Console.ReadLine());

                switch(Opcion_Mod)
                {
                    case 1:
                        ModificarRuta();
                        break;

                    case 2:
                        ModificarSecu();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey(true);
                        break;
                }
            }

            
        }

        public void ModificarRuta()
        {
            Mas = 'S';

            while (Mas == 'S')
            {
                do
                {
                    Console.Clear() ;
                    Console.WriteLine("***MODIFICAR RUTA DE BUS***\n");
                    Console.WriteLine("Ingrese la placa del bus: ");
                    String Placa = Console.ReadLine().ToUpper();

                    Encontro = 'N'; int I = 1;

                    while (I <= Nel && Encontro == 'N')
                    {
                        if (Placa == RESIVA[I].PLACA)
                        {
                            Console.WriteLine("\n***BUS A MODIFICAR*** \n");
                            Console.WriteLine($"Número de bus: {RESIVA[I].NUMBUS}");
                            Console.WriteLine($"Placa: {RESIVA[I].PLACA}");
                            Console.WriteLine($"Ruta: {RESIVA[I].RUTA}");
                            Console.WriteLine($"Valor entregado: {RESIVA[I].VALORENTREGADO}");
                            Console.WriteLine($"Número de recorridos: {RESIVA[I].SECUENCIARECORRIDO}");
                            Console.WriteLine($"Fecha de recorrido: {RESIVA[I].FECHARECORRIDO}");
                            Pos = I;
                            Encontro = 'S';

                        }
                        else
                        {
                            I = I + 1;

                        }
                    }

                    if (Encontro== 'N')
                    {
                        Console.WriteLine("El Bus con placa: " + Placa + " No se encuentra Registrado");
                    }
                    else
                    {
                        Console.WriteLine("\nEsta seguro de modificar? (S/N)");
                        Seguro = char.ToUpper(Console.ReadLine()[0]);

                        if (Seguro == 'S')
                        {
                            if (Pos == I)
                            {
                                Console.WriteLine("Digite la nueva ruta del bus: ");
                                RESIVA[Pos].RUTA = Console.ReadLine().ToUpper();
                            }
                        }
                        Console.WriteLine("RUTA DEL BUS MODIFICADA SATISFACTORIAMENTE");
                    }

                    Console.WriteLine("\nDesea Modificar otro? (S/N):");
                    Mas = char.ToUpper(Console.ReadLine()[0]);
                    
                } while (Mas == 'S');
                Console.ReadKey();
            }
        }

        public void ModificarSecu()
        {
            Mas = 'S';

            while (Mas == 'S')
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("***MODIFICAR SECUENCIA DE RECORRIDO DE BUS***\n");
                    Console.WriteLine("Ingrese la placa del bus: ");
                    String Placa = Console.ReadLine().ToUpper();

                    Encontro = 'N'; int I = 1;

                    while (I <= Nel && Encontro == 'N')
                    {
                        if (Placa == RESIVA[I].PLACA)
                        {
                            Console.WriteLine("\n***BUS A MODIFICAR*** \n");
                            Console.WriteLine($"Número de bus: {RESIVA[I].NUMBUS}");
                            Console.WriteLine($"Placa: {RESIVA[I].PLACA}");
                            Console.WriteLine($"Ruta: {RESIVA[I].RUTA}");
                            Console.WriteLine($"Valor entregado: {RESIVA[I].VALORENTREGADO}");
                            Console.WriteLine($"Número de recorridos: {RESIVA[I].SECUENCIARECORRIDO}");
                            Console.WriteLine($"Fecha de recorrido: {RESIVA[I].FECHARECORRIDO}");
                            Pos = I;
                            Encontro = 'S';

                        }
                        else
                        {
                            I = I + 1;

                        }
                    }

                    if (Encontro == 'N')
                    {
                        Console.WriteLine("El Bus con placa: " + Placa + " No se encuentra Registrado");
                    }
                    else
                    {
                        Console.WriteLine("\nEsta seguro de modificar? (S/N)");
                        Seguro = char.ToUpper(Console.ReadLine()[0]);

                        if (Seguro == 'S')
                        {
                            if (Pos == I)
                            {
                                Console.WriteLine("Digite la nueva secuencia de recorrido del bus: ");
                                RESIVA[Pos].SECUENCIARECORRIDO = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("SECUENCIA DEL BUS MODIFICADA SATISFACTORIAMENTE");
                        }
                    }

                    Console.WriteLine("\nDesea Modificar otro? (S/N):");
                    Mas = char.ToUpper(Console.ReadLine()[0]);

                } while (Mas == 'S');
                Console.ReadKey();
            }
        }

        public void BorrarDatos()
        {
            
            Console.WriteLine("Ingrese la contraseña para continuar: \n");
            REPassword = Console.ReadLine();
            if (REPassword == Password)
            {
                Console.Clear();
                Console.WriteLine("MENU DE BORRADO\n");

                Console.WriteLine(
                                    "1.PLACA\n" +
                                    "2.NUMERO DEL BUS\n");

                Console.WriteLine("Digite una opcion:\n");
                int Opcion_B = int.Parse(Console.ReadLine());

                switch (Opcion_B)
                {
                    case 1:

                        BorrarDatos_PorPLaca();
                        break;

                    case 2:
                        BorrarDatos_PorNBUS();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey(true);
                        break;
                }

            }
            else

            Console.WriteLine("Contraseña incorrecta");
            Console.ReadKey();
            
        }

        public void BorrarDatos_PorPLaca()
        {

            Mas = 'S';
            while (Mas == 'S')
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("**BORRADO POR PLACA**\n");
                    Console.WriteLine("Digite la Placa del bus que desea borrar: ");
                    Placa = Console.ReadLine().ToUpper();

                    Encontro = 'N';
                    int I = 1;

                    while (I <= Nel && Encontro == 'N')
                    {
                        if (Placa == RESIVA[I].PLACA)
                        {
                            Console.WriteLine("\nBus a Borrar");
                            Mostrarin(I);
                           
                            Pos = I;
                            Encontro = 'S';
                        }
                        else
                        {
                            I = I + 1;
                        }

                    }
                    if (Encontro == 'N')
                    {
                        Console.WriteLine("El Bus con placa: " + Placa + " No se encuentra Registrado");
                    }
                    else
                    {
                        Console.WriteLine("\nEsta Seguro de Eliminarlo? (S/N):");
                        Seguro = char.ToUpper(Console.ReadLine()[0]);

                        if (Seguro == 'S')
                        {

                            if (Pos == Nel)
                            {
                                Nel = Nel - 1;

                            }
                            else
                            {
                                for (int i = Pos; i < Nel; i++)
                                {

                                    RESIVA[i] = RESIVA[i + 1];

                                }
                                Nel = Nel - 1;

                            }
                            Console.WriteLine("DATOS DEL BUS BORRADOES SATISFACTORIAMENTE");
                        }

                    }

                    Console.WriteLine("\nDesea eliminar otro? (S/N):");
                    Mas = char.ToUpper(Console.ReadLine()[0]);
                    

                } while (Mas == 'S');

            }

        }

        public void Mostrarin(int I)
        {
            Console.WriteLine($"Número de bus: {RESIVA[I].NUMBUS}");
            Console.WriteLine($"Placa: {RESIVA[I].PLACA}");
            Console.WriteLine($"Ruta: {RESIVA[I].RUTA}");
            Console.WriteLine($"Valor entregado: {RESIVA[I].VALORENTREGADO}");
            Console.WriteLine($"Número de recorridos: {RESIVA[I].SECUENCIARECORRIDO}");
            Console.WriteLine($"Fecha de recorrido: {RESIVA[I].FECHARECORRIDO}");
        }

        public void BorrarDatos_PorNBUS()
        {

            Mas = 'S';
            while (Mas == 'S')
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("**BORRADO POR NUMERO DEL BUS**\n");
                    Console.WriteLine("Digite el Numero del bus que desea borrar: ");
                    numBus = int.Parse(Console.ReadLine());

                    Encontro = 'N';
                    int I = 1;

                    while (I <= Nel && Encontro == 'N')
                    {
                        if (numBus == RESIVA[I].NUMBUS)
                        {
                            Console.WriteLine("\nBus a Borrar");
                            Mostrarin(I);
                            Pos = I;
                            Encontro = 'S';
                        }
                        else
                        {
                            I = I + 1;
                        }

                    }
                    if (Encontro == 'N')
                    {
                        Console.WriteLine("El Autobus no esta Registrado...");
                    }
                    else
                    {
                        Console.WriteLine("\nEsta Seguro de Eliminarlo? (S/N):");
                        Seguro = char.ToUpper(Console.ReadLine()[0]);

                        if (Seguro == 'S')
                        {

                            if (Pos == Nel)
                            {
                                Nel = Nel - 1;

                            }
                            else
                            {
                                for (int i = Pos; i < Nel; i++)
                                {

                                    RESIVA[i] = RESIVA[i + 1];
                                }
                                Nel = Nel - 1;
                            }
                        }
                        Console.WriteLine("DATOS DEL BUS BORRADOES SATISFACTORIAMENTE");

                    }

                    Console.WriteLine("\nDesea eliminar otro? (S/N):");
                    Mas = char.ToUpper(Console.ReadLine()[0]);
                    

                } while (Mas == 'S');

            }


        }

        public void InformesDatos()
        {
            Console.Clear();
            Console.WriteLine("*** INFORME DE TODOS LOS BUSES DEL SIVA ***\n");
            if (Nel == 0)
            {
                Console.WriteLine("ERROR NO SE ENCUENTRA REGISTRADO NINGUN BUS");
            }
            else
            {
                for (int I = 1; I <= Nel; I++)
                {

                    Mostrarin(I);
                    Console.WriteLine("---------------------------------------\n");
                }
                Console.WriteLine("*** FIN DEL INFORME ***");
            }

            Console.Write("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
            

        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            int Princ;
            char SON = 'S';
            //Princ = Menu();
            while (SON == 'S')
            {
                switch (ob.Menu())
                {
                    case 1:
                        ob.Registrar_Datos();
                        break;

                    case 2:
                        ob.Consultar_Datos();
                        break;

                    case 3:
                        ob.Modificar();
                        break;

                    case 4:
                        ob.BorrarDatos();
                        break;

                    case 5:
                        ob.InformesDatos();
                        break;

                    case 6:
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
    }
}
