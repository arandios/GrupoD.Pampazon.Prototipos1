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

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in DetalleOrdenesDePrepracionProductosAOrdenSeleccionListView.Columns)
            {
                DetalleOrdenesDePrepracionProductosAOrdenSeleccionListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in OrdenesDePreparacionPendientesListView.Columns)
            {
                OrdenesDePreparacionPendientesListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido del encabezado
            foreach (ColumnHeader column in OrdenesDePreparacionPendientesProductoUbicacionListView.Columns)
            {
                OrdenesDePreparacionPendientesProductoUbicacionListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
            }


        }

        // ==============================================================================
        // EVENTOS DEL FORMULARIO
        // ==============================================================================

        private void BorrarFiltrosOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            //Realizar la busqueda, por los criterios indicados


            //Borrar los campos de busqueda, una vez hecha la busqueda.
            ClienteTextBoxOrdenSeleccion.Text = string.Empty;
            TransportistaTextBoxOrdenSeleccion.Text = string.Empty;
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text = string.Empty;
            PrioridadComboBoxOrdenSeleccion.SelectedIndex = -1; // Deseleccionar cualquier elemento

            // Restablecer la lista de órdenes de preparación
            actualizarListaOrdenDePreparacion();

            // Llamar al método para agrupar y mostrar los productos y ubicaciones
            AgruparOrdenesDePreparacionPendientes();
        }

        private void QuitarOrdenPreparacionASeleccionBTN_Click(object sender, EventArgs e)
        {
            // Obtener los elementos seleccionados en OrdenesDePreparacionPendientesListView
            var seleccionados = OrdenesDePreparacionPendientesListView.SelectedItems;

            if (seleccionados.Count > 0)
            {
                foreach (ListViewItem item in seleccionados)
                {
                    // Eliminar el elemento de OrdenesDePreparacionPendientesListView
                    OrdenesDePreparacionPendientesListView.Items.Remove(item);

                    // Agregar el elemento a DetalleOrdenesDePrepracionAOrdenSeleccionListView
                    DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Add(item);
                }

                // Actualizar la lista OrdenesDePreparacionPendientesProductoUbicacionListView
                AgruparOrdenesDePreparacionPendientes();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados para quitar.");
            }
        }



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
                //newItem.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                newItem.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                //newItem.SubItems.Add(string.Join(", ", ordenPreparacion.Mercaderias.Select(m => m.DescripcionProducto)));
                //newItem.SubItems.Add(ordenPreparacion.CantidadMercaderia.ToString());
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

            // Llamar al método para agrupar y mostrar los productos y ubicaciones
            AgruparOrdenesDePreparacionPendientes();
        }

        private void BuscarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            //Agrego validadores para datos ingresados por el usuario. 
            // Validar que el valor ingresado sea un número entero valido.
            // Verificar si el campo NumeroOrdenPreparacionTextBoxOrdenSeleccion no está vacío
            if (!string.IsNullOrEmpty(NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text))
            {
                // Validar que el valor ingresado sea un número entero
                if (!int.TryParse(NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text, out int idOrden))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                    return;
                }

                // Validar que el número no sea negativo
                if (idOrden < 0)
                {
                    MessageBox.Show("El número de orden no puede ser negativo.");
                    return;
                }

                // Validar que el número no sea demasiado largo
                if (NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text.Length > 3)
                {
                    MessageBox.Show("El número de orden no puede tener más de 3 dígitos.");
                    return;
                }

                // Validar que el número no sea demasiado corto
                if (NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text.Length < 3)
                {
                    MessageBox.Show("El número de orden no puede tener menos de 3 dígitos.");
                    return;
                }
            }

                // Limpiar la lista actual
                DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Clear();

            // Obtener los valores de los filtros
            string cliente = ClienteTextBoxOrdenSeleccion.Text.Trim();
            string transportista = TransportistaTextBoxOrdenSeleccion.Text.Trim();
            string numeroOrdenPreparacion = NumeroOrdenPreparacionTextBoxOrdenSeleccion.Text.Trim();
            string prioridad = PrioridadComboBoxOrdenSeleccion.SelectedItem?.ToString();

            // Verificar si al menos un filtro está completo
            if (string.IsNullOrWhiteSpace(cliente) && string.IsNullOrWhiteSpace(transportista) &&
                string.IsNullOrWhiteSpace(numeroOrdenPreparacion) && string.IsNullOrWhiteSpace(prioridad))
            {
                MessageBox.Show("Por favor, ingrese al menos un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la lista de órdenes de preparación desde el modelo
            var ordenesPreparacion = modelo.OrdenesDePreparacion;

            // Filtrar la lista según los criterios ingresados
            var ordenesFiltradas = ordenesPreparacion.Where(op =>
                (string.IsNullOrWhiteSpace(cliente) || op.DescripcionCliente.Contains(cliente, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(transportista) || op.TransportistaDetalle.Nombre.Contains(transportista, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(numeroOrdenPreparacion) || op.IDOrdenPreparacion.Contains(numeroOrdenPreparacion, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(prioridad) || op.Prioridad.ToString().Equals(prioridad, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            // Agregar las órdenes filtradas al ListView
            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(new[] {
            orden.IDOrdenPreparacion,
            orden.DescripcionCliente,
            orden.FechaOrdenRecepcion.ToString("yyyy-MM-dd"),
            orden.EstadoOrdenPreparacion.ToString(),
            orden.Prioridad.ToString(),
            orden.TransportistaDetalle.Nombre
        });
                DetalleOrdenesDePrepracionAOrdenSeleccionListView.Items.Add(item);
            }

            // Verificar si no se encontraron resultados
            if (!ordenesFiltradas.Any())
            {
                MessageBox.Show("No se encontraron órdenes de preparación con los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CrearOrdenSeleccionBTN_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay elementos en la lista OrdenesDePreparacionPendientesListView
            if (OrdenesDePreparacionPendientesListView.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes de preparación pendientes para crear una orden de selección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Agregar las órdenes de preparación a la orden de selección
            foreach (ListViewItem item in OrdenesDePreparacionPendientesListView.Items)
            {
                var ordenPreparacion = (OrdenPreparacion)item.Tag;
                ordenSeleccion.OrdenesPreparacion.Add(ordenPreparacion);
            }

            // Eliminar los ítems de OrdenesDePreparacionPendientesListView
            OrdenesDePreparacionPendientesListView.Items.Clear();

            // Eliminar los ítems de OrdenesDePreparacionPendientesProductoUbicacionListView
            OrdenesDePreparacionPendientesProductoUbicacionListView.Items.Clear();

            // Mostrar mensaje de confirmación
            MessageBox.Show($"Se ha creado la orden de selección número {ordenSeleccion.IDOrdenSeleccion} exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ajustar el ancho de las columnas automáticamente según el contenido
            foreach (ColumnHeader column in OrdenesDePreparacionPendientesProductoUbicacionListView.Columns)
            {
                OrdenesDePreparacionPendientesProductoUbicacionListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }

        // ==============================================================================
        // FOOTER DE PANTALLA
        // ==============================================================================

        //Cerrar ventana.
        private void CancelarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // ==============================================================================
        // DEFINICION DE METODOS:
        // ==============================================================================
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
                //item.SubItems.Add(ordenPreparacion.IdCliente.ToString()); -->Estos campos los voy a mostrar en la lista de al lado, de detalle. 
                item.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                //item.SubItems.Add(ordenPreparacion.Mercaderias.ToString());
                //item.SubItems.Add(ordenPreparacion.CantidadMercaderia.ToString());
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
            // Limpiar la lista de detalles de productos
            DetalleOrdenesDePrepracionProductosAOrdenSeleccionListView.Items.Clear();

            // Verificar si hay un ítem seleccionado
            if (DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedItems.Count > 0)
            {
                // Obtener la orden de preparación seleccionada
                var selectedItem = DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedItems[0];
                var ordenPreparacion = (OrdenPreparacion)selectedItem.Tag;

                // Agregar los detalles de la mercadería a la lista de productos
                foreach (var mercaderia in ordenPreparacion.Mercaderias)
                {
                    ListViewItem item = new ListViewItem(mercaderia.DescripcionProducto);
                    item.SubItems.Add(mercaderia.Cantidad.ToString());
                    DetalleOrdenesDePrepracionProductosAOrdenSeleccionListView.Items.Add(item);
                }
            }
        }

        private void AgruparOrdenesDePreparacionPendientes()
        {
            // Limpiar la lista actual
            OrdenesDePreparacionPendientesProductoUbicacionListView.Items.Clear();

            // Obtener los elementos de OrdenesDePreparacionPendientesListView
            var items = OrdenesDePreparacionPendientesListView.Items.Cast<ListViewItem>();

            // Agrupar por Producto y Ubicación y sumar la cantidad de mercadería
            var agrupacion = items
                .SelectMany(item => ((OrdenPreparacion)item.Tag).Mercaderias.Select(m => new
                {
                    Producto = m.DescripcionProducto,
                    Ubicacion = m.Ubicacion, // Asumiendo que Mercaderia tiene una propiedad Ubicacion
                    Cantidad = m.Cantidad
                }))
                .GroupBy(x => new { x.Producto, x.Ubicacion })
                .Select(g => new
                {
                    Producto = g.Key.Producto,
                    Ubicacion = g.Key.Ubicacion,
                    CantidadTotal = g.Sum(x => x.Cantidad)
                })
                .ToList();

            // Agregar los resultados agrupados a OrdenesDePreparacionPendientesProductoUbicacionListView
            foreach (var grupo in agrupacion)
            {
                ListViewItem item = new ListViewItem(grupo.Producto);
                item.SubItems.Add(grupo.Ubicacion);
                item.SubItems.Add(grupo.CantidadTotal.ToString());
                OrdenesDePreparacionPendientesProductoUbicacionListView.Items.Add(item);
            }

            // Ajustar el ancho de las columnas automáticamente según el contenido
            foreach (ColumnHeader column in OrdenesDePreparacionPendientesProductoUbicacionListView.Columns)
            {
                OrdenesDePreparacionPendientesProductoUbicacionListView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

    }
}

