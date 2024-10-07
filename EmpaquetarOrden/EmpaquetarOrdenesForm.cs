using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.EmpaquetarOrden
{
    public partial class EmpaquetarOrdenesForm : Form
    {
        private OrdenPreparacionModelo modelo = new OrdenPreparacionModelo();
        public EmpaquetarOrdenesForm()
        {
            InitializeComponent();
        }

        private void EmpaquetarOrdenesForm_Load(object sender, EventArgs e)
        {
            // Cargar la lista con datos al iniciar el formulario
            OrdenesParaPrepararlst.Items.Clear();

            foreach (var orden in modelo.Ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrdenPreparacion);
                item.SubItems.Add(orden.Prioridad.ToString());
                item.Tag = orden; // Almacenar el objeto completo en la propiedad Tag del item
                OrdenesParaPrepararlst.Items.Add(item);
            }

            Codigogrb.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OrdenesParaPrepararlst.Enabled = false;

            // Verificar si hay un ítem seleccionado
            if (OrdenesParaPrepararlst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para ver el detalle.");
                return;
            }

            // Obtener el ítem seleccionado
            var itemSeleccionado = OrdenesParaPrepararlst.SelectedItems[0];
            var ordenSeleccionada = (OrdenPreparacion)itemSeleccionado.Tag;

            // Limpiar el ListView de detalles antes de cargar los nuevos
            OrdenesPreparacionlst.Items.Clear();

            // Mostrar los detalles de la orden seleccionada
            foreach (var detalle in ordenSeleccionada.detalles)
            {
                ListViewItem itemDetalle = new ListViewItem(detalle.Producto.IdProducto.ToString()); // ID del producto
                itemDetalle.SubItems.Add(detalle.Producto.DescripcionProducto); // Descripción del producto
                itemDetalle.SubItems.Add(detalle.Producto.Detalle); // Detalle del producto
                itemDetalle.SubItems.Add(detalle.Cantidad.ToString()); // Cantidad

                // Agregar el detalle al ListView
                OrdenesPreparacionlst.Items.Add(itemDetalle);
            }
        }

        private void ConfirmarOrdenPreparadabtn_Click(object sender, EventArgs e)
        {
            if (OrdenesPreparacionlst.Items.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para confirmar.");
                return;
            }
            var itemSeleccionado = OrdenesParaPrepararlst.SelectedItems[0];
            var idOrden = itemSeleccionado.Text;
            var resultado = MessageBox.Show($"¿Desea confirmar la orden número {idOrden} como preparada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                OrdenesParaPrepararlst.Items.Remove(itemSeleccionado);
                MessageBox.Show($"La orden número {idOrden} ha sido confirmada y eliminada.");
                OrdenesPreparacionlst.Items.Clear();
                OrdenesParaPrepararlst.Enabled = true;

            }
            else
            {

                OrdenesPreparacionlst.Items.Clear();
                OrdenesParaPrepararlst.Enabled = true;

            }
        }

        private void VolverMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarOtraOrdenbtn_Click(object sender, EventArgs e)
        {
            OrdenesParaPrepararlst.Enabled = true;
            OrdenesPreparacionlst.Items.Clear();
        }
    }
}
