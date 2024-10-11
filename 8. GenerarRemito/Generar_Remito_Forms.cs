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

            // Verificar si el campo de texto est� vac�o
            if (string.IsNullOrWhiteSpace(DNITtxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un n�mero de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dniTexto = DNITtxt.Text;

            // Verificar si el valor ingresado es un n�mero entero
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
                    MessageBox.Show("No se encontr� un transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero de DNI v�lido. Tiene que ser num�rico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay �tems en TransportistasListV
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay transportistas para agregar. Agregue al menos uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si al menos un �tem tiene el checkbox marcado
            bool hayOrdenesSeleccionadas = false;

            // Crear una lista para almacenar los �tems que se agregar�n
            List<ListViewItem> ordenesAAgregar = new List<ListViewItem>();

            // Iterar sobre los �tems de TransportistasListV
            foreach (ListViewItem item in TransportistasListV.Items)
            {
                // Verificar si el checkbox est� marcado
                if (item.Checked)
                {
                    hayOrdenesSeleccionadas = true;

                    // Extraer los datos necesarios del �tem
                    string idOrden = item.SubItems[0].Text;
                    DateTime fechaHoy = DateTime.Now.Date;
                    string nombreTransportista = item.SubItems[2].Text;
                    string apellidoTransportista = item.SubItems[3].Text;



                    // Crear un nuevo �tem para DetalleRemitoLTV
                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());
                    nuevoItem.SubItems.Add($"{nombreTransportista} {apellidoTransportista}");

                    // Agregar el nuevo �tem a la lista de �rdenes a agregar
                    ordenesAAgregar.Add(nuevoItem);
                }
            }

            // Verificar si no se seleccion� ninguna orden
            if (!hayOrdenesSeleccionadas)
            {
                MessageBox.Show("Por favor, seleccione al menos una orden usando los checkboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar todos los �tems seleccionados a DetalleRemitoLTV
            foreach (var orden in ordenesAAgregar)
            {
                DetalleRemitoLTV.Items.Add(orden);
            }

            // Eliminar los �tems que fueron agregados de TransportistasListV
            foreach (var orden in ordenesAAgregar)
            {
                // Encontrar el �tem correspondiente en TransportistasListV y eliminarlo
                ListViewItem itemToRemove = TransportistasListV.Items
                    .Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems[0].Text == orden.Text); // Usar el ID de la orden para encontrar el �tem
                if (itemToRemove != null)
                {
                    TransportistasListV.Items.Remove(itemToRemove);
                }
            }


            // Habilitar el grupo de detalles
            DetalleRemitoGBX.Enabled = true;

            // Mensaje de �xito
            MessageBox.Show("�rdenes agregadas exitosamente a Detalle Remito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Verificar si hay al menos un �tem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay �rdenes para generar un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lista para almacenar las �rdenes a incluir en el remito
            var ordenesParaRemito = new List<OrdenesDePreparacion>();
            var ordenesEliminadas = new List<ListViewItem>(); // Para almacenar las �rdenes que se eliminar�n
            bool hayOrdenesSeleccionadas = false;

            // Iterar sobre los �tems de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                // Verificar si el checkbox est� marcado
                if (item.Checked)
                {
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                        ordenesEliminadas.Add(item); // Agregar a la lista de �rdenes a eliminar
                        hayOrdenesSeleccionadas = true; // Se ha encontrado al menos una orden seleccionada
                    }
                }
            }

            // Si no hay �rdenes seleccionadas, agregar todas las �rdenes
            if (!hayOrdenesSeleccionadas)
            {
                foreach (ListViewItem item in DetalleRemitoLTV.Items)
                {
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                        ordenesEliminadas.Add(item); // Agregar a la lista de �rdenes a eliminar
                    }
                }
            }

            // Obtener el DNI del transportista desde un control de entrada
            int dniTransportista;
            if (!int.TryParse(DNITtxt.Text, out dniTransportista))
            {
                MessageBox.Show("Por favor, ingrese un DNI v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preguntar al usuario si est� seguro de generar el remito
            DialogResult resultado = MessageBox.Show(
                "�Est� seguro de que desea generar el remito?",
                "Confirmaci�n",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Crear el remito a trav�s del modelo
                    Remito nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);

                    // Mostrar la confirmaci�n del remito
                    MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\n�rdenes: {string.Join(", ", nuevoRemito.Ordenes.Select(o => o.IdOrden))}",
                                    "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Eliminar las �rdenes seleccionadas de DetalleRemitoLTV
                    foreach (var ordenEliminada in ordenesEliminadas)
                    {
                        DetalleRemitoLTV.Items.Remove(ordenEliminada);
                    }

                    // Limpiar las listas y deshabilitar los GroupBox si no quedan �rdenes en DetalleRemitoLTV
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
                    // Mostrar mensaje de error si hay un problema con la validaci�n
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Cancelar la acci�n o mostrar un mensaje opcional
                MessageBox.Show("Operaci�n cancelada.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No hay �rdenes para eliminar de un remito.");
                return;
            }

            // Verificar si hay al menos un �tem con checkbox marcado
            bool hayOrdenesSeleccionadas = false;

            // Lista para almacenar las �rdenes a eliminar
            List<ListViewItem> ordenesAEliminar = new List<ListViewItem>();

            // Iterar sobre los �tems de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                // Verificar si el checkbox est� marcado
                if (item.Checked)
                {
                    hayOrdenesSeleccionadas = true;
                    ordenesAEliminar.Add(item);
                }
            }

            // Si no se seleccion� ninguna orden, mostrar mensaje de advertencia
            if (!hayOrdenesSeleccionadas)
            {
                MessageBox.Show("Por favor seleccione al menos una orden usando los checkboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmaci�n para eliminar
            var result = MessageBox.Show($"�Est� seguro de que desea eliminar las �rdenes seleccionadas?",
                                         "Confirmar Eliminaci�n",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // Cancelar si el usuario no confirma
            }

            // Eliminar las �rdenes seleccionadas de DetalleRemitoLTV
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

            MessageBox.Show("�rdenes devueltas a la lista de transportistas.", "�rdenes Devueltas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            // Confirmaci�n para eliminar
            var result = MessageBox.Show($"�Est� seguro de que desea salir?",
                                         "Confirmar Eliminaci�n",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // Cancelar si el usuario no confirma
            }
            this.Close();
        }
    }
}
