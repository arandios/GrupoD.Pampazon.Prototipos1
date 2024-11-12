using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._4._EmpaquetarOrden
{
    internal class EmpaquetarOrdenModelo
    {
        public List<OrdenPreparacion> ordenesPreparacion { get; private set; }  // Lista de órdenes

        public EmpaquetarOrdenModelo()
        {
            CargarOrdenes();  // Carga las órdenes al crear la instancia del modelo
        }

        // Método que obtiene la lista actual de órdenes
        public List<OrdenPreparacion> ObtenerOrdenActual()
        {
            return ordenesPreparacion;
        }

        // Método para cargar las órdenes iniciales (simulación de carga de datos)
        public void CargarOrdenes()
        {

            ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
            .Where(o => o.Estado == EstadoOrdenPreparacionEnum.Procesada)  // Filtra por estado "Procesada"
            .Select(o => new OrdenPreparacion
            {
                IdOrdenPreparacion = o.IdOrdenPreparacion.ToString(),
                Productos = o.Detalle.Select(d => new Producto
                {
                    SKUProducto = d.SKU,
                    DescripcionProducto = ProductoAlmacen.Productos.FirstOrDefault(p => p.SKU == d.SKU)?.NombreProducto ?? "Producto no encontrado",
                    Cantidad = d.Cantidad
                }).ToList()
            }).ToList();




        }
        public void CambiarEstadoOrdenPreparacion(int idOrden, EstadoOrdenPreparacionEnum nuevoEstado)
        {
            OrdenPreparacionAlmacen.cambiarEstado(idOrden, nuevoEstado);
            // Actualiza la lista de órdenes para excluir las que ya no están en estado "Procesada"
            CargarOrdenes();
        }



        //TODO: Cambiar estado de la Orden de Seleccion a Seleccionada. 
        public void cambiarEstadoOP()
        {
            foreach (var op in ordenesPreparacion)
            {
                Almacenes.OrdenPreparacionAlmacen.cambiarEstado(int.Parse(op.IdOrdenPreparacion), EstadoOrdenPreparacionEnum.Preparada);

            }
        }
    }
}

