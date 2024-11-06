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
        //DATOS DE PRUEBA DE ORDEN DE PREPARACION.

        public OrdenSeleccionModelo()
        {

            //LINQ

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
                o.Detalle.Sum(d => d.Cantidad)
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



        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }

        /*
        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            // Carga de datos de prueba. 
            new OrdenPreparacion(
                "1",
                "123",
                "El Miguelon",
                new List<Producto>
                {
                    new Producto { IDProducto = "P1", IdCliente = "123", DescripcionProducto = "Alcachofas", Cantidad = 10, Ubicacion = "1-1-1" },
                    new Producto { IDProducto = "P2", IdCliente = "123", DescripcionProducto = "Brocoli", Cantidad = 5, Ubicacion = "1-1-2" }
                },
                15,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                PrioridadEnum.Media,
                new Transportista(12345678, "Transportista A", "123")
            ),
            new OrdenPreparacion(
                "2",
                "456",
                "Star Labs",
                new List<Producto>
                {
                    new Producto { IDProducto = "P3", IdCliente = "456", DescripcionProducto = "Manzanas", Cantidad = 20, Ubicacion = "2-2-1" },
                    new Producto { IDProducto = "P4", IdCliente = "456", DescripcionProducto = "Brocoli", Cantidad = 10, Ubicacion = "2-2-2" }
                },
                30,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                PrioridadEnum.Alta,
                new Transportista(87654321, "Transportista B", "456")
            ),
            new OrdenPreparacion(
                "3",
                "789",
                "Acme",
                new List<Producto>
                {
                    new Producto { IDProducto = "P5", IdCliente = "789", DescripcionProducto = "Alcachofas", Cantidad = 15, Ubicacion = "3-3-1" }
                },
                15,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                PrioridadEnum.Baja,
                new Transportista(11223344, "Transportista C", "789")
            ),
            new OrdenPreparacion(
                "4",
                "101",
                "GeoPlast",
                new List<Producto>
                {
                    new Producto { IDProducto = "P6", IdCliente = "101", DescripcionProducto = "Bananas", Cantidad = 25, Ubicacion = "3-3-3" }
                },
                25,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                PrioridadEnum.Media,
                new Transportista(55667788, "Transportista D", "101")
            ),
            new OrdenPreparacion(
                "5",
                "202",
                "Cliente E",
                new List<Producto>
                {
                    new Producto { IDProducto = "P7", IdCliente = "202", DescripcionProducto = "Bananas", Cantidad = 30, Ubicacion = "3-3-3" }
                },
                30,
                DateTime.Now,
                PosiblesEstadosOrdenesGenerales.Pendiente,
                PrioridadEnum.Alta,
                new Transportista(99887766, "Transportista E", "202")
            ),

        new OrdenPreparacion(
        "6",
        "303",
        "Cliente F",
        new List<Producto>
        {
            new Producto { IDProducto = "P8", IdCliente = "303", DescripcionProducto = "Tomates", Cantidad = 20, Ubicacion = "4-4-1" }
        },
        20,
        new DateTime(2023, 8, 15),  // Fecha en el pasado
        PosiblesEstadosOrdenesGenerales.Pendiente,
        PrioridadEnum.Media,
        new Transportista(11112222, "Transportista F", "303")),
new OrdenPreparacion(
    "10",
    "303",
    "Cliente F",
    new List<Producto>
    {
        new Producto { IDProducto = "P8", IdCliente = "303", DescripcionProducto = "Tomates", Cantidad = 20, Ubicacion = "4-4-1" }
    },
    20,
    DateTime.Now.AddDays(3),  // Fecha 3 días en el futuro desde hoy
    PosiblesEstadosOrdenesGenerales.Pendiente,
    PrioridadEnum.Media,
    new Transportista(11112222, "Transportista F", "303")
),
new OrdenPreparacion(
    "7",
    "404",
    "Cliente G",
    new List<Producto>
    {
        new Producto { IDProducto = "P9", IdCliente = "404", DescripcionProducto = "Zanahorias", Cantidad = 10, Ubicacion = "4-4-2" }
    },
    10,
    DateTime.Now.AddDays(10),  // Fecha 10 días en el futuro desde hoy
    PosiblesEstadosOrdenesGenerales.Pendiente,
    PrioridadEnum.Baja,
    new Transportista(33334444, "Transportista G", "404")
),
new OrdenPreparacion(
    "8",
    "505",
    "Cliente H",
    new List<Producto>
    {
        new Producto { IDProducto = "P10", IdCliente = "505", DescripcionProducto = "Peras", Cantidad = 40, Ubicacion = "5-5-1" }
    },
    40,
    DateTime.Now.AddDays(20),  // Fecha 20 días en el futuro desde hoy
    PosiblesEstadosOrdenesGenerales.Pendiente,
    PrioridadEnum.Alta,
    new Transportista(55556666, "Transportista H", "505")
),
new OrdenPreparacion(
    "9",
    "606",
    "Cliente I",
    new List<Producto>
    {
        new Producto { IDProducto = "P11", IdCliente = "606", DescripcionProducto = "Naranjas", Cantidad = 50, Ubicacion = "5-5-2" }
    },
    50,
    DateTime.Now.AddMonths(1),  // Fecha 1 mes en el futuro desde hoy
    PosiblesEstadosOrdenesGenerales.Pendiente,
    PrioridadEnum.Media,
    new Transportista(77778888, "Transportista I", "606")
),
new OrdenPreparacion(
    "12",
    "707",
    "Cliente J",
    new List<Producto>
    {
        new Producto { IDProducto = "P12", IdCliente = "707", DescripcionProducto = "Uvas", Cantidad = 35, Ubicacion = "6-6-1" }
    },
    35,
    DateTime.Now.AddMonths(2),  // Fecha 2 meses en el futuro desde hoy
    PosiblesEstadosOrdenesGenerales.Pendiente,
    PrioridadEnum.Baja,
    new Transportista(99990000, "Transportista J", "707")
)
        };
        */


        /*TODO: Validar los datos de una Orden de Seleccion.
        Devolver mensaje de error si algo esta mal. 
        Devolver null si esta ok, y la operacion fue exitosa. 
         */
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
