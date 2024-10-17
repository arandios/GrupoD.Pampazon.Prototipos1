using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class Producto
    {
        public string Ubicacion { get; set; }
        public string SKU { get; set; }
        public int Cantidad { get; set; }

        public Producto(string ubicacion, string sku, int cantidad)
        {
            Ubicacion = ubicacion;
            SKU = sku;
            Cantidad = cantidad;
        }
    }
    
}

