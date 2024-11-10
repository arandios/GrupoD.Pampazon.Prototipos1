using Pampazon._3._BuscarProductosEnDepositos;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class BuscarProductosEnDepositosModelo
    {
        public List<OrdenDeSeleccionEnt> OrdenesDeSeleccion { get; private set; }

        public BuscarProductosEnDepositosModelo()
        {
            //LINQ  ---------------------- AJUSTAR SENTENCIA SEGUN REQUERIMIENTOS DE PANTALLA!

            OrdenesDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion
                .Select(ordenSeleccion => new OrdenDeSeleccionEnt
                {
                    IdOrdenSeleccion = ordenSeleccion.IdOrdenSeleccion,
                    FechaEmision = ordenSeleccion.FechaEmision,
                    OrdenesPreparacion = ordenSeleccion.OrdenesPreparacion
                        .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.First(op => op.IdOrdenPreparacion == id).IdOrdenPreparacion)
                        .ToList(),
                    EstadoOrden = ordenSeleccion.EstadoOrden,
                    FechaEstado = ordenSeleccion.FechaEstado
                }).ToList();
        }

        public List<OrdenDeSeleccionEnt> ObtenerOrdenesDeSeleccion()
        {
            return OrdenesDeSeleccion.Where(o => o.EstadoOrden == EstadoOrdenSeleccionEnum.Pendiente).ToList();
        }

        // Método para confirmar la orden de selección
        public void ConfirmarOrdenSeleccion(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenesDeSeleccion.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            if (ordenSeleccion != null)
            {
                var ordenesPreparacion = ordenSeleccion.OrdenesPreparacion
                    .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.First(op => op.IdOrdenPreparacion == id))
                    .ToList();

                // Cambiar el estado de las órdenes de preparación a "Procesada"
                foreach (var ordenPrep in ordenesPreparacion)
                {
                    ordenPrep.Estado = EstadoOrdenPreparacionEnum.Procesada;
                }

                // Cambiar el estado de la orden de selección a "Confirmada"
                ordenSeleccion.EstadoOrden = EstadoOrdenSeleccionEnum.Seleccionada;

                // Eliminar la orden de selección de la lista
                OrdenesDeSeleccion.Remove(ordenSeleccion);
            }
        }

        public void CargarOrdenesSeleccionEnComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var ordenes = ObtenerOrdenesDeSeleccion();
            foreach (var orden in ordenes)
            {
                comboBox.Items.Add(orden.IdOrdenSeleccion);
            }

            // Seleccionar la primera orden de selección si hay alguna
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0; // Selecciona automáticamente la primera
            }
        }

        public List<ProductoEnt> ObtenerProductosPorOrdenDeSeleccion(int idOrdenSeleccion)
        {
            var orden = OrdenesDeSeleccion.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            if (orden != null)
            {
                var ordenesPreparacion = orden.OrdenesPreparacion
                    .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.First(op => op.IdOrdenPreparacion == id))
                    .ToList();

                return ordenesPreparacion
                    .SelectMany(op => op.Detalle)
                    .GroupBy(detalle => new { detalle.SKU, ordenesPreparacion.First().IdCliente })
                    .Select(g => new ProductoEnt
                    {
                        SKU = g.Key.SKU,
                        IdCliente = g.Key.IdCliente,
                        NombreProducto = g.First().SKU != null
                                         ? ProductoAlmacen.Productos.FirstOrDefault(p => p.SKU == g.Key.SKU)?.NombreProducto
                                         : "Nombre desconocido",
                        Detalle = ProductoAlmacen.Productos
                            .FirstOrDefault(p => p.SKU == g.Key.SKU)?.Detalle
                            .Select(d => new UbicacionProductoDetalle
                            {
                                IdUbicacion = d.IdUbicacion,
                                Stock = d.Stock
                            }).ToList()
                    })
                    .ToList();
            }
            return new List<ProductoEnt>();
        }






    }
}
