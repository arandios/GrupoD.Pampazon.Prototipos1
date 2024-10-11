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
        }

        /// <summary>
        /// A partir del DNI del transportista se buscan las ordenes que hay a su nombre y se listan
        /// en la lista Detalle Transportista para poder selccionar una.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {
            BuscarTransportistaGBX.Enabled = false;
            OrdenesDelTransportistaGBX.Enabled ^= true;
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
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para agregar. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si hay un ítem seleccionado en TransportistasListV
            if (TransportistasListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ítem seleccionado
            ListViewItem selectedItem = TransportistasListV.SelectedItems[0];

            // Extraer los datos necesarios del ítem seleccionado
            string idOrden = selectedItem.SubItems[0].Text;
            DateTime fechaHoy = DateTime.Now.Date;
            string nombreTransportista = selectedItem.SubItems[2].Text;
            string apellidoTransportista = selectedItem.SubItems[3].Text;

            // Verificar si la orden ya fue agregada a DetalleRemitoLTV
            if (GenerarRemitoModelo.OrdenYaAgregada(idOrden, DetalleRemitoLTV))
            {
                MessageBox.Show("Esta orden ya ha sido agregada a Detalle Remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo ítem para DetalleRemitoLTV
            ListViewItem nuevoItem = new ListViewItem(idOrden);
            nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());
            nuevoItem.SubItems.Add($"{nombreTransportista} {apellidoTransportista}");
            TransportistasListV.Items.Remove(selectedItem);

            // Agregar el nuevo ítem a DetalleRemitoLTV
            DetalleRemitoLTV.Items.Add(nuevoItem);
            DetalleRemitoGBX.Enabled = true;
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

            // Obtener todas las órdenes de DetalleRemitoLTV
            var ordenesParaRemito = new List<OrdenesDePreparacion>();
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                string idOrden = item.SubItems[0].Text;
                OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                if (orden != null)
                {
                    ordenesParaRemito.Add(orden);
                }
            }

            // Obtener el DNI del transportista desde un control de entrada
            // Supongamos que tienes un TextBox para ingresar el DNI
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


                    TransportistasListV.Items.Clear();
                    DetalleRemitoLTV.Items.Clear();
                    DNITtxt.Clear();
                    BuscarTransportistaGBX.Enabled = true;
                    OrdenesDelTransportistaGBX.Enabled = false;
                    DetalleRemitoGBX.Enabled = false;
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

            if (DetalleRemitoLTV.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una orden para quitar.");
                return;
            }

            var ordenSeleccionada = DetalleRemitoLTV.SelectedItems[0];
            string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

            var result = MessageBox.Show($"¿Está seguro de que desea eliminar la orden: {numeroDeOrden}?",
                                         "Confirmar Eliminación",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            // Eliminar de DetalleRemitoLTV
            DetalleRemitoLTV.Items.Remove(ordenSeleccionada);

            // Devolver la orden a TransportistasListV
            var itemTransportista = GenerarRemitoModelo.DevolverOrdenALista(numeroDeOrden);
            if (itemTransportista != null)
            {
                TransportistasListV.Items.Add(itemTransportista);
            }

            MessageBox.Show("Orden devuelta a la lista de transportistas.", "Orden Devuelta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        /// <summary>
        /// BOTON DE SALIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelarBtn_Click(object sender, EventArgs e) //boton SALIR
        {
            // Confirmar la acción
            var result = MessageBox.Show("¿Está seguro que desea salir?",
                                          "Confirmar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
