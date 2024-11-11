using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._6._GenerarRemito
{
    internal class TransportistaRemito
    {
        public int DNI { get; set; }
        public string NombreT { get; set; }
        public string ApellidoT { get; set; }

        public TransportistaRemito(int dni, string nombre, string apellido) {
            DNI = dni;
            NombreT = nombre;
            ApellidoT = apellido;
        }
    }
}

