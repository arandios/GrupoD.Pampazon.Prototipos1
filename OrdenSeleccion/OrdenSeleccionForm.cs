using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.OrdenSeleccion
{
    public partial class OrdenSeleccionForm : Form
    {
        //El formulario tiene una referencia al modelo.
        private OrdenSeleccionModelo modelo = new();

        public OrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void CrearOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            var ordenSeleccion = new OrdenSeleccion();
            //TODO: Pasar datos de la Ordenseleccion (lista), al objeto ordenSeleccion.
        }
    }
}
