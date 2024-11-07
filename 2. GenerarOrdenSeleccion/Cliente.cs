using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._2._GenerarOrdenSeleccion
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public Prioridades prioridad { get; set; }
    }
}
