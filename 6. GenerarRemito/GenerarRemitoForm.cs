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
            OrdenesDelTransportistaGBX.Enabled = false;
            DetalleRemitoGBX.Enabled = false;
        }

        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {
            // Obtener el DNI ingresado en el TextBox
            if (string.IsNullOrWhiteSpace(DNITtxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir si el campo está vacío
            }

            if (int.TryParse(DNITtxt.Text, out int dni))
            {
                // Validar el DNI
                string mensajeValidacion = GenerarRemitoModelo.ComprobarDni(dni);
                if (!string.IsNullOrEmpty(mensajeValidacion))
                {
                    MessageBox.Show(mensajeValidacion, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si el DNI no es válido
                }

                // Verificar si el transportista tiene órdenes asociadas
                var ordenesDelTransportista = GenerarRemitoModelo.ObtenerOrdenesDePreparacionPorDni(dni);
                if (ordenesDelTransportista == null || ordenesDelTransportista.Count == 0)
                {
                    MessageBox.Show("El transportista no tiene órdenes asociadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir si no hay órdenes asociadas
                }

                // Obtener el nombre y apellido del transportista desde las órdenes
                string nombreTransportista = GenerarRemitoModelo.ObtenerNombreTransportistaPorDni(dni);
                NomApellTransportistaTxt.Text = nombreTransportista;

                // Limpiar la lista de transportistas antes de agregar nuevos elementos
                TransportistasListV.Items.Clear();
                foreach (var orden in ordenesDelTransportista)
                {
                    TransportistasListV.Items.Add(new ListViewItem(new[] { orden.IdOrden })); // Agregar órdenes a la lista
                }

                // Desactivar el grupo de búsqueda y habilitar el grupo de órdenes del transportista
                BuscarTransportistaGBX.Enabled = false;
                OrdenesDelTransportistaGBX.Enabled = true;
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
            // Verificar si hay órdenes para agregar
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para agregar. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay algún ítem seleccionado en TransportistasListV
            bool hayOrdenSeleccionada = false; // Variable para verificar si hay una orden seleccionada

            foreach (ListViewItem selectedItem in TransportistasListV.Items)
            {
                if (selectedItem.Checked) // Comprobar si el checkbox está seleccionado
                {
                    hayOrdenSeleccionada = true; // Al menos una orden está seleccionada
                    break; // No es necesario seguir verificando
                }
            }

            // Si no hay ninguna orden seleccionada, mostrar un mensaje
            if (!hayOrdenSeleccionada)
            {
                MessageBox.Show("Por favor seleccione al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una lista para almacenar los ítems a eliminar
            var itemsAEliminar = new List<ListViewItem>();

            // Procesar las órdenes seleccionadas
            foreach (ListViewItem selectedItem in TransportistasListV.Items)
            {
                if (selectedItem.Checked) // Comprobar si el checkbox está seleccionado
                {
                    // Extraer los datos necesarios del ítem seleccionado
                    string idOrden = selectedItem.SubItems[0].Text;
                    DateTime fechaHoy = DateTime.Now.Date;

                    // Crear un nuevo ítem para DetalleRemitoLTV
                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());

                    // Agregar el nuevo ítem a DetalleRemitoLTV
                    DetalleRemitoLTV.Items.Add(nuevoItem);

                    // Añadir el ítem seleccionado a la lista de eliminación
                    itemsAEliminar.Add(selectedItem);
                }
            }

            // Eliminar los ítems seleccionados de TransportistasListV
            foreach (ListViewItem item in itemsAEliminar)
            {
                TransportistasListV.Items.Remove(item);
            }

            // Habilitar el grupo de detalles del remito
            DetalleRemitoGBX.Enabled = true;
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

            // Preguntar al usuario si está seguro de generar el remito antes de realizar cualquier acción
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea generar el remito?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario responde que no, no se hace nada
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Recoger el DNI del transportista desde el control, sin validación porque ya se hizo antes
            int dniTransportista = int.Parse(DNITtxt.Text);

            // Verificar si hay ítems seleccionados (con checkbox marcado)
            bool hayItemsSeleccionados = DetalleRemitoLTV.Items.Cast<ListViewItem>().Any(item => item.Checked);

            // Crear la lista de órdenes:
            // - Si hay items seleccionados (checkbox activado), solo esas órdenes
            // - Si no hay ítems seleccionados, se toman todas las órdenes de DetalleRemitoLTV
            var ordenesParaRemito = DetalleRemitoLTV.Items.Cast<ListViewItem>()
                .Where(item => !hayItemsSeleccionados || item.Checked) // Si no hay seleccionados, se toman todos
                .Select(item =>
                {
                    string idOrden = item.SubItems[0].Text;
                    return modelo.ObtenerOrdenPorId(idOrden);
                })
                .Where(orden => orden != null) // Filtrar órdenes válidas
                .ToList();

            try
            {
                // Crear el remito a través del modelo
                Remito nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);

                // Mostrar la confirmación del remito
                MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\nÓrdenes: {string.Join(", ", nuevoRemito.Ordenes.Select(o => o.IdOrden))}",
                                "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                var itemsAEliminar = new List<ListViewItem>();

                if (hayItemsSeleccionados)
                {
                    // Solo eliminar ítems que estén marcados
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
                    // Si no hay ítems seleccionados, eliminar todos los ítems de DetalleRemitoLTV
                    itemsAEliminar.AddRange(DetalleRemitoLTV.Items.Cast<ListViewItem>());
                }

                // Eliminar los ítems seleccionados de DetalleRemitoLTV
                foreach (ListViewItem item in itemsAEliminar)
                {
                    DetalleRemitoLTV.Items.Remove(item);
                }

                // Comprobar si DetalleRemitoLTV está vacío
                if (DetalleRemitoLTV.Items.Count == 0)
                {
                    TransportistasListV.Items.Clear();
                    DNITtxt.Clear();
                    BuscarTransportistaGBX.Enabled = true;
                    OrdenesDelTransportistaGBX.Enabled = false;
                    DetalleRemitoGBX.Enabled = false;
                    NomApellTransportistaTxt.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si hay un problema con la validación
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Crear una lista para almacenar los ítems a eliminar
            var itemsAEliminar = new List<ListViewItem>();

            // Verificar si hay ítems seleccionados mediante el checkbox
            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                if (item.Checked)
                {
                    itemsAEliminar.Add(item); 
                }
            }

            // Si no hay ninguna orden seleccionada, mostrar un mensaje
            if (itemsAEliminar.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una orden para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mensaje = new StringBuilder("¿Está seguro de que desea eliminar las siguientes órdenes?\n");

            // Agregar cada ítem seleccionado al mensaje
            foreach (var item in itemsAEliminar)
            {
                mensaje.AppendLine(item.Text); // Aquí asumo que el texto del ítem se encuentra en item.Text
            }

            // Confirmar la acción de eliminación
            var result = MessageBox.Show(mensaje.ToString(),
                                          "Confirmar Eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del método
            if (result == DialogResult.No)
            {
                return;
            }

            // Recopilar los ítems eliminados para devolverlos a TransportistasListV
            foreach (var ordenSeleccionada in itemsAEliminar)
            {
                // Extraer el número de orden (asumiendo que es el primer subítem)
                string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

                // Crear un nuevo ítem para TransportistasListV
                ListViewItem nuevoItem = new ListViewItem(numeroDeOrden);
                nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[1].Text); // Copiar otros subítems según sea necesario
                nuevoItem.Checked = false; // Asegurarse de que el checkbox no esté seleccionado

                // Agregar el nuevo ítem a TransportistasListV
                TransportistasListV.Items.Add(nuevoItem);

                // Eliminar la orden seleccionada de DetalleRemitoLTV
                DetalleRemitoLTV.Items.Remove(ordenSeleccionada);
            }

            // Verificar si DetalleRemitoLTV está vacío para habilitar o deshabilitar el GroupBox
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                DetalleRemitoGBX.Enabled = false; // Deshabilitar el GroupBox si no hay órdenes
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
            // Confirmar la acci�n
            var result = MessageBox.Show("¿Está seguro que desea salir?",
                                          "Confirmar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del m�todo
            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}

