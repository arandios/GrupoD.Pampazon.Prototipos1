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

            // Filtrar solo las órdenes con estado "Procesada" (2)
            ordenesPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(o => o.Estado == EstadoOrdenPreparacionEnum.Procesada)  // Filtrar por estado
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

            /*
            // Cambiar estado de las órdenes de preparación a Preparada -- TODO: Verificar cambio de estado. 
            foreach (var ordenPreparacion in ordenesPreparacion)
            {
                ordenPreparacion.Estado = (EstadoOrdenPreparacionEnum)PosiblesEstadosOrdenesPreparacion_paraEmpaquetarOrden.Preparada;
            }
            */
        }

        //TODO: Cambiar estado de la Orden de Seleccion a Seleccionada. 
    }
}

