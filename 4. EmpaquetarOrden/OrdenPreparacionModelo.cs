using Pampazon.Almacenes;
using Pampazon.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon._4._EmpaquetarOrden
{
    internal class OrdenPreparacionModelo
    {
        public List<OrdenPreparacion> ordenesPreparacion { get; private set; }  // Lista de órdenes

        public OrdenPreparacionModelo()
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
             
             
             * /



            /*
            ordenes = new List<Orden>
            {
            new Orden
            {
                IdOrden = "1",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU001", DescripcionProducto = "Zapatilla ", Cantidad = 10 },
                    new Producto() { SKUProducto = "SKU002", DescripcionProducto = "Remera ", Cantidad = 5 },
                    new Producto() { SKUProducto = "SKU003", DescripcionProducto = "Pantalón ", Cantidad = 3 }

                }
            },
            new Orden
            {
                IdOrden = "2",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU004", DescripcionProducto = "Camisa", Cantidad = 7 },
                    new Producto() { SKUProducto = "SKU005", DescripcionProducto = "Buzo", Cantidad = 6 }
                }
            },
            new Orden
            {
                IdOrden = "3",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU006", DescripcionProducto = "Gorra", Cantidad = 15 },
                    new Producto() { SKUProducto = "SKU007", DescripcionProducto = "Medias", Cantidad = 50 }
                }
            },
            new Orden
            {
                IdOrden = "4",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU008", DescripcionProducto = "Campera", Cantidad = 8 },
                    new Producto() { SKUProducto = "SKU009", DescripcionProducto = "Short", Cantidad = 12 },
                    new Producto() { SKUProducto = "SKU0010", DescripcionProducto = "Bufanda", Cantidad = 25 }
                }
            },
            new Orden
            {
                IdOrden = "5",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU011", DescripcionProducto = "Guantes", Cantidad = 14 },
                    new Producto() { SKUProducto = "SKU012", DescripcionProducto = "Chaleco", Cantidad = 10 }
                }
            },
            new Orden
            {
                IdOrden = "6",
                Productos = new List<Producto>
                {
                    new Producto() { SKUProducto = "SKU013", DescripcionProducto = "Cinturón", Cantidad = 30 },
                    new Producto() { SKUProducto = "SKU014", DescripcionProducto = "Lentes de Sol", Cantidad = 20 }
                }
            }
            */
        }

    }
    }

