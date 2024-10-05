using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Transportista
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdOrden { get; set; } 

        public Transportista(int dni, string nombre, string apellido, string orden )
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            IdOrden = orden;
        }
    }
}
