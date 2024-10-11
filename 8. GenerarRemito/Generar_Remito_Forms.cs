using Pampazon.GenerarOrdenPreparacion;
using Pampazon.MenuPrincipal;
using Pampazon.Remitos;
using System.Text;



namespace Pampazon
{
    public partial class Generar_RemitoForms : Form
    {
        private GenerarRemitoModelo modelo = new();
        public Generar_RemitoForms()
        {
            InitializeComponent();
          
            OrdenesDelTransportistaGBX.Enabled = false;
            DetalleRemitoGBX.Enabled = false;
            DetalleRemitoLTV.ColumnWidthChanging += (sender, e) =>
            {
                e.NewWidth = DetalleRemitoLTV.Columns[e.ColumnIndex].Width; // Mantener el ancho actual
                e.Cancel = true; // Cancelar el cambio
            };

            TransportistasListV.ColumnWidthChanging += (sender, e) =>
            {
                e.NewWidth = DetalleRemitoLTV.Columns[e.ColumnIndex].Width; // Mantener el ancho actual
                e.Cancel = true; // Cancelar el cambio
            };
        }
        /// <summary>
        /// A partir del DNI del transportista se buscan las ordenes que hay a su nombre y se listan
        /// en la lista Detalle Transportista para poder selccionar una.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {

            TransportistasListV.Items.Clear();

            // Verificar si el campo de texto está vacío
            if (string.IsNullOrWhiteSpace(DNITtxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dniTexto = DNITtxt.Text;

            // Verificar si el valor ingresado es un número entero
            if (int.TryParse(dniTexto, out int dni))
            {
                // Llamar a ComprobarDni para obtener el mensaje de error (si lo hay)
                string error = GenerarRemitoModelo.ComprobarDni(dni);

                // Si hay un error, mostrarlo
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la lista de transportistas y filtrar los que coinciden con el DNI, lo hace el modelo
                var transportistasEncontrados = GenerarRemitoModelo.ObtenerTransportistas()
                    .Where(t => t.DNI == dni).ToList();

                // Verificar si se encontraron transportistas
                if (transportistasEncontrados.Any())
                {
                    // Agregar cada transportista encontrado a TransportistasListV
                    foreach (var transportista in transportistasEncontrados)
                    {
                        ListViewItem item = new ListViewItem(transportista.IdOrden);
                        item.SubItems.Add(transportista.DNI.ToString());
                        item.SubItems.Add(transportista.Nombre);
                        item.SubItems.Add(transportista.Apellido);

                        TransportistasListV.Items.Add(item);
                    }

                    BuscarTransportistaGBX.Enabled = false;
                    OrdenesDelTransportistaGBX.Enabled ^= true;
                }
                else
                {
                    MessageBox.Show("No se encontró un transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de DNI válido. Tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay ítems en TransportistasListV
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay transportistas para agregar. Agregue al menos uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si al menos un ítem tiene el checkbox marcado
            bool hayOrdenesSeleccionadas = false;

            // Crear una lista para almacenar los ítems que se agregarán
            List<ListViewItem> ordenesAAgregar = new List<ListViewItem>();

            // Iterar sobre los ítems de TransportistasListV
            foreach (ListViewItem item in TransportistasListV.Items)
            {
                // Verificar si el checkbox está marcado
                if (item.Checked)
                {
                    hayOrdenesSeleccionadas = true;

                    // Extraer los datos necesarios del ítem
                    string idOrden = item.SubItems[0].Text;
                    DateTime fechaHoy = DateTime.Now.Date;
                    string nombreTransportista = item.SubItems[2].Text;
                    string apellidoTransportista = item.SubItems[3].Text;



                    // Crear un nuevo ítem para DetalleRemitoLTV
                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());
                    nuevoItem.SubItems.Add($"{nombreTransportista} {apellidoTransportista}");

                    // Agregar el nuevo ítem a la lista de órdenes a agregar
                    ordenesAAgregar.Add(nuevoItem);
                }
            }

            // Verificar si no se seleccionó ninguna orden
            if (!hayOrdenesSeleccionadas)
            {
                MessageBox.Show("Por favor, seleccione al menos una orden usando los checkboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar todos los ítems seleccionados a DetalleRemitoLTV
            foreach (var orden in ordenesAAgregar)
            {
                DetalleRemitoLTV.Items.Add(orden);
            }

            // Eliminar los ítems que fueron agregados de TransportistasListV
            foreach (var orden in ordenesAAgregar)
            {
                // Encontrar el ítem correspondiente en TransportistasListV y eliminarlo
                ListViewItem itemToRemove = TransportistasListV.Items
                    .Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems[0].Text == orden.Text); // Usar el ID de la orden para encontrar el ítem
                if (itemToRemove != null)
                {
                    TransportistasListV.Items.Remove(itemToRemove);
                }
            }


            // Habilitar el grupo de detalles
            DetalleRemitoGBX.Enabled = true;

            // Mensaje de éxito
            MessageBox.Show("Órdenes agregadas exitosamente a Detalle Remito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //NO BORRAR
        {
            //NO BORRAR PORQUE SE ROMPE LA PANTALLA//

        }




        /// <summary>
        /// Boton para generar remito a partir de los datos del transportista y la orden
        /// detalladas en la lista "Detalle Remito"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un ítem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para generar un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lista para almacenar las órdenes a incluir en el remito
            var ordenesParaRemito = new List<OrdenesDePreparacion>();
            var ordenesEliminadas = new List<ListViewItem>(); // Para almacenar las órdenes que se eliminarán
            bool hayOrdenesSeleccionadas = false;

            // Iterar sobre los ítems de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                // Verificar si el checkbox está marcado
                if (item.Checked)
                {
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                        ordenesEliminadas.Add(item); // Agregar a la lista de órdenes a eliminar
                        hayOrdenesSeleccionadas = true; // Se ha encontrado al menos una orden seleccionada
                    }
                }
            }

            // Si no hay órdenes seleccionadas, agregar todas las órdenes
            if (!hayOrdenesSeleccionadas)
            {
                foreach (ListViewItem item in DetalleRemitoLTV.Items)
                {
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                        ordenesEliminadas.Add(item); // Agregar a la lista de órdenes a eliminar
                    }
                }
            }

            // Obtener el DNI del transportista desde un control de entrada
            int dniTransportista;
            if (!int.TryParse(DNITtxt.Text, out dniTransportista))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preguntar al usuario si está seguro de generar el remito
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea generar el remito?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Crear el remito a través del modelo
                    Remito nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);

                    // Mostrar la confirmación del remito
                    MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\nÓrdenes: {string.Join(", ", nuevoRemito.Ordenes.Select(o => o.IdOrden))}",
                                    "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Eliminar las órdenes seleccionadas de DetalleRemitoLTV
                    foreach (var ordenEliminada in ordenesEliminadas)
                    {
                        DetalleRemitoLTV.Items.Remove(ordenEliminada);
                    }

                    // Limpiar las listas y deshabilitar los GroupBox si no quedan órdenes en DetalleRemitoLTV
                    if (DetalleRemitoLTV.Items.Count == 0)
                    {
                        TransportistasListV.Items.Clear();
                        DNITtxt.Clear();
                        BuscarTransportistaGBX.Enabled = true;
                        OrdenesDelTransportistaGBX.Enabled = false;
                        DetalleRemitoGBX.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error si hay un problema con la validación
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Cancelar la acción o mostrar un mensaje opcional
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








        /// <summary>
        /// Quita la orden seleccionada de la lista Detalle Remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitarOrdenBtn_Click(object sender, EventArgs e)
        {
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para eliminar de un remito.");
                return;
            }

            // Verificar si hay al menos un ítem con checkbox marcado
            bool hayOrdenesSeleccionadas = false;

            // Lista para almacenar las órdenes a eliminar
            List<ListViewItem> ordenesAEliminar = new List<ListViewItem>();

            // Iterar sobre los ítems de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                // Verificar si el checkbox está marcado
                if (item.Checked)
                {
                    hayOrdenesSeleccionadas = true;
                    ordenesAEliminar.Add(item);
                }
            }

            // Si no se seleccionó ninguna orden, mostrar mensaje de advertencia
            if (!hayOrdenesSeleccionadas)
            {
                MessageBox.Show("Por favor seleccione al menos una orden usando los checkboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación para eliminar
            var result = MessageBox.Show($"¿Está seguro de que desea eliminar las órdenes seleccionadas?",
                                         "Confirmar Eliminación",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // Cancelar si el usuario no confirma
            }

            // Eliminar las órdenes seleccionadas de DetalleRemitoLTV
            foreach (var orden in ordenesAEliminar)
            {
                // Devolver la orden a TransportistasListV
                var itemTransportista = GenerarRemitoModelo.DevolverOrdenALista(orden.SubItems[0].Text);
                if (itemTransportista != null)
                {
                    TransportistasListV.Items.Add(itemTransportista);
                }
                DetalleRemitoLTV.Items.Remove(orden); // Eliminar de DetalleRemitoLTV
            }

            MessageBox.Show("Órdenes devueltas a la lista de transportistas.", "Órdenes Devueltas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            // Confirmación para eliminar
            var result = MessageBox.Show($"¿Está seguro de que desea salir?",
                                         "Confirmar Eliminación",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // Cancelar si el usuario no confirma
            }
            this.Close();
        }
    }
}
