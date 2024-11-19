using Pampazon._7._ConsultarOrdenesPreparacion;
using Pampazon.Almacenes;
using Pampazon.ConsultarOrdenes;
using Pampazon.Entidades;
using Pampazon.GenerarOrdenPreparacion;
using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ListarOrdenes
{
    public partial class ConsultarOrdenesForm : Form
    {
        ConsultarOrdenesPreparacionModelo modelo = new();

        public ConsultarOrdenesForm()
        {
            InitializeComponent();
            OrdenesLTV.FullRowSelect = true;
            // Asignar el evento KeyDown a los campos de texto
            CodigoClienteTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            RazonSocialTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            CuitTXT.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            EstadoCMB.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            FechaInicioDTP.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            FechaFinDTP.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            PrioridadCMB.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);

            // Asignar el evento Leave a los campos de texto
            CodigoClienteTxt.Leave += new EventHandler(CamposTexto_Leave);
            RazonSocialTxt.Leave += new EventHandler(CamposTexto_Leave);
            CuitTXT.Leave += new EventHandler(CamposTexto_Leave);
        }
        private void CamposTexto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter
                BuscarOrdenes_Click(sender, e);
                // Poner el foco en el primer ítem de la lista OrdenesLTV
                if (OrdenesLTV.Items.Count > 0)
                {
                    OrdenesLTV.Items[0].Selected = true;
                    OrdenesLTV.Items[0].Focused = true;
                    OrdenesLTV.EnsureVisible(0);
                    OrdenesLTV.Focus();
                }
            }
        }

        private void CamposTexto_Leave(object? sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                AutocompletarCampos(textBox.Text);
            }
        }

        private void CodigoClienteTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodigoClienteTxt.Text))
            {
                RazonSocialTxt.Enabled = false;
                CuitTXT.Enabled = false;
            }
            else
            {
                RazonSocialTxt.Enabled = true;
                CuitTXT.Enabled = true;
            }
        }

        private void RazonSocialTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                CodigoClienteTxt.Enabled = false;
                CuitTXT.Enabled = false;
            }
            else
            {
                CodigoClienteTxt.Enabled = true;
                CuitTXT.Enabled = true;
            }
        }

        private void CuitTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CuitTXT.Text))
            {
                CodigoClienteTxt.Enabled = false;
                RazonSocialTxt.Enabled = false;
            }
            else
            {
                CodigoClienteTxt.Enabled = true;
                RazonSocialTxt.Enabled = true;
            }
        }
        private void AutocompletarCampos(string input)
        {
            var (codigoCliente, razonSocial, cuit) = modelo.AutocompletarCamposCliente(input);

            if (!string.IsNullOrEmpty(codigoCliente))
            {
                CodigoClienteTxt.Text = codigoCliente;
            }

            if (!string.IsNullOrEmpty(razonSocial))
            {
                RazonSocialTxt.Text = razonSocial;
            }

            if (!string.IsNullOrEmpty(cuit))
            {
                CuitTXT.Text = cuit;
            }
        }
        private void ListarOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void BuscarOrdenes_Click(object? sender, EventArgs e)
        {
            string codigoCliente = CodigoClienteTxt.Text;
            string razonSocial = RazonSocialTxt.Text;
            string cuit = CuitTXT.Text;
            string estadoSeleccionado = EstadoCMB.Text;
            string prioridadSeleccionada = PrioridadCMB.Text;
            DateTime fechaInicio = FechaInicioDTP.Value.Date;
            DateTime fechaFin = FechaFinDTP.Value.Date;

            List<OrdenDePreparacionConsultas> ordenesEncontradas = modelo.BuscarOrdenes(codigoCliente, razonSocial, cuit, estadoSeleccionado, prioridadSeleccionada, fechaInicio, fechaFin);

            if (!ordenesEncontradas.Any())
            {
                MessageBox.Show("No se encontraron órdenes con los filtros aplicados.");
                OrdenesLTV.Items.Clear();
                ProductoLTV.Items.Clear();
            }
            else
            {
                CargarOrdenesEnListView(ordenesEncontradas);
            }
        }
        private void CargarOrdenesEnListView(List<OrdenDePreparacionConsultas> ordenes)
        {
            OrdenesLTV.Items.Clear();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrdenPreparacion.ToString());
                item.SubItems.Add(orden.FechaEmision.ToShortDateString());
                item.SubItems.Add(orden.Estado.ToString());
                item.SubItems.Add(orden.Prioridad.ToString());

                OrdenesLTV.Items.Add(item);
            }

            if (OrdenesLTV.Items.Count > 0)
            {
                OrdenesLTV.Items[0].Selected = true;
                OrdenesLTV.Items[0].Focused = true;
                OrdenesLTV.EnsureVisible(0);
            }
        }
        private void BorrarFiltrosBtn_Click(object sender, EventArgs e)
        {
            CodigoClienteTxt.Clear();
            RazonSocialTxt.Clear();
            CuitTXT.Clear();
            EstadoCMB.SelectedIndex = -1;
            PrioridadCMB.SelectedIndex = -1;
            FechaInicioDTP.Value = DateTime.Today;
            FechaFinDTP.Value = DateTime.Today;
            OrdenesLTV.Items.Clear();
            ProductoLTV.Items.Clear();
        }
        private void SalirBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea salir?",
                                         "Confirmar",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
        private void OrdenesLTV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (OrdenesLTV.SelectedItems.Count > 0)
            {
                var itemSeleccionado = OrdenesLTV.SelectedItems[0];
                int idOrdenSeleccionada = int.Parse(itemSeleccionado.SubItems[0].Text);

                var productos = modelo.ObtenerProductosPorOrdenId(idOrdenSeleccionada);

                ProductoLTV.Items.Clear();

                foreach (var producto in productos)
                {
                    var item = new ListViewItem(producto.SKU);
                    item.SubItems.Add(producto.NombreProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    ProductoLTV.Items.Add(item);
                }
            }
        }
        private void OrdenesGRP_Enter(object sender, EventArgs e)
        {

        }

        private void CodigoCLienteLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
