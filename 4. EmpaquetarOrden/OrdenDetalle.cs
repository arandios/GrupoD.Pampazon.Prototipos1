using Pampazon.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.EmpaquetarOrden
{
    internal class OrdenDetalle
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
