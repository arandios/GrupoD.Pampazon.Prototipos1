using Pampazon._4._EmpaquetarOrden;
using Pampazon._6._GenerarRemito;
using Pampazon._8._ConsultarProductos;
using Pampazon.BuscarProductosEnDepositos;
using Pampazon.OrdenSeleccion;
using Pampazon.Remitos;
using Pampazon.Diseño;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.ListarOrdenes;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;

namespace Pampazon.MenuPrincipal
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
            Saludolbl.Text = "Bienvenido " + Environment.UserName;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparar, int lparam);


        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }
      


        private void GenerarOrderPreparacionBtn(object sender, EventArgs e)
        {
            try
            {
                GenerarOrdenPreparacionForm generarOrden = new();
                UIHelper.ConfigurarBotones(generarOrden);
                UIHelper.ConfigurarListViewYAnchoColumnas(generarOrden);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(generarOrden);
                }
                AbrirFormularioEnPanel(generarOrden);
                NombreDePantallaLBL.Text = "Generar Orden de Preparación";
                NombreDePantallaLBL.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el formulario de Orden de Entrega: " + ex.Message);
            }
        }

        private void GenerarOrdenDeSeleccionBTN_Click(object sender, EventArgs e)
        {
            try
            {
                OrdenSeleccionForm ordenSeleccionForm = new();
                UIHelper.ConfigurarBotones(ordenSeleccionForm);
                UIHelper.ConfigurarListViewYAnchoColumnas(ordenSeleccionForm);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(ordenSeleccionForm);
                }
                AbrirFormularioEnPanel(ordenSeleccionForm);
                NombreDePantallaLBL.Text = "Generar Orden de Selección";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void BuscarProductosEnDepositosBTN_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarProductosEnDepositosFormulario AgregarProductosEnDepositosFormulario = new();
                UIHelper.ConfigurarBotones(AgregarProductosEnDepositosFormulario);
                UIHelper.ConfigurarListViewYAnchoColumnas(AgregarProductosEnDepositosFormulario);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(AgregarProductosEnDepositosFormulario);
                }
                AbrirFormularioEnPanel(AgregarProductosEnDepositosFormulario);
                NombreDePantallaLBL.Text = "Buscar Productos en Depósitos";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GenerarOrdenDeEntregabtn_Click(object sender, EventArgs e)
        {
            try
            {
                OrdenEntrega.GenerarOrdenEntregaForm ordenEntregaForm = new();
                UIHelper.ConfigurarBotones(ordenEntregaForm);
                UIHelper.ConfigurarListViewYAnchoColumnas(ordenEntregaForm);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(ordenEntregaForm);
                }
                AbrirFormularioEnPanel(ordenEntregaForm);
                NombreDePantallaLBL.Text = "Generar Orden de Entrega";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el formulario de Orden de Entrega: " + ex.Message);
            }
        }

        private void EmpaquetarOrdenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmpaquetarOrdenForm empaquetarOrdenForm = new();
                UIHelper.ConfigurarBotones(empaquetarOrdenForm);
                UIHelper.ConfigurarListViewYAnchoColumnas(empaquetarOrdenForm);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(empaquetarOrdenForm);
                }
                AbrirFormularioEnPanel(empaquetarOrdenForm);
                NombreDePantallaLBL.Text = "Empaquetar Orden";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GenerarRemitoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarRemitoForm formRemito = new();
                UIHelper.ConfigurarBotones(formRemito);
                UIHelper.ConfigurarListViewYAnchoColumnas(formRemito);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(formRemito);
                }
                AbrirFormularioEnPanel(formRemito);
                NombreDePantallaLBL.Text = "Generar Remito";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void Menu_ConsultarOrdenesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarOrdenesForm formOrdenes = new();
                UIHelper.ConfigurarBotones(formOrdenes);
                UIHelper.ConfigurarListViewYAnchoColumnas(formOrdenes);
                if (panelMenu.Width == 300)
                {
                    AjustarMenuFormulario(formOrdenes);
                }
                AbrirFormularioEnPanel(formOrdenes);
                NombreDePantallaLBL.Text = "Consultar Ordenes";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void BuscarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarProductosForm Formulario = new();
                UIHelper.ConfigurarBotones(Formulario);
                UIHelper.ConfigurarListViewYAnchoColumnas(Formulario);
                if (panelMenu.Width == 300)
                {
                AjustarMenuFormulario(Formulario);
                }
                AbrirFormularioEnPanel(Formulario);
                NombreDePantallaLBL.Text = "Buscar Productos";
                NombreDePantallaLBL.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizarBtn_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm.ActiveForm.WindowState = FormWindowState.Maximized;
            RestaurarBtn.Visible = true;
            MaximizarBtn.Visible = false;
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm.ActiveForm.WindowState = FormWindowState.Normal;
            RestaurarBtn.Visible = false;
            MaximizarBtn.Visible = true;
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pictureBotonMenu_Click(object sender, EventArgs e)
        {
            AjustarMenu();
        }

        private void AjustarMenuFormulario(Form formulario)
        {
            UIHelper.ConfigurarListViewYAnchoColumnas(formulario);

            if (panelMenu.Width == 300)
            {
                panelMenu.Width = 50;
            }
            else panelMenu.Width = 300;
        } 
        private void AjustarMenu()
        {

            if (panelMenu.Width == 300)
            {
                panelMenu.Width = 50;
            }
            else panelMenu.Width = 300;
        }
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
