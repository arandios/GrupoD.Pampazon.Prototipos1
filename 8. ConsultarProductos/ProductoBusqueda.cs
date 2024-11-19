using Pampazon.Entidades;
using System.Collections.Generic;

namespace Pampazon._8._ConsultarProductos
{
    internal class ProductoBusqueda
    {
        public string SKU { get; set; }
        public string NombreProducto { get; set; }
        public string IdCliente { get; set; }
        public List<UbicacionProductoDetalleBusqueda> Detalle { get; set; } = new();

        public ProductoBusqueda(string sku, string nombreProducto,string idCliente, List<UbicacionProductoDetalleBusqueda> detalle)
        {
            SKU = sku;
            NombreProducto = nombreProducto;
            IdCliente = idCliente;
            Detalle = detalle;
        }
    }

    
}
