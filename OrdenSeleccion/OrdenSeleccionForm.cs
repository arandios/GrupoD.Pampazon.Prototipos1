using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pampazon.OrdenSeleccion
{
    public partial class OrdenSeleccionForm : Form
    {
        //El formulario tiene una referencia al modelo.
        private OrdenSeleccionModelo modelo = new OrdenSeleccionModelo();

        public OrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void OrdenSeleccionForm_Load_1(object sender, EventArgs e)
        {
            // Habilitar las partes superiores del formulario.
            FiltrosOPgroupBox.Enabled = true;
            OPgroupBox.Enabled = true;
            OSgroupBox.Enabled = false;

            // Verificar si la lista de órdenes de preparación no está vacía
            if (modelo.OrdenesDePreparacion == null || !modelo.OrdenesDePreparacion.Any())
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // CARGAR DATOS A LA LISTA DE ORDENES DE PREPARACION.
            foreach (var ordenPreparacion in modelo.OrdenesDePreparacion)
            {
                if (ordenPreparacion == null || string.IsNullOrEmpty(ordenPreparacion.IDOrdenPreparacion))
                {
                    continue; // Saltar elementos nulos o con ID vacío
                }

                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IDOrdenPreparacion;
                item.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                item.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                item.SubItems.Add(ordenPreparacion.Mercaderias.ToString());
                item.SubItems.Add(ordenPreparacion.CantidadMercaderia.ToString());
                item.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());
                item.SubItems.Add(ordenPreparacion.EstadoOrdenPreparacion.ToString());
                item.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                item.SubItems.Add(ordenPreparacion.TransportistaDetalle.Nombre);
                

                item.Tag = ordenPreparacion; // Guardar el objeto completo como Tag
                DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Add(item);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in DetalleOrdenesDePrepracionAOrdenSeleccionListView.Columns)
            {
                DetalleOrdenesDePrepracionAOrdenSeleccionListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
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
