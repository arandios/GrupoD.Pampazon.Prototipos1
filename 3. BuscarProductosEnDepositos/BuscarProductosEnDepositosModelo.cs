﻿










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

        //Antes devolvia List<OrdenSeleccionENT>
        public List<int> ObtenerOrdenesDeSeleccion()
        {
            // Obtener los IDs de las órdenes de selección con estado "Pendiente"
            return OrdenesDeSeleccion
                .Where(o => o.EstadoOrden == EstadoOrdenSeleccionEnum.Pendiente)
                .Select(o => o.IdOrdenSeleccion)
                .ToList();
        }



        // Método para confirmar la orden de selección

        /*
        public void ConfirmarOrdenSeleccion(int idOrdenSeleccion)
        {
            //TODO: revisar: parece que está haciendo los cambios en la orden de seleccion sobre una COPIA
            var ordenSeleccion = OrdenesDeSeleccion.First(o => o.IdOrdenSeleccion == idOrdenSeleccion);

            var ordenSeleccionEntidad = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion.First(o => o.IdOrdenSeleccion == idOrdenSeleccion);

            var ordenesPreparacionEntidad = ordenSeleccionEntidad.OrdenesPreparacion
                .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.First(op => op.IdOrdenPreparacion == id))
                .ToList();

            // Cambiar el estado de las órdenes de preparación a "Procesada"
            foreach (var ordenPrepEntidad in ordenesPreparacionEntidad)
            {
                ordenPrepEntidad.Estado = EstadoOrdenPreparacionEnum.Procesada;
            }

            // Cambiar el estado de la orden de selección a "Seleccionada"
            ordenSeleccionEntidad.EstadoOrden = EstadoOrdenSeleccionEnum.Seleccionada;

            // Eliminar la orden de selección de la lista
            OrdenesDeSeleccion.Remove(ordenSeleccion);
        }
        */

        public void ConfirmarOrdenSeleccion(int idOrdenSeleccion)
        {
            // Obtener la orden de selección desde el almacenamiento persistente
            var ordenSeleccionEntidad = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion
                .FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);

            if (ordenSeleccionEntidad == null)
            {
                throw new InvalidOperationException("La orden de selección no existe.");
            }

            // Cambiar el estado de las órdenes de preparación asociadas a "Procesada"
            foreach (var idOrdenPreparacion in ordenSeleccionEntidad.OrdenesPreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion
                    .FirstOrDefault(op => op.IdOrdenPreparacion == idOrdenPreparacion);

                if (ordenPreparacion != null)
                {
                    // Mostrar el estado antes de cambiarlo
                    //MessageBox.Show($"Estado antes de cambiar: {ordenPreparacion.Estado}");

                    cambiarStock(ordenPreparacion);

                    // Cambiar el estado
                    ordenPreparacion.Estado = EstadoOrdenPreparacionEnum.Procesada;

                    // Mostrar el estado después de cambiarlo
                    //MessageBox.Show($"Estado después de cambiar: {ordenPreparacion.Estado}");

                    OrdenPreparacionAlmacen.Grabar();
                }
            }

            // Cambiar el estado de la orden de selección a "Seleccionada"
            ordenSeleccionEntidad.EstadoOrden = EstadoOrdenSeleccionEnum.Seleccionada;

            // Persistir los cambios en el almacenamiento
            OrdenDeSeleccionAlmacen.Grabar();

            // Eliminar la orden de selección de la lista en memoria de órdenes de selección activas
            OrdenesDeSeleccion.RemoveAll(o => o.IdOrdenSeleccion == idOrdenSeleccion);
        }


            public void  cambiarStock( OrdenPreparacionEnt orden  ) {
                
                foreach(var prod in orden.Detalle )
                {
                Almacenes.ProductoAlmacen.restarStock(prod.SKU, prod.Cantidad);
                }

            }



        public void CargarOrdenesSeleccionEnComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            //var ordenes = ObtenerOrdenesDeSeleccion();
            List<int> ordenes = ObtenerOrdenesDeSeleccion();

            foreach (var orden in ordenes)
            {
                comboBox.Items.Add(orden);
            }


            /*
            foreach (var orden in ordenes)
            {
                comboBox.Items.Add(orden.IdOrdenSeleccion);
            }
            */

            // Seleccionar la primera orden de selección si hay alguna
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0; // Selecciona automáticamente la primera
            }
        }

        public List<Producto> ObtenerProductosPorOrdenDeSeleccion(int idOrdenSeleccion)
        {
            var orden = OrdenesDeSeleccion.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            if (orden == null)
            {
                throw new InvalidOperationException($"No se encontró la orden de selección con ID {idOrdenSeleccion}");
            }

            var ordenesPreparacion = orden.OrdenesPreparacion
                .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == id))
                .Where(op => op != null)
                .ToList();


            // Un diccionario SKU / Cantidad.
            var cantReqXProducto = new Dictionary<string, int>();
            foreach (var ordenPrep in ordenesPreparacion)
            {
                foreach (var detalleOrdenPrep in ordenPrep.Detalle)
                {
                    if (cantReqXProducto.ContainsKey(detalleOrdenPrep.SKU))
                    {
                        cantReqXProducto[detalleOrdenPrep.SKU] += detalleOrdenPrep.Cantidad;
                    }
                    else
                    {
                        cantReqXProducto.Add(detalleOrdenPrep.SKU, detalleOrdenPrep.Cantidad);
                    }
                }
            }

            // cantReqXProducto tiene "lo que necesito". resultado es lo que tengo que devolver
            var resultado = new List<Producto>();

            foreach (string sku in cantReqXProducto.Keys) // cada SKU está UNA sola vez.
            {
                var productoEntidad = ProductoAlmacen.Productos.FirstOrDefault(p => p.SKU == sku);
                if (productoEntidad == null)
                {
                    throw new InvalidOperationException($"No se encontró el producto con SKU {sku}");
                }

                var productoResultado = new Producto(sku, productoEntidad.IdCliente.ToString(), productoEntidad.NombreProducto, new List<UbicacionProdutoDetalle_ParaBuscarProductosEnDepo>());

                // Donde lo encuentro?
                foreach (var ubicacionEnStock in productoEntidad.Detalle)
                {
                    var resultadoUbicacion = new UbicacionProdutoDetalle_ParaBuscarProductosEnDepo
                    {
                        IdUbicacion = ubicacionEnStock.IdUbicacion,
                        Stock = Math.Min(cantReqXProducto[sku], ubicacionEnStock.Stock)
                    };

                    cantReqXProducto[sku] -= resultadoUbicacion.Stock;
                    productoResultado.Detalle.Add(resultadoUbicacion);

                    if (cantReqXProducto[sku] == 0)
                    {
                        break;
                    }
                }

                resultado.Add(productoResultado);

                
            }
            return resultado;
        }




        /*
        public List<Producto> ObtenerProductosPorOrdenDeSeleccion(int idOrdenSeleccion)
        {
            var orden = OrdenesDeSeleccion.FirstOrDefault(o => o.IdOrdenSeleccion == idOrdenSeleccion);
            var ordenesPreparacion = orden.OrdenesPreparacion
                .Select(id => OrdenPreparacionAlmacen.OrdenesPreparacion.First(op => op.IdOrdenPreparacion == id))
                .ToList();


            //...para cada orden de preparacion en la orden de seleccion
            //   buscar productos => una lista de productos / cantidades zapa 10 zapa 20 zapa 30 reme 10 reme 15
            //
            //agrupar por producto => suma cantidades. => zapa 60 reme 25

            //para cada producto en la lista...
            //para cada ubicacion de ese producto
            //  tomar cantidad necesaria o la que hay, la menor.
            //si no consegui la cantidad necesaria => siguiente ubicacion.

            //un diccionario SKU / Cantidad.
            var cantReqXProducto = new Dictionary<string, int>();
            foreach (var ordenPrep in ordenesPreparacion)
            {
                foreach (var detalleOrdenPrep in ordenPrep.Detalle)
                {
                    if (cantReqXProducto.ContainsKey(detalleOrdenPrep.SKU))
                    {
                        cantReqXProducto[detalleOrdenPrep.SKU] += detalleOrdenPrep.Cantidad;
                    }
                    else
                    {
                        cantReqXProducto.Add(detalleOrdenPrep.SKU, detalleOrdenPrep.Cantidad);
                    }
                }
            }

            //cantReqXProducto tiene "lo que necesito". resultado es lo que tengo que devolver
            var resultado = new List<Producto>();

            foreach (string sku in cantReqXProducto.Keys) //cada SKU esta UNA sola vez.
            {
                var productoEntidad = ProductoAlmacen.Productos.First(p => p.SKU == sku);
                var productoResultado = new Producto(sku, productoEntidad.IdCliente.ToString(), productoEntidad.NombreProducto, new List<UbicacionProdutoDetalle_ParaBuscarProductosEnDepo>());

                //donde lo encuentro?
                foreach (var ubicacionEnStock in productoEntidad.Detalle)
                {
                    var resultadoUbicacion = new UbicacionProdutoDetalle_ParaBuscarProductosEnDepo
                    {
                        IdUbicacion = ubicacionEnStock.IdUbicacion,
                        Stock = Math.Min(cantReqXProducto[sku], ubicacionEnStock.Stock)
                    };

                    cantReqXProducto[sku] -= resultadoUbicacion.Stock;
                    productoResultado.Detalle.Add(resultadoUbicacion);

                    if (cantReqXProducto[sku] == 0)
                    {
                        break;
                    }
                }

                resultado.Add(productoResultado);
            }
            return resultado;
        }*/


    }
}
