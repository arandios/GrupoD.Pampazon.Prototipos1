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
                                    where (PosiblesEstadosOrdenesGenerales)orden.Estado == PosiblesEstadosOrdenesGenerales.Pendiente
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
                OrdenesPreparacion = OPseleccionadas.Select(op => int.Parse(op.IDOrdenPreparacion)).ToList(),
                EstadoOrden = EstadoOrdenSeleccionEnum.Pendiente,
                FechaEstado = DateTime.Now
            };

            //------> TODO: VERIFICAR SI ESTA BIEN PARA GUARDAR EN EL JSON!

            // Agregar la nueva orden a la lista de Ordenes de Seleccion
            //OrdenDeSeleccionAlmacen.Agregar(nuevaOrdenSeleccion);
            


            // Grabar la lista actualizada en el archivo JSON
            //OrdenDeSeleccionAlmacen.Grabar();
        }


    /* V1
    public string IngresarOrdenSeleccion(OrdenSeleccion ordenSeleccion)
    {
        return null;
    }
    */

    public string BorrarOrdenDePreparacion(OrdenPreparacion OrdenDePreparacionSeleccionada)
        {
            //Validaciones.
            //TODO: Reveer que validaciones serian necesarias aqui. Limitaciones antes de borrar. (No deberia haber?)

            OrdenesDePreparacion.Remove(OrdenDePreparacionSeleccionada);
            return null; //todo ok.
        }
    }
}
