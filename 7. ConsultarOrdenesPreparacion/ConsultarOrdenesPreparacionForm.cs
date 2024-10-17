using Pampazon._7._ConsultarOrdenesPreparacion;
using Pampazon.ConsultarOrdenes;
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
            modelo.InicializarDatos();
            

        }
        private void ListarOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void BuscarOrdenes_Click(object sender, EventArgs e)
        {
            List<OrdenDePreparacion> ordenesEncontradas = new List<OrdenDePreparacion>();

            // Obtener todas las órdenes primero
            var todasLasOrdenes = modelo.ObtenerTodasLasOrdenes();

            // Verificar si hay un código de cliente ingresado
            if (!string.IsNullOrEmpty(CodigoClienteTxt.Text))
            {
                if (int.TryParse(CodigoClienteTxt.Text, out int codigoCliente))
                {
                    // Filtrar las órdenes por el Código de Cliente
                    ordenesEncontradas = todasLasOrdenes.Where(o => o.Cliente.CodigoCliente == codigoCliente).ToList();
                }
            }
            // Si no hay código de cliente, verificar si hay una razón social ingresada
            else if (!string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                // Obtener las órdenes por razón social
                ordenesEncontradas = modelo.ObtenerOrdenesPorRazonSocial(RazonSocialTxt.Text);
            }
            // Si no hay razón social, verificar si hay un CUIT ingresado
            else if (!string.IsNullOrEmpty(CuitTxt.Text))
            {
                // Obtener las órdenes por CUIT
                ordenesEncontradas = modelo.ObtenerOrdenesPorCuit(CuitTxt.Text);
            }
            // Si no se ingresó ningún criterio, verificar si hay filtros adicionales seleccionados
            else if (!string.IsNullOrEmpty(EstadoComboBox.Text) ||
                     !string.IsNullOrEmpty(PrioridadComboBox.Text) ||
                     (FechaInicioDTP.Value.Date != DateTime.Today || FechaFinDTP.Value.Date != DateTime.Today))
            {
                // Si no hay filtros en cliente, buscar todas las órdenes y aplicar los filtros adicionales
                ordenesEncontradas = todasLasOrdenes.ToList();
            }
            // Si no se encontró nada hasta ahora, entonces establecer la lista de órdenes
            if (!ordenesEncontradas.Any())
            {
                ordenesEncontradas = todasLasOrdenes.ToList();
            }

            // Aplicar filtros adicionales (Estado, Prioridad, Fechas) si hay órdenes encontradas
            if (ordenesEncontradas.Any())
            {
                FiltrarPorEstadoPrioridadYFechas(ref ordenesEncontradas);

                // Cargar las órdenes en el ListView
                CargarOrdenesEnListView(ordenesEncontradas);
            }
            else
            {
                MessageBox.Show("No se encontraron órdenes con los criterios ingresados.");
            }
        }

        // Método auxiliar para aplicar los filtros de Estado, Prioridad y Fechas
        private void FiltrarPorEstadoPrioridadYFechas(ref List<OrdenDePreparacion> ordenes)
        {
            // Filtrar por Estado (si se seleccionó uno)
            if (!string.IsNullOrEmpty(EstadoComboBox.Text))
            {
                ordenes = ordenes
                    .Where(o => o.Estado.Equals(EstadoComboBox.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filtrar por Prioridad (si se seleccionó una)
            if (!string.IsNullOrEmpty(PrioridadComboBox.Text))
            {
                ordenes = ordenes
                    .Where(o => o.Prioridad.Equals(PrioridadComboBox.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Verificar si las fechas de los DateTimePickers son diferentes a la fecha predeterminada (hoy)
            DateTime fechaInicioPredeterminada = DateTime.Today;
            if (FechaInicioDTP.Value.Date != fechaInicioPredeterminada || FechaFinDTP.Value.Date != fechaInicioPredeterminada)
            {
                DateTime fechaInicio = FechaInicioDTP.Value.Date;
                DateTime fechaFin = FechaFinDTP.Value.Date;

                // Filtrar por rango de fechas
                ordenes = ordenes
                    .Where(o => o.Fecha.Date >= fechaInicio && o.Fecha.Date <= fechaFin)
                    .ToList();
            }
        }
        private void CargarOrdenesEnListView(List<OrdenDePreparacion> ordenes)
        {
            // Limpiar ListView antes de agregar nuevas órdenes
            OrdenesLTV.Items.Clear();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrden.ToString()); // IdOrdenColumna
                item.SubItems.Add(orden.Fecha.ToShortDateString()); // FechaOPColumna
                item.SubItems.Add(orden.Estado); // EstadoColumna
                item.SubItems.Add(orden.Prioridad); // PrioridadColumna

                OrdenesLTV.Items.Add(item);
            }

            // Autoseleccionar el primer elemento si hay elementos en el ListView
            if (OrdenesLTV.Items.Count > 0)
            {
                OrdenesLTV.Items[0].Selected = true; // Seleccionar el primer elemento
                OrdenesLTV.Items[0].Focused = true;  // Hacerlo el elemento enfocado
                OrdenesLTV.EnsureVisible(0);         // Asegurarse de que el primer elemento sea visible
            }
        }


        private void BorrarFiltrosBtn_Click(object sender, EventArgs e)
        {
            CodigoClienteTxt.Clear();
            RazonSocialTxt.Clear();
            CuitTxt.Clear();
            EstadoComboBox.SelectedIndex = -1;
            PrioridadComboBox.SelectedIndex = -1;
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

                // Obtener la orden de preparación desde el modelo usando el IdOrden
                var ordenSeleccionada = modelo.ObtenerOrdenPorId(idOrdenSeleccionada);

                // Verificar que la orden no sea nula
                if (ordenSeleccionada != null)
                {
                    // Limpiar el ListView de productos
                    ProductoLTV.Items.Clear();

                    // Cargar los productos en el ListView
                    foreach (var producto in ordenSeleccionada.Productos)
                    {
                        var item = new ListViewItem(producto.SKU); // SKU_Columna
                        item.SubItems.Add(producto.Nombre); // Producto_Columna
                        item.SubItems.Add(producto.Cantidad.ToString()); // Cantidad_Columna

                        // Convertir la ubicación a string utilizando el método ToString() de PosicionProducto
                        item.SubItems.Add(producto.Ubicacion.ToString()); // Ubicacion_Columna

                        // Agregar el item al ListView de productos
                        ProductoLTV.Items.Add(item);
                    }
                }
                else
                {
                    // Manejar el caso donde no se encontró la orden
                    MessageBox.Show("No se encontró la orden seleccionada.");
                }
            }
        }




    }
}
