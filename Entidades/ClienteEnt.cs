using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class ClienteEnt
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        //public List<TransportistaEnt> Transportistas { get; } = new();
        public PrioridadEnum Prioridad { get; set; }
    }
}
