using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Inventario: Vino
    {
        public double Precio_Venta { get; set; }
        public double Precio_Compra { get; set; }
        
        public Inventario() { }

        public Inventario(string nombre, string presentacion, int año_Elaboracion, double contenidoAzucar, string tipo, string lugarOrigen, string color) : base(nombre, presentacion, año_Elaboracion, contenidoAzucar, tipo, lugarOrigen, color)
        {

        }
    }
}
