using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenSeleccion
{
    public class TransportistaEnt //Antes se llamaba "Transportista"
    {
        //PROPIEDADES
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string IdCliente { get; set; }

        //CONSTRUCTOR
        public TransportistaEnt(int dni, string nombre, string codigoCliente)
        {
            DNI = dni;
            Nombre = nombre;
            IdCliente = codigoCliente;
        }
        
        //METODOS
    }
}
