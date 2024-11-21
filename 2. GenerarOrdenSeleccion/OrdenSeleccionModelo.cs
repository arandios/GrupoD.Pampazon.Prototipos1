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
            //LINQ Version3 --> mas parecido a SQL
            OrdenesDePreparacion = (from orden in OrdenPreparacionAlmacen.OrdenesPreparacion
                                    where (PosiblesEstadosOrdenesGenerales)orden.Estado == PosiblesEstadosOrdenesGenerales.Pendiente //Hay que castear el enum
                                    join cliente in ClienteAlmacen.Clientes
                                    on orden.IdCliente equals cliente.IdCliente into clientesJoin
                                    from cliente in clientesJoin.DefaultIfEmpty()
                                    select new OrdenPreparacion(
                                        orden.IdOrdenPreparacion.ToString(),
                                        (Prioridades)orden.Prioridad,
                                        orden.IdCliente.ToString(),
                                        orden.FechaEmision,
                                        (PosiblesEstadosOrdenesGenerales)orden.Estado,
                                        cliente?.RazonSocial ?? "Cliente no encontrado"
                                    )).ToList();


            //Equivalente a lo de arriba, pero en sintaxis Lambda
            /*
            var op = OrdenPreparacionAlmacen.OrdenesPreparacion
                                            .Select(o => new OrdenPreparacion
                                            (
                                                o.IdOrdenPreparacion.ToString(),
                                                (Prioridades)o.Prioridad,
                                                o.IdCliente.ToString(),
                                                o.FechaEmision,
                                                (PosiblesEstadosOrdenesGenerales)o.Estado,
                                                ClienteAlmacen.Clientes.First(c => c.IdCliente == o.IdCliente).RazonSocial
                                            )).ToList();
            */
        }


        public void IngresarOrdenSeleccion(List<OrdenPreparacion> OPseleccionadas)
        {
            // Obtener el número ID para la nueva Orden de Selección
            int nuevoIdOrdenSeleccion = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.Any()
                ? OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.Max(o => o.IdOrdenSeleccion) + 1
                : 1;

            // Creao una instancia de OrdenDeSeleccionEnt
            var nuevaOrdenSeleccion = new OrdenDeSeleccionEnt
            {
                IdOrdenSeleccion = nuevoIdOrdenSeleccion,
                FechaEmision = DateTime.Now,
                OrdenesPreparacion = OPseleccionadas.Select(op => new OrdenPreparacionEnt
                {
                    IdOrdenPreparacion = int.Parse(op.IDOrdenPreparacion),
                    Prioridad = (PrioridadEnum)op.Prioridad,
                    IdCliente = int.Parse(op.IdCliente),
                    FechaEmision = op.fechaOrdenPreparacion,
                    Estado = (EstadoOrdenPreparacionEnum)op.EstadoOrdenPreparacion,
                }).Select(opEnt => opEnt.IdOrdenPreparacion).ToList(), // Convertir a lista de IDs
                EstadoOrden = EstadoOrdenSeleccionEnum.Pendiente,
                FechaEstado = DateTime.Now
            };

            // Agregar la nueva orden a la lista de Ordenes de Seleccion
            OrdenDeSeleccionAlmacen.Agregar(nuevaOrdenSeleccion);

            // Grabar la lista actualizada en el archivo JSON
            OrdenDeSeleccionAlmacen.Grabar(); //TODO: Grabar deberia estar en el almacen?

            //Cambiar estado Orden de Preparacion
            //TODO VERIFICAR EN JSON
            foreach (var op in OPseleccionadas)
            {
                OrdenPreparacionAlmacen.cambiarEstado(int.Parse(op.IDOrdenPreparacion), EstadoOrdenPreparacionEnum.Procesamiento);
            }
        }
    }
}
