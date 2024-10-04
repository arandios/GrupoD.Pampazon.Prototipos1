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

            // Habilitar selección múltiple --> Para Ordenes de Preparacion.
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.MultiSelect = true;

            // Llenar el ComboBox con los valores del enum CodigoPrioridad
            PrioridadComboBoxOrdenSeleccion.DataSource = Enum.GetValues(typeof(CodigoPrioridad));

            // Verificar si la lista de órdenes de preparación no está vacía
            if (modelo.OrdenesDePreparacion == null || !modelo.OrdenesDePreparacion.Any())
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // CARGAR DATOS A LA LISTA DE ORDENES DE PREPARACION.
            actualizarListaOrdenDePreparacion();
        }

        /*
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

        private void CrearOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos seleccionados en la lista de detalles de órdenes de preparación
            if (DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden de preparación para crear una orden de selección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de OrdenSeleccion
            var ordenSeleccion = new OrdenSeleccion
            {
                IDOrdenSeleccion = Guid.NewGuid().ToString(), // Generar un ID único para la orden de selección
                FechaEmision = DateTime.Now,
                OrdenesPreparacion = new List<OrdenPreparacion>(),
                EstadoOrdenDeSeleccion = "Nueva", // Estado inicial de la orden de selección
                FechaEstados = DateTime.Now
            };

            // Agregar las órdenes de preparación seleccionadas a la orden de selección
            foreach (ListViewItem item in DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedItems)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                ordenSeleccion.OrdenesPreparacion.Add(ordenPreparacion);

                // Crear un nuevo ítem para la lista de órdenes de preparación pendientes
                ListViewItem newItem = new ListViewItem();
                newItem.Text = ordenPreparacion.IDOrdenPreparacion;
                newItem.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                newItem.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                newItem.SubItems.Add(string.Join(", ", ordenPreparacion.Mercaderias.Select(m => m.DescripcionProducto)));
                newItem.SubItems.Add(ordenPreparacion.CantidadMercaderia.ToString());
                newItem.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());
                newItem.SubItems.Add(ordenPreparacion.EstadoOrdenPreparacion.ToString());
                newItem.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                newItem.SubItems.Add(ordenPreparacion.TransportistaDetalle.Nombre);

                newItem.Tag = ordenPreparacion; // Guardar el objeto completo como Tag
                OrdenesDePreparacionPendientesListView.Items.Add(newItem);
            }

            // Eliminar los ítems seleccionados de la lista de detalles de órdenes de preparación
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedItems)
            {
                itemsToRemove.Add(item);
            }
            foreach (var item in itemsToRemove)
            {
                DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Remove(item);
            }

            // Habilitar OSgroupBox
            OSgroupBox.Enabled = true;

            MessageBox.Show("Orden de Preparacion agregada al detalle.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void QuitarOrdenPreparacionASeleccionBTN_Click(object sender, EventArgs e)
        {
            if (OrdenesDePreparacionPendientesListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Seleccione un y solo una Orden de Preparacion para borrar de la lista.");
                return;
            }
            var item = OrdenesDePreparacionPendientesListView.SelectedItems[0];
            var ordenDePreparacionSeleccionada = (OrdenPreparacion)item.Tag;

            var error = modelo.BorrarOrdenDePreparacion(ordenDePreparacionSeleccionada);
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            //La Orden de Preparacion se borro de la lista.
            actualizarListaOrdenDePreparacion();

        }

        private void actualizarListaOrdenDePreparacion()
        {
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Clear();

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

        private void DetalleOrdenesDePrepracionAOrdenSeleccionListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
