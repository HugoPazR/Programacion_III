using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Personas
    {
        public Personas()
        {
        }

        public Personas(string identificacion, string nombre, string sexo, int edad)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
            
        }
         
        public String Identificacion { get; set; }
        public String Nombre { get; set;}
        public string Sexo { get; set;}   
        public int Edad { get; set;}
        public decimal Pulsaciones { get; set;}

        public override string ToString()
        {
            return "\n"
                    + "\nIdentificacion: " + Identificacion
                    + "\nNombre:" + Nombre
                    + "\nSexo:  " + Sexo
                    + "\nEdad:  " + Edad
                    + "\nPulsaciones: " + Pulsaciones//.ToString("F2")
                    + "\n____________________________________________";

        }

        public void CalcularPulsacion()
        {

            if (Sexo.ToUpper().Equals("F"))
            {
                Pulsaciones = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("M"))
            {
                Pulsaciones = (210 - Edad) / 10;
            }
            else
            {
                Pulsaciones = 0;
            }

        }
        /*public String Identificacion { get; set; }
        public String Nombre { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public float Pulsaciones { get; set; }*/

        
    }
}
