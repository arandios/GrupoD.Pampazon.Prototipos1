using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    public partial class ConfirmarOrdenSeleccion : Form
    {
        public ConfirmarOrdenSeleccion()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenSeleccion_Load(object sender, EventArgs e)
        {
            // Crear múltiples órdenes de selección
            List<OrdenSeleccion> ordenes = new List<OrdenSeleccion>
            {
            new OrdenSeleccion(
                123, // Nro_OrdenS
                DateTime.Now, // FechaEmision
                456, // OP_Asociada
                "En Proceso", // Estado
                DateTime.Now, // Fecha_Estado
                new List<Productos> // Lista de productos
                {
                        new Productos(123, 1001, "Producto A", 10),
                        new Productos(123, 1002, "Producto B", 5)
                }
            ),
            new OrdenSeleccion(
            124, // Nro_OrdenS
            DateTime.Now.AddDays(-1), // FechaEmision
            457, // OP_Asociada
            "Entregado", // Estado
            DateTime.Now.AddDays(-1), // Fecha_Estado
                new List<Productos> // Lista de productos
                {
                    new Productos(124, 2001, "Producto C", 2),
                    new Productos(124, 2002, "Producto D", 3)
                }
            ),
            new OrdenSeleccion(
            125, // Nro_OrdenS
            DateTime.Now.AddDays(-2), // FechaEmision
            458, // OP_Asociada
            "Cancelado", // Estado
            DateTime.Now.AddDays(-2), // Fecha_Estado
                new List<Productos> // Lista de productos
            {
                new Productos(125, 3001, "Producto E", 1),
                new Productos(125, 3002, "Producto F", 4),
                new Productos(125, 3003, "Producto G", 6)
            }
                )
            // Puedes agregar más órdenes aquí
            };

            // Cargar todas las órdenes en el ListView
            foreach (var orden in ordenes)
            {
                CargarOrdenSeleccionEnListView(orden);
            }
        }



        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        // Método para cargar la orden y los productos en los ListView
        private void CargarOrdenSeleccionEnListView(OrdenSeleccion ordenSeleccion)
        {
            // Agregar información de la orden al primer ListView
            ListViewItem itemOrden = new ListViewItem(ordenSeleccion.Nro_OrdenS.ToString()); // Nro orden
            itemOrden.SubItems.Add(ordenSeleccion.Estado); // Estado
            itemOrden.SubItems.Add(ordenSeleccion.FechaEmision.ToShortDateString()); // Fecha Entrega
            itemOrden.SubItems.Add(ordenSeleccion.OP_Asociada.ToString()); // OP asociada

            LstOrdenesSeleccion.Items.Add(itemOrden); // Añadir el ítem de la orden al ListView

            // Agregar los productos al segundo ListView
            foreach (var producto in ordenSeleccion.Productos)
            {
                ListViewItem itemProducto = new ListViewItem(producto.Producto_Codigo.ToString()); // Id Producto
                itemProducto.SubItems.Add(producto.Producto_Nombre); // Producto
                itemProducto.SubItems.Add(producto.Cantidad.ToString()); // Cantidad

                LSTDetalleOrden.Items.Add(itemProducto); // Añadir el ítem del producto al ListView
            }
        }

        // Crear una instancia de OrdenSeleccion y llamar al método para cargar los ListView
       
    }








}

