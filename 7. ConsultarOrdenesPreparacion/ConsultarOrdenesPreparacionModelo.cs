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
        private List<OrdenPreparacionEnt> ordenesPreparacion;

        public ConsultarOrdenesPreparacionModelo()
        {
            // Inicializar 'ordenes' con los datos de 'OrdenPreparacionAlmacen'
            ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Select(o =>
                {
                    var orden = new OrdenPreparacionEnt
                    {
                        IdOrdenPreparacion = o.IdOrdenPreparacion,
                        Prioridad = o.Prioridad,
                        IdCliente = o.IdCliente,
                        DNITransportista = o.DNITransportista,
                        FechaEmision = o.FechaEmision,
                        FechaRetiro = o.FechaRetiro,
                        HoraRetiro = o.HoraRetiro,
                        Estado = o.Estado
                    };

                    
                    orden.Detalle.AddRange(o.Detalle); 

                    return orden;
                })
                .ToList();
        }
        public List<ProductoConsulta> ObtenerProductosPorOrdenId(int idOrdenPreparacion)
        {
            var orden = ObtenerOrdenPorId(idOrdenPreparacion);
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
        public List<OrdenPreparacionEnt> ObtenerOrdenesPorRazonSocial(string razonSocial)
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
        public List<OrdenPreparacionEnt> ObtenerOrdenesPorCuit(string cuit)
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

        public OrdenPreparacionEnt ObtenerOrdenPorId(int idOrdenPreparacion)
        {
            return ordenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOrdenPreparacion);
        }

        public List<OrdenPreparacionEnt> ObtenerTodasLasOrdenes()
        {
            return ordenesPreparacion;
        }

        // Método para filtrar las órdenes por estado, prioridad y fechas
        public void FiltrarPorEstadoPrioridadYFechas(ref List<OrdenPreparacionEnt> ordenesEncontradas,
     string estadoSeleccionado, string prioridadSeleccionada, DateTime fechaInicio, DateTime fechaFin)
        {
            // Filtrar por Estado
            if (!string.IsNullOrEmpty(estadoSeleccionado))
            {
                EstadoOrdenPreparacionEnum estado = (EstadoOrdenPreparacionEnum)Enum.Parse(typeof(EstadoOrdenPreparacionEnum), estadoSeleccionado);
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Estado == estado).ToList();
            }

            // Filtrar por Prioridad
            if (!string.IsNullOrEmpty(prioridadSeleccionada))
            {
                PrioridadEnum prioridad = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), prioridadSeleccionada);
                ordenesEncontradas = ordenesEncontradas.Where(o => o.Prioridad == prioridad).ToList();
            }

            // Filtrar por Fecha de Inicio
            if (fechaInicio != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision >= fechaInicio).ToList();
            }

            // Filtrar por Fecha de Fin
            if (fechaFin != DateTime.Today)
            {
                ordenesEncontradas = ordenesEncontradas.Where(o => o.FechaEmision <= fechaFin).ToList();
            }
        }


        // Método para aplicar filtros adicionales
        public List<OrdenPreparacionEnt> BuscarOrdenes(string codigoCliente, string razonSocial, string cuit, string estadoSeleccionado, string prioridadSeleccionada, DateTime fechaInicio, DateTime fechaFin)
        {
            List<OrdenPreparacionEnt> ordenesEncontradas = ordenesPreparacion;

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
