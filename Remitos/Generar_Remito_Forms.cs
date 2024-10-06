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
                // Verificar si el DNI es v�lido
                if (GenerarRemitoModelo.ComprobarDni(dni))
                {
                    // Obtener la lista de transportistas y filtrar los que coinciden con el DNI, lo hace el modelo
                    var transportistasEncontrados = GenerarRemitoModelo.ObtenerTransportistas()
                        .Where(t => t.DNI == dni).ToList();

                    // Verificar si se encontraron transportistas
                    if (transportistasEncontrados.Any())
                    {
                        // Agregar cada transportista encontrado a TransportistasListV
                        foreach (var transportista in transportistasEncontrados)
                        {
                            ListViewItem item = new ListViewItem(transportista.Nombre); 
                            item.SubItems.Add(transportista.DNI.ToString()); 
                            item.SubItems.Add(transportista.Apellido); 
                            item.SubItems.Add(transportista.IdOrden); 

                            TransportistasListV.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontr� un transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es v�lido. Debe tener al menos 8 d�gitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero de DNI v�lido. Tiene que ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay un �tem seleccionado en TransportistasListV
            if (TransportistasListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un transportista de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el �tem seleccionado
            ListViewItem selectedItem = TransportistasListV.SelectedItems[0];

            // Extraer los datos necesarios del �tem seleccionado
            string idOrden = selectedItem.SubItems[3].Text;
            DateTime fechaHoy = DateTime.Now.Date;
            string nombreTransportista = selectedItem.SubItems[0].Text;
            string apellidoTransportista = selectedItem.SubItems[2].Text;

            // Verificar si la orden ya fue agregada a DetalleRemitoLTV
            if (GenerarRemitoModelo.OrdenYaAgregada(idOrden, DetalleRemitoLTV))
            {
                MessageBox.Show("Esta orden ya ha sido agregada a Detalle Remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo �tem para DetalleRemitoLTV
            ListViewItem nuevoItem = new ListViewItem(idOrden);
            nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());
            nuevoItem.SubItems.Add($"{nombreTransportista} {apellidoTransportista}");

            // Agregar el nuevo �tem a DetalleRemitoLTV
            DetalleRemitoLTV.Items.Add(nuevoItem);
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

            // Verificar si hay un �tem seleccionado en DetalleRemitoLTV
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para generar el remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el �tem seleccionado de DetalleRemitoLTV
            var selectedItem = DetalleRemitoLTV.SelectedItems[0];

            // Obtener el IdOrden de la orden seleccionada
            string idOrden = selectedItem.SubItems[0].Text;

            // Verificar si hay un �tem seleccionado en TransportistasListV
            if (TransportistasListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener DNI del transportista (desde el ListView de Transportistas)
            var selectedTransportista = TransportistasListV.SelectedItems[0];
            int dniTransportista = int.Parse(selectedTransportista.SubItems[1].Text);

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
                    // Crear el remito a trav�s del modelo (l�gica de negocio)
                    Remito nuevoRemito = modelo.GenerarRemito(idOrden, dniTransportista);

                    // Mostrar la confirmaci�n del remito
                    MessageBox.Show($"Remito generado:\nN�mero de Orden: {nuevoRemito.NumeroDeOrden}\nTransportista DNI: {nuevoRemito.DNITransportista}",
                                    "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Borrar el �tem seleccionado de DetalleRemitoLTV
                    DetalleRemitoLTV.Items.Remove(selectedItem);

                    // Eliminar todos los transportistas en Detalle transportista que tienen el mismo IdOrden 
                    foreach (ListViewItem item in TransportistasListV.Items.Cast<ListViewItem>().ToList())
                    {
                        if (item.SubItems[3].Text == idOrden) 
                        {
                            TransportistasListV.Items.Remove(item);
                        }
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
            // Verificar si hay al menos un �tem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay �rdenes para eliminar de un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay un �tem seleccionado
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenSeleccionada = DetalleRemitoLTV.SelectedItems[0];

            // Extraer el n�mero de orden
            string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

            // Confirmar la acci�n de eliminaci�n
            var result = MessageBox.Show($"�Est� seguro de que desea eliminar la orden: {numeroDeOrden}?",
                                          "Confirmar Eliminaci�n",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del m�todo
            if (result == DialogResult.No)
            {
                return;
            }

  

            // Eliminar la orden seleccionada
            DetalleRemitoLTV.Items.Remove(ordenSeleccionada);

            MessageBox.Show("Orden eliminada con �xito.", "Orden Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
