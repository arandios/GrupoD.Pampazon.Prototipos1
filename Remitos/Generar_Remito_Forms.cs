using Pampazon.Remitos;
using System.Text;

namespace Pampazon
{
    public partial class Generar_RemitoForms : Form
    {
        private GenerarRemitoModelo modelo = new();
        private List<ListViewItem> todasLasOrdenes = new List<ListViewItem>();
        public Generar_RemitoForms()
        {
            

            InitializeComponent();

            List<OrdenesDeEntrega> ordenes = GenerarRemitoModelo.ObtenerOrdenes();

            // Llenar el ListView con los datos existentes
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrden); // Usar IdOrden

                item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy")); // Razón social
                item.SubItems.Add(orden.IdCliente); // Código del cliente como string

                OrdenesListV.Items.Add(item);

                // Guardar una copia de cada item en la lista todasLasOrdenes de la clase
                todasLasOrdenes.Add((ListViewItem)item.Clone());
            }

        }

       

        private void OrdenesListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenesListV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrdenesListV.SelectedItems[0];
                string idOrden = selectedItem.SubItems[0].Text; 
                string razonSocial = selectedItem.SubItems[1].Text;
            }

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            // Limpiar las listas de órdenes y transportistas
            
            TransportistasLTB.Items.Clear();

            // Obtener el ID del cliente ingresado
            string idClienteIngresado = BuscarClienteTxt.Text.Trim(); 

            // Verificar si el ID del cliente ingresado no está vacío
            if (!string.IsNullOrEmpty(idClienteIngresado))
            {
                // Filtrar las órdenes por el IdCliente 
                var ordenesFiltradas = todasLasOrdenes
                    .Where(item => item.SubItems[2].Text == idClienteIngresado).ToList();

                // Verificar si hay órdenes filtradas
                if (ordenesFiltradas.Count > 0)
                {
                    OrdenesListV.Items.Clear();
                    // Agregar las órdenes filtradas a OrdenesListV
                    OrdenesListV.Items.AddRange(ordenesFiltradas.ToArray());

                    // Obtener los transportistas asociados al cliente
                    List<Transportista> transportistas = GenerarRemitoModelo.ObtenerTransportistas();
                    var transportistasFiltrados = transportistas.Where(t => t.IdCliente == idClienteIngresado).ToList(); 

                    // Verificar si hay transportistas filtrados
                    if (transportistasFiltrados.Count > 0)
                    {
                        // Agregar los transportistas filtrados al ListBox
                        foreach (var transportista in transportistasFiltrados)
                        {
                            TransportistasLTB.Items.Add(transportista.Nombre);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron transportistas para ese cliente.", "Resultados de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron órdenes para ese cliente.", "Resultados de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
           
            if (TransportistasLTB.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OrdenesListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem ordenSeleccionada = OrdenesListV.SelectedItems[0];
            string idOrden = ordenSeleccionada.SubItems[0].Text; // Cambiado a IdOrden
            string IDcliente = ordenSeleccionada.SubItems[2].Text;
            string fecha = ordenSeleccionada.SubItems[1].Text;

            string transportistaSeleccionado = TransportistasLTB.SelectedItem.ToString();

            ListViewItem nuevoItem = new ListViewItem(idOrden); // Cambiado a IdOrden
            nuevoItem.SubItems.Add(IDcliente);
            nuevoItem.SubItems.Add(transportistaSeleccionado);
            nuevoItem.SubItems.Add(fecha);

            DetalleRemitoLTV.Items.Add(nuevoItem);
            OrdenesListV.Items.Remove(ordenSeleccionada);

            // Eliminar la orden confirmada de la lista original de órdenes
            todasLasOrdenes.RemoveAll(item => item.SubItems[0].Text == idOrden);

            // Restaurar todas las órdenes en OrdenesListV (exceptuando la eliminada)
            OrdenesListV.Items.Clear();
            OrdenesListV.Items.AddRange(todasLasOrdenes.ToArray());

            TransportistasLTB.Items.Clear();
            BuscarClienteTxt.Clear();

        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un remito para generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una lista para almacenar los nuevos remitos
            List<Remito> nuevosRemitos = new List<Remito>();

            // Recorrer cada item en DetalleRemitoLTV y crear un nuevo remito
            foreach (ListViewItem item in DetalleRemitoLTV.SelectedItems)
            {
                // Obtener los datos de cada columna
                string numeroOrden = item.SubItems[0].Text; 
                string razonSocial = item.SubItems[1].Text;
                string transportista = item.SubItems[2].Text;

                // Obtener la lista de productos asociados a la orden
                List<Productos> productos = ObtenerProductosPorOrden(numeroOrden);

                // Mostrar ventana de confirmación
                var confirmResult = MessageBox.Show(
                    ObtenerDetallesRemito(numeroOrden, razonSocial, transportista, productos),
                    "Confirmar Generación de Remito",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Si el usuario confirma, crear el nuevo remito
                if (confirmResult == DialogResult.Yes)
                {
                    // Crear un nuevo remito con la fecha actual
                    Remito nuevoRemito = new Remito(numeroOrden, razonSocial, transportista, productos); 

                    // Agregar el nuevo remito a la lista
                    nuevosRemitos.Add(nuevoRemito);
                }
            }

            // Eliminar la orden seleccionada de DetalleRemitoLTV
            foreach (ListViewItem item in DetalleRemitoLTV.SelectedItems)
            {
                DetalleRemitoLTV.Items.Remove(item);
            }

            // FALTA GUARDARLOS EN JSON

            MessageBox.Show("Remitos generados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Método para obtener los detalles del remito
        private string ObtenerDetallesRemito(string numeroOrden, string razonSocial, string transportista, List<Productos> productos)
        {
            StringBuilder detalles = new StringBuilder();
            detalles.AppendLine($"Número de Orden: {numeroOrden}");
            detalles.AppendLine($"Razón Social: {razonSocial}");
            detalles.AppendLine($"Transportista: {transportista}");
            detalles.AppendLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
            detalles.AppendLine("Productos:");

            foreach (var producto in productos)
            {
                // Cambiar producto.Id a producto.IdProducto
                detalles.AppendLine($"- {producto.IdProducto} (ID: {producto.Categoria})");
            }

            return detalles.ToString();
        }

        private static string ObtenerIdClientePorOrden(string numeroOrden)
        {
            // Obtener la lista de órdenes
            List<OrdenesDeEntrega> ordenes = GenerarRemitoModelo.ObtenerOrdenes();

            // Buscar la orden correspondiente al numeroOrden
            var orden = ordenes.FirstOrDefault(o => o.IdOrden == numeroOrden);

            // Devuelve el ID del cliente si se encuentra la orden, o null si no
            return orden != null ? orden.IdCliente.ToString() : null;
        }


        internal static List<Productos> ObtenerProductosPorOrden(string numeroOrden)
        {
            List<Productos> productos = new List<Productos>();

            // Obtener el idCliente basado en el numeroOrden
            string idCliente = ObtenerIdClientePorOrden(numeroOrden); 

            // Lógica para generar productos de ejemplo
            for (int i = 1; i <= 10; i++) // Suponiendo que cada orden tiene 10 productos
            {
                // Crear un nuevo producto, usando el constructor de la clase Productos
                productos.Add(new Productos(
                    idProducto: $"IP_{i:D4}", 
                    idCliente: idCliente,      
                    nombre: $"Producto {i}",   
                    cantidad: 1                
                ));
            }

            return productos;
        }

        private void SalisBtn_Click(object sender, EventArgs e)
        {

            if (DetalleRemitoLTV.Items.Count > 0)
            {
                // Preguntar al usuario si está seguro de salir
                DialogResult resultado = MessageBox.Show("Hay remitos sin confirmar. ¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


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
            string nroOrden = itemSeleccionado.SubItems[0].Text;
            string fecha = itemSeleccionado.SubItems[3].Text;
            string codigoCliente = itemSeleccionado.SubItems[1].Text;

            // Crear un nuevo ítem para agregar a OrdenesListV
            ListViewItem nuevoItem = new ListViewItem(nroOrden);
            nuevoItem.SubItems.Add(fecha);
            nuevoItem.SubItems.Add(codigoCliente);


            // Agregar el nuevo ítem en la primera posición de OrdenesListV
            OrdenesListV.Items.Insert(0, nuevoItem);

            // Eliminar el ítem de DetalleRemitoLTV
            DetalleRemitoLTV.Items.Remove(itemSeleccionado);

            // Asegurarse de que OrdenesListV se actualice
            OrdenesListV.Refresh();

            // Seleccionar y enfocar el nuevo ítem agregado
            OrdenesListV.Items[0].Selected = true;
            OrdenesListV.Items[0].Focused = true;

            MessageBox.Show("La orden ha sido cancelada y devuelta a la lista de órdenes en la primera posición.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ReportarBtn_Click(object sender, EventArgs e)
        {
            using (ReportesForm reportesForm = new ReportesForm())
            {
                reportesForm.ShowDialog(); 
            }
        }
    }
}
