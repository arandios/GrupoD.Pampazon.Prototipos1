using Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._8._ConsultarProductos
{
    internal class BuscarProductosModelo
    {
        private List<ProductoBusqueda> productos;
        private List<ClientesBusqueda> clientes;

        public BuscarProductosModelo()
        {
            productos = ObtenerTodosLosProductos();
            clientes = ObtenerTodosLosClientes();
        }

        private List<ProductoBusqueda> ObtenerTodosLosProductos()
        {
            // Convertir los productos de ProductoAlmacen a ProductoBusqueda
            return ProductoAlmacen.Productos.Select(p => new ProductoBusqueda(
                p.SKU,
                p.NombreProducto,
                p.IdCliente.ToString(),
                p.Detalle.Select(d => new UbicacionProductoDetalleBusqueda(
                    d.IdUbicacion,
                    d.Stock
                )).ToList()
            )).ToList();
        }
        private List<ClientesBusqueda> ObtenerTodosLosClientes()
        {
            // Convertir los clientes de ClienteAlmacen a ClientesBusqueda
            return ClienteAlmacen.Clientes.Select(c => new ClientesBusqueda(
                c.IdCliente.ToString(),
                c.RazonSocial,
                c.CUIT
            )).ToList();
        }

        public List<ProductoBusqueda> ObtenerProductos()
        {
            return productos;
        } 
        public List<ClientesBusqueda> ObtenerClientes()
        {
            return clientes;
        }

       
        // Método para buscar productos
        public List<ProductoBusqueda> BuscarProductos(string idCliente, string razonSocial, string cuit, string sku, string nombreProducto, int stockMinimo, int stockMaximo)
        {
            List<ProductoBusqueda> productosEncontrados = productos;

            if (!string.IsNullOrEmpty(idCliente))
            {
                productosEncontrados = productosEncontrados.Where(p => p.IdCliente == idCliente).ToList();
            }

            if (!string.IsNullOrEmpty(razonSocial))
            {
                var clientesFiltrados = clientes.Where(c => c.razonSocial.Contains(razonSocial, StringComparison.OrdinalIgnoreCase)).Select(c => c.idCliente).ToList();
                productosEncontrados = productosEncontrados.Where(p => clientesFiltrados.Contains(p.IdCliente)).ToList();
            }

            if (!string.IsNullOrEmpty(cuit))
            {
                var clientesFiltrados = clientes.Where(c => c.cuit.Equals(cuit, StringComparison.OrdinalIgnoreCase)).Select(c => c.idCliente).ToList();
                productosEncontrados = productosEncontrados.Where(p => clientesFiltrados.Contains(p.IdCliente)).ToList();
            }

            if (!string.IsNullOrEmpty(sku))
            {
                productosEncontrados = productosEncontrados.Where(p => p.SKU.Equals(sku, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(nombreProducto))
            {
                productosEncontrados = productosEncontrados.Where(p => p.NombreProducto.Contains(nombreProducto, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (stockMinimo > 0)
            {
                productosEncontrados = productosEncontrados.Where(p => p.Detalle.Sum(d => d.Stock) >= stockMinimo).ToList();
            }

            if (stockMaximo > 0)
            {
                productosEncontrados = productosEncontrados.Where(p => p.Detalle.Sum(d => d.Stock) <= stockMaximo).ToList();
            }

            return productosEncontrados;
        }
        public string ObtenerRazonSocialCliente(string idCliente)
        {
            var cliente = clientes.FirstOrDefault(c => c.idCliente == idCliente);
            return cliente != null ? cliente.razonSocial : string.Empty;
        }

        public (string codigoCliente, string razonSocial, string cuit) AutocompletarCamposCliente(string input)
        {
            var cliente = clientes.FirstOrDefault(c =>
                c.idCliente.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                c.razonSocial.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                c.cuit.Equals(input, StringComparison.OrdinalIgnoreCase));

            if (cliente != null)
            {
                return (cliente.idCliente, cliente.razonSocial, cliente.cuit);
            }

            return (string.Empty, string.Empty, string.Empty);
        }
    }
}



