using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._4._EmpaquetarOrden
{
    internal class OrdenPreparacion
    {
        public string IdOrdenPreparacion { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();

    }
}
