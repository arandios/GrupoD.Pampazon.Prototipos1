using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDeEntrega
    {
        public string IdOrden { get; set; } 
        public DateTime Fecha { get; set; } 
        public int DNItransportista { get; set; }

        // Constructor
        public OrdenesDeEntrega(string idOrden, int dniTransportista)
        {
            IdOrden = idOrden;
            dniTransportista = dniTransportista; 
            Fecha = DateTime.Now.AddDays(new Random().Next(-10, 1)).Date;
        }


    }
}
