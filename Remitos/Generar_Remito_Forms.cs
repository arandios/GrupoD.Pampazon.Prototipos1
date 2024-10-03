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
                item.SubItems.Add(orden.CodigoCliente.ToString()); // Agregar C�digoCliente a la columna ClienteColumna
                // Agregar RazonSocial a la columna RazonSocialColumna
                OrdenesListV.Items.Add(item);
            }

            // Seleccionar autom�ticamente la primera opci�n
            if (OrdenesListV.Items.Count > 0)
            {
                OrdenesListV.Items[0].Selected = true;
                OrdenesListV.Items[0].Focused = true; // Asegura que el �tem est� enfocado
            }

            // Suscribir al evento SelectedIndexChanged
            OrdenesListV.SelectedIndexChanged += new EventHandler(OrdenesListV_SelectedIndexChanged);

        }

        private void SelectFirstItemInListView()
        {
            if (OrdenesListV.Items.Count > 0)
            {
                OrdenesListV.Items[0].Selected = true;
                OrdenesListV.Items[0].Focused = true; // Esto asegura que el �tem est� enfocado
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
            // Limpiar el ListBox antes de mostrar los resultados de b�squeda
            TransportistasLTB.Items.Clear();

            // Obtener el n�mero de cliente ingresado
            int codigoCliente;
            bool esNumeroValido = int.TryParse(BuscarClienteTxt.Text, out codigoCliente);

            if (esNumeroValido)
            {
                // Obtener la lista de transportistas
                List<Transportista> transportistas = TransportistaModelo.ObtenerTransportistas();

                // Filtrar los transportistas por el c�digo de cliente
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
                    MessageBox.Show("No se encontraron transportistas para ese cliente.", "Resultados de b�squeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si no se ingresa un n�mero v�lido, mostrar un mensaje de error
                MessageBox.Show("Por favor, ingrese un n�mero de cliente v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Verificar que haya una orden seleccionada en el ListView de �rdenes
            if (OrdenesListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos de la orden seleccionada en OrdenesListV
            ListViewItem ordenSeleccionada = OrdenesListV.SelectedItems[0];
            string nroOrden = ordenSeleccionada.SubItems[0].Text; // Columna NroOrdenColumna
            string razonSocial = ordenSeleccionada.SubItems[1].Text; // Columna ClienteColumna (raz�n social)
            string codigoCliente = ordenSeleccionada.SubItems[2].Text; // Columna C�digoClienteColumna

            // Obtener el transportista seleccionado del ListBox
            string transportistaSeleccionado = TransportistasLTB.SelectedItem.ToString();

            // Agregar los datos al ListView DetalleRemitoLTV en el nuevo orden, incluyendo el c�digo del cliente en una columna oculta
            ListViewItem nuevoItem = new ListViewItem(nroOrden); // Columna NroOrdenColumna
            nuevoItem.SubItems.Add(razonSocial); // Columna ClienteColumna (raz�n social)
            nuevoItem.SubItems.Add(transportistaSeleccionado);  // Columna TransportistaConfirmadoColumna
            nuevoItem.SubItems.Add(codigoCliente);  // Columna oculta para almacenar el c�digo del cliente

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
                return; // Si no hay selecci�n, salir del m�todo
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
                int numeroOrden = Convert.ToInt32(item.SubItems[0].Text); // Columna de n�mero de orden
                string razonSocial = item.SubItems[1].Text; // Columna de raz�n social
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

            // Por ejemplo, guardar en una base de datos o mostrar un mensaje de confirmaci�n
            MessageBox.Show("Remitos generados con �xito.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SalisBtn_Click(object sender, EventArgs e)
        {

            if (DetalleRemitoLTV.Items.Count > 0)
            {
                // Preguntar al usuario si est� seguro de salir
                DialogResult resultado = MessageBox.Show("Hay remitos sin confirmar. �Est� seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            // Verificar si hay un �tem seleccionado en DetalleRemitoLTV
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden en la lista de remitos para cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preguntar al usuario si est� seguro de cancelar
            DialogResult resultado = MessageBox.Show("�Est� seguro de que desea cancelar esta orden y devolverla a la lista de �rdenes?", "Confirmar Cancelaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona "No", cancelar la operaci�n
            if (resultado == DialogResult.No)
            {
                return;
            }

            // Obtener el �tem seleccionado en DetalleRemitoLTV
            ListViewItem itemSeleccionado = DetalleRemitoLTV.SelectedItems[0];

            // Extraer los valores de las columnas de DetalleRemitoLTV
            string nroOrden = itemSeleccionado.SubItems[0].Text; // Columna NroOrden
            string razonSocial = itemSeleccionado.SubItems[1].Text; // Columna ClienteConfirmadoColumna (raz�n social)
            string codigoCliente = itemSeleccionado.SubItems[3].Text; // C�digo de cliente (index oculto)

            // Crear un nuevo �tem para agregar a OrdenesListV
            ListViewItem nuevoItem = new ListViewItem(nroOrden); // NroOrdenColumna
            nuevoItem.SubItems.Add(razonSocial); // ClienteColumna (index 1)
            nuevoItem.SubItems.Add(codigoCliente); // C�digoClienteColumna (index 2)
            

            // Agregar el nuevo �tem en la primera posici�n de OrdenesListV
            OrdenesListV.Items.Insert(0, nuevoItem);

            // Eliminar el �tem de DetalleRemitoLTV
            DetalleRemitoLTV.Items.Remove(itemSeleccionado);

            // Asegurarse de que OrdenesListV se actualice
            OrdenesListV.Refresh();

            // Seleccionar y enfocar el nuevo �tem agregado
            OrdenesListV.Items[0].Selected = true;
            OrdenesListV.Items[0].Focused = true;

            // Mensaje de confirmaci�n
            MessageBox.Show("La orden ha sido cancelada y devuelta a la lista de �rdenes en la primera posici�n.", "Confirmaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
