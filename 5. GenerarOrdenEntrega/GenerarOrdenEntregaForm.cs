using Pampazon._5._GenerarOrdenEntrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pampazon.OrdenEntrega
{
    public partial class GenerarOrdenEntregaForm : Form
    {
        
        private GenerarOrdenEntregaModelo modelo = new GenerarOrdenEntregaModelo();

        public GenerarOrdenEntregaForm()
        {
            InitializeComponent();
            ConfigurarListView();
            CargarLista();
        }

        private void ConfigurarListView()
        {
            Orden_EntregaLST.View = View.Details;
            Orden_EntregaLST.Columns.Add("Id orden de preparación", 250);
            Orden_EntregaLST.Columns.Add("Fecha retiro Orden de Preparación", 250);
        }

        private void CargarLista()
        {
            Orden_EntregaLST.Items.Clear();

            foreach (var orden in modelo.ordenesPreparacion)
            {
                ListViewItem item = new ListViewItem(orden.IdOrdenPreparacion);
                item.SubItems.Add(orden.FechaRetiro.ToString("dd/MM/yyyy"));
                Orden_EntregaLST.Items.Add(item);
            }
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO: CREAR LA ORDEN DE ENTREGA, PASAR AL MODELO! SEGUIR EJEMPLO GENERAR OS
        private void GenerarOrdenEntregabtn_Click(object sender, EventArgs e)
        {

            if (Orden_EntregaLST.Items.Count < 5)
            {
                MessageBox.Show("Error: Debe haber al menos 5 ítems en la lista para generar una orden de entrega.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea generar la orden de entrega?",
                                                  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Orden de entrega generada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia la lista de visualización
                Orden_EntregaLST.Items.Clear();

                // Vuelve a cargar las órdenes de preparación desde el modelo para obtener las nuevas
                modelo.CargarOrdenes();  // Esto asegura que el modelo se actualice con las nuevas órdenes
                modelo.cambiarEstadoOP();
               modelo.CargarOrdenes(); // Refresca el ListView con las órdenes actualizadas
            }
        }
    }
}