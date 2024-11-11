using Pampazon._7._ConsultarOrdenesPreparacion;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.ConsultarOrdenes
{

   
    internal class ConsultarOrdenesPreparacionModelo
    {
        private List<OrdenDePreparacionConsultas> ordenesPreparacion;

        public ConsultarOrdenesPreparacionModelo()
        {
            // Inicializar 'ordenesPreparacion' con los datos de 'OrdenPreparacionAlmacen'
            ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Select(o =>
                {
                    var detalles = o.Detalle.Select(d => new OrdenPreparacionConsultaDetalle
                    {
                        SKU = d.SKU,
                        Cantidad = d.Cantidad
                    }).ToList();

                    // Convertir EstadoOrdenPreparacionEnum a EstadoOrdenPreparacionConsultaEnum
                    EstadoOrdenPreparacionConsultaEnum estadoConsulta = (EstadoOrdenPreparacionConsultaEnum)Enum.Parse(typeof(EstadoOrdenPreparacionConsultaEnum), o.Estado.ToString());

                    return new OrdenDePreparacionConsultas(
                        o.IdOrdenPreparacion,
                        o.FechaEmision,
                        estadoConsulta,
                        o.Prioridad.ToString(),
                        o.IdCliente,
                        detalles
                    );
                })
                .ToList();
        }

        public List<ProductoConsulta> ObtenerProductosPorOrdenId(int idOrdenPreparacion)
        {
                var orden = ordenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOrdenPreparacion);
                if (orden == null)
                {
                    return new List<ProductoConsulta>();
                }

                var productosAlmacen = ProductoAlmacen.Productos;

                return orden.Detalle.Select(detalle =>
                {
                    var productoAlmacen = productosAlmacen.FirstOrDefault(p => p.SKU == detalle.SKU);
                    return new ProductoConsulta(
                        detalle.SKU,
                        productoAlmacen?.NombreProducto ?? "Desconocido",
                        detalle.Cantidad
                    );
                }).ToList();
        }
        






        // Búsqueda por razón social 
        public List<OrdenDePreparacionConsultas> ObtenerOrdenesPorRazonSocial(string razonSocial)
        {
            var clientes = ClienteAlmacen.Clientes;
            var clientesFiltrados = clientes
                .Where(c => c.RazonSocial.Equals(razonSocial, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.IdCliente)
                .ToHashSet();

            return ordenesPreparacion
                .Where(o => clientesFiltrados.Contains(o.IdCliente))
                .ToList();
        }

        // Búsqueda por CUIT
        public List<OrdenDePreparacionConsultas> ObtenerOrdenesPorCuit(string cuit)
        {
            var clientes = ClienteAlmacen.Clientes;
            var clientesFiltrados = clientes
                .Where(c => c.CUIT.Equals(cuit, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.IdCliente)
                .ToHashSet();

            return ordenesPreparacion
                .Where(o => clientesFiltrados.Contains(o.IdCliente))
                .ToList();
        }

        public OrdenDePreparacionConsultas ObtenerOrdenPorId(int idOrdenPreparacion)
        {
            return ordenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOrdenPreparacion);
        }

        public List<OrdenDePreparacionConsultas> ObtenerTodasLasOrdenes()
        {
            return ordenesPreparacion;
        }

        // Método para filtrar las órdenes por estado, prioridad y fechas
        public void FiltrarPorEstadoPrioridadYFechas(ref List<OrdenDePreparacionConsultas> ordenesEncontradas,
             string estadoSeleccionado, string prioridadSeleccionada, DateTime fechaInicio, DateTime fechaFin)
        {
            // Filtrar por Estado
            if (!string.IsNullOrEmpty(estadoSeleccionado))
            {
                EstadoOrdenPreparacionConsultaEnum estadoConsulta = (EstadoOrdenPreparacionConsultaEnum)Enum.Parse(typeof(EstadoOrdenPreparacionConsultaEnum), estadoSeleccionado);
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Estado == estadoConsulta).ToList();
            }

            // Filtrar por Prioridad
            if (!string.IsNullOrEmpty(prioridadSeleccionada))
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Prioridad.Equals(prioridadSeleccionada, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Filtrar por Fecha de Inicio
            if (fechaInicio != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision >= fechaInicio).ToList();
            }

            // Filtrar por Fecha de Fin
            if (fechaFin != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision <= fechaFin.AddDays(1).AddTicks(-1)).ToList();
            }
        }


        // Método para aplicar filtros adicionales
        public List<OrdenDePreparacionConsultas> BuscarOrdenes(string codigoCliente, string razonSocial, string cuit, string estadoSeleccionado, string prioridadSeleccionada, DateTime fechaInicio, DateTime fechaFin)
        {
            List<OrdenDePreparacionConsultas> ordenesEncontradas = ordenesPreparacion;

            // Filtrar por código de cliente
            if (!string.IsNullOrEmpty(codigoCliente))
            {
                if (int.TryParse(codigoCliente, out int codigo))
                {
                    ordenesEncontradas = ordenesEncontradas.Where(o => o.IdCliente == codigo).ToList();
                }
            }
            // Filtrar por razón social
            else if (!string.IsNullOrEmpty(razonSocial))
            {
                ordenesEncontradas = ObtenerOrdenesPorRazonSocial(razonSocial);
            }
            // Filtrar por CUIT
            else if (!string.IsNullOrEmpty(cuit))
            {
                ordenesEncontradas = ObtenerOrdenesPorCuit(cuit);
            }

            // Aplicar filtros por estado, prioridad y fechas
            if (ordenesEncontradas.Any())
            {
                FiltrarPorEstadoPrioridadYFechas(ref ordenesEncontradas, estadoSeleccionado, prioridadSeleccionada, fechaInicio, fechaFin);
            }

            return ordenesEncontradas;
        }
    }




}
