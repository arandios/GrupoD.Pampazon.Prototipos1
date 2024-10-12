using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        public List<OrdenesDePreparacion> Ordenes { get; set; }
        public int DNITransportista { get; set; }
        public DateTime FechaDeEmision { get; set; }

        // Constructor
        public Remito (List<OrdenesDePreparacion> ordenes, int transportista)
        {
            Ordenes = ordenes;
            DNITransportista = transportista;
            FechaDeEmision = DateTime.Now;
        }
        

    }

}

