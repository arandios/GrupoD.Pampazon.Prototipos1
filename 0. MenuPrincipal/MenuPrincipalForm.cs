using Pampazon._6._GenerarRemito;
using Pampazon.BuscarProductosEnDepositos;
using Pampazon.EmpaquetarOrden;
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
                ListarOrdenes.ConsultarOrdenesForm formOrdenes = new();
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
                GenerarRemitoForms formRemito = new();
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
                OrdenSeleccion.OrdenSeleccionForm ordenSeleccionForm = new();
                ordenSeleccionForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void ConfirmarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {

        }

        private void GenerarOrdenDeEntregabtn_Click(object sender, EventArgs e)
        {
            try
            {

                OrdenEntrega.GenerarOrdenEntregaForm ordenEntregaForm = new();
                ordenEntregaForm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al abrir el formulario de Orden de Entrega: " + ex.Message);
            }
        }


        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)
        {
            try
            {
                GenerarOrdenPreparacionForm generarOrden = new();
                generarOrden.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al abrir el formulario de Orden de Entrega: " + ex.Message);
            }
        }

        private void Confirmar_Orden_EntregaBTN_Click(object sender, EventArgs e)
        {

        }

        private void EmpaquetarOrdenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmpaquetarOrdenesForm empaquetarOrdenForm = new();
                empaquetarOrdenForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void BuscarProductosEnDepositosBTN_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarProductosEnDepositosFormulario AgregarProductosEnDepositosFormulario = new();
                AgregarProductosEnDepositosFormulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
