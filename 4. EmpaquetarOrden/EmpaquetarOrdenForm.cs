
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

namespace Pampazon._4._EmpaquetarOrden
{
    public partial class EmpaquetarOrdenForm : Form
    {
        private EmpaquetarOrdenModelo modelo = new EmpaquetarOrdenModelo();
        private int indiceActualOrden = 0;
        public EmpaquetarOrdenForm()
        {
            InitializeComponent();
            CargarLista();
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarLista()
        {

            OrdenesParaPrepararLST.Items.Clear();


            if (indiceActualOrden < modelo.ordenesPreparacion.Count)
            {

                OrdenPreparacion ordenActual = modelo.ordenesPreparacion[indiceActualOrden];

                // Recorrer los productos de la orden actual
                foreach (Producto producto in ordenActual.Productos)
                {
                    // Crear un nuevo ítem para cada producto en la orden
                    ListViewItem item = new ListViewItem(producto.SKUProducto); // Muestra SKUProducto
                    item.SubItems.Add(producto.DescripcionProducto);  //  descripción del producto
                    item.SubItems.Add(producto.Cantidad.ToString());  //cantidad

                    // Agregar el ítem al ListView
                    OrdenesParaPrepararLST.Items.Add(item);
                }
            }
            else
            {
                // Mostrar mensaje cuando no haya más ordenes para procesar
                MessageBox.Show("No hay más productos para empaquetar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Confirmarbtn_Click(object sender, EventArgs e)
        {
            // Confirmar si la orden fue empaquetada
            //DialogResult result = MessageBox.Show("¿Confirmar que la orden está preparada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            /*if (result == DialogResult.Yes)
            {*/
                // Incrementar el índice para mostrar la siguiente orden
                indiceActualOrden++;

                // Cargar la siguiente orden si hay más
                CargarLista();
            //}
        }
    }
}
