using Pampazon.GenerarOrdenPreparacion;
using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pampazon
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel model = new();

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();

            PrioridadCMB.Items.Add("Alta");
            PrioridadCMB.Items.Add("Media");
            PrioridadCMB.Items.Add("Baja");
            PrioridadCMB.Enabled = false;


            FechaSelecter.CustomFormat = "MM/dd/yyyy";
            DateTime today = DateTime.Today;
            FechaSelecter.MinDate = today;
            FechaSelecter.MaxDate = today.AddDays(90);

            this.ProductosStockLST.SelectedIndexChanged += new EventHandler(this.ProductosStockLista_SelectedIndexChanged);
            CodigoClienteTXT.TextChanged += CodigoClienteTXT_TextChanged;
            RazonSocialClienteTXT.TextChanged += RazonSocialClienteTXT_TextChanged;

        }
        private void CodigoClienteTXT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodigoClienteTXT.Text))
            {
                RazonSocialClienteTXT.Enabled = false;
            }
            else
            {
                RazonSocialClienteTXT.Enabled = true;
            }
        }
        private void RazonSocialClienteTXT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RazonSocialClienteTXT.Text))
            {
                CodigoClienteTXT.Enabled = false;
            }
            else
            {
                CodigoClienteTXT.Enabled = true;
            }
        }

        private void GenerarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            foreach (ColumnHeader column in ProductosStockLST.Columns)
            {
                ProductosStockLST.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            foreach (ColumnHeader column in OrdenTempLista.Columns)
            {
                OrdenTempLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void OrdenTempLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenTempLista.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrdenTempLista.SelectedItems[0];
                int currentIndex = OrdenTempLista.SelectedIndices[0];
                //previousSelectedIndex = currentIndex; // Update the previous index
                string nombreProducto = selectedItem.Text;
                //model.retirarProductoDeOrdenYAgregarloDevuelta(nombreProducto);
                //MessageBox.Show($"Se retiro de el pedido '{nombreProducto}' de la orden ", "Info");
                ActualizarListaOrden();
            }
        }
        private void ActualizarListaOrden()
        {
            OrdenTempLista.Items.Clear();
            OrdenTempLista.FullRowSelect = true;
            if (model.Orden.Productos.Count > 0)
            {
                foreach (var ProdOrden in model.Orden.Productos)
                {
                    ListViewItem itemOrden = new ListViewItem();
                    itemOrden.Text = ProdOrden.Id;
                    itemOrden.SubItems.Add(ProdOrden.Stock.ToString());
                    itemOrden.Tag = ProdOrden;
                    OrdenTempLista.Items.Add(itemOrden);
                }

            }
        }

        private void LimpiarFiltros(object sender, EventArgs e)
        {
            ProductosStockLST.Items.Clear();
            SKUProductoTXT.Text = "";
            NombreProductoTXT.Text = "";
            ProductoSeleccionadoTxt.Text = "";
            MaxCantidadTxt.Text = "";
            AgregarCantidadTXT.Text = "";
            // Clear other filters if necessary
        }

        private void BuscarProductoBtn(object sender, EventArgs e)
        {
            // Reiniciar siempre el cliente al valor no válido
            CodigoClienteTXT.Enabled = true;
            RazonSocialClienteTXT.Enabled = true;
            model.IDCliente = -1;
            ProductosStockLST.Items.Clear();

            if (string.IsNullOrEmpty(CodigoClienteTXT.Text) && string.IsNullOrEmpty(RazonSocialClienteTXT.Text))
            {
                MessageBox.Show("Ingrese ID cliente o Razon Social");
            }
            else if (!string.IsNullOrEmpty(CodigoClienteTXT.Text) && !string.IsNullOrEmpty(RazonSocialClienteTXT.Text))
            {
                MessageBox.Show("Busque cliente por ID o por Razon Social. Elija una");
                CodigoClienteTXT.Clear();
                RazonSocialClienteTXT.Clear();
            }
            else if (!string.IsNullOrEmpty(CodigoClienteTXT.Text))
            {
                RazonSocialClienteTXT.Enabled = false;
                if (int.TryParse(CodigoClienteTXT.Text, out int clienteNumber))
                {
                    int clienteID = model.obtenerCliente(clienteNumber);
                    if (clienteID == -1)
                    {
                        MessageBox.Show($"ID Cliente {CodigoClienteTXT.Text} no existe.");
                        CodigoClienteTXT.Clear();
                    }
                    else
                    {
                        model.Orden.changeIDCliente(clienteID);
                        model.IDCliente = clienteID;
                        model.setProductosClientes(clienteID);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para buscar ID cliente.");
                    CodigoClienteTXT.Clear();
                }
            }
            else if (!string.IsNullOrEmpty(RazonSocialClienteTXT.Text))
            {
                CodigoClienteTXT.Enabled = false;
                int clienteID = model.obtenerCliente(-1, RazonSocialClienteTXT.Text);
                if (clienteID == -1)
                {
                    MessageBox.Show($"Razon Social '{RazonSocialClienteTXT.Text}' no existe.");
                }
                else
                {
                    model.Orden.changeIDCliente(clienteID);
                    CodigoClienteTXT.Text = clienteID.ToString();
                    model.setProductosClientes(clienteID);
                    model.IDCliente = clienteID;
                }
            }

            if (model.IDCliente != -1)
            {
                ActualizarListaProductos(SKUProductoTXT.Text, NombreProductoTXT.Text);
            }
        }

        private void ActualizarListaProductos(string codProducto, string nombreProducto)
        {
            ProductosStockLST.Items.Clear();
            ProductosStockLST.FullRowSelect = true;
            foreach (var Prod in model.obtenerProdFiltrados(codProducto.ToUpper(), nombreProducto.ToUpper()))
            {
                if (Prod.Stock > 0)
                {
                    //agregar a la lista.
                    ListViewItem item = new();
                    item.Text = Prod.Id.ToUpper();
                    item.SubItems.Add(Prod.NombreProducto.ToUpper());
                    item.SubItems.Add(Prod.Stock.ToString());
                    item.Tag = Prod;
                    ProductosStockLST.Items.Add(item);
                }
            }
            ProductosStockLST.Enabled = true;

            // Implement transportista list update logic
        }
        private void ProductosStockLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductosStockLST.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ProductosStockLST.SelectedItems[0];
                ProductoSeleccionadoTxt.Text = selectedItem.Text;
                MaxCantidadTxt.Text = selectedItem.SubItems[2].Text;
                AgregarCantidadTXT.Enabled = true; ;
                // Puedes acceder a otros valores aquí si es necesario
            }

        }

        private void CancelarOrderBtn(object sender, EventArgs e)
        {
            if (model.Orden.Productos.Count > 0)
            {
                DialogResult result = MessageBox.Show($"Cancelar Orden", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    model.cancelarOrden();
                    ActualizarListaOrden();
                    cargarTransportistas();
                    cargarNombreTransportistas();
                    PrioridadCMB.SelectedIndex = -1;
                    PrioridadCMB.Enabled = false;
                    CodigoClienteTXT.Enabled = true;
                    RazonSocialClienteTXT.Enabled = true;

                    MessageBox.Show("Orden Cancelada", "Info");

                }
            }
        }

        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)

        {
            bool eshorarioNumero;
            if (string.IsNullOrEmpty(HorarioTextBox.Text))
            {
                eshorarioNumero = false;
            }
            else
            {
                if (!int.TryParse(HorarioTextBox.Text, out int horario))
                {
                    eshorarioNumero = false;
                }
                else
                {
                    if (!(horario > 0 & horario <= 24))
                    {
                        eshorarioNumero = false;
                    }
                    else { eshorarioNumero = true; }
                };
            }

            string selectedPriority = PrioridadCMB.SelectedItem?.ToString();
            string dniTransportista = DniTransportistaCMB.SelectedItem?.ToString();


            if (model.Orden.Productos.Count == 0)
            {
                DialogResult result = MessageBox.Show($"Ingrese Productos para generar Orden", "Confirmation");
            }
            else if (FechaSelecter.Value < DateTime.Today.AddDays(1))
            {
                DialogResult result = MessageBox.Show($"Selecciona una fecha de Retiro mayor a la actual", "Confirmation");
            }
            else if (!eshorarioNumero)
            {
                DialogResult result = MessageBox.Show($"Seleccione un horario de Retiro. Un valor entre el 0 y el 24", "Confirmation");
            }
            else if (string.IsNullOrEmpty(selectedPriority))
            {
                DialogResult result = MessageBox.Show($"Seleccione Prioridad Alta, Media o Baja", "Confirmation");
            }

            else if (string.IsNullOrEmpty(dniTransportista) || model.Orden.DNITransportista <= 0)
            {
                DialogResult result = MessageBox.Show($"Seleccione un transportista por DNI o por Nombre", "Confirmation");
            }

            else
            {

                DialogResult resultOrden = MessageBox.Show($" ID Cliente: {model.Orden.IDCliente}\n Fecha de entrega: {FechaSelecter.Value.ToString("dd-MM-yyyy")}   Horario: {HorarioTextBox.Text}\n Dni Transportista: {model.Orden.DNITransportista}\n\n\n Confirmar Orden", "CONFIRMAR ORDEN DE ENTREGA", MessageBoxButtons.YesNo);
                if (resultOrden == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show($"Orden ingresada con exito, le enviaremos un mail con los detalles", "Confirmar Orden");


                    DateTime originalDate = FechaSelecter.Value;
                    DateTime resetDate = new DateTime(
                        originalDate.Year,
                        originalDate.Month,
                        originalDate.Day,
                        0, 0, 0
                    );

                    // Assign the reset date back to FechaSelecter.Value
                    FechaSelecter.Value = resetDate;
                    FechaSelecter.Value = FechaSelecter.Value.AddHours(Int32.Parse(HorarioTextBox.Text));
                    model.Orden.FechaDeEntrega = FechaSelecter.Value;

                    model.agregarOrderAlmacen();
                    model.Orden.borrarOrden();

                    // front
                    ActualizarListaOrden();
                    PrioridadCMB.SelectedIndex = -1;
                    HorarioTextBox.Text = "";
                    DniTransportistaCMB.SelectedIndex = -1;
                    NombreTransportistaCMB.SelectedIndex = -1;
                    FechaSelecter.Value = DateTime.Today;
                    CodigoClienteTXT.Enabled = true;
                    RazonSocialClienteTXT.Enabled = true;
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void CodigoClienteInput_TextChanged(object sender, EventArgs e)
        {

        }



        private void VolverBtn(object sender, EventArgs e)
        {
            if (model.Orden.Productos.Count > 0)
            {
                DialogResult resultOrden = MessageBox.Show($"Desea salir? No se guardara la orden en proceso", "Confirmar Salir", MessageBoxButtons.YesNo);
                if (resultOrden == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void GenerarOrdenPreparacionForm_Load_1(object sender, EventArgs e)
        {

        }
        
        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            int cantidad;
            bool esNumero = int.TryParse(AgregarCantidadTXT.Text, out cantidad);
            int cantidadMax;
            bool esNumeroMax = int.TryParse(MaxCantidadTxt.Text.ToString(), out cantidadMax);

            if (ProductoSeleccionadoTxt.Text == "")
            {
                MessageBox.Show("Seleccione un Producto", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!esNumero)
            {
                MessageBox.Show("Ingrese una cantidad a retirar", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarCantidadTXT.Text = ""; 
            }
            else if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cantidad > cantidadMax)
            {
                MessageBox.Show("La cantidad a retirar no puede ser mayor a la cantidad disponible", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var prod = model.obtenerProdIndividual(ProductoSeleccionadoTxt.Text);
                if (prod == null)
                {
                    MessageBox.Show("Error: Producto no encontrado en depósito", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    prod.Stock = cantidadMax - cantidad;
                    MaxCantidadTxt.Text = (cantidadMax - cantidad).ToString();
                    model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad);
                    ActualizarListaOrden();
                    ProductosStockLST.Items.Clear();
                    CodigoClienteTXT.Enabled = false;
                    RazonSocialClienteTXT.Enabled = false;
                    PrioridadCMB.Enabled = true;

                    ProductoSeleccionadoTxt.Text = "";
                    MaxCantidadTxt.Text = "";
                    AgregarCantidadTXT.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FechaSelecter_ValueChanged(object sender, EventArgs e)
        {

        }

        public void cargarTransportistas()
        {
            if (model.Orden.Productos.Count > 0)
            {
                DniTransportistaCMB.DisplayMember = "DNI"; // Show DNI in the ComboBox
                DniTransportistaCMB.DataSource = new BindingSource(model.ObtenerTransportistas(), null);
                DniTransportistaCMB.SelectedIndex = -1; // Clear selection
            }
            else
            {
                DniTransportistaCMB.DataSource = null; // Clear the DataSource
                DniTransportistaCMB.Items.Clear(); // Clear the Items (if needed)
            }

        }
        public void cargarNombreTransportistas()
        {

            if (model.Orden.Productos.Count > 0)
            {
                NombreTransportistaCMB.DisplayMember = "NombreCompleto"; // Show combined Nombre and Apellido
                NombreTransportistaCMB.DataSource = new BindingSource(model.ObtenerTransportistas(), null);
                NombreTransportistaCMB.SelectedIndex = -1; // Clear selection
            }
            else
            {
                NombreTransportistaCMB.DataSource = null; // Clear the DataSource
                NombreTransportistaCMB.Items.Clear(); // Clear the Items (if needed)

            }

        }

        private void DniTransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DniTransportistaCMB.SelectedItem != null)
            {
                var selectedTransportista = (GenerarOrdenPreparacion.Transportista)DniTransportistaCMB.SelectedItem;

                // Ensure that selectedTransportista is not null
                if (selectedTransportista != null)
                {
                    // Now you can safely access properties like selectedTransportista.Nombre
                    // For example:
                    NombreTransportistaCMB.Text = selectedTransportista.Nombre + " " + selectedTransportista.Apellido;
                    model.Orden.DNITransportista = selectedTransportista.DNI;
                }

            }
            else
            {
                // Handle the case where no item is selected
                DniTransportistaCMB.SelectedIndex = -1; // Clear selection // Clear the text or handle appropriately
            }
        }

        private void NombreTransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NombreTransportistaCMB.SelectedItem != null)
            {
                var selectedNombreTransportista = (GenerarOrdenPreparacion.Transportista)NombreTransportistaCMB.SelectedItem;

                // Ensure that selectedTransportista is not null
                if (selectedNombreTransportista != null)
                {
                    // Now you can safely access properties like selectedTransportista.Nombre
                    // For example:
                    DniTransportistaCMB.Text = selectedNombreTransportista.DNI.ToString();
                }

            }
            else
            {
                // Handle the case where no item is selected
                NombreTransportistaCMB.SelectedIndex = -1; // Clear the text or handle appropriately
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PrioridadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPriority = PrioridadCMB.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPriority))
            {
                model.Orden.Prioridad = selectedPriority.ToUpper();
                cargarTransportistas();
                cargarNombreTransportistas();
                // Clear selections after loading transportistas
                DniTransportistaCMB.SelectedIndex = -1; // Clear selection
                NombreTransportistaCMB.SelectedIndex = -1; // Clear selection
            }
        }

        private void SKUProductoTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
