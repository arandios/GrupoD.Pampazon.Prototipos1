using Pampazon.MenuPrincipal;
using Pampazon.Remitos;
using System.Text;



namespace Pampazon
{
    public partial class Generar_RemitoForms : Form
    {
        private GenerarRemitoModelo modelo = new();

        //private List<ListViewItem> todasLasOrdenes = new List<ListViewItem>();
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
                // Verificar si el DNI es válido
                if (GenerarRemitoModelo.ComprobarDni(dni))
                {
                    // Obtener la lista de transportistas y filtrar los que coinciden con el DNI
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
                        MessageBox.Show("No se encontró un transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido. Debe tener al menos 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay un ítem seleccionado en TransportistasListV
            if (TransportistasListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un transportista de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ítem seleccionado
            ListViewItem selectedItem = TransportistasListV.SelectedItems[0];

            // Extraer los datos necesarios del ítem seleccionado
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

            // Crear un nuevo ítem para DetalleRemitoLTV
            ListViewItem nuevoItem = new ListViewItem(idOrden);
            nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());
            nuevoItem.SubItems.Add($"{nombreTransportista} {apellidoTransportista}");

            // Agregar el nuevo ítem a DetalleRemitoLTV
            DetalleRemitoLTV.Items.Add(nuevoItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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

            // Verificar si hay un ítem seleccionado en DetalleRemitoLTV
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para generar el remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ítem seleccionado de DetalleRemitoLTV
            var selectedItem = DetalleRemitoLTV.SelectedItems[0];

            // Obtener el IdOrden de la orden seleccionada
            string idOrden = selectedItem.SubItems[0].Text; // Asegúrate de que sea la columna correcta

            // Verificar si hay un ítem seleccionado en TransportistasListV
            if (TransportistasListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transportista = selectedItem.SubItems[2].Text; // Transportista del ítem seleccionado

            DateTime fechaInicio = DateTime.Now.AddDays(-2000);
            DateTime fechaVencimiento = DateTime.Now.AddDays(30);
            DateTime fechaEmision = DateTime.Now;

            // Preguntar al usuario si está seguro de generar el remito
            var result = MessageBox.Show($"¿Está seguro de que desea generar el remito?\n" +
                                          $"Número de Orden: {idOrden}\n" /*+
                                          $"Transportista: {transportista}\n" +
                                          $"Fecha de Inicio de Actividad: {fechaInicio.ToShortDateString()}\n" +
                                          $"Fecha de Emision: {fechaEmision.ToShortDateString()}\n" +
                                          $"Fecha de Vencimiento del Comprobante: {fechaVencimiento.ToShortDateString()}"*/,
                                          "Confirmar Generación de Remito",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }

            // Crear un nuevo remito
            Remito nuevoRemito = new Remito(idOrden, transportista)
            {
                FechaDeInicioActividad = fechaInicio,
                FechaDeVencimientoDelComprobante = fechaVencimiento
            };

            // Mostrar información del remito generado
            MessageBox.Show($"Remito generado:\nNúmero de Orden: {nuevoRemito.NumeroDeOrden}\nTransportista: {nuevoRemito.Transportista}",
                            "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Borrar el ítem seleccionado de DetalleRemitoLTV
            DetalleRemitoLTV.Items.Remove(selectedItem);

            // Eliminar todos los transportistas que tienen el mismo IdOrden
            foreach (ListViewItem item in TransportistasListV.Items.Cast<ListViewItem>().ToList())
            {
                if (item.SubItems[3].Text == idOrden) // Asumiendo que el IdOrden está en la cuarta columna (índice 3)
                {
                    TransportistasListV.Items.Remove(item);
                }
            }
        }




        /// <summary>
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

            // Verificar si hay un ítem seleccionado
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenSeleccionada = DetalleRemitoLTV.SelectedItems[0];

            // Extraer el número de orden
            string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

            // Confirmar la acción de eliminación
            var result = MessageBox.Show($"¿Está seguro de que desea eliminar la orden: {numeroDeOrden}?",
                                          "Confirmar Eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtener la orden seleccionada
  

            // Eliminar la orden seleccionada
            DetalleRemitoLTV.Items.Remove(ordenSeleccionada);

            MessageBox.Show("Orden eliminada con éxito.", "Orden Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
