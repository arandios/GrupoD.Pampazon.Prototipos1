using Pampazon._4._EmpaquetarOrden;
using Pampazon._6._GenerarRemito;
using Pampazon._8._ConsultarProductos;
using Pampazon.BuscarProductosEnDepositos;
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



        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelForms.Controls.Count > 0)
                this.panelForms.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(formHijo);
            this.panelForms.Tag = formHijo;
            formHijo.Show();
        }

        private void Menu_ConsultarOrdenesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ListarOrdenes.ConsultarOrdenesForm formOrdenes = new();
                AbrirFormularioEnPanel(formOrdenes);
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
                GenerarRemitoForm formRemito = new();
                AbrirFormularioEnPanel(formRemito);
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
                AbrirFormularioEnPanel(ordenSeleccionForm);
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
                AbrirFormularioEnPanel(ordenEntregaForm);
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
                AbrirFormularioEnPanel(generarOrden);
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
                EmpaquetarOrdenForm empaquetarOrdenForm = new();
                AbrirFormularioEnPanel(empaquetarOrdenForm);
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
                AbrirFormularioEnPanel(AgregarProductosEnDepositosFormulario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarProductosForm Formulario = new();
                AbrirFormularioEnPanel(Formulario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBotonesConsultas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
