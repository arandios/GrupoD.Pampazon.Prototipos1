using Pampazon.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.EmpaquetarOrden
{
    internal class OrdenPreparacionModelo
    {
        public List<OrdenPreparacion> Ordenes { get; set; } = new List<OrdenPreparacion>()
        {
            new OrdenPreparacion
            {
                IdOrdenPreparacion = "2938",
                Prioridad = Prioridad.Alta,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 1,
                            DescripcionProducto = "Zapatilla nike",
                            Detalle = "Nike Air Force"
                        },
                        Cantidad = 300
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 2,
                            DescripcionProducto = "Ojotas Nike",
                            Detalle = "Ojotas verano modelo original"
                        },
                        Cantidad = 250
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 3,
                            DescripcionProducto = "Zapatilla Adidas",
                            Detalle = "Modelos surtidos Adidas"
                        },
                        Cantidad = 321
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "7839",
                Prioridad = Prioridad.Alta,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 6,
                            DescripcionProducto = "Zapatilla Adidas",
                            Detalle = "Adidas Superstar"
                        },
                        Cantidad = 200
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 4,
                            DescripcionProducto = "Ojotas Adidas",
                            Detalle = "Ojotas verano modelo original"
                        },
                        Cantidad = 150
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "5839",
                Prioridad = Prioridad.Alta,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 10,
                            DescripcionProducto = "Celular Samsung",
                            Detalle = "Samsung Galaxy S22"
                        },
                        Cantidad = 320
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 438,
                            DescripcionProducto = "Tablet Apple",
                            Detalle = "iPad Pro 12.9\""
                        },
                        Cantidad = 439
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "5678",
                Prioridad = Prioridad.Alta,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 59,
                            DescripcionProducto = "Pintura Blanca",
                            Detalle = "Pintura Látex Interior 20L"
                        },
                        Cantidad = 112
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 938,
                            DescripcionProducto = "Pincel",
                            Detalle = "Pincel de Cerdas Sintéticas 2\""
                        },
                        Cantidad = 578
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "9101",
                Prioridad = Prioridad.Media,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 365,
                            DescripcionProducto = "Monitor LG",
                            Detalle = "Monitor 27'' UHD 4K"
                        },
                        Cantidad = 32
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 326,
                            DescripcionProducto = "Teclado Mecánico",
                            Detalle = "Teclado Mecánico RGB"
                        },
                        Cantidad = 211
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "7682",
                Prioridad = Prioridad.Media,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 412,
                            DescripcionProducto = "Sábanas King Size",
                            Detalle = "Sábanas Algodón 100% 500 hilos"
                        },
                        Cantidad = 376
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 924,
                            DescripcionProducto = "Funda Almohada",
                            Detalle = "Funda Algodón Antialérgico"
                        },
                        Cantidad = 400
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "2783",
                Prioridad = Prioridad.Baja,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 325,
                            DescripcionProducto = "Laptop HP",
                            Detalle = "HP Pavilion 15'' i7 16GB RAM"
                        },
                        Cantidad = 20
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 934,
                            DescripcionProducto = "Mouse Inalámbrico",
                            Detalle = "Mouse Logitech MX Master 3"
                        },
                        Cantidad = 400
                    }
                }
            },

            new OrdenPreparacion
            {
                IdOrdenPreparacion = "1819",
                Prioridad = Prioridad.Baja,
                detalles = new List<OrdenDetalle>
                {
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 22,
                            DescripcionProducto = "Cuaderno A4",
                            Detalle = "Cuaderno Rayado 100 Hojas"
                        },
                        Cantidad = 340
                    },
                    new OrdenDetalle
                    {
                        Producto = new Producto
                        {
                            IdProducto = 76,
                            DescripcionProducto = "Lapiceras BIC",
                            Detalle = "Lapiceras Tinta Azul x50"
                        },
                        Cantidad = 600
                    }
                }
            },
        };
    }
}
