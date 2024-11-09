using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pampazon.OrdenEntrega
{
    public partial class GenerarOrdenEntregaForm : Form
    {
        private List<ListViewItem> Items;
        public class OrdenEntregaData
        {
            public int NroOrden { get; set; }
            public string FechaEntrega { get; set; }
        }

        public GenerarOrdenEntregaForm()
        {
            InitializeComponent();
            Items = new List<ListViewItem>();


            ConfigurarListView();

            GenerarEjemplos();
        }

        private void ConfigurarListView()
        {
            Orden_EntregaLST.View = View.Details;
            Orden_EntregaLST.Columns.Add("Id orden de preparación", 250);
            Orden_EntregaLST.Columns.Add("Fecha retiro Orden de Preparación", 250);
        }


        private void GenerarEjemplos()
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem("0000" + i);
                item.SubItems.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy"));
                Orden_EntregaLST.Items.Add(item);
            }
        }

        private void Buscar_ID(object sender, EventArgs e)
        {

        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ordenes_Preparacion_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdenEntregaForm_Load(object sender, EventArgs e)
        {

        }

        private void txtIdOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerarOrdenEntregabtn_Click(object sender, EventArgs e)
        {

            if (Orden_EntregaLST.Items.Count < 7)
            {
                MessageBox.Show("Error: Debe haber al menos 7 ítems en la lista para generar una orden de entrega.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro de que desea generar la orden de entrega?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Orden de entrega generada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Orden_EntregaLST.Items.Clear();
                for (int i = 10; i <= 14; i++)
                {
                    ListViewItem item = new ListViewItem("000" + i);
                    item.SubItems.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy"));
                    Orden_EntregaLST.Items.Add(item);
                }
            }
        }

        private void Orden_Entrega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdenDespachoCMB_Enter(object sender, EventArgs e)
        {

        }
    }
}