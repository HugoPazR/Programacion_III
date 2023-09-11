using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS_Prueba
{

    public class Program
    {
        public static int NMeses, NProgramas;
        public static string[] Meses;
        public static string[] Programas;
        public static double[,] DPS;

        public void Registrar()
        {
            
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE PROSPERIDAD SOCIAL");

            Console.WriteLine("A continuación, digite el número de meses que desea registrar");
            do
            {
                NMeses = int.Parse(Console.ReadLine());
                if (NMeses < 1 || NMeses > 12)
                {
                    Console.WriteLine("Digite un número de meses válido (máx. 12)");
                }
            } while (NMeses < 1 || NMeses > 12);

            Console.WriteLine("A continuación, digite el número de programas que desea registrar");

            do
            {
                NProgramas = int.Parse(Console.ReadLine());
                if (NProgramas < 1 || NProgramas > 10)
                {
                    Console.WriteLine("Digite un número de programas válido (máx. 10)");
                }
            } while (NProgramas < 1 || NProgramas > 10);

            Meses = new string[NMeses];
            Programas = new string[NProgramas];
            DPS = new double[NProgramas, NMeses];

            for (int M = 0; M < NMeses; M++)
            {
                Console.WriteLine("Digite el nombre del mes " + (M + 1) + ": ");
                Meses[M] = Console.ReadLine();
            }

            for (int P = 0; P < NProgramas; P++)
            {
                Console.WriteLine("Digite el nombre del programa " + (P + 1) + ": ");
                Programas[P] = Console.ReadLine();
            }

            for (int i = 0; i < NProgramas; i++)
            {
                for (int j = 0; j < NMeses; j++)
                {
                    Console.WriteLine("Ingrese Datos Del Programa " + Programas[i] + " Del Mes de " + Meses[j] + ": ");
                    DPS[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void Mostar_Informe()
        {
            Console.Clear();
            if (NMeses == 0)
            {
                Console.WriteLine("No hay datos registrados");
            }
            else
            {
                Console.WriteLine("\n//////////////////////////////Tabla de Datos://////////////////////////////");
                //Console.Write("Programas\t");
                foreach (var mes in Meses)
                {
                    Console.Write("\t" + mes);
                }
                Console.WriteLine();

                for (int i = 0; i < NProgramas; i++)
                {
                    Console.Write(Programas[i] + "\t");
                    for (int j = 0; j < NMeses; j++)
                    {
                        Console.Write(DPS[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                /*for (int i = 0; i < NProgramas; i++)
                {
                    for (int j = 0; j < NMeses; j++)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("                 " + Meses[j]);
                        Console.WriteLine(Programas[i] + "  " + DPS[i, j]);
                    }
                }*/
            }
            
            Console.ReadKey();
        }

        public void Consultar_Mayor_Pago()
        {
            Console.Clear();
            if (NMeses == 0)
            {
                Console.WriteLine("NO HAY INFORMACION REGISTRADA DE NINGUN PROGRAMA");
            }
            else
            {
                Console.WriteLine("\nConsulta de programa que pagó más en un mes específico:");
                Console.Write("Ingrese el número del mes que desea consultar (1-" + NMeses + "): ");
                int mesConsulta = int.Parse(Console.ReadLine());

                if (mesConsulta < 1 || mesConsulta > NMeses)
                {
                    Console.WriteLine("Mes no válido.");
                }
                else
                {
                    // Encontrar el programa con el mayor pago en el mes seleccionado
                    double maxPago = double.MinValue;
                    string programaMaxPago = "";

                    for (int i = 0; i < NProgramas; i++)
                    {
                        double pagoActual = DPS[i, mesConsulta - 1];
                        if (pagoActual > maxPago)
                        {
                            maxPago = pagoActual;
                            programaMaxPago = Programas[i];
                        }
                    }

                    Console.WriteLine("\nEn el mes de " + Meses[mesConsulta - 1] + ", el programa que pagó más fue: " + programaMaxPago);
                    Console.WriteLine("Pago: " + maxPago);
                }
            }
            
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int Opcion_Menu;
            do
            {
                Console.Clear();
                Console.WriteLine("************BIENVENIDO AL DEPARTAMENTO DE PROSPERIDAD SOCIAL***********\n");
                Console.WriteLine("                              MENU DE OPCIONES                         \n" +
                                   " 1. REGISTRAR DATOS \n" 
                                 + " 2. MOSTRAR INFORME \n" 
                                 + " 3. CONSULTAR MAYOR PAGO\n"
                                 + " 4. SALIR.          \n" 
                                 + "SELECCIONE UNA OPCION...");
                Opcion_Menu = int.Parse(Console.ReadLine());

                Program  ob = new Program();

                switch (Opcion_Menu)
                {
                    case 1:
                        ob.Registrar();
                    break;
                    case 2:
                        ob.Mostar_Informe();
                    break;
                    case 3:
                        ob.Consultar_Mayor_Pago();
                    break;
                    case 4:
                        Console.WriteLine("Saliendo del programa");
                    break;
                }

            } while (Opcion_Menu!=4);
            

        }
    }
}
