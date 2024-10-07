using Pampazon.OrdenSeleccion;
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

namespace Pampazon.MenuPrincipal
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_ConsultarOrdenesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ListarOrdenes.ListarOrdenesForm formOrdenes = new ListarOrdenes.ListarOrdenesForm();
                formOrdenes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }



        private void GenerarRemitoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Generar_RemitoForms formRemito = new Generar_RemitoForms();
                formRemito.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }



        private void GenerarOrdenDeSeleccionBTN_Click(object sender, EventArgs e)
        {
            try
            {
                OrdenSeleccion.OrdenSeleccionForm ordenSeleccionForm = new OrdenSeleccion.OrdenSeleccionForm();
                ordenSeleccionForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void ConfirmarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmarOrdenSeleccion.ConfirmarOrdenSeleccion confirmarOrdenForm = new ConfirmarOrdenSeleccion.ConfirmarOrdenSeleccion();
                confirmarOrdenForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Confirmation form: " + ex.Message);
            }
        }

        private void GenerarOrdenDeEntregabtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                OrdenEntrega.OrdenEntregaForm ordenEntregaForm = new OrdenEntrega.OrdenEntregaForm();
                ordenEntregaForm.ShowDialog();  
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un error al abrir el formulario de Orden de Entrega: " + ex.Message);
            }
        }
    }
}
