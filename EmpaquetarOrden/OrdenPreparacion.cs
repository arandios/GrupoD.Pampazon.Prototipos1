using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.EmpaquetarOrden
{
    internal class OrdenPreparacion
    {
        public string IdOrdenPreparacion { get; set; }
        public List<OrdenDetalle> detalles { get; set; }
        public object CodigoOrden { get; internal set; }
        public Prioridad Prioridad { get; set; }
    }
}
