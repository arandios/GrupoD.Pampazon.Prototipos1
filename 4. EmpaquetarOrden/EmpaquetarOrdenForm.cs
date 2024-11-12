
using Pampazon.Entidades;
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

                // Cargar los productos de la orden actual
                foreach (Producto producto in ordenActual.Productos)
                {
                    ListViewItem item = new ListViewItem(producto.SKUProducto);
                    item.SubItems.Add(producto.DescripcionProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    OrdenesParaPrepararLST.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No hay más productos para empaquetar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Confirmarbtn_Click(object sender, EventArgs e)
        {
            if (indiceActualOrden < modelo.ordenesPreparacion.Count)
            {
                // Obtén la orden actual
                var ordenActual = modelo.ordenesPreparacion[indiceActualOrden];

                // Cambia el estado de la orden actual a "Preparada"
                modelo.CambiarEstadoOrdenPreparacion(int.Parse(ordenActual.IdOrdenPreparacion), EstadoOrdenPreparacionEnum.Preparada);

                // Recarga la lista de órdenes y reinicia el índice
                modelo.CargarOrdenes();
                indiceActualOrden = 0;  // Reinicia el índice para comenzar con la primera orden "Procesada"

                // Carga la primera orden de la lista actualizada
                CargarLista();
            }
        }

        private void OrdenesParaPrepararLST_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
