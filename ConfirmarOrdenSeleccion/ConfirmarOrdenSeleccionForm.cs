﻿using Pampazon.OrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ConfirmarOrdenSeleccion
{
    public partial class ConfirmarOrdenSeleccion : Form
    {
        private ConfirmarOrdenSeleccionModelo modelo;

        public ConfirmarOrdenSeleccion()
        {
            InitializeComponent();
            // Agregar las opciones al ComboBox
            CMBEstado.Items.Add("Pendiente");
            CMBEstado.Items.Add("Confirmada");
            modelo = new ConfirmarOrdenSeleccionModelo(); // Inicializar el modelo
        }

        private void ConfirmarOrdenSeleccion_Load(object sender, EventArgs e)
        {
            // Mostrar las órdenes pendientes inicialmente
            MostrarOrdenesPendientesEnListView();
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para cargar la orden y los productos en los ListView
        private void CargarOrdenSeleccionEnListView(OrdenSeleccion ordenSeleccion)
        {
            // Cargar en el ListView de órdenes
            ListViewItem itemOrden = new ListViewItem(ordenSeleccion.Nro_OrdenS.ToString()); // Nro orden
            itemOrden.SubItems.Add(ordenSeleccion.Estado); // Estado
            itemOrden.SubItems.Add(ordenSeleccion.FechaEmision.ToShortDateString()); // Fecha Emisión
            itemOrden.SubItems.Add(ordenSeleccion.OP_Asociada.ToString()); // OP Asociada

            LstOrdenesSeleccion.Items.Add(itemOrden); // Añadir la orden al ListView
        }

        // Método para cargar los productos en el ListView de productos
        private void CargarProductosEnListView(List<Productos> productos)
        {
            LSTDetalleOrden.Items.Clear(); // Limpiar el ListView de productos antes de agregar nuevos

            foreach (var producto in productos)
            {
                ListViewItem itemProducto = new ListViewItem(producto.Producto_Codigo.ToString()); // Código de Producto
                itemProducto.SubItems.Add(producto.Producto_Nombre); // Nombre del Producto
                itemProducto.SubItems.Add(producto.Cantidad.ToString()); // Cantidad

                LSTDetalleOrden.Items.Add(itemProducto); // Añadir el producto al ListView
            }
        }

        // Método para mostrar las órdenes pendientes en el ListView
        private void MostrarOrdenesPendientesEnListView()
        {
            LstOrdenesSeleccion.Items.Clear(); // Limpiar el ListView de órdenes
            foreach (var orden in modelo.OrdenesPendientes)
            {
                CargarOrdenSeleccionEnListView(orden);
            }
        }

        // Método para mostrar las órdenes confirmadas en el ListView
        private void MostrarOrdenesConfirmadasEnListView()
        {
            LstOrdenesSeleccion.Items.Clear(); // Limpiar el ListView de órdenes
            foreach (var orden in modelo.OrdenesConfirmadas)
            {
                CargarOrdenSeleccionEnListView(orden);
            }
        }

        private void CMBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListViewSegunCategoria();
        }

        private void ActualizarListViewSegunCategoria()
        {
            if (CMBEstado.SelectedItem != null)
            {
                if (CMBEstado.SelectedItem.ToString() == "Confirmada")
                {
                    // Mostrar órdenes confirmadas
                    MostrarOrdenesConfirmadasEnListView();
                }
                else if (CMBEstado.SelectedItem.ToString() == "Pendiente")
                {
                    // Mostrar órdenes pendientes
                    MostrarOrdenesPendientesEnListView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría.");

            }
        }

        private void DetallesOrdenBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesSeleccion.SelectedItems.Count > 0)
            {
                // Obtener el índice de la orden seleccionada
                int selectedIndex = LstOrdenesSeleccion.SelectedIndices[0];

                // Obtener la orden seleccionada
                OrdenSeleccion ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenS == int.Parse(LstOrdenesSeleccion.SelectedItems[0].Text))
                                                    ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenS == int.Parse(LstOrdenesSeleccion.SelectedItems[0].Text));

                if (ordenSeleccionada != null)
                {
                    // Cargar los productos de la orden seleccionada en el ListView
                    CargarProductosEnListView(ordenSeleccionada.Productos);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para ver los detalles.");
            }
        }

        private void ConfirmarOrdenSeleccionBTN_Click(object sender, EventArgs e)
        {
            if (LstOrdenesSeleccion.SelectedItems.Count > 0)
            {
                // Obtener el índice de la orden seleccionada
                int selectedIndex = LstOrdenesSeleccion.SelectedIndices[0];

                // Obtener la orden seleccionada
                OrdenSeleccion ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenS == int.Parse(LstOrdenesSeleccion.SelectedItems[0].Text))
                                                    ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenS == int.Parse(LstOrdenesSeleccion.SelectedItems[0].Text));

                if (ordenSeleccionada != null)
                {
                    // Validar si la orden ya está confirmada
                    if (ordenSeleccionada.Estado == "Confirmada")
                    {
                        MessageBox.Show("La orden ya está confirmada.");
                        return; // Salir si ya está confirmada
                    }

                    // Construir el detalle de la orden con los productos
                    string detalleOrden = $"Orden N°: {ordenSeleccionada.Nro_OrdenS}\n" +
                                          $"Estado actual: {ordenSeleccionada.Estado}\n" +                     
                                          $"Productos:\n";

                    foreach (var producto in ordenSeleccionada.Productos)
                    {
                        detalleOrden += $"- {producto.Producto_Nombre}: {producto.Cantidad} unidades\n";
                    }

                    // Mostrar el MessageBox con opción de Confirmar o Cancelar
                    DialogResult resultado = MessageBox.Show($"¿Desea confirmar la siguiente orden de selección?\n\n{detalleOrden}",
                                                              "Confirmación de Orden de Selección",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes) // Si el usuario elige confirmar
                    {
                        // Confirmar la orden
                        modelo.ConfirmarOrden(ordenSeleccionada);

                        // Mostrar mensaje de éxito
                        MessageBox.Show("La orden ha sido confirmada con éxito.");

                        // Actualizar el ListView con las órdenes pendientes
                        MostrarOrdenesPendientesEnListView();
                    }
                    else if (resultado == DialogResult.No) // Si el usuario elige cancelar
                    {
                        // Mostrar mensaje de cancelación
                        MessageBox.Show("La confirmación de la orden ha sido cancelada con éxito.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para confirmar.");
            }
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            // Validar que la caja de texto no esté vacía
            if (string.IsNullOrEmpty(IdOrdentxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de orden.");
                return;
            }

            // Validar que el valor ingresado sea un número entero
            if (!int.TryParse(IdOrdentxt.Text, out int idOrden))
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
            if (IdOrdentxt.Text.Length > 3)
            {
                MessageBox.Show("El número de orden no puede tener más de 3 dígitos.");
                return;
            }
            // Validar que el número no sea demasiado corto 
            if (IdOrdentxt.Text.Length < 3)
            {
                MessageBox.Show("El número de orden no puede tener menos de 3 dígitos.");
                return;
            }

            // Buscar la orden en las listas de pendientes y confirmadas
            OrdenSeleccion ordenSeleccionada = modelo.OrdenesPendientes.FirstOrDefault(o => o.Nro_OrdenS == idOrden)
                                                ?? modelo.OrdenesConfirmadas.FirstOrDefault(o => o.Nro_OrdenS == idOrden);

            // Validar si la orden existe
            if (ordenSeleccionada == null)
            {
                MessageBox.Show("No se encontró ninguna orden con ese número.");
                return;
            }

            // Limpiar el ListView de órdenes y cargar solo la orden encontrada
            LstOrdenesSeleccion.Items.Clear();
            CargarOrdenSeleccionEnListView(ordenSeleccionada);
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            // Limpiar la caja de texto de búsqueda
            IdOrdentxt.Clear();

            // Limpiar el ListView de productos
            LSTDetalleOrden.Items.Clear();

            // Restaurar siempre las órdenes pendientes
            MostrarOrdenesPendientesEnListView();
        }
    }








}

