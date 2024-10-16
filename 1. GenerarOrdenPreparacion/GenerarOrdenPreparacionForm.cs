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

namespace Pampazon
{
    public partial class GenerarOrdenPreparacionForm : Form
    {
        private GenerarOrdenPreparacionModel model = new();

        public GenerarOrdenPreparacionForm()
        {
            InitializeComponent();

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
            // Handle selection change logic here
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            // Logic for generating the preparation order
        }

        private void LimpiarFiltros(object sender, EventArgs e)
        {
            NombreProductoInput.Clear();
            // Clear other filters if necessary
        }

        private void BuscarProductoBtn(object sender, EventArgs e)
        {
            if(model.Orden.IDCliente == -1) { 
            if(CodigoClienteInput.Text == "" & RazonSocialClienteInput.Text == "")
            {
               DialogResult result = MessageBox.Show($"Ingrese ID cliente o Razon Social");
            }
            else if(CodigoClienteInput.Text != "" & RazonSocialClienteInput.Text != "")
            {
                DialogResult result = MessageBox.Show($"Busque cliente por ID o por Razon Social. Elija una");
                CodigoClienteInput.Text = "";
                RazonSocialClienteInput.Text = "";
            }
            else if(CodigoClienteInput.Text != "" & RazonSocialClienteInput.Text == "")
            {
                int clienteNumber;
                if(!int.TryParse(CodigoClienteInput.Text, out clienteNumber))
                {
                    MessageBox.Show($"Ingrese un numero para buscar ID cliente");
                    CodigoClienteInput.Text = "";
                }
                else if (model.obtenerCliente(clienteNumber) == -1)
                {
                    MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text} no existe. Busque devuelta o por razon Social");
                }
                else
                {
                   model.Orden.changeIDCliente(model.obtenerCliente(clienteNumber));
                   MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text}");
                }
            }else if (CodigoClienteInput.Text == "" & RazonSocialClienteInput.Text != "")
            {
                if(model.obtenerCliente(-1, RazonSocialClienteInput.Text) == -1)
                {
                    MessageBox.Show($"Razon Social {RazonSocialClienteInput.Text} no existe. Busque devuelta o por ID Cliente");
                }
                else
                {
                    model.Orden.changeIDCliente(model.obtenerCliente(-1, RazonSocialClienteInput.Text));
                    CodigoClienteInput.Text = model.Orden.IDCliente.ToString().ToUpper();
                    MessageBox.Show($"ID Cliente seleccionado {CodigoClienteInput.Text}. Razon Social {RazonSocialClienteInput.Text}");
                }
            }
            } // hasta aca llega la seleccioan de cliente



        }
        
        private void ActualizarListaTransportista()
        {
            // Implement transportista list update logic
        }

        private void CancelarOrderBtn(object sender, EventArgs e)
        {
            // Logic to cancel the order
        }

        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)
        {
            // Logic to generate preparation order
        }

        private void VolverBtn(object sender, EventArgs e)
        {
            this.Close();
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

        private void ProductosStockLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
