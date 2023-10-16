using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Vino
    {
        // Propiedades de la clase Vino
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public int Año_Elaboracion { get; set; }
        public double ContenidoAzucar { get; set; }
        public string Tipo { get; set; }
        public string LugarOrigen { get; set; }
        public string Color { get; set; }

        public Vino(string nombre, string presentacion, int año_Elaboracion, double contenidoAzucar, string tipo, string lugarOrigen, string color)
        {
            Nombre = nombre;
            Presentacion = presentacion;
            Año_Elaboracion = año_Elaboracion;
            ContenidoAzucar = contenidoAzucar;
            Tipo = tipo;
            LugarOrigen = lugarOrigen;
            Color = color;
        }

        public Vino()
        {
        }
    }

}
