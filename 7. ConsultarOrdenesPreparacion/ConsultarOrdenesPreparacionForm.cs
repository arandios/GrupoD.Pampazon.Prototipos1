using Pampazon.ConsultarOrdenes;
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

        private void BuscarOrdenes_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CodigoClienteTxt.Text, out int CodCliente))
            {
                MessageBox.Show("Por favor ingrese un codigo de cliente valido");
                return;
            }



        }

        private void BorrarFiltrosBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
