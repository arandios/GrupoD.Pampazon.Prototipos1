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
        public int CodigoCliente { get; set; } // Cambiado de NroCliente a CodigoCliente

        public Transportista(int dni, string nombre, int codigoCliente)
        {
            DNI = dni;
            Nombre = nombre;
            CodigoCliente = codigoCliente;
        }
    }
}
