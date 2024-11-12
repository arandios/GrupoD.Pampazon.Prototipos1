using Pampazon.Entidades;
using Pampazon.Remitos;
using System.Data;
using System.Net;
using System.Text;

namespace Pampazon._6._GenerarRemito
{
    public partial class GenerarRemitoForm : Form
    {
        private GenerarRemitoModelo modelo = new();
        public GenerarRemitoForm()
        {
            InitializeComponent();
            OrdenesDelTransportistaGRP.Enabled = false;
            DetalleRemitoGRP.Enabled = false;
        }

        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DNITXT.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(DNITXT.Text, out int dni))
            {
                string mensajeValidacion = GenerarRemitoModelo.ComprobarDni(dni);
                if (!string.IsNullOrEmpty(mensajeValidacion))
                {
                    MessageBox.Show(mensajeValidacion, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!GenerarRemitoModelo.ExisteTransportistaPorDni(dni))
                {
                    MessageBox.Show("El transportista no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ordenesListas = GenerarRemitoModelo.ObtenerOrdenes();
                var ordenesDelTransportista = GenerarRemitoModelo.ObtenerOrdenesDePreparacionPorDni(ordenesListas, dni);

                if (ordenesDelTransportista == null || ordenesDelTransportista.Count == 0)
                {
                    MessageBox.Show("El transportista no tiene órdenes pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string nombreTransportista = GenerarRemitoModelo.ObtenerNombreTransportistaPorDni(dni);
                NomApellTransportistaTXT.Text = nombreTransportista;

                TransportistasListV.Items.Clear();
                foreach (var orden in ordenesDelTransportista)
                {
                    TransportistasListV.Items.Add(new ListViewItem(new[] { orden.IdOrden }));
                }

                BuscarTransportistaGRP.Enabled = false;
                OrdenesDelTransportistaGRP.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para agregar. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hayOrdenSeleccionada = false; 

            foreach (ListViewItem selectedItem in TransportistasListV.Items)
            {
                if (selectedItem.Checked)
                {
                    hayOrdenSeleccionada = true;
                    break;
                }
            }

            
            if (!hayOrdenSeleccionada)
            {
                MessageBox.Show("Por favor seleccione al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var itemsAEliminar = new List<ListViewItem>();

            
            foreach (ListViewItem selectedItem in TransportistasListV.Items)
            {
                if (selectedItem.Checked) 
                {
                    
                    string idOrden = selectedItem.SubItems[0].Text;
                    DateTime fechaHoy = DateTime.Now.Date;

                    
                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());

                    
                    DetalleRemitoLTV.Items.Add(nuevoItem);

                    
                    itemsAEliminar.Add(selectedItem);
                }
            }

            
            foreach (ListViewItem item in itemsAEliminar)
            {
                TransportistasListV.Items.Remove(item);
            }

            
            DetalleRemitoGRP.Enabled = true;
        }

        /// <summary>
        /// Boton para generar remito a partir de los datos del transportista y la orden
        /// detalladas en la lista "Detalle Remito"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para generar un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea generar el remito?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int dniTransportista = int.Parse(DNITXT.Text);

            bool hayItemsSeleccionados = DetalleRemitoLTV.Items.Cast<ListViewItem>().Any(item => item.Checked);

            var ordenesParaRemito = DetalleRemitoLTV.Items.Cast<ListViewItem>()
                .Where(item => !hayItemsSeleccionados || item.Checked)
                .Select(item =>
                {
                    string idOrden = item.SubItems[0].Text;
                    return modelo.ObtenerOrdenPorId(idOrden);
                })
                .Where(orden => orden != null)
                .Cast<OrdenesDePreparacionRemito>()
                .ToList();

            try
            {
                RemitoEnt nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);

                MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\nÓrdenes: {string.Join(", ", nuevoRemito.OrdenesPreparacion)}",
                                "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var itemsAEliminar = new List<ListViewItem>();
                if (hayItemsSeleccionados)
                {
                    foreach (ListViewItem item in DetalleRemitoLTV.Items)
                    {
                        if (item.Checked)
                        {
                            itemsAEliminar.Add(item);
                        }
                    }
                }
                else
                {
                    itemsAEliminar.AddRange(DetalleRemitoLTV.Items.Cast<ListViewItem>());
                }

                foreach (ListViewItem item in itemsAEliminar)
                {
                    DetalleRemitoLTV.Items.Remove(item);
                }

                if (DetalleRemitoLTV.Items.Count == 0)
                {
                    TransportistasListV.Items.Clear();
                    DNITXT.Clear();
                    BuscarTransportistaGRP.Enabled = true;
                    OrdenesDelTransportistaGRP.Enabled = false;
                    DetalleRemitoGRP.Enabled = false;
                    NomApellTransportistaTXT.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// Quita la orden seleccionada de la lista Detalle Remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un ítem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para eliminar de un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var itemsAEliminar = new List<ListViewItem>();
            
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                if (item.Checked)
                {
                    itemsAEliminar.Add(item);
                }
            }
            
            if (itemsAEliminar.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una orden para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensaje = new StringBuilder("¿Está seguro de que desea eliminar las siguientes órdenes?\n");
            
            foreach (var item in itemsAEliminar)
            {
                mensaje.AppendLine(item.Text); 
            }

            var result = MessageBox.Show(mensaje.ToString(),
                                          "Confirmar Eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            
            foreach (var ordenSeleccionada in itemsAEliminar)
            {
                
                string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

                
                ListViewItem nuevoItem = new ListViewItem(numeroDeOrden);
                nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[1].Text); 
                nuevoItem.Checked = false;

                
                TransportistasListV.Items.Add(nuevoItem);

                
                DetalleRemitoLTV.Items.Remove(ordenSeleccionada);
            }

            if (DetalleRemitoLTV.Items.Count == 0)
            {
                DetalleRemitoGRP.Enabled = false; 
            }

            MessageBox.Show("Órdenes eliminadas con éxito y devueltas a la lista de transportistas.", "Órdenes Eliminadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// BOTON DE SALIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void TransportistasListV_MouseClick(object sender, MouseEventArgs e)
        {
            if (TransportistasListV.SelectedItems.Count > 0)
            {
                var selectedItem = TransportistasListV.SelectedItems[0];
                string idOrden = selectedItem.SubItems[0].Text;
                DateTime fechaHoy = DateTime.Now.Date;

                ListViewItem nuevoItem = new ListViewItem(idOrden);
                nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());

                DetalleRemitoLTV.Items.Add(nuevoItem);
                TransportistasListV.Items.Remove(selectedItem);

                DetalleRemitoGRP.Enabled = true;
            }
        }

        private void DetalleRemitoLTV_MouseClick(object sender, MouseEventArgs e)
        {
            if (DetalleRemitoLTV.SelectedItems.Count > 0)
            {
                var selectedItem = DetalleRemitoLTV.SelectedItems[0];
                string idOrden = selectedItem.SubItems[0].Text;

                ListViewItem nuevoItem = new ListViewItem(idOrden);
                nuevoItem.SubItems.Add(selectedItem.SubItems[1].Text);

                TransportistasListV.Items.Add(nuevoItem);
                DetalleRemitoLTV.Items.Remove(selectedItem);

                if (DetalleRemitoLTV.Items.Count == 0)
                {
                    DetalleRemitoGRP.Enabled = false;
                }
            }
        }

        private void DetalleRemitoGRP_Enter(object sender, EventArgs e)
        {

        }

        private void NomApellTransportistaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

