using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class OrdenDeSeleccionEnt
    {
        public int IdOrdenSeleccion { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> OrdenesPreparacion { get; } = new();
        public EstadoOrdenSeleccionEnum EstadoOrden { get; set; }
        public DateTime FechaEstado { get; set; }
    }
}
