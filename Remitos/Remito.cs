using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Remito
    {
        public int NumeroDeOrden { get; set; }     // Número de orden como entero
        public string RazonSocial { get; set; }     // Razón social de la empresa
        public string Transportista { get; set; }   // Nombre del transportista

        // Constructor
        public Remito(int numeroDeOrden, string razonSocial, string transportista)
        {
            NumeroDeOrden = numeroDeOrden;
            RazonSocial = razonSocial;
            Transportista = transportista;
        }
    }
}
