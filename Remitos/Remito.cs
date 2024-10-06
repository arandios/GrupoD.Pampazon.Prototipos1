using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        public string NumeroDeOrden { get; set; }
        public int DNITransportista { get; set; }
        public DateTime FechaDeEmision { get; set; }

        // Constructor
        public Remito(string numeroDeOrden, int transportista)
        {
            NumeroDeOrden = numeroDeOrden;
            DNITransportista = transportista;
            FechaDeEmision = DateTime.Now;
            
        }
    }
}
