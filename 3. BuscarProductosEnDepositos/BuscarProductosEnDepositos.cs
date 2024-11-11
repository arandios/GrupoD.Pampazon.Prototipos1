using Pampazon._3._BuscarProductosEnDepositos;
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
        private List<Producto> productosInfo;

        public AgregarProductosEnDepositosFormulario()
        {
            InitializeComponent();
            modelo = new BuscarProductosEnDepositosModelo();
            productosInfo = new List<Producto>(); // Inicializar la lista para evitar el error CS8618
        }

        // ==============================================================================

        private void AgregarProductosEnDepositosFormulario_Load_1(object sender, EventArgs e)
        {
            // Cargar las órdenes de selección en el ComboBox
            CargarOrdenesDeSeleccionEnComboBox();

            // Establecer el estilo del ComboBox para que solo permita selección
            OrdenSeleccionCMB.DropDownStyle = ComboBoxStyle.DropDownList;

            // Seleccionar la primera orden de selección si hay alguna
            if (OrdenSeleccionCMB.Items.Count > 0)
            {
                OrdenSeleccionCMB.SelectedIndex = 0; // Selecciona automáticamente la primera orden de selección
            }
        }

        private void CargarOrdenesDeSeleccionEnComboBox()
        {
            // Obtener la lista de órdenes de selección pendientes y cargarla en el ComboBox
            modelo.CargarOrdenesSeleccionEnComboBox(OrdenSeleccionCMB);
        }

        // Evento que se dispara al seleccionar una OrdenDeSeleccion en el ComboBox
        private void CMBOrdenSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenSeleccionCMB.SelectedItem != null)
            {
                int idOrdenSeleccion = (int)OrdenSeleccionCMB.SelectedItem;
                CargarProductosEnListView(idOrdenSeleccion);
            }
        }

        private void BTNConfirmarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            if (OrdenSeleccionCMB.SelectedItem != null)
            {
                // Mostrar MessageBox para confirmar la acción
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas confirmar esta orden?",
                                                      "Confirmar Orden",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idOrdenSeleccion = (int)OrdenSeleccionCMB.SelectedItem;
                    modelo.ConfirmarOrdenSeleccion(idOrdenSeleccion);

                    // Recargar las órdenes de selección en el ComboBox
                    CargarOrdenesDeSeleccionEnComboBox();

                    // Limpiar el ListView después de confirmar la orden
                    ProductosLST.Items.Clear();

                    // Seleccionar la siguiente orden automáticamente
                    if (OrdenSeleccionCMB.Items.Count > 0)
                    {
                        OrdenSeleccionCMB.SelectedIndex = 0; // Selecciona la primera orden disponible

                        // Cargar los productos de la nueva orden seleccionada en el ListView
                        int nuevaOrdenSeleccionID = (int)OrdenSeleccionCMB.SelectedItem;
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

        private void CancelarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==============================================================================

        private void CargarProductosEnListView(int idOrdenSeleccion)
        {
            var productosEnt = modelo.ObtenerProductosPorOrdenDeSeleccion(idOrdenSeleccion);
            productosInfo = productosEnt.Select(pe => new Producto(
                pe.SKUProducto,
                pe.IdCliente.ToString(),
                pe.NombreProducto,
                pe.Detalle?.Select(d => new UbicacionProdutoDetalle_ParaBuscarProductosEnDepo
                {
                    IdUbicacion = d.IdUbicacion,
                    Stock = d.Stock
                }).ToList() ?? new List<UbicacionProdutoDetalle_ParaBuscarProductosEnDepo>() // Lista vacía si es null
            )).ToList();

            ProductosLST.Items.Clear();

            foreach (var producto in productosInfo)
            {
                foreach (var detalle in producto.Detalle)
                {
                    ListViewItem item = new ListViewItem(detalle.IdUbicacion ?? "Ubicación desconocida");
                    item.SubItems.Add(producto.SKUProducto);
                    item.SubItems.Add(detalle.Stock.ToString());
                    ProductosLST.Items.Add(item);
                }
            }


 


        }

    }
}
