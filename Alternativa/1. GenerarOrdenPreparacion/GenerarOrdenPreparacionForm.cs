using Pampazon.GenerarOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pampazon
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel model = new();

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();
            ActualizarLista();
            ActualizarListaTransportista();
            /* this.ProductosStockLista.SelectedIndexChanged += new EventHandler(this.ProductosStockLista_SelectedIndexChanged);
             this.OrdenTempLista.SelectedIndexChanged += new EventHandler(this.OrdenTempLista_SelectedIndexChanged);
             this.TransportistasComboBox.SelectedIndexChanged += new EventHandler(this.TransportistasComboBox_SelectedIndexChanged);*/


            // Deshabilitar el GroupBox inferior (Detalle) al cargar el formulario
            OPMercaderiaGroupBox.Enabled = true;
            OPDetalleMercaderiaGroupBox.Enabled = false;

        }
        private void GenerarOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            ActualizarLista();
            ActualizarListaOrden();
            ActualizarListaTransportista();



            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in ProductosStockLista.Columns)
            {
                ProductosStockLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in OrdenTempLista.Columns)
            {
                OrdenTempLista.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }


        }
        private void ActualizarLista(string nombreProd = "", int idDeposito = -1)
        {
            ProductosStockLista.Items.Clear();
            foreach (var Prod in model.obtenerProdFiltrados(nombreProd.ToUpper(), idDeposito))
            {
                if (Prod.Stock > 0)
                {
                    //agregar a la lista.
                    ListViewItem item = new();
                    item.Text = Prod.NombreProducto;
                    item.SubItems.Add(Prod.Stock.ToString());
                    item.SubItems.Add(Prod.IdDeposito.ToString());
                    item.SubItems.Add(Prod.DirDeposito);
                    item.SubItems.Add(Prod.Localidad);
                    item.Tag = Prod;
                    ProductosStockLista.Items.Add(item);
                }
            }
        } // fin metodo act Lista
        private void ActualizarListaOrden()
        {
            OrdenTempLista.Items.Clear();
            if (model.Orden.Productos.Count > 0)
            {
                foreach (var ProdOrden in model.Orden.Productos)
                {
                    ListViewItem itemOrden = new();
                    itemOrden.Text = ProdOrden.NombreProducto;
                    itemOrden.SubItems.Add(ProdOrden.Stock.ToString());
                    itemOrden.SubItems.Add(ProdOrden.IdDeposito.ToString());
                    itemOrden.Tag = ProdOrden;
                    OrdenTempLista.Items.Add(itemOrden);
                }
            }
        }
        private int previousSelectedIndex = -1; // Store the previous selected index
        private void OrdenTempLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenTempLista.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrdenTempLista.SelectedItems[0];
                int currentIndex = OrdenTempLista.SelectedIndices[0];
                previousSelectedIndex = currentIndex; // Update the previous index
                string nombreProducto = selectedItem.Text;
                model.retirarProductoDeOrdenYAgregarloDevuelta(nombreProducto);
                MessageBox.Show($"Se retiro de el pedido '{nombreProducto}' de la orden ", "Info");
                ActualizarListaOrden();
                ActualizarLista();
            }
        }
        //TransportistasComboBox

        /* private void ProductosStockLista_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (ProductosStockLista.SelectedItems.Count > 0)
             {
                 ListViewItem selectedItem = ProductosStockLista.SelectedItems[0];
                 ProductoSeleccionadoTxt.Text = selectedItem.Text;
                 DepositoTxt.Text = selectedItem.SubItems[2].Text;
                 MaxCantidadTxt.Text = selectedItem.SubItems[1].Text;
                 AgregarCantidadTextBox.Enabled = true; ;
                 // Puedes acceder a otros valores aquí si es necesario
             }
         }
         */

        private void Generar_Click(object sender, EventArgs e)
        {

        }

        private void BuscarProductoBtn(object sender, EventArgs e)
        {
            //
            if (DepositoBuscarTextBox.Text == "")
            {
                ActualizarLista(ProdNombreBox.Text.ToUpper(), -1);
            }
            else if (DepositoBuscarTextBox.Text != "")
            {
                int n;
                if (int.TryParse(DepositoBuscarTextBox.Text, out n))
                {
                    if (n <= 0)
                    {
                        MessageBox.Show("Ingrese un numero valido mayor a 0", "Deposito ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DepositoBuscarTextBox.Text = "";
                    }
                    else
                    {
                        ActualizarLista(ProdNombreBox.Text.ToUpper(), n);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero valido", "Deposito ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DepositoBuscarTextBox.Text = "";
                }
            }
        }

        private void LimpiarFiltros(object sender, EventArgs e)
        {
            ActualizarLista();
            ProdNombreBox.Text = "";
            DepositoBuscarTextBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //  ProductosStockLista.item.
        }

        /*  private void AgregarProductosOrdenBtn_Click(object sender, EventArgs e)
          {
              int deposito;
              bool esInt = int.TryParse(DepositoTxt.Text, out deposito);
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
                  DepositoBuscarTextBox.Text = "";
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
                  else
                  {
                      var prod = model.obtenerProdIndividual(ProductoSeleccionadoTxt.Text.ToUpper(), Convert.ToInt32(DepositoTxt.Text));
                      if (prod == null)
                      {
                          MessageBox.Show("Error producto no encontrado en deposito", "Cantidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      }
                      else
                      {
                          prod.Stock = cantidadMax - cantidad;
                          MaxCantidadTxt.Text = (cantidadMax - cantidad).ToString();
                          ActualizarLista();
                          if (model.Orden.Productos.Count == 0)
                          {
                              model.Orden.renameDeposito(deposito);
                              model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad, deposito);
                          }
                          else if (model.Orden.DepositoID != deposito)
                          {
                              MessageBox.Show("Selecione productos del mismo deposito, genere una orden nueva para productos de otros depositos", "No coincide numero de deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                          else
                          {
                              model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad, deposito);
                              ActualizarListaOrden();

                          }
                      }

                  }
              }
              ProductoSeleccionadoTxt.Text = "";
              DepositoTxt.Text = "";
              MaxCantidadTxt.Text = "";
              //model.Orden.AddProducto(ProductoSeleccionadoTxt.Text, cantidad, deposito);
              AgregarCantidadTextBox.Text = "";
              ActualizarListaOrden();
              ActualizarLista();

          }*/


        //TODO: Eliminar metodo:
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DepositoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarListaTransportista()
        {
            //OPTransportistasListView.Items.Clear();
            foreach (var transportista in model.Transportistas)
            {
                //agregar a la lista.
                ListViewItem item = new ListViewItem();
                item.Text = transportista.Nombre.ToString().ToUpper();
                item.SubItems.Add(transportista.Apellido.ToString().ToUpper());
                item.SubItems.Add(transportista.DNI.ToString().ToUpper());
                item.Tag = transportista;
                //OPTransportistasListView.Items.Add(item);
            }
        } // fin metodo act Lista


        /*private void TransportistasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportistasComboBox.SelectedItems.Count > 0)
            {
                ListViewItem transportistaSelecionado = TransportistasComboBox.SelectedItems[0];
                TransportistaSeleccionadoTxt.Text = transportistaSelecionado.Text.ToUpper() + " " + transportistaSelecionado.SubItems[1].Text.ToUpper() + "  DNI " + transportistaSelecionado.SubItems[2].Text.ToUpper();
                model.Orden.DNITransportista = int.Parse(transportistaSelecionado.SubItems[2].Text);
                // Puedes acceder a otros valores aquí si es necesario
            }


        }*/

        private void CancelarOrderBtn(object sender, EventArgs e)
        {
            if (model.Orden.Productos.Count > 0)
            {
                DialogResult result = MessageBox.Show($"Cancelar Orden", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    model.cancelarOrden();
                    model.Orden.borrarOrden();
                    MessageBox.Show("Orden Cancelada", "Info");
                    ActualizarListaOrden();
                    ActualizarLista();
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
            if (model.Orden.Productos.Count == 0)
            {
                DialogResult result = MessageBox.Show($"Ingrese Productos para generar Orden", "Confirmation");
            }
            else if (model.Orden.DNITransportista == -1)
            {
                DialogResult result = MessageBox.Show($"Seleccione un transportista", "Confirmation");
            }

            else
            {
                DialogResult resultOrden = MessageBox.Show($"Confirmar Orden", "Confirmation", MessageBoxButtons.YesNo);
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

        private void VolverBtn(object sender, EventArgs e)
        {
            this.Close();
        }


        //TODO: Eliminar metodos de eventos que no existen
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        //fin de clase
    }
}
