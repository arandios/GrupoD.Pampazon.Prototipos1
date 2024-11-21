using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pampazon._8._ConsultarProductos
{
    public partial class BuscarProductosForm : Form
    {
        BuscarProductosModelo busquedaProductosModelo = new BuscarProductosModelo();

        public BuscarProductosForm()
        {
            InitializeComponent();
            ProductosLTV.FullRowSelect = true;

            // Asignar el evento KeyDown a los campos de texto
            CodigoClienteTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            RazonSocialTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            CuitTXT.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            SKUTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            NombreProdTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            StockMinimoTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);
            StockMaximoTxt.KeyDown += new KeyEventHandler(CamposTexto_KeyDown);

            // Asignar el evento Leave a los campos de texto
            CodigoClienteTxt.Leave += new EventHandler(CamposTexto_Leave);
            RazonSocialTxt.Leave += new EventHandler(CamposTexto_Leave);
            CuitTXT.Leave += new EventHandler(CamposTexto_Leave);

            // Asignar el evento Resize al formulario

            CargarProductos();
        }

       

        private void CamposTexto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter
                BuscarProductos_Click(sender, e);
                // Poner el foco en el primer ítem de la lista ProductosLTV
                if (ProductosLTV.Items.Count > 0)
                {
                    ProductosLTV.Items[0].Selected = true;
                    ProductosLTV.Items[0].Focused = true;
                    ProductosLTV.EnsureVisible(0);
                    ProductosLTV.Focus();
                }
            }
        }

        private void CamposTexto_Leave(object? sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                AutocompletarCampos(textBox.Text);
            }
        }

        private void CodigoClienteTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodigoClienteTxt.Text))
            {
                RazonSocialTxt.Enabled = false;
                CuitTXT.Enabled = false;
            }
            else
            {
                RazonSocialTxt.Enabled = true;
                CuitTXT.Enabled = true;
            }
        }

        private void RazonSocialTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                CodigoClienteTxt.Enabled = false;
                CuitTXT.Enabled = false;
            }
            else
            {
                CodigoClienteTxt.Enabled = true;
                CuitTXT.Enabled = true;
            }
        }

        private void CuitTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CuitTXT.Text))
            {
                CodigoClienteTxt.Enabled = false;
                RazonSocialTxt.Enabled = false;
            }
            else
            {
                CodigoClienteTxt.Enabled = true;
                RazonSocialTxt.Enabled = true;
            }
        }

        private void AutocompletarCampos(string input)
        {
            var (codigoCliente, razonSocial, cuit) = busquedaProductosModelo.AutocompletarCamposCliente(input);

            if (!string.IsNullOrEmpty(codigoCliente))
            {
                CodigoClienteTxt.Text = codigoCliente;
            }

            if (!string.IsNullOrEmpty(razonSocial))
            {
                RazonSocialTxt.Text = razonSocial;
            }

            if (!string.IsNullOrEmpty(cuit))
            {
                CuitTXT.Text = cuit;
            }
        }

        public void CargarProductos()
        {
            var productos = busquedaProductosModelo.ObtenerProductos();
            ProductosLTV.Items.Clear(); // Limpiar la lista antes de cargar nuevos elementos

            foreach (var producto in productos)
            {
                foreach (var detalle in producto.Detalle)
                {
                    var listViewItem = new ListViewItem(producto.SKU);
                    listViewItem.SubItems.Add(producto.NombreProducto);
                    listViewItem.SubItems.Add(producto.IdCliente);
                    listViewItem.SubItems.Add(busquedaProductosModelo.ObtenerRazonSocialCliente(producto.IdCliente));
                    listViewItem.SubItems.Add(detalle.IdUbicacion);
                    listViewItem.SubItems.Add(detalle.Stock.ToString());
                    ProductosLTV.Items.Add(listViewItem);
                }
            }
        }

        private void BuscarProductos_Click(object? sender, EventArgs e)
        {
            string idCliente = CodigoClienteTxt.Text;
            string rz = RazonSocialTxt.Text;
            string cuit = CuitTXT.Text;
            string sku = SKUTxt.Text;
            string nombreProducto = NombreProdTxt.Text;
            int.TryParse(StockMinimoTxt.Text, out int stockMinimo);
            int.TryParse(StockMaximoTxt.Text, out int stockMaximo);

            List<ProductoBusqueda> productosEncontrados = busquedaProductosModelo.BuscarProductos(idCliente, rz, cuit, sku, nombreProducto, stockMinimo, stockMaximo);

            if (!productosEncontrados.Any())
            {
                MessageBox.Show("No se encontraron productos con los filtros aplicados.");
                ProductosLTV.Items.Clear();
            }
            else
            {
                CargarProductosEnListView(productosEncontrados);
            }
        }

        private void CargarProductosEnListView(List<ProductoBusqueda> productos)
        {
            ProductosLTV.Items.Clear();

            foreach (var producto in productos)
            {
                foreach (var detalle in producto.Detalle)
                {
                    var listViewItem = new ListViewItem(producto.SKU);
                    listViewItem.SubItems.Add(producto.NombreProducto);
                    listViewItem.SubItems.Add(producto.IdCliente);
                    listViewItem.SubItems.Add(busquedaProductosModelo.ObtenerRazonSocialCliente(producto.IdCliente));
                    listViewItem.SubItems.Add(detalle.IdUbicacion);
                    listViewItem.SubItems.Add(detalle.Stock.ToString());
                    ProductosLTV.Items.Add(listViewItem);
                }
            }
        }

        private void BorrarFiltrosBTN_Click(object sender, EventArgs e)
        {
            CodigoClienteTxt.Clear();
            RazonSocialTxt.Clear();
            CuitTXT.Clear();
            SKUTxt.Clear();
            NombreProdTxt.Clear();
            StockMinimoTxt.Clear();
            StockMaximoTxt.Clear();
            CargarProductos();
        }

        private void ProductosLTV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CuitTXT_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
