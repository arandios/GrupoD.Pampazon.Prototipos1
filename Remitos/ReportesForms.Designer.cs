

namespace Pampazon.Remitos
{
    partial class ReportesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DetalleTexto = new RichTextBox();
            CausaLista = new ListBox();
            label1 = new Label();
            label2 = new Label();
            GenerarReporteBtn = new Button();
            CancelarReporteBtn = new Button();
            SuspendLayout();
            // 
            // DetalleTexto
            // 
            DetalleTexto.Location = new Point(12, 84);
            DetalleTexto.Name = "DetalleTexto";
            DetalleTexto.Size = new Size(297, 107);
            DetalleTexto.TabIndex = 0;
            DetalleTexto.Text = "";
            // 
            // CausaLista
            // 
            CausaLista.FormattingEnabled = true;
            CausaLista.ItemHeight = 15;
            CausaLista.Items.AddRange(new object[] { "No se encontró transportista", "Fallo de sistema", "Incidentes en orden de entrega", "Otros" });
            CausaLista.Location = new Point(17, 32);
            CausaLista.Name = "CausaLista";
            CausaLista.Size = new Size(210, 19);
            CausaLista.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Causa del reporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Detalle de reporte";
            // 
            // GenerarReporteBtn
            // 
            GenerarReporteBtn.Location = new Point(12, 197);
            GenerarReporteBtn.Name = "GenerarReporteBtn";
            GenerarReporteBtn.Size = new Size(149, 23);
            GenerarReporteBtn.TabIndex = 4;
            GenerarReporteBtn.Text = "Generar reporte";
            GenerarReporteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            GenerarReporteBtn.UseVisualStyleBackColor = true;
            GenerarReporteBtn.Click += GenerarReporteBtn_Click;
            // 
            // CancelarReporteBtn
            // 
            CancelarReporteBtn.Location = new Point(160, 197);
            CancelarReporteBtn.Name = "CancelarReporteBtn";
            CancelarReporteBtn.Size = new Size(149, 23);
            CancelarReporteBtn.TabIndex = 5;
            CancelarReporteBtn.Text = "Cancelar";
            CancelarReporteBtn.UseVisualStyleBackColor = true;
            CancelarReporteBtn.Click += CancelarReporteBtn_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 233);
            Controls.Add(CancelarReporteBtn);
            Controls.Add(GenerarReporteBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CausaLista);
            Controls.Add(DetalleTexto);
            Name = "ReportesForm";
            Text = "Reportes";
            Load += ReportesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private RichTextBox DetalleTexto;
        private ListBox CausaLista;
        private Label label1;
        private Label label2;
        private Button GenerarReporteBtn;
        private Button CancelarReporteBtn;
    }
}