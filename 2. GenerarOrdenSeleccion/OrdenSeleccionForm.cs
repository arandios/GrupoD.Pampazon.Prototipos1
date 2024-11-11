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
        private List<OrdenPreparacion> ordenesDisponibles = new List<OrdenPreparacion>();
        private List<OrdenPreparacion> ordenesAgregadas = new List<OrdenPreparacion>();

        public OrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void OrdenSeleccionForm_Load_1(object sender, EventArgs e)
        {
            // Habilitar las partes superiores del formulario.
            FiltrosOPGRP.Enabled = true;
            OPGRP.Enabled = true;
            OSGRP.Enabled = false;

            // Habilitar selección múltiple --> Para Ordenes de Preparacion.
            OrdenesDePrepracionAOrdenSeleccionLST.MultiSelect = true;

            // Llenar el ComboBox con los valores del enum CodigoPrioridad
            PrioridadOrdenSeleccionCMB.DataSource = Enum.GetValues(typeof(Prioridades));

            //Borrar filtros que pudieran llegar a quedar precargados.
            BorrarFiltros();

            // Verificar si la lista de órdenes de preparación no está vacía
            if (modelo.OrdenesDePreparacion == null || modelo.OrdenesDePreparacion.Count == 0)
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Establecer la fecha por defecto a 2 años en el futuro
            FechaFinalOrdenSeleccionDTP.Value = DateTime.Now.AddYears(2);

            // CARGAR DATOS A LA LISTA DE ORDENES DE PREPARACION.
            ActualizarListaOrdenDePreparacion();


            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in OrdenesDePrepracionAOrdenSeleccionLST.Columns)
            {
                OrdenesDePrepracionAOrdenSeleccionLST.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in DetalleOrdenesDePreparacionPendientesLST.Columns)
            {
                DetalleOrdenesDePreparacionPendientesLST.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }


        }


        // ==============================================================================
        // EVENTOS DEL FORMULARIO
        // ==============================================================================

        private void BuscarOrdenSeleccionBTN_Click(object sender, EventArgs e) //TODO: Cambiar nombre del metodo a BuscarOrdenesDePreparacionBTN_Click
        {
            // Limpiar la lista actual
            OrdenesDePrepracionAOrdenSeleccionLST.Items.Clear();

            // Obtener los valores de los filtros
            string clienteAFiltrar = ClienteOrdenSeleccionTXT.Text.Trim(); // Razon social cliente
            string idOrdenAFiltrar = NumeroOrdenPreparacionOrdenSeleccionTXT.Text.Trim();
            string prioridadAFiltrar = PrioridadOrdenSeleccionCMB.SelectedItem?.ToString();
            DateTime? fechaInicioAFiltrar = FechaInicioOrdenSeleccionDTP.Value.Date;
            DateTime? fechaFinalAFiltrar = FechaFinalOrdenSeleccionDTP.Value.Date;

            // Verificar si al menos un filtro está completo
            if (string.IsNullOrWhiteSpace(clienteAFiltrar) &&
                string.IsNullOrWhiteSpace(idOrdenAFiltrar) &&
                string.IsNullOrWhiteSpace(prioridadAFiltrar) &&
                fechaInicioAFiltrar == null &&
                fechaFinalAFiltrar == null)
            {
                MessageBox.Show("Por favor, ingrese al menos un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la lista de órdenes de preparación desde el modelo
            var ordenesPreparacion = modelo.OrdenesDePreparacion;

            // Filtrar la lista según los criterios ingresados
            var ordenesFiltradas = ordenesPreparacion
                .Where(op =>
                    (string.IsNullOrEmpty(clienteAFiltrar) || op.DescripcionCliente.Contains(clienteAFiltrar, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || op.IDOrdenPreparacion == idOrdenAFiltrar) &&
                    (string.IsNullOrEmpty(prioridadAFiltrar) || op.Prioridad.ToString() == prioridadAFiltrar) &&
                    (!fechaInicioAFiltrar.HasValue || op.fechaOrdenPreparacion.Date >= fechaInicioAFiltrar.Value) &&  // Filtro inclusivo para la fecha de inicio
                    (!fechaFinalAFiltrar.HasValue || op.fechaOrdenPreparacion.Date <= fechaFinalAFiltrar.Value)        // Filtro inclusivo para la fecha final
                )
                .ToList();

            if (ordenesFiltradas.Any())
            {
                // Agregar las órdenes filtradas al ListView
                foreach (var orden in ordenesFiltradas)
                {
                    // Verificar si el ítem ya existe en DetalleOrdenesDePrepracionAOrdenSeleccionListView
                    if (!OrdenesDePrepracionAOrdenSeleccionLST.Items.Cast<ListViewItem>().Any(item => item.Tag == orden))
                    {
                        var item = new ListViewItem(new[]
                        {
                    orden.IDOrdenPreparacion,
                    orden.DescripcionCliente,
                    orden.fechaOrdenPreparacion.ToString("dd/MM/yyyy"), // Formato de fecha cambiado a DIA/MES/AÑO
                    orden.Prioridad.ToString(),
                });

                        // Asociar el objeto orden como Tag del ListViewItem
                        item.Tag = orden;
                        OrdenesDePrepracionAOrdenSeleccionLST.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron órdenes de preparación con los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void BorrarFiltrosOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de búsqueda
            ClienteOrdenSeleccionTXT.Text = string.Empty;
            //TransportistaTextBoxOrdenSeleccion.Text = string.Empty;
            NumeroOrdenPreparacionOrdenSeleccionTXT.Text = string.Empty;
            PrioridadOrdenSeleccionCMB.SelectedIndex = -1; // Deseleccionar cualquier elemento

            // Restablecer la lista de órdenes de preparación
            ActualizarListaOrdenDePreparacion();

            // Filtrar las órdenes de preparación que no han sido agregadas
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in OrdenesDePrepracionAOrdenSeleccionLST.Items)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                if (ordenesAgregadas.Contains(ordenPreparacion))
                {
                    itemsToRemove.Add(item);
                }
            }

            // Remover los ítems que han sido agregados
            foreach (var item in itemsToRemove)
            {
                OrdenesDePrepracionAOrdenSeleccionLST.Items.Remove(item);
            }
        }



        private void QuitarOrdenPreparacionASeleccionBTN_Click(object sender, EventArgs e)
        {
            // Obtener los elementos seleccionados en OrdenesDePreparacionPendientesListView
            var seleccionados = DetalleOrdenesDePreparacionPendientesLST.SelectedItems;

            if (seleccionados.Count > 0)
            {
                foreach (ListViewItem item in seleccionados)
                {
                    // Eliminar el elemento de OrdenesDePreparacionPendientesListView
                    DetalleOrdenesDePreparacionPendientesLST.Items.Remove(item);

                    // Agregar el elemento a DetalleOrdenesDePrepracionAOrdenSeleccionListView
                    OrdenesDePrepracionAOrdenSeleccionLST.Items.Add(item);

                    // Eliminar el elemento de la lista de órdenes disponibles
                    var ordenPreparacion = (OrdenPreparacion)item.Tag;
                    ordenesDisponibles.Remove(ordenPreparacion);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados para quitar.");
            }
        }

        private void AgregarAOrdenSeleccionBTN_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay elementos seleccionados en la lista de detalles de órdenes de preparación
            if (OrdenesDePrepracionAOrdenSeleccionLST.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden de preparación para crear una orden de selección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de OrdenSeleccion
            var ordenSeleccion = new OrdenSeleccion
            {
                FechaEmision = DateTime.Now,
                OrdenesPreparacion = new List<OrdenPreparacion>(),
                EstadoOrdenDeSeleccion = "Nueva", // Estado inicial de la orden de selección
                FechaEstados = DateTime.Now
            };

            // Agregar las órdenes de preparación seleccionadas a la orden de selección
            foreach (ListViewItem item in OrdenesDePrepracionAOrdenSeleccionLST.SelectedItems)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                ordenSeleccion.OrdenesPreparacion.Add(ordenPreparacion);

                // Verificar si el ítem ya existe en OrdenesDePreparacionPendientesListView
                if (!DetalleOrdenesDePreparacionPendientesLST.Items.Cast<ListViewItem>().Any(existingItem => existingItem.Tag == ordenPreparacion))
                {
                    // Crear un nuevo ítem para la lista de órdenes de preparación pendientes
                    ListViewItem newItem = new ListViewItem();
                    newItem.Text = ordenPreparacion.IDOrdenPreparacion;
                    newItem.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                    newItem.SubItems.Add(ordenPreparacion.fechaOrdenPreparacion.ToString("dd/MM/yyyy"));
                    newItem.SubItems.Add(ordenPreparacion.Prioridad.ToString());

                    newItem.Tag = ordenPreparacion; // Guardar el objeto completo como Tag
                    DetalleOrdenesDePreparacionPendientesLST.Items.Add(newItem);

                    // Agregar a la lista de órdenes agregadas
                    ordenesAgregadas.Add(ordenPreparacion);
                }
            }

            // Ajustar automáticamente el ancho de la columna según el contenido completo
            DetalleOrdenesDePreparacionPendientesLST.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);



            // Eliminar los ítems seleccionados de la lista de detalles de órdenes de preparación
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in OrdenesDePrepracionAOrdenSeleccionLST.SelectedItems)
            {
                itemsToRemove.Add(item);
            }
            foreach (var item in itemsToRemove)
            {
                OrdenesDePrepracionAOrdenSeleccionLST.Items.Remove(item);
            }

            // Habilitar OSgroupBox
            OSGRP.Enabled = true;

            MessageBox.Show("Orden de Preparacion agregada al detalle.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        //Cuando se hace click en "GENERAR ORDEN DE SELECCION"
        private void CrearOrdenSeleccionBTN_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay elementos en la lista OrdenesDePreparacionPendientesListView
            if (DetalleOrdenesDePreparacionPendientesLST.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes de preparación pendientes para crear una orden de selección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de OrdenSeleccionEnt
            var ordenSeleccion = new OrdenSeleccion
            {
                //IDOrdenSeleccion = Guid.NewGuid().ToString(), // Generar un ID único para la orden de selección
                FechaEmision = DateTime.Now,
                OrdenesPreparacion = new List<OrdenPreparacion>(), //Es la lista que hay que pasar al modelo.
                EstadoOrdenDeSeleccion = "Pendiente", // Estado inicial de la orden de selección
                FechaEstados = DateTime.Now
            };

            // Agregar las órdenes de preparación a la orden de selección
            foreach (ListViewItem item in DetalleOrdenesDePreparacionPendientesLST.Items)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                ordenSeleccion.OrdenesPreparacion.Add(ordenPreparacion);
            }

            // Eliminar las órdenes de preparación que se han agregado a la orden de selección de la lista de órdenes disponibles
            foreach (ListViewItem item in DetalleOrdenesDePreparacionPendientesLST.Items)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                ordenesDisponibles.Remove(ordenPreparacion);
            }

            //Le pido al modelo que cree una nueva OS. con esas OP.
            modelo.IngresarOrdenSeleccion(ordenSeleccion.OrdenesPreparacion);

            // Vaciar la lista DetalleOrdenesDePreparacionPendientesListView
            DetalleOrdenesDePreparacionPendientesLST.Items.Clear();

            // Mostrar mensaje de confirmación
            MessageBox.Show($"Se ha creado la orden de selección exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //TODO: PASAR AL MODELO. 
            //Cambiar estado de las ordenes  de preparacion a PROCESAMIENTO. TODO: VERIFICAR
            /*
            foreach (var orden in ordenSeleccion.OrdenesPreparacion)
            {
                orden.EstadoOrdenPreparacion = PosiblesEstadosOrdenesGenerales.Procesamiento;
            }
            */

        }


        // ==============================================================================
        // DEFINICION DE METODOS AUXILIARES:
        // ==============================================================================


        private void ActualizarListaOrdenDePreparacion()
        {
            OrdenesDePrepracionAOrdenSeleccionLST.Items.Clear();

            // CARGAR DATOS A LA LISTA DE ORDENES DE PREPARACION.
            foreach (var ordenPreparacion in modelo.OrdenesDePreparacion)
            {
                if (ordenPreparacion == null || string.IsNullOrEmpty(ordenPreparacion.IDOrdenPreparacion))
                {
                    continue; // Saltar elementos nulos o con ID vacío
                }

                ListViewItem item = new ListViewItem();
                item.Text = ordenPreparacion.IDOrdenPreparacion;
                item.SubItems.Add(ordenPreparacion.DescripcionCliente?.ToString() ?? "Valor por defecto");
                item.SubItems.Add(ordenPreparacion.fechaOrdenPreparacion.ToString("dd/MM/yyyy"));  // Formatear solo la fecha
                item.SubItems.Add(ordenPreparacion.Prioridad.ToString());




                item.Tag = ordenPreparacion; // Guardar el objeto completo como Tag
                OrdenesDePrepracionAOrdenSeleccionLST.Items.Add(item);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in OrdenesDePrepracionAOrdenSeleccionLST.Columns)
            {
                OrdenesDePrepracionAOrdenSeleccionLST.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void BorrarFiltros()
        {
            ClienteOrdenSeleccionTXT.Text = string.Empty;
            NumeroOrdenPreparacionOrdenSeleccionTXT.Text = string.Empty;
            PrioridadOrdenSeleccionCMB.SelectedIndex = -1;
            FechaInicioOrdenSeleccionDTP.Value = DateTime.Now;
            FechaFinalOrdenSeleccionDTP.Value = DateTime.Now;
        }


        //Cerrar ventana.
        private void CancelarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrioridadOrdenSeleccionCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}