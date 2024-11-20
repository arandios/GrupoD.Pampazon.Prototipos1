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
            GenerarRemitoForm_Load(this, new EventArgs());
        }

        private void GenerarRemitoForm_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
            RegistrarEventos();
            CargarDatosIniciales();
        }

        private void InicializarFormulario()
        {
            BuscarTransportistaGRP.Focus();
            TransportistasCBX.Focus();
            Gruposinicializados();
        }

        private void RegistrarEventos()
        {
            TransportistasCBX.KeyDown += new KeyEventHandler(TransportistasCBX_KeyDown);
            TransportistasListV.KeyDown += new KeyEventHandler(TransportistasListV_KeyDown);
            DetalleRemitoLTV.KeyDown += new KeyEventHandler(DetalleRemitoLTV_KeyDown);
            IdCLienteCBX.SelectedIndexChanged += new EventHandler(IdCLienteCBX_SelectedIndexChanged);
            RZCBX.SelectedIndexChanged += new EventHandler(RZCBX_SelectedIndexChanged);
            IdCLienteCBX.KeyDown += new KeyEventHandler(IdCLienteCBX_KeyDown);
            RZCBX.KeyDown += new KeyEventHandler(RZCBX_KeyDown);
        }

        private void CargarDatosIniciales()
        {
            CargarTransportistasEnComboBox();
            ConfigurarComboBox();
        }

        private void Gruposinicializados()
        {
            BuscarTransportistaGRP.Enabled = true;
            OrdenesDelTransportistaGRP.Enabled = false;
            DetalleRemitoGRP.Enabled = false;
            FiltrarOrdenesPorClienteGBX.Enabled = false;
        }

        private void TransportistasCBX_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarTransportistaBtn_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (TransportistasListV.Items.Count > 0)
                {
                    TransportistasListV.Focus();
                    TransportistasListV.Items[0].Selected = true;
                    TransportistasListV.Items[0].Focused = true;
                }
            }
        }

        private void TransportistasListV_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TransportistasListV.SelectedItems.Count > 0)
            {
                TransportistasListV_MouseClick(this, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (TransportistasListV.Items.Count > 0)
                {
                    TransportistasListV.Focus();
                    TransportistasListV.Items[0].Selected = true;
                    TransportistasListV.Items[0].Focused = true;
                }
                else
                {
                   GenerarRemitoBTN.Focus();
                }
            }
        }

        private void DetalleRemitoLTV_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && DetalleRemitoLTV.SelectedItems.Count > 0)
            {
                DetalleRemitoLTV_MouseClick(this, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void IdCLienteCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdCLienteCBX.SelectedIndex != -1)
            {
                RZCBX.Enabled = false;
            }
        }

        private void RZCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RZCBX.SelectedIndex != -1)
            {
                IdCLienteCBX.Enabled = false;
            }
        }
        private void IdCLienteCBX_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && IdCLienteCBX.SelectedIndex != -1)
            {
                FiltrarOrdenes(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void RZCBX_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && RZCBX.SelectedIndex != -1)
            {
                FiltrarOrdenes(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FiltrarOrdenes(object? sender, EventArgs e)
        {
            string? idClienteSeleccionado = IdCLienteCBX.SelectedItem?.ToString();
            string? razonSocialSeleccionada = RZCBX.SelectedItem?.ToString();

            var ordenesListas = GenerarRemitoModelo.ObtenerOrdenes();
            var ordenesFiltradas = ordenesListas.Where(o =>
                (string.IsNullOrEmpty(idClienteSeleccionado) || o.IdCliente.ToString() == idClienteSeleccionado) &&
                (string.IsNullOrEmpty(razonSocialSeleccionada) || GenerarRemitoModelo.obtenerClientes().FirstOrDefault(c => c.IdCliente == o.IdCliente)?.RazonSocial == razonSocialSeleccionada)
            ).ToList();

            TransportistasListV.Items.Clear();
            foreach (var orden in ordenesFiltradas)
            {
                var cliente = GenerarRemitoModelo.obtenerClientes().FirstOrDefault(c => c.IdCliente == orden.IdCliente);
                string razonSocial = cliente != null ? cliente.RazonSocial : "Desconocido";
                string idCliente = cliente != null ? cliente.IdCliente.ToString() : "Desconocido";

                // Verificar si la orden ya está en DetalleRemitoLTV
                bool ordenYaEnDetalle = DetalleRemitoLTV.Items.Cast<ListViewItem>()
                    .Any(item => item.SubItems[0].Text == orden.IdOrden);

                if (!ordenYaEnDetalle)
                {
                    TransportistasListV.Items.Add(new ListViewItem(new[] { orden.IdOrden, idCliente, razonSocial }));
                    TransportistasListV.Focus();
                    TransportistasListV.Items[0].Selected = true;
                    TransportistasListV.Items[0].Focused = true;
                }
            }
        }
        


            private void CargarTransportistasEnComboBox()
        {
            var transportistas = GenerarRemitoModelo.obtenerTransportistas();

            TransportistasCBX.DataSource = transportistas;
            TransportistasCBX.DisplayMember = "DNI"; // Mostrar solo el DNI
            TransportistasCBX.ValueMember = "DNI";
            TransportistasCBX.SelectedIndex = -1;
        }

        private void ConfigurarComboBox()
        {
            TransportistasCBX.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TransportistasCBX.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TransportistasCBX.Text))
            {
                MostrarMensajeError("Por favor, ingrese un DNI.");
                return;
            }

            if (int.TryParse(TransportistasCBX.Text, out int dni))
            {
                if (!ValidarDniTransportista(dni)) return;

                var ordenesDelTransportista = ObtenerOrdenesDelTransportista(dni);
                if (ordenesDelTransportista == null || ordenesDelTransportista.Count == 0)
                {
                    MostrarMensajeInformacion("El transportista no tiene órdenes pendientes.");
                    LimpiarFormulario();
                    return;
                }

                CargarDatosTransportista(dni, ordenesDelTransportista);
                FiltrarOrdenesPorClienteGBX.Enabled = true;
            }
            else
            {
                MostrarMensajeError("Ingrese un DNI válido. Debe ser numérico");
            }
        }
        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarMensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidarDniTransportista(int dni)
        {
            string mensajeValidacion = GenerarRemitoModelo.ComprobarDni(dni);
            if (!string.IsNullOrEmpty(mensajeValidacion))
            {
                MostrarMensajeError(mensajeValidacion);
                return false;
            }

            if (!GenerarRemitoModelo.ExisteTransportistaPorDni(dni))
            {
                MostrarMensajeError("El transportista no existe.");
                return false;
            }

            return true;
        }
        private List<OrdenesDePreparacionRemito> ObtenerOrdenesDelTransportista(int dni)
        {
            var ordenesListas = GenerarRemitoModelo.ObtenerOrdenes();
            return GenerarRemitoModelo.ObtenerOrdenesDePreparacionPorDni(ordenesListas, dni);
        }
        private void CargarDatosTransportista(int dni, List<OrdenesDePreparacionRemito> ordenesDelTransportista)
        {
            string nombreTransportista = GenerarRemitoModelo.ObtenerNombreTransportistaPorDni(dni);
            NomApellTransportistaTXT.Text = nombreTransportista;

            TransportistasListV.Items.Clear();
            foreach (var orden in ordenesDelTransportista)
            {
                var cliente = GenerarRemitoModelo.obtenerClientes().FirstOrDefault(c => c.IdCliente == orden.IdCliente);
                string razonSocial = cliente != null ? cliente.RazonSocial : "Desconocido";
                string idCliente = cliente != null ? cliente.IdCliente.ToString() : "Desconocido";
                TransportistasListV.Items.Add(new ListViewItem(new[] { orden.IdOrden, idCliente, razonSocial }));
            }

            GenerarRemitoModelo.CargarClientesEnComboBox(IdCLienteCBX, RZCBX, ordenesDelTransportista);

            OrdenesDelTransportistaGRP.Enabled = true;
            TransportistasCBX.Enabled = false;
            BuscarTransportistaBtn.Enabled = false;
        }
        private void LimpiarFormulario()
        {
            TransportistasCBX.SelectedIndex = -1;
            TransportistasListV.Items.Clear();
        }




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
                    string idCliente = selectedItem.SubItems[1].Text;
                    string razonSocial = selectedItem.SubItems[2].Text;
                    DateTime fechaHoy = DateTime.Now.Date;

                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(idCliente);
                    nuevoItem.SubItems.Add(razonSocial);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());

                    DetalleRemitoLTV.Items.Add(nuevoItem);
                    itemsAEliminar.Add(selectedItem);
                }
            }

            foreach (var item in itemsAEliminar)
            {
                TransportistasListV.Items.Remove(item);
            }

            DetalleRemitoGRP.Enabled = true;
        }

        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            if (!ConfirmarGeneracionRemito()) return;

            int dniTransportista = int.Parse(TransportistasCBX.Text);
            var ordenesParaRemito = ObtenerOrdenesParaRemito();

            try
            {
                RemitoEnt nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);
                MostrarMensajeRemitoGenerado(nuevoRemito);
                EliminarItemsSeleccionados();
                LimpiarFormularioSiNoHayItems();
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex.Message);
            }
        }

        private bool ConfirmarGeneracionRemito()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea generar el remito?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private List<OrdenesDePreparacionRemito> ObtenerOrdenesParaRemito()
        {
            bool hayItemsSeleccionados = DetalleRemitoLTV.Items.Cast<ListViewItem>().Any(item => item.Checked);

            return DetalleRemitoLTV.Items.Cast<ListViewItem>()
                .Where(item => !hayItemsSeleccionados || item.Checked)
                .Select(item =>
                {
                    string idOrden = item.SubItems[0].Text;
                    return modelo.ObtenerOrdenPorId(idOrden);
                })
                .Where(orden => orden != null)
                .Cast<OrdenesDePreparacionRemito>()
                .ToList();
        }

        private void MostrarMensajeRemitoGenerado(RemitoEnt nuevoRemito)
        {
            MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\nÓrdenes: {string.Join(", ", nuevoRemito.OrdenesPreparacion)}",
                            "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EliminarItemsSeleccionados()
        {
            bool hayItemsSeleccionados = DetalleRemitoLTV.Items.Cast<ListViewItem>().Any(item => item.Checked);
            var itemsAEliminar = new List<ListViewItem>();

            if (hayItemsSeleccionados)
            {
                itemsAEliminar.AddRange(DetalleRemitoLTV.Items.Cast<ListViewItem>().Where(item => item.Checked));
            }
            else
            {
                itemsAEliminar.AddRange(DetalleRemitoLTV.Items.Cast<ListViewItem>());
            }

            foreach (ListViewItem item in itemsAEliminar)
            {
                DetalleRemitoLTV.Items.Remove(item);
            }
        }

        private void LimpiarFormularioSiNoHayItems()
        {
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                BorrarBtn_Click(this, new EventArgs());
            }
        }

        



        private void QuitarOrdenBtn_Click(object sender, EventArgs e)
        {
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

            foreach (var ordenSeleccionada in itemsAEliminar)
            {
                string idOrden = ordenSeleccionada.SubItems[0].Text;
                string idCliente = ordenSeleccionada.SubItems[1].Text;
                string razonSocial = ordenSeleccionada.SubItems[2].Text;
                DateTime fechaHoy = DateTime.Now.Date;

                ListViewItem nuevoItem = new ListViewItem(idOrden);
                nuevoItem.SubItems.Add(idCliente);
                nuevoItem.SubItems.Add(razonSocial);
                nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());

                TransportistasListV.Items.Add(nuevoItem);
                DetalleRemitoLTV.Items.Remove(ordenSeleccionada);
            }

            if (DetalleRemitoLTV.Items.Count == 0)
            {
                DetalleRemitoGRP.Enabled = false;
            }

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

        private void TransportistasListV_MouseClick(object sender, MouseEventArgs e)
        {
            if (TransportistasListV.SelectedItems.Count > 0)
            {
                var selectedItem = TransportistasListV.SelectedItems[0];
                string idOrden = selectedItem.SubItems[0].Text;
                string idCliente = selectedItem.SubItems[1].Text;
                string razonSocial = selectedItem.SubItems[2].Text;
                DateTime fechaHoy = DateTime.Now.Date;

                ListViewItem nuevoItem = new ListViewItem(idOrden);
                nuevoItem.SubItems.Add(idCliente);
                nuevoItem.SubItems.Add(razonSocial);
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
                string idCliente = selectedItem.SubItems[1].Text;
                string razonSocial = selectedItem.SubItems[2].Text;

                ListViewItem nuevoItem = new ListViewItem(idOrden);
                nuevoItem.SubItems.Add(idCliente);
                nuevoItem.SubItems.Add(razonSocial);

                TransportistasListV.Items.Add(nuevoItem);
                DetalleRemitoLTV.Items.Remove(selectedItem);

                if (DetalleRemitoLTV.Items.Count == 0)
                {
                    DetalleRemitoGRP.Enabled = false;
                }
            }
        }
        private void BorrarFiltrosBTN_Click(object sender, EventArgs e)
        {
            // Limpiar la selección de los ComboBox
            IdCLienteCBX.SelectedIndex = -1;
            RZCBX.SelectedIndex = -1;
            IdCLienteCBX.Enabled = true;
            RZCBX.Enabled = true;

            // Obtener el DNI del transportista actual
            if (int.TryParse(TransportistasCBX.Text, out int dni))
            {
                var ordenesListas = GenerarRemitoModelo.ObtenerOrdenes();
                var ordenesDelTransportista = GenerarRemitoModelo.ObtenerOrdenesDePreparacionPorDni(ordenesListas, dni);

                TransportistasListV.Items.Clear();

                foreach (var orden in ordenesDelTransportista)
                {
                    var cliente = GenerarRemitoModelo.obtenerClientes().FirstOrDefault(c => c.IdCliente == orden.IdCliente);
                    string razonSocial = cliente != null ? cliente.RazonSocial : "Desconocido";
                    string idCliente = cliente != null ? cliente.IdCliente.ToString() : "Desconocido";

                    // Verificar si la orden ya está en DetalleRemitoLTV
                    bool ordenYaEnDetalle = DetalleRemitoLTV.Items.Cast<ListViewItem>()
                        .Any(item => item.SubItems[0].Text == orden.IdOrden);

                    if (!ordenYaEnDetalle)
                    {
                        TransportistasListV.Items.Add(new ListViewItem(new[] { orden.IdOrden, idCliente, razonSocial }));
                    }
                }
            }

        }
        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            TransportistasListV.Items.Clear();
            DetalleRemitoLTV.Items.Clear();
            IdCLienteCBX.Items.Clear();
            RZCBX.Items.Clear();
            NomApellTransportistaTXT.Text = string.Empty;
            BuscarTransportistaGRP.Enabled = true;
            BuscarTransportistaBtn.Enabled = true;
            TransportistasCBX.Enabled = true;
            OrdenesDelTransportistaGRP.Enabled = false;
            DetalleRemitoGRP.Enabled = false;
            FiltrarOrdenesPorClienteGBX.Enabled = false;
            TransportistasCBX.SelectedIndex = -1;
        }
    }
}

