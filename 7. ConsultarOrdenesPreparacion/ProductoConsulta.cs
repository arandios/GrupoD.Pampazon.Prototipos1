using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class ProductoConsulta
    {
        public string SKU { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }

        public ProductoConsulta(string sku, string nombreProducto, int cantidad)
        {
            SKU = sku;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
        }
    }

}
