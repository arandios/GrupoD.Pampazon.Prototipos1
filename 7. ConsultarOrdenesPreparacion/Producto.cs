using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class Producto
    {
        public string SKU { get; set; }  // Código único del producto
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Producto(string sku, string nombre, int cantidad)
        {
            SKU = sku;
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }

}
