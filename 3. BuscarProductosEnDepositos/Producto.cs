using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class Producto
    {
        public string SKU { get; set; }
        public int IdCliente { get; set; }
        public List<UbicacionProductoDetalle> Detalle { get; set; }

        // Constructor
        public Producto(string sku, int idCliente, string nombreProducto, List<UbicacionProductoDetalle> detalle)
        {
            SKU = sku;
            IdCliente = idCliente;
            Detalle = detalle ?? new List<UbicacionProductoDetalle>();
        }
    }
    
}

