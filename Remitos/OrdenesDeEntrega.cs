using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class OrdenesDeEntrega
    {
        public int NroDeOrden { get; set; }
        public string RazonSocial { get; set; }
        public int CodigoCliente { get; set; }

        // Constructor
        public OrdenesDeEntrega(int nroDeOrden, string razonSocial, int codigo)
        {
            NroDeOrden = nroDeOrden;
            RazonSocial = razonSocial;
            CodigoCliente = codigo;
        }
    }
}
