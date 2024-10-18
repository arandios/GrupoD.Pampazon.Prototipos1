using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.BuscarProductosEnDepositos
{
    public partial class AgregarProductosEnDepositosFormulario : Form
    {
        private BuscarProductosEnDepositosModelo modelo;

        public AgregarProductosEnDepositosFormulario()
        {
            InitializeComponent();
            modelo = new BuscarProductosEnDepositosModelo();
        }
        private void CargarOrdenesDeSeleccionEnComboBox()
        {            
            CMBOrdenSeleccion.Items.Clear();
            var ordenes = modelo.ObtenerOrdenesDeSeleccion();
            foreach (var orden in ordenes)
            {
                CMBOrdenSeleccion.Items.Add(orden.IDOrdenSeleccion);
            }

            // Seleccionar la primera orden de selección si hay alguna
            if (CMBOrdenSeleccion.Items.Count > 0)
            {
                CMBOrdenSeleccion.SelectedIndex = 0; // Selecciona automáticamente la primera
            }
        }



        private void CargarProductosEnListView(int idOrdenSeleccion)
        {
            LSTProductos.Items.Clear();
            var productos = modelo.ObtenerProductosPorOrdenDeSeleccion(idOrdenSeleccion);

            foreach (var producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Ubicacion);
                item.SubItems.Add(producto.SKU);
                item.SubItems.Add(producto.Cantidad.ToString());
                LSTProductos.Items.Add(item);
            }
        }

        private void AgregarProductosEnDepositosFormulario_Load_1(object sender, EventArgs e)
        {
            // Cargar las órdenes de selección en el ComboBox
            CargarOrdenesDeSeleccionEnComboBox();

            // Establecer el estilo del ComboBox para que solo permita selección
            CMBOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;

            // Seleccionar la primera orden de selección si hay alguna
            if (CMBOrdenSeleccion.Items.Count > 0)
            {
                CMBOrdenSeleccion.SelectedIndex = 0; // Selecciona automáticamente la primera orden de selección
            }
        }
        // Evento que se dispara al seleccionar una OrdenDeSeleccion en el ComboBox

        private void CMBOrdenSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBOrdenSeleccion.SelectedItem != null)
            {
                int idOrdenSeleccion = (int)CMBOrdenSeleccion.SelectedItem;
                CargarProductosEnListView(idOrdenSeleccion);
            }
        }



        private void CancelarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNConfirmarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            if (CMBOrdenSeleccion.SelectedItem != null)
            {
                // Mostrar MessageBox para confirmar la acción
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas confirmar esta orden?",
                                                      "Confirmar Orden",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idOrdenSeleccion = (int)CMBOrdenSeleccion.SelectedItem;
                    modelo.ConfirmarOrdenSeleccion(idOrdenSeleccion);

                    // Recargar las órdenes de selección en el ComboBox
                    CargarOrdenesDeSeleccionEnComboBox();

                    // Limpiar el ListView después de confirmar la orden
                    LSTProductos.Items.Clear();

                    // Seleccionar la siguiente orden automáticamente
                    if (CMBOrdenSeleccion.Items.Count > 0)
                    {
                        CMBOrdenSeleccion.SelectedIndex = 0; // Selecciona la primera orden disponible

                        // Cargar los productos de la nueva orden seleccionada en el ListView
                        int nuevaOrdenSeleccionID = (int)CMBOrdenSeleccion.SelectedItem;
                        CargarProductosEnListView(nuevaOrdenSeleccionID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una orden de selección antes de confirmar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
