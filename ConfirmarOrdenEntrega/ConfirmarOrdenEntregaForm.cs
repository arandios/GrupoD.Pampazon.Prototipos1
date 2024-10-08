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
        
        private void CargarOrdenEntregaEnListView(OrdenEntrega ordenEntrega)
        {
            // Cargar en el ListView de ordenes
            ListViewItem itemOrden = new ListViewItem(ordenEntrega.Nro_OrdenE.ToString());// Nro Orden
            itemOrden.SubItems.Add(ordenEntrega.Estado);// estado
            itemOrden.SubItems.Add(ordenEntrega.OrdenesPreparacionAsociadas.Count.ToString());// cantidad
            // Agregar los productos de la orden en el ListView de productos
            LstOrdenesEntrega.Items.Add(itemOrden);
        }

        private void CargarOrdenesPreparacionEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            LSTDetalle.Items.Clear(); // Limpiar el ListView de detalles
            foreach (var ordenPreparacion in ordenesPreparacion)
            {
                ListViewItem itemDetalle = new ListViewItem(ordenPreparacion.Nro_OrdenP.ToString()); // Solo mostrar el Nro_OrdenP
                LSTDetalle.Items.Add(itemDetalle); // Agregar el Nro_OrdenP al ListView de detalles
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
            // Verificar si el ComboBox tiene un valor seleccionado
            if (CMBEstado.SelectedItem != null)
            {
                string estadoSeleccionado = CMBEstado.SelectedItem.ToString();

                if (estadoSeleccionado == "Confirmada")
                {
                    MostrarOrdenesConfirmadasEnListView();
                }
                else
                {
                    MostrarOrdenesPendientesEnListView();
                }
            }
            else
            {
                // Si no hay nada seleccionadose muestra todas las ordenes pendientes
                MostrarOrdenesPendientesEnListView(); 
            }

            // Limpiar el ListView de detalles siempre
            LSTDetalle.Items.Clear();
            IdOrdentxt.Focus();
        }


        private void DetallesOrdenBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesEntrega.SelectedItems.Count > 0)
            {
                int nroOrdenSeleccionada = int.Parse(LstOrdenesEntrega.SelectedItems[0].Text);
                OrdenEntrega ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == nroOrdenSeleccionada)
                                                  ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == nroOrdenSeleccionada);

                if (ordenSeleccionada != null)
                {
                    CargarOrdenesPreparacionEnListView(ordenSeleccionada.OrdenesPreparacionAsociadas);
                    ultimaOrdenCargada = ordenSeleccionada; // Actualizar la última orden cargada
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
                    // Validar que la orden no haya sido confirmada previamente
                    if (!modelo.ValidarOrdenNoConfirmada(ordenSeleccionada, out string mensajeError))
                    {
                        MessageBox.Show(mensajeError);
                        return;
                    }

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
            // Limpiar la caja de texto de búsqueda
            IdOrdentxt.Clear();

            // Restaurar siempre las órdenes pendientes
            MostrarOrdenesPendientesEnListView();
            // Limpiar el ListView de productos
            LSTDetalle.Items.Clear();

            // Colocar el cursor en la caja de texto
            IdOrdentxt.Focus();
        }

        private void CMBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListViewSegunCategoria();
        }

        private void ConfirmarOrdenEntregaForm_Load_1(object sender, EventArgs e)
        {
            // Mostrar las órdenes pendientes inicialmente en el ListView
            MostrarOrdenesPendientesEnListView();

            // Asegurarse de que el ListView de detalles (LSTDetalle) esté vacío al cargar el formulario
            LSTDetalle.Items.Clear();
        }
    }
}
