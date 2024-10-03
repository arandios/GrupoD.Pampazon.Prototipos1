using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.Reportes;

namespace Pampazon.Remitos
{
    public partial class ReportesForm : Form
    {
        private ReporteFormModelo modelo = new();
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

        }

        private void GenerarReporteBtn_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un ítem en la lista
            if (CausaLista.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una causa de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no hay selección
            }

            // Obtener la causa seleccionada y el texto del RichTextBox
            string causaSeleccionada = CausaLista.SelectedItem.ToString();
            string detalleTexto = DetalleTexto.Text;

            // Crear el contenido a guardar
            string contenidoReporte = $"Causa: {causaSeleccionada}\nDetalles:\n{detalleTexto}";

            // Definir la ruta y el nombre del archivo
            string rutaArchivo = "reporte.txt"; // Puedes cambiar esto a la ubicación deseada

            try
            {
                // Guardar el contenido en el archivo
                System.IO.File.WriteAllText(rutaArchivo, contenidoReporte);
                MessageBox.Show("Reporte generado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarReporteBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el reporte?",
                                            "Confirmar Cancelación",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí", cerrar la ventana
            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana actual
            }
        }
    }
}
