using Pampazon.GenerarOrdenPreparacion;
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
        private List<Orden> ordenes = new List<Orden>();
        public EmpaquetarOrdenesForm()
        {
            InitializeComponent();
        }

        private void EmpaquetarOrdenesForm_Load(object sender, EventArgs e)
        {
            // Cargar la lista con datos al iniciar el formulario
            CargarLista();
        }

        private void CargarLista()
        {
            // Limpiar la lista
            OrdenesParaPrepararlst.Items.Clear();

            // Cargar la lista de órdenes desde el modelo
            foreach (var orden in modelo.Ordenes)
            {
                ListViewItem item = new ListViewItem(orden.IdOrdenPreparacion);
                item.SubItems.Add(orden.Prioridad.ToString());
                item.Tag = orden; // Almacenar el objeto completo en el Tag del ítem
                OrdenesParaPrepararlst.Items.Add(item);
            }



            // Autoseleccionar el primer ítem si la lista tiene elementos
            if (OrdenesParaPrepararlst.Items.Count > 0)
            {
                OrdenesParaPrepararlst.Items[0].Selected = true; // Seleccionar el primer ítem

                // Obtener la orden seleccionada
                var ordenSeleccionada = (OrdenPreparacion)OrdenesParaPrepararlst.Items[0].Tag;

                // Limpiar el ListView de detalles antes de cargar los nuevos detalles
                OrdenesPreparacionlst.Items.Clear();

                // Mostrar los detalles de la orden seleccionada
                foreach (var detalle in ordenSeleccionada.detalles)
                {
                    ListViewItem itemDetalle = new ListViewItem(detalle.Producto.IdProducto.ToString());
                    itemDetalle.SubItems.Add(detalle.Producto.DescripcionProducto + " - " + detalle.Producto.Detalle);

                    itemDetalle.SubItems.Add(detalle.Cantidad.ToString());

                    // Agregar los detalles al ListView
                    OrdenesPreparacionlst.Items.Add(itemDetalle);
                }
            }
        }



        private void ConfirmarOrdenPreparadabtn_Click(object sender, EventArgs e)
        {
            if (OrdenesPreparacionlst.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes para preparar.");
                return;
            }
            var itemSeleccionado = OrdenesParaPrepararlst.SelectedItems[0];
            var idOrden = itemSeleccionado.Text;
            var resultado = MessageBox.Show($"¿Desea confirmar la orden número {idOrden} como preparada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                var ordenAEliminar = modelo.Ordenes.FirstOrDefault(o => o.IdOrdenPreparacion == idOrden);
                if (ordenAEliminar != null)
                {
                    modelo.Ordenes.Remove(ordenAEliminar);  // Eliminar del modelo
                }

                OrdenesParaPrepararlst.Items.Remove(itemSeleccionado);
                MessageBox.Show($"La orden número {idOrden} ha sido confirmada y eliminada.");
                OrdenesPreparacionlst.Items.Clear();
                OrdenesParaPrepararlst.Enabled = true;
                CargarLista();

            }
            else
            {

                OrdenesPreparacionlst.Items.Clear();

            }
        }

        private void VolverMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

