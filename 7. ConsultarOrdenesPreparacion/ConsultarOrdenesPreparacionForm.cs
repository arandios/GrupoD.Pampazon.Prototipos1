using Pampazon._7._ConsultarOrdenesPreparacion;
using Pampazon.Almacenes;
using Pampazon.ConsultarOrdenes;
using Pampazon.Entidades;
using Pampazon.GenerarOrdenPreparacion;
using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ListarOrdenes
{
    public partial class ConsultarOrdenesForm : Form
    {
        ConsultarOrdenesPreparacionModelo modelo = new();

        public ConsultarOrdenesForm()
        {
            InitializeComponent();
            //modelo.InicializarDatos();
            OrdenesLTV.FullRowSelect = true;


        }

        private void CodigoClienteTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CodigoClienteTxt.Text))
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
            if (!string.IsNullOrWhiteSpace(RazonSocialTxt.Text))
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
            if (!string.IsNullOrWhiteSpace(CuitTXT.Text))
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
        private void ListarOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void BuscarOrdenes_Click(object sender, EventArgs e)
        {
            List<OrdenPreparacionEnt> ordenesEncontradas = new List<OrdenPreparacionEnt>();

            // Obtener todas las órdenes primero
            var todasLasOrdenes = modelo.ObtenerTodasLasOrdenes();

            // Verificar si hay un código de cliente ingresado
            if (!string.IsNullOrEmpty(CodigoClienteTxt.Text))
            {
                if (int.TryParse(CodigoClienteTxt.Text, out int codigoCliente))
                {
                    // Filtrar las órdenes por el Código de Cliente
                    ordenesEncontradas = todasLasOrdenes.Where(o => o.IdCliente == codigoCliente).ToList();
                }
            }
            // Si no hay código de cliente, verificar si hay una razón social ingresada
            else if (!string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                // Obtener las órdenes por razón social utilizando el modelo
                ordenesEncontradas = modelo.ObtenerOrdenesPorRazonSocial(RazonSocialTxt.Text);
            }
            // Si no hay razón social, verificar si hay un CUIT ingresado
            else if (!string.IsNullOrEmpty(CuitTXT.Text))
            {
                // Obtener las órdenes por CUIT utilizando el modelo
                ordenesEncontradas = modelo.ObtenerOrdenesPorCuit(CuitTXT.Text);
            }
            // Si no se ingresó ningún criterio, verificar si hay filtros adicionales seleccionados
            else if (!string.IsNullOrEmpty(EstadoCMB.Text) ||
                     !string.IsNullOrEmpty(PrioridadCMB.Text) ||
                     (FechaInicioDTP.Value.Date != DateTime.Today || FechaFinDTP.Value.Date != DateTime.Today))
            {
                // Si no hay filtros en cliente, buscar todas las órdenes y aplicar los filtros adicionales
                ordenesEncontradas = todasLasOrdenes.ToList();
            }

            // Obtener los valores de los controles del formulario para aplicar los filtros
            string estadoSeleccionado = EstadoCMB.Text;
            string prioridadSeleccionada = PrioridadCMB.Text;
            DateTime fechaInicio = FechaInicioDTP.Value.Date;
            DateTime fechaFin = FechaFinDTP.Value.Date;

            // Aplicar filtros adicionales (Estado, Prioridad, Fechas) si hay órdenes encontradas
            if (ordenesEncontradas.Any())
            {
                modelo.FiltrarPorEstadoPrioridadYFechas(ref ordenesEncontradas, estadoSeleccionado, prioridadSeleccionada, fechaInicio, fechaFin);
            }

            // Verificar si después de todos los filtros aún no hay órdenes encontradas
            if (!ordenesEncontradas.Any())
            {
                MessageBox.Show("No se encontraron órdenes con los filtros aplicados.");
                OrdenesLTV.Items.Clear();
                ProductoLTV.Items.Clear();
            }
            else
            {
                // Cargar las órdenes en el ListView
                CargarOrdenesEnListView(ordenesEncontradas);
            }
        }

        private void CargarOrdenesEnListView(List<OrdenPreparacionEnt> ordenes)
        {
            // Limpiar ListView antes de agregar nuevas órdenes
            OrdenesLTV.Items.Clear();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrdenPreparacion.ToString());
                item.SubItems.Add(orden.FechaEmision.ToShortDateString());
                item.SubItems.Add(orden.Estado.ToString()); // Convertimos el enum a string
                item.SubItems.Add(orden.Prioridad.ToString()); // Convertimos el enum a string

                OrdenesLTV.Items.Add(item);
            }

            // Autoseleccionar el primer elemento si hay elementos en el ListView
            if (OrdenesLTV.Items.Count > 0)
            {
                OrdenesLTV.Items[0].Selected = true;
                OrdenesLTV.Items[0].Focused = true;
                OrdenesLTV.EnsureVisible(0);
            }
        }



        private void BorrarFiltrosBtn_Click(object sender, EventArgs e)
        {
            CodigoClienteTxt.Clear();
            RazonSocialTxt.Clear();
            CuitTXT.Clear();
            EstadoCMB.SelectedIndex = -1;
            PrioridadCMB.SelectedIndex = -1;
            FechaInicioDTP.Value = DateTime.Today;
            FechaFinDTP.Value = DateTime.Today;
            OrdenesLTV.Items.Clear();
            ProductoLTV.Items.Clear();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
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

        private void OrdenesLTV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verificar si hay una orden seleccionada
            if (OrdenesLTV.SelectedItems.Count > 0)
            {
                // Obtener el IdOrden de la fila seleccionada
                var itemSeleccionado = OrdenesLTV.SelectedItems[0];
                int idOrdenSeleccionada = int.Parse(itemSeleccionado.SubItems[0].Text); // Asumiendo que IdOrden está en la primera columna

                // Obtener los productos de la orden de preparación desde el modelo usando el IdOrden
                var productos = modelo.ObtenerProductosPorOrdenId(idOrdenSeleccionada);

                // Limpiar el ListView de productos
                ProductoLTV.Items.Clear();

                // Cargar los productos en el ListView
                foreach (var producto in productos)
                {
                    var item = new ListViewItem(producto.SKU); // SKU_Columna
                    item.SubItems.Add(producto.Nombre); // Producto_Columna
                    item.SubItems.Add(producto.Cantidad.ToString()); // Cantidad_Columna

                    // Agregar el item al ListView de productos
                    ProductoLTV.Items.Add(item);
                }
            }
        }


        private void OrdenesGRP_Enter(object sender, EventArgs e)
        {

        }
    }
}
