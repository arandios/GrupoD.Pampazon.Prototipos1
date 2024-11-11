using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class ClienteConsulta
    {
        public int CodigoCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }

        public ClienteConsulta(int codigoCliente, string razonSocial, string cuit)
        {
            CodigoCliente = codigoCliente;
            RazonSocial = razonSocial;
            Cuit = cuit;
        }
    }
}
