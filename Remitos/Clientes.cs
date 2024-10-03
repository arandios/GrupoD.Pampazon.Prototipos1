using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Remitos
{
    internal class Clientes
    {
        public int CodigoCliente { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }

        public Clientes(int codigoCliente, string cuit, string razonSocial)
        {
            CodigoCliente = codigoCliente;
            Cuit = cuit;
            RazonSocial = razonSocial;
        }
    }
}
