using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Entidades
{
    public class ProductoEnt
    {
        public string SKU { get; set; }
        public int IdCliente { get; set; }
        public string NombreProducto { get; set; }
        public List<UbicacionProductoDetalle> Detalle { get;   } = new();
    }
}
