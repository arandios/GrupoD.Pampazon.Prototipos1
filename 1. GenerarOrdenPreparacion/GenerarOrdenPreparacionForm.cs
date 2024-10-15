using Pampazon.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel model = new();

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
            ActualizarListaTransportista();

        }

        private void GenerarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            ActualizarListaTransportista();
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            foreach (ColumnHeader column in ProductosStockLista.Columns)
            {
                ProductosStockLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            foreach (ColumnHeader column in OrdenTempLista.Columns)
            {
                OrdenTempLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void OrdenTempLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change logic here
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            // Logic for generating the preparation order
        }

        private void LimpiarFiltros(object sender, EventArgs e)
        {
            NombreProductoInput.Clear();
            // Clear other filters if necessary
        }

        private void BuscarProductoBtn(object sender, EventArgs e)
        {
            // Implement product search logic
        }

        private void ActualizarListaTransportista()
        {
            // Implement transportista list update logic
        }

        private void CancelarOrderBtn(object sender, EventArgs e)
        {
            // Logic to cancel the order
        }

        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)
        {
            // Logic to generate preparation order
        }

        private void VolverBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void CodigoClienteInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
