using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.OrdenEntrega
{
    public partial class OrdenEntrega : Form
    {
        public OrdenEntrega()
        {
            InitializeComponent();
            ConfigurarListView();
            AgregarDatos();
            AgregarDatos2();
            AgregarDatosl3();
            AgregarDatosl2();
        }
        private void ConfigurarListView()
        {
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
         
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
           
        }
        private void AgregarDatos()
        {

            ListViewItem item = new ListViewItem("12345");
            item.SubItems.Add("Entregado");
            item.SubItems.Add("987");
            item.SubItems.Add("2024-10-05");
            item.SubItems.Add("Juan Pérez");
            listView2.Items.Add(item);
        }
        private void AgregarDatos2()
        {
            ListViewItem item = new ListViewItem("12346");
            item.SubItems.Add("Entregado"); // Cambiado el orden de los subitems
            item.SubItems.Add("988");
            item.SubItems.Add("2024-10-06");
            item.SubItems.Add("Juan Domingo Perón");
            listView2.Items.Add(item);
        }
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDatosl2()
        {

            ListViewItem item = new ListViewItem("123");
            item.SubItems.Add("PS5");
            item.SubItems.Add("11");
            listView1.Items.Add(item);
        }
        private void AgregarDatosl3()
        {

            ListViewItem item = new ListViewItem("124");
            item.SubItems.Add("Manzana");
            item.SubItems.Add("9");
            
            listView1.Items.Add(item);

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
