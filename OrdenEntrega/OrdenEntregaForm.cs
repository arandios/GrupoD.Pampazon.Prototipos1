using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.OrdenEntrega
{
    public partial class OrdenEntregaForm : Form
    {
        private List<ListViewItem> Items;
        public class OrdenEntregaData
        {
            public int NroOrden { get; set; }
            public string FechaEntrega { get; set; }
            public int IdTransportista { get; set; }
            public string NombreTransportista { get; set; }
            public string Estado { get; set; }
        }
        public OrdenEntregaForm()
        {
            InitializeComponent();
            ConfigurarListView();
            AgregarDatos();
            Items = new List<ListViewItem>();
            foreach (ListViewItem item in Ordenes_Preparacion.Items)
            {
                Items.Add((ListViewItem)item.Clone());
            }
        }
        private void ConfigurarListView()
        {
            Ordenes_Preparacion.View = View.Details;
            Ordenes_Preparacion.FullRowSelect = true;

            Ordenes_Preparacion.Columns.Add("Nro Orden", -2, HorizontalAlignment.Left);
            Ordenes_Preparacion.Columns.Add("Fecha de Entrega", -2, HorizontalAlignment.Left);
            Ordenes_Preparacion.Columns.Add("Estado", -2, HorizontalAlignment.Left);

            Orden_Entrega.View = View.Details;
            Orden_Entrega.FullRowSelect = true;

            Orden_Entrega.Columns.Add("Nro Orden", -2, HorizontalAlignment.Left);
            Orden_Entrega.Columns.Add("Fecha de Entrega", -2, HorizontalAlignment.Left);
            Orden_Entrega.Columns.Add("Estado", -2, HorizontalAlignment.Left);
        }

        private void AgregarDatos()
        {
            List<OrdenEntregaData> datos = new List<OrdenEntregaData>();

            for (int i = 1; i <= 5; i++)
            {
                datos.Add(new OrdenEntregaData
                {
                    NroOrden = i * 2,
                    FechaEntrega = "2024-10-0" + i,
                    Estado = "Empaquetado"

                });
            }
            foreach (var dato in datos)
            {
                ListViewItem item = new ListViewItem(dato.NroOrden.ToString());
                item.SubItems.Add(dato.FechaEntrega);
                item.SubItems.Add(dato.Estado);
                Ordenes_Preparacion.Items.Add(item);
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

        private void AgregarDatos2()
        {

            List<OrdenEntregaData> datos = new List<OrdenEntregaData>();

            for (int i = 1; i <= 5; i++)
            {
                datos.Add(new OrdenEntregaData
                {
                    NroOrden = i * 2,
                    FechaEntrega = "2024-10-0" + i,
                    Estado = "Empaquetado"

                });
            }
            foreach (var dato in datos)
            {
                ListViewItem item = new ListViewItem(dato.NroOrden.ToString());
                item.SubItems.Add(dato.FechaEntrega);
                item.SubItems.Add(dato.Estado);
                Orden_Entrega.Items.Add(item);
            }
        }


        private void OrdenEntregaForm_Load(object sender, EventArgs e)
        {

        }

        private void txtIdOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            bool isIdOrdenEmpty = string.IsNullOrWhiteSpace(txtIdOrden.Text);
            bool isFechaEntregaEmpty = string.IsNullOrWhiteSpace(FechaEntregacmb.Text);

            if (isIdOrdenEmpty && isFechaEntregaEmpty)
            {
                MessageBox.Show("Debe ingresar un ID de Orden o seleccionar una Fecha de Entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RestaurarElementos();
                return;
            }

            if (!isIdOrdenEmpty && int.TryParse(txtIdOrden.Text, out int idOrden))
            {
                FiltrarElementosID(idOrden);
            }
            else if (!isFechaEntregaEmpty)
            {
                FiltrarElementosPorFecha(FechaEntregacmb.Text);
            }
            else
            {
                MessageBox.Show("El campo de ID de Orden debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RestaurarElementos();
            }
        }

        private void FiltrarElementosID(int idOrden)
        {
            Ordenes_Preparacion.Items.Clear();
            foreach (var item in Items)
            {
                if (item.Text == idOrden.ToString())
                {
                    Ordenes_Preparacion.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void FiltrarElementosPorFecha(string fechaEntrega)
        {
            Ordenes_Preparacion.Items.Clear();
            foreach (var item in Items)
            {
                if (item.SubItems[1].Text == fechaEntrega)
                {
                    Ordenes_Preparacion.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
        private void RestaurarElementos()
        {
            Ordenes_Preparacion.Items.Clear();
            foreach (var item in Items)
            {
                Ordenes_Preparacion.Items.Add((ListViewItem)item.Clone());
            }
        }



        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (Ordenes_Preparacion.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Ordenes_Preparacion.SelectedItems[0];
                ListViewItem itemToMove = (ListViewItem)selectedItem.Clone();
                Orden_Entrega.Items.Add(itemToMove);
                Ordenes_Preparacion.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden para mover.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seleccionar_Click_1(object sender, EventArgs e)
        {
            if (Ordenes_Preparacion.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Ordenes_Preparacion.SelectedItems[0];
                ListViewItem itemToMove = (ListViewItem)selectedItem.Clone();
                Orden_Entrega.Items.Add(itemToMove);
                Ordenes_Preparacion.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden para mover.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarOrdenEntregabtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "¿Está seguro de que desea generar la orden de entrega?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (Orden_Entrega.Items.Count == 0)
            {
                MessageBox.Show("No se puede generar la orden de entrega porque la lista está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result == DialogResult.Yes)
            {
                GenerarOrdenDeEntrega();
            }
            else
            {
                MessageBox.Show("La generación de la orden de entrega ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GenerarOrdenDeEntrega()
        {
            MessageBox.Show("La orden de entrega ha sido generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Orden_Entrega.Items.Clear();
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            txtIdOrden.Text = string.Empty;
            FechaEntregacmb.Text = string.Empty;
            RestaurarElementos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            if (Orden_Entrega.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Orden_Entrega.SelectedItems[0];
                ListViewItem itemToMove = (ListViewItem)selectedItem.Clone();
                Ordenes_Preparacion.Items.Add(itemToMove);
                Orden_Entrega.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden para devolver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaEntregacmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
