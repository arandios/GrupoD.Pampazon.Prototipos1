using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class OrdenDeEntregaEnt
    {
        public int IdOrdenEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado = "Completada";
        public List<int> OrdenesDePreparacion { get;  } = new();
    }
}
