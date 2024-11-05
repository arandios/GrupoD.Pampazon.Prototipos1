using Pampazon.OrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDePreparacion
    {
       
        public string IdOrden { get; set; }    
        public int DNItransportista { get; set; }
        public string NombreTransportista { get; set; }
        public string ApellidoTransportista { get; set; }
        

        // Constructor
        public OrdenesDePreparacion(string idOrden, int dniTransportista, string Nombre, string Apellido)
        {
          
            IdOrden = idOrden;
            DNItransportista = dniTransportista; 
            NombreTransportista = Nombre;
            ApellidoTransportista = Apellido;
        }


    }
}
