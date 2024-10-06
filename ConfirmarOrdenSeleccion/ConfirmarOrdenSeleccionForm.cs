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
        private ConfirmarOrdenSeleccionModelo modelo;

        public ConfirmarOrdenSeleccion()
        {
            InitializeComponent();
            // Agregar las opciones al ComboBox
            CMBEstado.Items.Add("Pendiente");
            CMBEstado.Items.Add("Confirmada");
            modelo = new ConfirmarOrdenSeleccionModelo(); // Inicializar el modelo
        }

        private void ConfirmarOrdenSeleccion_Load(object sender, EventArgs e)
        {
            // Mostrar las órdenes pendientes inicialmente
            MostrarOrdenesPendientesEnListView();
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para cargar la orden y los productos en los ListView
        private void CargarOrdenSeleccionEnListView(OrdenSeleccion ordenSeleccion)
        {
            // Cargar en el ListView de órdenes
            ListViewItem itemOrden = new ListViewItem(ordenSeleccion.Nro_OrdenS.ToString()); // Nro orden
            itemOrden.SubItems.Add(ordenSeleccion.Estado); // Estado
            itemOrden.SubItems.Add(ordenSeleccion.FechaEmision.ToShortDateString()); // Fecha Emisión
            itemOrden.SubItems.Add(ordenSeleccion.OP_Asociada.ToString()); // OP Asociada

            LstOrdenesSeleccion.Items.Add(itemOrden); // Añadir la orden al ListView

            // Agregar los productos relacionados a esta orden en el ListView de productos
            CargarProductosEnListView(ordenSeleccion.Productos);
        }

        // Método para cargar los productos en el ListView de productos
        private void CargarProductosEnListView(List<Productos> productos)
        {
            LSTDetalleOrden.Items.Clear(); // Limpiar el ListView de productos antes de agregar nuevos

            foreach (var producto in productos)
            {
                ListViewItem itemProducto = new ListViewItem(producto.Producto_Codigo.ToString()); // Código de Producto
                itemProducto.SubItems.Add(producto.Producto_Nombre); // Nombre del Producto
                itemProducto.SubItems.Add(producto.Cantidad.ToString()); // Cantidad

                LSTDetalleOrden.Items.Add(itemProducto); // Añadir el producto al ListView
            }
        }

        // Método para mostrar las órdenes pendientes en el ListView
        private void MostrarOrdenesPendientesEnListView()
        {
            LstOrdenesSeleccion.Items.Clear(); // Limpiar el ListView de órdenes
            foreach (var orden in modelo.OrdenesPendientes)
            {
                CargarOrdenSeleccionEnListView(orden);
            }
        }

        // Método para mostrar las órdenes confirmadas en el ListView
        private void MostrarOrdenesConfirmadasEnListView()
        {
            LstOrdenesSeleccion.Items.Clear(); // Limpiar el ListView de órdenes
            foreach (var orden in modelo.OrdenesConfirmadas)
            {
                CargarOrdenSeleccionEnListView(orden);
            }
        }

        private void GenerarOrdenEntregaBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesSeleccion.SelectedItems.Count > 0)
            {
                // Obtener el índice de la orden seleccionada
                int selectedIndex = LstOrdenesSeleccion.SelectedIndices[0];

                // Obtener la orden seleccionada
                OrdenSeleccion ordenSeleccionada = modelo.OrdenesPendientes[selectedIndex];

                // Confirmar la orden
                modelo.ConfirmarOrden(ordenSeleccionada);

                // Notificar al usuario
                MessageBox.Show("La orden ha sido confirmada.");

                // Actualizar el ListView según la categoría seleccionada
                ActualizarListViewSegunCategoria();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para confirmar.");
            }
        }

        private void CMBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListViewSegunCategoria();
        }

        private void ActualizarListViewSegunCategoria()
        {
            if (CMBEstado.SelectedItem != null)
            {
                if (CMBEstado.SelectedItem.ToString() == "Confirmada")
                {
                    // Mostrar órdenes confirmadas
                    MostrarOrdenesConfirmadasEnListView();
                }
                else if (CMBEstado.SelectedItem.ToString() == "Pendiente")
                {
                    // Mostrar órdenes pendientes
                    MostrarOrdenesPendientesEnListView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría.");
            }
        }
    }








}

