using Pampazon._3._BuscarProductosEnDepositos;
using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.BuscarProductosEnDepositos
{
    internal class BuscarProductosEnDepositosModelo
    {
        public List<OrdenDeSeleccion>OrdenesDeSeleccion { get; private set; }



        public BuscarProductosEnDepositosModelo()
        {
            //OrdenesDeSeleccion = new List<OrdenDeSeleccion>



            //LINQ  ---------------------- AJUSTAR SENTENCIA SEGUN REQUERIMIENTOS DE PANTALLA!

            OrdenesDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesDeSeleccion
            .Where(orden => orden.EstadoOrden == EstadoOrdenSeleccionEnum.Pendiente)
            .Select(orden => new OrdenDeSeleccion(
                orden.IdOrdenSeleccion,
                ((PosiblesEstadosOrdenesGenerales)orden.EstadoOrden).ToString()
            ))
            .ToList();


            /*
            {
                new OrdenDeSeleccion(1, "Pendiente")
                {
                   OrdenesDePreparacion = new List<OrdenDePreparacion>
                    {
                        new OrdenDePreparacion("OP001", DateTime.Now, "C001", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("12-43-2", "SKU001", 10),  // Sector 12, Posición 43, Fila 2
                            new Producto("12-43-3", "SKU002", 20)   // Sector 12, Posición 43, Fila 3
                        }),
                        new OrdenDePreparacion("OP002", DateTime.Now, "C002", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("15-22-5", "SKU003", 30),  // Sector 15, Posición 22, Fila 5
                            new Producto("15-22-6", "SKU004", 40)   // Sector 15, Posición 22, Fila 6
                        })
                    }
                },
                new OrdenDeSeleccion(2, "Pendiente")
                {
                    OrdenesDePreparacion = new List<OrdenDePreparacion>
                    {
                        new OrdenDePreparacion("OP003", DateTime.Now, "C003", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("23-11-4", "SKU005", 15),  // Sector 23, Posición 11, Fila 4
                            new Producto("23-11-5", "SKU006", 25)   // Sector 23, Posición 11, Fila 5
                        }),
                        new OrdenDePreparacion("OP004", DateTime.Now, "C004", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("17-33-3", "SKU007", 18),  // Sector 17, Posición 33, Fila 3
                            new Producto("17-33-4", "SKU008", 22)   // Sector 17, Posición 33, Fila 4
                        })
                    }
                },
                new OrdenDeSeleccion(3, "Pendiente")
                {
                    OrdenesDePreparacion = new List<OrdenDePreparacion>
                    {
                        new OrdenDePreparacion("OP005", DateTime.Now, "C005", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("19-54-1", "SKU009", 12),  // Sector 19, Posición 54, Fila 1
                            new Producto("19-54-2", "SKU010", 20)   // Sector 19, Posición 54, Fila 2
                        }),
                        new OrdenDePreparacion("OP006", DateTime.Now, "C006", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("14-25-3", "SKU011", 10),  // Sector 14, Posición 25, Fila 3
                            new Producto("14-25-4", "SKU012", 15)   // Sector 14, Posición 25, Fila 4
                        })
                    }
                },
                new OrdenDeSeleccion(4, "Pendiente")
                {
                    OrdenesDePreparacion = new List<OrdenDePreparacion>
                    {
                        new OrdenDePreparacion("OP007", DateTime.Now, "C007", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("11-43-2", "SKU013", 25),  // Sector 11, Posición 43, Fila 2
                            new Producto("11-43-3", "SKU014", 30)   // Sector 11, Posición 43, Fila 3
                        }),
                        new OrdenDePreparacion("OP008", DateTime.Now, "C008", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("16-31-5", "SKU015", 20),  // Sector 16, Posición 31, Fila 5
                            new Producto("16-31-6", "SKU016", 18)   // Sector 16, Posición 31, Fila 6
                        })
                    }
                },
                new OrdenDeSeleccion(5, "Pendiente")
                {
                    OrdenesDePreparacion = new List<OrdenDePreparacion>
                    {
                        new OrdenDePreparacion("OP009", DateTime.Now, "C009", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("18-21-2", "SKU017", 10),  // Sector 18, Posición 21, Fila 2
                            new Producto("18-21-3", "SKU018", 22)   // Sector 18, Posición 21, Fila 3
                        }),
                        new OrdenDePreparacion("OP010", DateTime.Now, "C010", "Pendiente", DateTime.Now,
                        new List<Producto>
                        {
                            new Producto("13-37-1", "SKU019", 5),   // Sector 13, Posición 37, Fila 1
                            new Producto("13-37-2", "SKU020", 11)   // Sector 13, Posición 37, Fila 2
                        })
                    }
                },
        
            };*/
        }




        public List<Producto> ObtenerProductosPorOrdenDeSeleccion(int idOrdenSeleccion)
        {
            var orden = OrdenesDeSeleccion.FirstOrDefault(o => o.IDOrdenSeleccion == idOrdenSeleccion);
            if (orden != null)
            {
                return orden.OrdenesDePreparacion.SelectMany(op => op.Productos).ToList();
            }
            return new List<Producto>();
        }

        public List<OrdenDeSeleccion> ObtenerOrdenesDeSeleccion()
        {
            return OrdenesDeSeleccion.Where(o => o.Estado == "Pendiente").ToList();
        }

        // Método para confirmar la orden de selección
        public void ConfirmarOrdenSeleccion(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenesDeSeleccion.FirstOrDefault(o => o.IDOrdenSeleccion == idOrdenSeleccion);
            if (ordenSeleccion != null)
            {
                // Cambiar el estado de las órdenes de preparación a "Procesada"
                foreach (var ordenPrep in ordenSeleccion.OrdenesDePreparacion)
                {
                    ordenPrep.Estado = "Procesada";
                    ordenPrep.FechaEstado = DateTime.Now; // Actualiza la fecha
                }

                // Cambiar el estado de la orden de selección a "Confirmada"
                ordenSeleccion.Estado = "Confirmada";

                // Eliminar la orden de selección de la lista
                OrdenesDeSeleccion.Remove(ordenSeleccion);
            }
        }
        public void CargarOrdenesEnComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var ordenes = ObtenerOrdenesDeSeleccion();
            foreach (var orden in ordenes)
            {
                comboBox.Items.Add(orden.IDOrdenSeleccion);
            }

            // Seleccionar la primera orden de selección si hay alguna
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0; // Selecciona automáticamente la primera
            }
        }
        public void CargarProductosEnListView(int idOrdenSeleccion, ListView listView)
        {
            listView.Items.Clear();
            var productos = ObtenerProductosPorOrdenDeSeleccion(idOrdenSeleccion);

            foreach (var producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Ubicacion);
                item.SubItems.Add(producto.SKU);
                item.SubItems.Add(producto.Cantidad.ToString());
                listView.Items.Add(item);
            }
        }
    }
}