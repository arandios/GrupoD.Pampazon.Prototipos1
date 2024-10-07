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
    public partial class OrdenEntregaForm : Form
    {
        public class OrdenEntregaData
        {
            public int NroOrden { get; set; }
            public string FechaEntrega { get; set; }
            public int IdTransportista { get; set; }
            public string NombreTransportista { get; set; }
            public string Estado { get; set; }
        }
        public OrdenEntregaForm()
        {
            InitializeComponent();
            ConfigurarListView();
            AgregarDatos();
            AgregarDatos2();
        }
        private void ConfigurarListView()
        {
            listView2.View = View.Details;
            listView2.FullRowSelect = true;

            listView2.Columns.Add("Nro Orden", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("Fecha de Entrega", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("ID Transportista", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("Nombre Transportista", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("Estado", -2, HorizontalAlignment.Left);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Nro Orden", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Fecha de Entrega", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("ID Transportista", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Nombre Transportista", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Estado", -2, HorizontalAlignment.Left);
        }

        private void AgregarDatos()
        {
            List<OrdenEntregaData> datos = new List<OrdenEntregaData>();

            for (int i = 1; i <= 5; i++)
            {
                datos.Add(new OrdenEntregaData
                {
                    NroOrden = i * 2,
                    FechaEntrega = "2024-10-0" + i,
                    IdTransportista = i,
                    NombreTransportista = "cliente " + i,
                    Estado = "Empaquetado"

                });
            }
            foreach (var dato in datos)
            {
                ListViewItem item = new ListViewItem(dato.NroOrden.ToString());
                item.SubItems.Add(dato.FechaEntrega);
                item.SubItems.Add(dato.IdTransportista.ToString());
                item.SubItems.Add(dato.NombreTransportista);
                item.SubItems.Add(dato.Estado);
                listView2.Items.Add(item);
            }


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

        private void AgregarDatos2()
        {

            List<OrdenEntregaData> datos = new List<OrdenEntregaData>();

            for (int i = 1; i <= 5; i++)
            {
                datos.Add(new OrdenEntregaData
                {
                    NroOrden = i * 2,
                    FechaEntrega = "2024-10-0" + i,
                    IdTransportista = i,
                    NombreTransportista = "cliente " + i * 2,
                    Estado = "Empaquetado"

                });
            }
            foreach (var dato in datos)
            {
                ListViewItem item = new ListViewItem(dato.NroOrden.ToString());
                item.SubItems.Add(dato.FechaEntrega);
                item.SubItems.Add(dato.IdTransportista.ToString());
                item.SubItems.Add(dato.NombreTransportista);
                item.SubItems.Add(dato.Estado);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrdenEntregaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
