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
        private List<OrdenSeleccion> OrdenesSeleccionConfirmadas = new List<OrdenSeleccion>();
        private List<OrdenSeleccion> ordenes = new List<OrdenSeleccion>();
        private ConfirmarOrdenSeleccionModelo modelo; // Instancia del modelo

        public ConfirmarOrdenSeleccion()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenSeleccion_Load(object sender, EventArgs e)
        {
            modelo = new ConfirmarOrdenSeleccionModelo(); // Inicializar el modelo

            // Cargar todas las órdenes en el ListView desde el modelo
            foreach (var orden in modelo.Ordenes)
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

