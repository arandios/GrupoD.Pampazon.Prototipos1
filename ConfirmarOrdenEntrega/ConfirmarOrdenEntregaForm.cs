using Pampazon.ConfirmarOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ConfirmarOrdenEntrega
{
    public partial class ConfirmarOrdenEntregaForm : Form
    {
        private OrdenEntrega ultimaOrdenCargada;
        private ConfirmarOrdenEntregaModelo modelo;

        public ConfirmarOrdenEntregaForm()
        {
            InitializeComponent();
            CMBEstado.Items.Add("Pendiente");
            CMBEstado.Items.Add("Confirmada");
            modelo = new ConfirmarOrdenEntregaModelo();
        }
        private void ConfirmarOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            MostrarOrdenesPendientesEnListView();
            LSTDetalle.Items.Clear();
        }
        private void CargarOrdenEntregaEnListView(OrdenEntrega ordenEntrega)
        {
            ListViewItem itemOrden = new ListViewItem(ordenEntrega.Nro_OrdenE.ToString());
            itemOrden.SubItems.Add(ordenEntrega.Estado);
            itemOrden.SubItems.Add(ordenEntrega.OrdenesPreparacionAsociadas.Count.ToString());
            LstOrdenesEntrega.Items.Add(itemOrden);
        }

        private void CargarOrdenesPreparacionEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            LSTDetalle.Items.Clear();
            foreach (var ordenPreparacion in ordenesPreparacion)
            {
                ListViewItem itemDetalle = new ListViewItem(ordenPreparacion.Nro_OrdenP.ToString());
                LSTDetalle.Items.Add(itemDetalle);
            }
        }

        private void MostrarOrdenesPendientesEnListView()
        {
            LstOrdenesEntrega.Items.Clear();
            foreach (var orden in modelo.OrdenesPendientes)
            {
                CargarOrdenEntregaEnListView(orden);
            }
        }

        private void MostrarOrdenesConfirmadasEnListView()
        {
            LstOrdenesEntrega.Items.Clear();
            foreach (var orden in modelo.OrdenesConfirmadas)
            {
                CargarOrdenEntregaEnListView(orden);
            }
        }
        private void ActualizarListViewSegunCategoria()
        {
            if (CMBEstado.SelectedItem.ToString() == "Confirmada")
            {
                MostrarOrdenesConfirmadasEnListView();
            }
            else
            {
                MostrarOrdenesPendientesEnListView();
            }
            LSTDetalle.Items.Clear();
            IdOrdentxt.Focus();
        }


        private void DetallesOrdenBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesEntrega.SelectedItems.Count > 0)
            {
                int selectedIndex = LstOrdenesEntrega.SelectedIndices[0];
                OrdenEntrega ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == int.Parse(LstOrdenesEntrega.SelectedItems[0].Text))
                                                  ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == int.Parse(LstOrdenesEntrega.SelectedItems[0].Text));

                if (ordenSeleccionada != null)
                {
                    CargarOrdenesPreparacionEnListView(ordenSeleccionada.OrdenesPreparacionAsociadas);
                    ultimaOrdenCargada = ordenSeleccionada;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para ver los detalles.");
            }
            IdOrdentxt.Focus();
        }

        private void ConfirmarOrdenEntregaBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesEntrega.SelectedItems.Count > 0)
            {
                int selectedIndex = LstOrdenesEntrega.SelectedIndices[0];
                OrdenEntrega ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == int.Parse(LstOrdenesEntrega.SelectedItems[0].Text))
                                                  ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == int.Parse(LstOrdenesEntrega.SelectedItems[0].Text));

                if (ordenSeleccionada != null)
                {
                    if (ultimaOrdenCargada == null || ultimaOrdenCargada.Nro_OrdenE != ordenSeleccionada.Nro_OrdenE)
                    {
                        MessageBox.Show("Debe visualizar los detalles de la orden seleccionada antes de confirmar.");
                        return;
                    }

                    modelo.ConfirmarOrden(ordenSeleccionada);
                    MessageBox.Show("Orden confirmada exitosamente.");
                    ActualizarListViewSegunCategoria();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para confirmar.");
            }
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IdOrdentxt.Text, out int idOrden))
            {
                if (modelo.ValidarOrden(idOrden, out OrdenEntrega orden, out string mensajeError))
                {
                    MessageBox.Show($"Orden N° {idOrden} encontrada en estado {orden.Estado}");
                }
                else
                {
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de orden válido.");
            }
            IdOrdentxt.Clear();
            IdOrdentxt.Focus();
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {

        }

        private void CMBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListViewSegunCategoria();
        }
    }
}
