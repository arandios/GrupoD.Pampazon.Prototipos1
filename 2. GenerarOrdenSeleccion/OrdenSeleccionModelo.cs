using Pampazon._2._GenerarOrdenSeleccion;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.OrdenSeleccion
{
    internal class OrdenSeleccionModelo
    {
        //1. Traigo DATOS DE ORDEN DE PREPARACION pendientes.

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }
        
        
        public OrdenSeleccionModelo()
        {

            //LINQ 3
            OrdenesDePreparacion = (from orden in OrdenPreparacionAlmacen.OrdenesPreparacion
                                    where (PosiblesEstadosOrdenesGenerales)orden.Estado == PosiblesEstadosOrdenesGenerales.Pendiente // Filtra por estado "Pendiente"
                                    join cliente in ClienteAlmacen.Clientes
                                    on orden.IdCliente equals cliente.IdCliente into clientesJoin
                                    from cliente in clientesJoin.DefaultIfEmpty() // Realiza el LEFT JOIN
                                    select new OrdenPreparacion(
                                        orden.IdOrdenPreparacion.ToString(),                 // IDOrdenPreparacion
                                        (Prioridades)orden.Prioridad,                        // Prioridad
                                        orden.IdCliente.ToString(),                          // IdCliente
                                        orden.FechaRetiro,                                   // FechaRetiro
                                        (PosiblesEstadosOrdenesGenerales)orden.Estado,       // Estado
                                        cliente?.RazonSocial ?? "Cliente no encontrado"      // DescripcionCliente (con valor predeterminado en caso de NULL)
                                    )).ToList();






            //LINQ 2 -Adaptada a cambio de atributos en OrdenPreparacion.

            /*
             Esta expresión LINQ está usando el método Select para proyectar (transformar) 
            cada elemento en OrdenPreparacionAlmacen.OrdenesPreparacion 
            en una nueva instancia de la clase OrdenPreparacion. 
             


                    OrdenesDePreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion.Select(o => new OrdenPreparacion(
             o.IdOrdenPreparacion.ToString(),                   // IDOrdenPreparacion
             (Prioridades)o.Prioridad,                          // Prioridades (conversión de PrioridadEnum a Prioridades)
             o.IdCliente.ToString(),                            // IdCliente
             o.FechaRetiro,                                     // FechaRetiro
             (PosiblesEstadosOrdenesGenerales)o.Estado,         // Estado (conversión de EstadoOrdenPreparacionEnum a PosiblesEstadosOrdenesGenerales)
             ClienteAlmacen.Clientes.FirstOrDefault(c => c.IdCliente == o.IdCliente)?.RazonSocial // RazonSocial del cliente
         )).ToList();
            */




            //LINQ V1- Hecha por el profe.
            /*
            OrdenesDePreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion.Select(o => new OrdenPreparacion(
                o.IdOrdenPreparacion.ToString(),
                o.IdCliente.ToString(),
                ClienteAlmacen.Clientes.First(c => c.IdCliente == o.IdCliente).RazonSocial,
                o.Detalle.Select(d => new Producto
                {
                    IDProducto = d.SKU,
                    Cantidad = d.Cantidad,
                    DescripcionProducto = ProductoAlmacen.Productos.First(p => p.SKU == d.SKU).NombreProducto,
                    IdCliente = o.IdCliente.ToString()
                }).ToList(),
                o.Detalle.Sum(d => d.Cantidad),
                o.FechaEmision,
                o.Estado.ToString(),

            )).ToList();
            */


            /*
                        var ordenes = new List<OrdenPreparacion>();

                        foreach (var ordenEntidad in OrdenPreparacionAlmacen.OrdenesPreparacion)
                        {
                            var productosOrden = new List<Producto>();
                            foreach (var ordenDetalle in ordenEntidad.Detalle)
                            {
                                ProductoEnt productoEnt = null;

                                foreach (var productoEntidad in ProductoAlmacen.Productos)
                                {
                                    if (productoEntidad.SKU == ordenDetalle.SKU)
                                    {
                                        productoEnt = productoEntidad;
                                        break;
                                    }
                                }

                                var producto = new Producto();
                                producto.IDProducto = ordenDetalle.SKU;
                                producto.DescripcionProducto

                                productosOrden.Add(producto);
                            }


                            var orden = new OrdenPreparacion(
                                 ordenEntidad.IdOrdenPreparacion.ToString(),
                                 ordenEntidad.IdCliente.ToString(),
                                 productosOrden
                            );

                            ordenes.Add(orden);
                        }

                        OrdenesDePreparacion = ordenes;
            */
        }


        public string IngresarOrdenSeleccion(OrdenSeleccion ordenSeleccion)
        {
            return null;
        }

        public string BorrarOrdenDePreparacion(OrdenPreparacion OrdenDePreparacionSeleccionada)
        {
            //Validaciones.
            //TODO: Reveer que validaciones serian necesarias aqui. Limitaciones antes de borrar. (No deberia haber?)

            OrdenesDePreparacion.Remove(OrdenDePreparacionSeleccionada);
            return null; //todo ok.
        }
    }
}
