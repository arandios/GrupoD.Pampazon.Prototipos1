using Pampazon.Remitos;

namespace Pampazon
{
    public partial class Generar_RemitoForms : Form
    {
        private RemitoModelo modelo = new();
        private ListViewItem ordenEliminada;
        public Generar_RemitoForms()
        {
            InitializeComponent();

            // Obtener los datos desde la clase OrdenesDeEntregaModelo
            List<OrdenesDeEntrega> ordenes = OrdenesDeEntregaModelo.ObtenerOrdenes();

            // Llenar el ListView con los datos existentes
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NroDeOrden.ToString("D6")); // No necesitas usar ToString("D6") ya que ya es un string
                item.SubItems.Add(orden.RazonSocial);
                item.SubItems.Add(orden.CodigoCliente.ToString()); // Agregar CódigoCliente a la columna ClienteColumna
                // Agregar RazonSocial a la columna RazonSocialColumna
                OrdenesListV.Items.Add(item);
            }

            // Seleccionar automáticamente la primera opción
            if (OrdenesListV.Items.Count > 0)
            {
                OrdenesListV.Items[0].Selected = true;
                OrdenesListV.Items[0].Focused = true; // Asegura que el ítem esté enfocado
            }

            // Suscribir al evento SelectedIndexChanged
            OrdenesListV.SelectedIndexChanged += new EventHandler(OrdenesListV_SelectedIndexChanged);

        }

        private void SelectFirstItemInListView()
        {
            if (OrdenesListV.Items.Count > 0)
            {
                OrdenesListV.Items[0].Selected = true;
                OrdenesListV.Items[0].Focused = true; // Esto asegura que el ítem esté enfocado
            }
        }

        private void OrdenesListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenesListV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrdenesListV.SelectedItems[0];
                string nroDeOrden = selectedItem.SubItems[0].Text;
                string razonSocial = selectedItem.SubItems[1].Text;
            }

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los resultados de búsqueda
            TransportistasLTB.Items.Clear();

            // Obtener el número de cliente ingresado
            int codigoCliente;
            bool esNumeroValido = int.TryParse(BuscarClienteTxt.Text, out codigoCliente);

            if (esNumeroValido)
            {
                // Obtener la lista de transportistas
                List<Transportista> transportistas = TransportistaModelo.ObtenerTransportistas();

                // Filtrar los transportistas por el código de cliente
                var resultados = transportistas.Where(t => t.CodigoCliente == codigoCliente).ToList();

                // Verificar si hay resultados
                if (resultados.Count > 0)
                {
                    // Agregar los nombres de los transportistas al ListBox
                    foreach (var transportista in resultados)
                    {
                        TransportistasLTB.Items.Add(transportista.Nombre);
                    }
                }
                else
                {
                    // Mostrar un mensaje en ventana si no se encuentran transportistas
                    MessageBox.Show("No se encontraron transportistas para ese cliente.", "Resultados de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si no se ingresa un número válido, mostrar un mensaje de error
                MessageBox.Show("Por favor, ingrese un número de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            // Verificar que haya un transportista seleccionado en el ListBox
            if (TransportistasLTB.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que haya una orden seleccionada en el ListView de órdenes
            if (OrdenesListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos de la orden seleccionada en OrdenesListV
            ListViewItem ordenSeleccionada = OrdenesListV.SelectedItems[0];
            string nroOrden = ordenSeleccionada.SubItems[0].Text; // Columna NroOrdenColumna
            string razonSocial = ordenSeleccionada.SubItems[1].Text; // Columna ClienteColumna (razón social)
            string codigoCliente = ordenSeleccionada.SubItems[2].Text; // Columna CódigoClienteColumna

            // Obtener el transportista seleccionado del ListBox
            string transportistaSeleccionado = TransportistasLTB.SelectedItem.ToString();

            // Agregar los datos al ListView DetalleRemitoLTV en el nuevo orden, incluyendo el código del cliente en una columna oculta
            ListViewItem nuevoItem = new ListViewItem(nroOrden); // Columna NroOrdenColumna
            nuevoItem.SubItems.Add(razonSocial); // Columna ClienteColumna (razón social)
            nuevoItem.SubItems.Add(transportistaSeleccionado);  // Columna TransportistaConfirmadoColumna
            nuevoItem.SubItems.Add(codigoCliente);  // Columna oculta para almacenar el código del cliente

            DetalleRemitoLTV.Items.Add(nuevoItem);

            // Eliminar la orden seleccionada de OrdenesListV
            OrdenesListV.Items.Remove(ordenSeleccionada);

            // Limpiar la lista de transportistas
            TransportistasLTB.Items.Clear();

            BuscarClienteTxt.Clear();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en DetalleRemitoLTV
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un remito para generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Si no hay selección, salir del método
            }

            // Verificar si hay elementos en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay remitos en la lista para generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una lista para almacenar los nuevos remitos
            List<Remito> nuevosRemitos = new List<Remito>();

            // Recorrer cada item en DetalleRemitoLTV y crear un nuevo remito
            foreach (ListViewItem item in DetalleRemitoLTV.SelectedItems) // Cambiado a SelectedItems
            {
                // Obtener los datos de cada columna
                int numeroOrden = Convert.ToInt32(item.SubItems[0].Text); // Columna de número de orden
                string razonSocial = item.SubItems[1].Text; // Columna de razón social
                string transportista = item.SubItems[2].Text; // Columna de transportista

                // Crear un nuevo remito
                Remito nuevoRemito = new Remito(numeroOrden, razonSocial, transportista);

                // Agregar el nuevo remito a la lista
                nuevosRemitos.Add(nuevoRemito);
            }

            // Eliminar la orden seleccionada de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.SelectedItems)
            {
                DetalleRemitoLTV.Items.Remove(item);
            }

            // FALTA GUARDARLOS EN JSON

            // Por ejemplo, guardar en una base de datos o mostrar un mensaje de confirmación
            MessageBox.Show("Remitos generados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SalisBtn_Click(object sender, EventArgs e)
        {

            if (DetalleRemitoLTV.Items.Count > 0)
            {
                // Preguntar al usuario si está seguro de salir
                DialogResult resultado = MessageBox.Show("Hay remitos sin confirmar. ¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.No)
                {
                    return; // Si elige "No", no hacer nada y regresar
                }
            }
            this.Close();

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay un ítem seleccionado en DetalleRemitoLTV
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden en la lista de remitos para cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preguntar al usuario si está seguro de cancelar
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar esta orden y devolverla a la lista de órdenes?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona "No", cancelar la operación
            if (resultado == DialogResult.No)
            {
                return;
            }

            // Obtener el ítem seleccionado en DetalleRemitoLTV
            ListViewItem itemSeleccionado = DetalleRemitoLTV.SelectedItems[0];

            // Extraer los valores de las columnas de DetalleRemitoLTV
            string nroOrden = itemSeleccionado.SubItems[0].Text; // Columna NroOrden
            string razonSocial = itemSeleccionado.SubItems[1].Text; // Columna ClienteConfirmadoColumna (razón social)
            string codigoCliente = itemSeleccionado.SubItems[3].Text; // Código de cliente (index oculto)

            // Crear un nuevo ítem para agregar a OrdenesListV
            ListViewItem nuevoItem = new ListViewItem(nroOrden); // NroOrdenColumna
            nuevoItem.SubItems.Add(razonSocial); // ClienteColumna (index 1)
            nuevoItem.SubItems.Add(codigoCliente); // CódigoClienteColumna (index 2)
            

            // Agregar el nuevo ítem en la primera posición de OrdenesListV
            OrdenesListV.Items.Insert(0, nuevoItem);

            // Eliminar el ítem de DetalleRemitoLTV
            DetalleRemitoLTV.Items.Remove(itemSeleccionado);

            // Asegurarse de que OrdenesListV se actualice
            OrdenesListV.Refresh();

            // Seleccionar y enfocar el nuevo ítem agregado
            OrdenesListV.Items[0].Selected = true;
            OrdenesListV.Items[0].Focused = true;

            // Mensaje de confirmación
            MessageBox.Show("La orden ha sido cancelada y devuelta a la lista de órdenes en la primera posición.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
