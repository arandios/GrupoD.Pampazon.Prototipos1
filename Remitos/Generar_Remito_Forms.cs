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

            // Aquí tomaremos el primer ítem de DetalleRemitoLTV para la confirmación
            var primerItem = DetalleRemitoLTV.Items[0];
            var dniT = TransportistasListV.Items[0];
            string numeroDeOrden = primerItem.SubItems[0].Text;
            string transportista = primerItem.SubItems[2].Text;
       
            int dni = int.Parse(dniT.SubItems[1].Text);

            DateTime fechaInicio = DateTime.Now.AddDays(-2000);

            DateTime fechaVencimiento = DateTime.Now.AddDays(30);

            DateTime fechaEmision = DateTime.Now;

            // Preguntar al usuario si está seguro de generar el remito
            var result = MessageBox.Show($"¿Está seguro de que desea generar el remito?\n" +
                                          $"Número de Orden: {numeroDeOrden}\n" +
                                          $"Transportista: {transportista}\n" +
                                          $"DNI: {dni}\n" +
                                          $"Fecha de Inicio de Actividad: {fechaInicio.ToShortDateString()}\n" +
                                          $"Fecha de Emision: {fechaEmision.ToShortDateString()}\n" +
                                          $"Fecha de Vencimiento del Comprobante: {fechaVencimiento.ToShortDateString()}",
                                          "Confirmar Generación de Remito",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }

            // Crear un nuevo remito
            Remito nuevoRemito = new Remito(numeroDeOrden, transportista)
            {
                
                FechaDeInicioActividad = fechaInicio,
                
                FechaDeVencimientoDelComprobante = fechaVencimiento
            };

            // Mostrar información del remito generado
            MessageBox.Show($"Remito generado:\nNúmero de Orden: {nuevoRemito.NumeroDeOrden}\nTransportista: {nuevoRemito.Transportista}\n" +
                            $"Fecha de Inicio: {nuevoRemito.FechaDeInicioActividad.ToShortDateString()}\n" +
                            $"Fecha de Vencimiento: {nuevoRemito.FechaDeVencimientoDelComprobante.ToShortDateString()}",
                            "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
             DetalleRemitoLTV.Items.Remove(primerItem);
             TransportistasListV.Items.Remove(dniT);

          

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

            // Confirmar la acción de eliminación
            var result = MessageBox.Show("¿Está seguro de que desea eliminar la orden seleccionada?",
                                          "Confirmar Eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }

           
            var ordenSeleccionada = DetalleRemitoLTV.SelectedItems[0];

           
            DetalleRemitoLTV.Items.Remove(ordenSeleccionada);

        
            MessageBox.Show("Orden eliminada con éxito.", "Orden Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
