﻿using Pampazon.OrdenSeleccion;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
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

        private void GenerarRemitoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Generar_RemitoForms formRemito = new Generar_RemitoForms();
                formRemito.Show();
                this.Hide(); // Hide current form or consider closing it
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
                OrdenSeleccion.OrdenSeleccion ordenSeleccionForm = new OrdenSeleccion.OrdenSeleccion();
                ordenSeleccionForm.Show();
                this.Hide(); // Hide current form or consider closing it
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }
    }
}
