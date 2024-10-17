using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class Cliente
    {
        public int CodigoCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }

        public Cliente(int codigoCliente, string razonSocial, string cuit)
        {
            CodigoCliente = codigoCliente;
            RazonSocial = razonSocial;
            Cuit = cuit;
        }
    }
}
