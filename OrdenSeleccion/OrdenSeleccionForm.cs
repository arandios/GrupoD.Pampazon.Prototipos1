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


        private void OrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            //CARGAR DATOS A LA LISTA DE ORDENES DE PREPARACION.
        }


        private void CrearOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            var ordenSeleccion = new OrdenSeleccion();
            //TODO: Pasar datos de la Ordenseleccion (lista), al objeto ordenSeleccion.

            //Carga datos de la Orden de preparacion a la orden de seleccion.
            //ordenSeleccion.Nombre = NombreText.Text;

            //Se lo paso al modelo. 
            /*var error =modelo.IngresarOrdenSeleccion(ordenSeleccion);
             if(error !=null)
            {
            Message.Box(error)
            }
            else{
            Message.Box("Los datos se han ingresado correctamente. ")
            }
             */



        }


        private void BorrarFiltrosOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            //Realizar la busqueda, por los criterios indicados


            //Borrar los campos de busqueda, una vez hecha la busqueda.
            ClienteTextBoxOrdenSeleccion.Text = string.Empty;
            TransportistaTextBoxOrdenSeleccion.Text = string.Empty;
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text = string.Empty;
            PrioridadComboBoxOrdenSeleccion.SelectedIndex = -1; // Deseleccionar cualquier elemento


        }

        //-------------------------------------------------------------- FOOTER DE PANTALLA
        //Cerrar ventana.
        private void CancelarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
