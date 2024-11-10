using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._7._ConsultarOrdenesPreparacion
{
    internal class ProductoConsulta
    {
        public string SKU { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public List<UbicacionConsultaDetalle> Detalles { get; } = new();

        public ProductoConsulta(string sku, string nombre, int cantidad)
        {
            SKU = sku;
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }

}
