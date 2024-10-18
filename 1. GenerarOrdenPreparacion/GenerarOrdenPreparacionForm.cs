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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pampazon
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel model = new();

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();

            PrioridadComboBox.Items.Add("Alta");
            PrioridadComboBox.Items.Add("Media");
            PrioridadComboBox.Items.Add("Baja");
            PrioridadComboBox.Enabled = false;


            FechaSelecter.CustomFormat = "MM/dd/yyyy";
            DateTime today = DateTime.Today;
            FechaSelecter.MinDate = today;
            FechaSelecter.MaxDate = today.AddDays(90);

            this.ProductosStockLista.SelectedIndexChanged += new EventHandler(this.ProductosStockLista_SelectedIndexChanged);


        }

        private void GenerarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            foreach (ColumnHeader column in ProductosStockLista.Columns)
            {
                ProductosStockLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
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
            ProductosStockLista.Items.Clear();
            SKUProductoInput.Text = "";
            NombreProductoInput.Text = "";

            // Clear other filters if necessary
        }

        private void BuscarProductoBtn(object sender, EventArgs e)
        {

            if (CodigoClienteInput.Text.ToUpper() != model.IDCliente.ToString().ToUpper())
            {
                model.IDCliente = -1;
                ProductosStockLista.Items.Clear();
                if (CodigoClienteInput.Text == "" & RazonSocialClienteInput.Text == "")
                {
                    DialogResult result = MessageBox.Show($"Ingrese ID cliente o Razon Social");
                }
                else if (CodigoClienteInput.Text != "" & RazonSocialClienteInput.Text != "")
                {
                    DialogResult result = MessageBox.Show($"Busque cliente por ID o por Razon Social. Elija una");
                    CodigoClienteInput.Text = "";
                    RazonSocialClienteInput.Text = "";
                }
                else if (CodigoClienteInput.Text != "" & RazonSocialClienteInput.Text == "")
                {
                    int clienteNumber;
                    if (!int.TryParse(CodigoClienteInput.Text, out clienteNumber))
                    {
                        MessageBox.Show($"Ingrese un numero para buscar ID cliente");
                        CodigoClienteInput.Text = "";
                    }
                    else if (model.obtenerCliente(clienteNumber) == -1)
                    {
                        CodigoClienteInput.Text = "";
                        MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text} no existe. Busque devuelta o por razon Social");
                    }
                    else // caso favorable
                    {
                        model.Orden.changeIDCliente(model.obtenerCliente(clienteNumber));
                        model.IDCliente = model.Orden.IDCliente;
                        model.setProductosClientes(model.Orden.IDCliente);
                        MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text}");
                    }
                }
                else if (CodigoClienteInput.Text == "" & RazonSocialClienteInput.Text != "")
                {
                    if (model.obtenerCliente(-1, RazonSocialClienteInput.Text) == -1)
                    {
                        MessageBox.Show($"Razon Social {RazonSocialClienteInput.Text} no existe. Busque devuelta o por ID Cliente");
                    }
                    else // caso favorable
                    {
                        model.Orden.changeIDCliente(model.obtenerCliente(-1, RazonSocialClienteInput.Text));
                        CodigoClienteInput.Text = model.Orden.IDCliente.ToString().ToUpper();
                        model.setProductosClientes(model.Orden.IDCliente);
                        model.IDCliente = model.Orden.IDCliente;
                        MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text}. Razon Social {RazonSocialClienteInput.Text}");
                    }
                } // fin de if orden con productos == 0
            } // fin de if orden con productos == 0
            if (model.IDCliente != -1)
            {
                ActualizarListaProductos(SKUProductoInput.Text, NombreProductoInput.Text);
            }

        }  // hasta aca llega la seleccioan de cliente y producto

        private void ActualizarListaProductos(string codProducto, string nombreProducto)
        {
            ProductosStockLista.Items.Clear();
            ProductosStockLista.FullRowSelect = true;
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
                    ProductosStockLista.Items.Add(item);
                }
            }
            ProductosStockLista.Enabled = true;

            // Implement transportista list update logic
        }
        private void ProductosStockLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductosStockLista.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ProductosStockLista.SelectedItems[0];
                ProductoSeleccionadoTxt.Text = selectedItem.Text;
                MaxCantidadTxt.Text = selectedItem.SubItems[2].Text;
                AgregarCantidadTextBox.Enabled = true; ;
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
                    PrioridadComboBox.SelectedIndex = -1;
                    PrioridadComboBox.Enabled = false;
                    CodigoClienteInput.Enabled = true;
                    RazonSocialClienteInput.Enabled = true;
               
                    MessageBox.Show("Orden Cancelada", "Info");

                }
                else
                {
                    // User clicked No
                    MessageBox.Show("Continuar con la orden", "Info");
                }

            }
        }

        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)

        {
            bool eshorarioNumero;
            if (string.IsNullOrEmpty(HorarioTextBox.Text)){
                eshorarioNumero = false;
            }
            else
            {
             if(!int.TryParse(HorarioTextBox.Text, out int horario))
                {
                    eshorarioNumero = false;
                }
             else
                {
                    if(!(horario > 0 & horario <= 24))
                    {
                       eshorarioNumero = false;
                    } else { eshorarioNumero = true; }
                };
            }

            string selectedPriority = PrioridadComboBox.SelectedItem?.ToString();
            string dniTransportista = DniTransportistaComboBox.SelectedItem?.ToString();


            if (model.Orden.Productos.Count == 0)
            {
                DialogResult result = MessageBox.Show($"Ingrese Productos para generar Orden", "Confirmation");
            } 
            else if (FechaSelecter.Value < DateTime.Today.AddDays(1)) {
                DialogResult result = MessageBox.Show($"Selecciona una fecha de Retiro mayor", "Confirmation");
            }
            else if (!eshorarioNumero)  {
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
        
                DialogResult resultOrden = MessageBox.Show($" ID Cliente:{model.Orden.IDCliente}\n Fecha de entrega:{FechaSelecter.Value.ToString("dd-MM-yyyy")} Horario: {HorarioTextBox.Text}\n Dni Transportista: {model.Orden.DNITransportista}\n\n\n Confirmar Orden", "CONFIRMAR ORDEN DE ENTREGA", MessageBoxButtons.YesNo);
                if (resultOrden == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show($"Orden ingresada con exitos, le enviaremos un mail con los detalles", "Confirmar Orden");
                    model.Orden.borrarOrden();
                    ActualizarListaOrden();
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Continuar con la orden");
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
            this.Close();
        }

        private void GenerarOrdenPreparacionForm_Load_1(object sender, EventArgs e)
        {

        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            int cantidad;
            bool esNumero = int.TryParse(AgregarCantidadTextBox.Text, out cantidad);
            int cantidadMax;
            bool esNumeroMax = int.TryParse(MaxCantidadTxt.Text.ToString(), out cantidadMax);
            if (ProductoSeleccionadoTxt.Text == "")
            {
                MessageBox.Show("Seleccione un Producto", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!esNumero)
            {
                MessageBox.Show("Ingrese un numero Valido", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarCantidadTextBox.Text = "";
            }
            else if (esNumero)
            {
                if (cantidad <= 0)
                {
                    MessageBox.Show("Cantidad tiene que ser mayor que 0", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cantidad > cantidadMax)
                {
                    MessageBox.Show("Cantidad a retirar no puede ser mayor a la cantidad depositada", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else // ok el numero
                {
                    var prod = model.obtenerProdIndividual(ProductoSeleccionadoTxt.Text);
                    if (prod == null)
                    {
                        MessageBox.Show("Error producto no encontrado en deposito", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        prod.Stock = cantidadMax - cantidad;
                        MaxCantidadTxt.Text = (cantidadMax - cantidad).ToString();
                        model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad);
                        ActualizarListaOrden();
                        ProductosStockLista.Items.Clear();
                        CodigoClienteInput.Enabled = false;
                        RazonSocialClienteInput.Enabled = false;
                        PrioridadComboBox.Enabled = true;
                    }

                }
            }
            ProductoSeleccionadoTxt.Text = "";
            MaxCantidadTxt.Text = "";
            //model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad, deposito);
            AgregarCantidadTextBox.Text = "";
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
                DniTransportistaComboBox.DisplayMember = "DNI"; // Show DNI in the ComboBox
                DniTransportistaComboBox.DataSource = new BindingSource(model.ObtenerTransportistas(), null);
                DniTransportistaComboBox.SelectedIndex = -1; // Clear selection
            }
            else
            {
                DniTransportistaComboBox.DataSource = null; // Clear the DataSource
                DniTransportistaComboBox.Items.Clear(); // Clear the Items (if needed)
            }

        }
        public void cargarNombreTransportistas()
        {

            if (model.Orden.Productos.Count > 0)
            {
                NombreTransportistaComboBox.DisplayMember = "NombreCompleto"; // Show combined Nombre and Apellido
                NombreTransportistaComboBox.DataSource = new BindingSource(model.ObtenerTransportistas(), null);
                NombreTransportistaComboBox.SelectedIndex = -1; // Clear selection
            }
            else
            {
                NombreTransportistaComboBox.DataSource = null; // Clear the DataSource
                NombreTransportistaComboBox.Items.Clear(); // Clear the Items (if needed)

            }

        }

        private void DniTransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DniTransportistaComboBox.SelectedItem != null)
            {
                var selectedTransportista = (GenerarOrdenPreparacion.Transportista)DniTransportistaComboBox.SelectedItem;

                // Ensure that selectedTransportista is not null
                if (selectedTransportista != null)
                {
                    // Now you can safely access properties like selectedTransportista.Nombre
                    // For example:
                    NombreTransportistaComboBox.Text = selectedTransportista.Nombre + " " + selectedTransportista.Apellido;
                    model.Orden.DNITransportista = selectedTransportista.DNI;
                }

            }
            else
            {
                // Handle the case where no item is selected
                DniTransportistaComboBox.SelectedIndex = -1; // Clear selection // Clear the text or handle appropriately
            }
        }

        private void NombreTransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NombreTransportistaComboBox.SelectedItem != null)
            {
                var selectedNombreTransportista = (GenerarOrdenPreparacion.Transportista)NombreTransportistaComboBox.SelectedItem;

                // Ensure that selectedTransportista is not null
                if (selectedNombreTransportista != null)
                {
                    // Now you can safely access properties like selectedTransportista.Nombre
                    // For example:
                    DniTransportistaComboBox.Text = selectedNombreTransportista.DNI.ToString();
                }

            }
            else
            {
                // Handle the case where no item is selected
                NombreTransportistaComboBox.SelectedIndex = -1; // Clear the text or handle appropriately
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
            string selectedPriority = PrioridadComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPriority))
            {
                model.Orden.Prioridad = selectedPriority.ToUpper();
                cargarTransportistas();
                cargarNombreTransportistas();
                // Clear selections after loading transportistas
                DniTransportistaComboBox.SelectedIndex = -1; // Clear selection
                NombreTransportistaComboBox.SelectedIndex = -1; // Clear selection
            }
        }
    }
}
