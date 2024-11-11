using Pampazon._3._BuscarProductosEnDepositos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class Producto
    {
        public string SKUProducto { get; set; }
        public string IdCliente { get; set; }

        public string NombreProducto { get; set; }
        
        public List<UbicacionProdutoDetalle_ParaBuscarProductosEnDepo> Detalle { get; set; }

        public Producto(string skuProducto, string idCliente, string nombreProducto, List<UbicacionProdutoDetalle_ParaBuscarProductosEnDepo> detalle)
        {
            SKUProducto = skuProducto;
            IdCliente = idCliente;
            NombreProducto = nombreProducto;
            Detalle = detalle;
        }
    }

}

