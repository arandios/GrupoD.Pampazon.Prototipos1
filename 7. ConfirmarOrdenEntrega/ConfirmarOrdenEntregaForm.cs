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
        ConfirmarOrdenEntregaModelo modelo = new();

        public ConfirmarOrdenEntregaForm()
        {
            InitializeComponent();  
        }
        
        private void CargarOrdenEntregaEnListView(OrdenEntrega ordenEntrega)
        {
            // Cargar en el ListView de ordenes
            ListViewItem itemOrden = new ListViewItem(ordenEntrega.Nro_OrdenE.ToString()); // Nro Orden
            itemOrden.SubItems.Add(ordenEntrega.OrdenesPreparacionAsociadas.Count.ToString()); // cantidad

            // Agregar los productos de la orden en el ListView de productos
            LstOrdenesEntrega.Items.Add(itemOrden);

            // Seleccionar automáticamente el primer item y cargar sus detalles si es el único
            if (LstOrdenesEntrega.Items.Count == 1)
            {
                LstOrdenesEntrega.Items[0].Selected = true; // Selecciona el primer ítem
                LstOrdenesEntrega.Items[0].Focused = true;  // Establece el foco en el primer ítem
                LstOrdenesEntrega_SelectedIndexChanged(this, EventArgs.Empty); // Llama al método para cargar detalles
            }
        }

        private void CargarOrdenesPreparacionEnListView(List<OrdenPreparacion> ordenesPreparacion)
        {
            LSTDetalle.Items.Clear(); // Limpiar el ListView de detalles

            // Agregar las ordenes de preparacion al ListView de detalles
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
                    /*if (!modelo.ValidarOrdenNoConfirmada(ordenSeleccionada, out string mensajeError))
                    {
                        MessageBox.Show(mensajeError);
                        return;
                    }*/


                    LSTDetalle.Clear();
                    modelo.ConfirmarOrden(ordenSeleccionada);
                    MessageBox.Show("Orden confirmada exitosamente.");
                    // Limpiar la caja de texto de búsqueda
                    IdOrdentxt.Clear();

                    // Restaurar siempre las órdenes pendientes
                    MostrarOrdenesPendientesEnListView();
                   

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
            // Obtener el número de orden ingresado en el TextBox
            string numeroOrdenStr = IdOrdentxt.Text.Trim();

            // Asegúrate de que sea un número válido
            if (!int.TryParse(numeroOrdenStr, out int numeroOrden))
            {
                MessageBox.Show("Por favor, ingrese un número de orden válido.");
                return;
            }

            // Buscar la orden en las listas de órdenes pendientes o confirmadas
            var ordenEncontrada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == numeroOrden)
                                 ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == numeroOrden);

            if (ordenEncontrada != null)
            {
                // Limpiar el ListView antes de mostrar los resultados
                LstOrdenesEntrega.Items.Clear();
                // Crear un nuevo ListViewItem para mostrar la orden encontrada
                ListViewItem itemOrden = new ListViewItem(ordenEncontrada.Nro_OrdenE.ToString()); // Nro Orden
                itemOrden.SubItems.Add(ordenEncontrada.Estado); // Estado
                itemOrden.SubItems.Add(ordenEncontrada.OrdenesPreparacionAsociadas.Count.ToString()); // Cantidad

                // Agregar el item al ListView
                LstOrdenesEntrega.Items.Add(itemOrden);

                // Seleccionar el ítem y cargar detalles
                LstOrdenesEntrega.Items[0].Selected = true; // Selecciona el primer ítem
                LstOrdenesEntrega.Items[0].Focused = true;  // Establece el foco en el primer ítem
                LstOrdenesEntrega_SelectedIndexChanged(this, EventArgs.Empty); // Cargar detalles
            }
            else
            {
                MessageBox.Show("No se encontró ninguna orden con ese número.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Limpiar el TextBox después de buscar
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
           
        }

        private void ConfirmarOrdenEntregaForm_Load_1(object sender, EventArgs e)
        {
            // Mostrar las órdenes pendientes inicialmente en el ListView
            MostrarOrdenesPendientesEnListView();

            // Asegurarse de que el ListView de detalles (LSTDetalle) esté vacío al cargar el formulario
            LSTDetalle.Items.Clear();
        }

        private void LstOrdenesEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstOrdenesEntrega.SelectedItems.Count > 0)
            {
                int nroOrdenSeleccionada = int.Parse(LstOrdenesEntrega.SelectedItems[0].Text);
                OrdenEntrega ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenE == nroOrdenSeleccionada)
                                                  ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenE == nroOrdenSeleccionada);

                if (ordenSeleccionada != null)
                {
                    // Cargar los detalles de las órdenes de preparación en LSTDetalle
                    CargarOrdenesPreparacionEnListView(ordenSeleccionada.OrdenesPreparacionAsociadas);
                   
                }
            }
            else
            {
                // Opcional: limpiar LSTDetalle si no hay selección
                LSTDetalle.Items.Clear();
            }
        }
    }
}
