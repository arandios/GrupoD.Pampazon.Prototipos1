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
        public DateTime Fecha { get; set; } 
        public int DNItransportista { get; set; }
        public string EstadoDeOrden { get; set; } = "Preparadas";

        // Constructor
        public OrdenesDePreparacion(string idOrden, int dniTransportista)
        {
            IdOrden = idOrden;
            DNItransportista = dniTransportista; 
            Fecha = DateTime.Now.AddDays(new Random().Next(-10, 1)).Date;
        }


    }
}
