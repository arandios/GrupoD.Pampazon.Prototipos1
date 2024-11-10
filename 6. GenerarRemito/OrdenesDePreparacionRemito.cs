using Pampazon._6._GenerarRemito;
using Pampazon.OrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDePreparacionRemito
    {
       
        public string IdOrden { get; set; }    
        public int DNItransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string ApellidoTransportista { get; set; }
        public EstadoOrdenPreparacionRemito Estado { get; set; } 


        // Constructor
        public OrdenesDePreparacionRemito(string idOrden, int dniTransportista, string Nombre, string Apellido)
        {
          
            IdOrden = idOrden;
            DNItransportista = dniTransportista; 
            NombreTransportista = Nombre;
            ApellidoTransportista = Apellido;
        }


    }
}
