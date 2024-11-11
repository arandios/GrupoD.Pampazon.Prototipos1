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
        }

        private void CodigoClienteTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CodigoClienteTxt.Text))
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
            if (!string.IsNullOrWhiteSpace(RazonSocialTxt.Text))
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
            if (!string.IsNullOrWhiteSpace(CuitTXT.Text))
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
        private void ListarOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void BuscarOrdenes_Click(object sender, EventArgs e)
        {
            List<OrdenDePreparacionConsultas> ordenesEncontradas = new List<OrdenDePreparacionConsultas>();

            var todasLasOrdenes = modelo.ObtenerTodasLasOrdenes();

            if (!string.IsNullOrEmpty(CodigoClienteTxt.Text))
            {
                if (int.TryParse(CodigoClienteTxt.Text, out int codigoCliente))
                {
                    ordenesEncontradas = todasLasOrdenes.Where(o => o.IdCliente == codigoCliente).ToList();
                }
            }
            else if (!string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                ordenesEncontradas = modelo.ObtenerOrdenesPorRazonSocial(RazonSocialTxt.Text);
            }
            else if (!string.IsNullOrEmpty(CuitTXT.Text))
            {
                ordenesEncontradas = modelo.ObtenerOrdenesPorCuit(CuitTXT.Text);
            }
            else if (!string.IsNullOrEmpty(EstadoCMB.Text) ||
                     !string.IsNullOrEmpty(PrioridadCMB.Text) ||
                     (FechaInicioDTP.Value.Date != DateTime.Today || FechaFinDTP.Value.Date != DateTime.Today))
            {
                ordenesEncontradas = todasLasOrdenes.ToList();
            }

            string estadoSeleccionado = EstadoCMB.Text;
            string prioridadSeleccionada = PrioridadCMB.Text;
            DateTime fechaInicio = FechaInicioDTP.Value.Date;
            DateTime fechaFin = FechaFinDTP.Value.Date;

            if (ordenesEncontradas.Any())
            {
                modelo.FiltrarPorEstadoPrioridadYFechas(ref ordenesEncontradas, estadoSeleccionado, prioridadSeleccionada, fechaInicio, fechaFin);
            }

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
    }
}
