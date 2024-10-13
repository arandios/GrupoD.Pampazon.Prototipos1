using Pampazon.Remitos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon._6._GenerarRemito
{
    public partial class GenerarRemitoForms : Form
    {
        private GenerarRemitoModelo modelo = new();
        public GenerarRemitoForms()
        {
            InitializeComponent();
            OrdenesDelTransportistaGBX.Enabled = false;
            DetalleRemitoGBX.Enabled = false;   
        }

        private void BuscarTransportistaBtn_Click(object sender, EventArgs e)
        {
            TransportistasListV.Items.Clear();

            // Verificar si el campo de texto est� vac�o
            if (string.IsNullOrWhiteSpace(DNITtxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un n�mero de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dniTexto = DNITtxt.Text;

            // Verificar si el valor ingresado es un n�mero entero
            if (int.TryParse(dniTexto, out int dni))
            {
                // Llamar a ComprobarDni para obtener el mensaje de error (si lo hay)
                string error = GenerarRemitoModelo.ComprobarDni(dni);

                // Si hay un error, mostrarlo
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la lista de transportistas y filtrar los que coinciden con el DNI, lo hace el modelo
                var transportistasEncontrados = GenerarRemitoModelo.ObtenerTransportistas()
                    .Where(t => t.DNI == dni).ToList();

                // Verificar si se encontraron transportistas
                if (transportistasEncontrados.Any())
                {
                    // Agregar cada transportista encontrado a TransportistasListV
                    foreach (var transportista in transportistasEncontrados)
                    {
                        ListViewItem item = new ListViewItem(transportista.IdOrden);
                        TransportistasListV.Items.Add(item);
                    }
                    OrdenesDelTransportistaGBX.Enabled = true;  
                }
                else
                {
                    MessageBox.Show("No se encontr� un transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero de DNI v�lido. Tiene que ser num�rico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega la orden seleccionada y la envia a Detalle remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay órdenes para agregar
            if (TransportistasListV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para agregar. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una lista para almacenar los ítems a eliminar
            var itemsAEliminar = new List<ListViewItem>();

            // Verificar si hay algún ítem seleccionado en TransportistasListV
            foreach (ListViewItem selectedItem in TransportistasListV.Items)
            {
                if (selectedItem.Checked) // Comprobar si el checkbox está seleccionado
                {
                    // Extraer los datos necesarios del ítem seleccionado
                    string idOrden = selectedItem.SubItems[0].Text;
                    DateTime fechaHoy = DateTime.Now.Date;


                    // Verificar si la orden ya fue agregada a DetalleRemitoLTV
                    if (GenerarRemitoModelo.OrdenYaAgregada(idOrden, DetalleRemitoLTV))
                    {
                        MessageBox.Show($"La orden {idOrden} ya ha sido agregada a Detalle Remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Saltar al siguiente ítem
                    }

                    // Crear un nuevo ítem para DetalleRemitoLTV
                    ListViewItem nuevoItem = new ListViewItem(idOrden);
                    nuevoItem.SubItems.Add(fechaHoy.ToShortDateString());


                    // Agregar el nuevo ítem a DetalleRemitoLTV
                    DetalleRemitoLTV.Items.Add(nuevoItem);

                    // Añadir el ítem seleccionado a la lista de eliminación
                    itemsAEliminar.Add(selectedItem);
                }
            }

            // Eliminar los ítems seleccionados de TransportistasListV
            foreach (ListViewItem item in itemsAEliminar)
            {
                TransportistasListV.Items.Remove(item);
            }

            // Habilitar el grupo de detalles del remito
            DetalleRemitoGBX.Enabled = true;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //NO BORRAR
        {
            //NO BORRAR PORQUE SE ROMPE LA PANTALLA//

        }


        /// <summary>
        /// Boton para generar remito a partir de los datos del transportista y la orden
        /// detalladas en la lista "Detalle Remito"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un ítem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para generar un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener todas las órdenes de DetalleRemitoLTV
            var ordenesParaRemito = new List<OrdenesDePreparacion>();
            bool hayOrdenesSeleccionadas = false;

            foreach (ListViewItem item in DetalleRemitoLTV.Items)
            {
                if (item.Checked) // Si el checkbox está seleccionado
                {
                    hayOrdenesSeleccionadas = true; // Marcar que hay órdenes seleccionadas
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                    }
                }
            }

            // Si no hay órdenes seleccionadas, se agregarán todas
            if (!hayOrdenesSeleccionadas)
            {
                foreach (ListViewItem item in DetalleRemitoLTV.Items)
                {
                    string idOrden = item.SubItems[0].Text;
                    OrdenesDePreparacion orden = GenerarRemitoModelo.ObtenerOrdenPorId(idOrden);
                    if (orden != null)
                    {
                        ordenesParaRemito.Add(orden);
                    }
                }
                // Limpiar DetalleRemitoLTV ya que se generará el remito con todas las órdenes
                DetalleRemitoLTV.Items.Clear();
            }

            // Obtener el DNI del transportista desde un control de entrada
            int dniTransportista;
            if (!int.TryParse(DNITtxt.Text, out dniTransportista))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preguntar al usuario si está seguro de generar el remito
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea generar el remito?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Crear el remito a través del modelo
                    Remito nuevoRemito = modelo.GenerarRemito(ordenesParaRemito, dniTransportista);

                    // Mostrar la confirmación del remito
                    MessageBox.Show($"Remito generado:\nTransportista DNI: {nuevoRemito.DNITransportista}\nÓrdenes: {string.Join(", ", nuevoRemito.Ordenes.Select(o => o.IdOrden))}",
                                    "Remito Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar las listas y deshabilitar los grupos si se generó con todas las órdenes
                    if (!hayOrdenesSeleccionadas)
                    {
                        TransportistasListV.Items.Clear();
                        DNITtxt.Clear();
                        BuscarTransportistaGBX.Enabled = true;
                        OrdenesDelTransportistaGBX.Enabled = false;
                        DetalleRemitoGBX.Enabled = false;
                    }
                    else
                    {
                        // Si se generó con algunas órdenes, eliminar solo las seleccionadas de DetalleRemitoLTV
                        foreach (ListViewItem item in DetalleRemitoLTV.Items.Cast<ListViewItem>().ToList())
                        {
                            if (item.Checked)
                            {
                                DetalleRemitoLTV.Items.Remove(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error si hay un problema con la validación
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Cancelar la acción o mostrar un mensaje opcional
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        /// <summary>
        /// Quita la orden seleccionada de la lista Detalle Remito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitarOrdenBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un �tem en DetalleRemitoLTV
            if (DetalleRemitoLTV.Items.Count == 0)
            {
                MessageBox.Show("No hay �rdenes para eliminar de un remito. Agregue al menos una orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay un �tem seleccionado
            if (DetalleRemitoLTV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenSeleccionada = DetalleRemitoLTV.SelectedItems[0];

            // Extraer el n�mero de orden
            string numeroDeOrden = ordenSeleccionada.SubItems[0].Text;

            // Confirmar la acci�n de eliminaci�n
            var result = MessageBox.Show($"�Est� seguro de que desea eliminar la orden: {numeroDeOrden}?",
                                          "Confirmar Eliminaci�n",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del m�todo
            if (result == DialogResult.No)
            {
                return;
            }



            // Eliminar la orden seleccionada
            DetalleRemitoLTV.Items.Remove(ordenSeleccionada);

            MessageBox.Show("Orden eliminada con �xito.", "Orden Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// BOTON DE SALIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            // Confirmar la acci�n
            var result = MessageBox.Show("Esta seguro que desea salir?",
                                          "Confirmar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario elige No, salir del m�todo
            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}

