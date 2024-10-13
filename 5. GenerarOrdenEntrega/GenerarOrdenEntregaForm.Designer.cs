namespace Pampazon.OrdenEntrega
{
    partial class GenerarOrdenEntregaForm
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
            Salirbtn = new Button();
            GenerarOrdenEntregabtn = new Button();
            label2 = new Label();
            groupBox3 = new GroupBox();
            Orden_Entrega = new ListView();
            CodOrdenColumna = new ColumnHeader();
            RazonClienteColumna = new ColumnHeader();
            TransportistaColumna = new ColumnHeader();
            fechaOPColumna = new ColumnHeader();
            fechaOEColumna = new ColumnHeader();
            OPColumna = new ColumnHeader();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(757, 816);
            Salirbtn.Margin = new Padding(2, 3, 2, 3);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(214, 53);
            Salirbtn.TabIndex = 17;
            Salirbtn.Text = "&Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.BackColor = Color.FromArgb(192, 255, 192);
            GenerarOrdenEntregabtn.Location = new Point(455, 816);
            GenerarOrdenEntregabtn.Margin = new Padding(2, 3, 2, 3);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(280, 53);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "&Generar/ Confirmar Orden de Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = false;
            GenerarOrdenEntregabtn.Click += GenerarOrdenEntregabtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 219);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Orden_Entrega);
            groupBox3.Location = new Point(0, 35);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(971, 758);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes a despacho:";
            // 
            // Orden_Entrega
            // 
            Orden_Entrega.Columns.AddRange(new ColumnHeader[] { CodOrdenColumna, RazonClienteColumna, TransportistaColumna, fechaOPColumna, fechaOEColumna, OPColumna });
            Orden_Entrega.Location = new Point(9, 36);
            Orden_Entrega.Margin = new Padding(3, 4, 3, 4);
            Orden_Entrega.Name = "Orden_Entrega";
            Orden_Entrega.Size = new Size(956, 714);
            Orden_Entrega.TabIndex = 22;
            Orden_Entrega.UseCompatibleStateImageBehavior = false;
            Orden_Entrega.View = View.Details;
            // 
            // CodOrdenColumna
            // 
            CodOrdenColumna.Text = "Código Orden de Entrega";
            CodOrdenColumna.Width = 160;
            // 
            // RazonClienteColumna
            // 
            RazonClienteColumna.Text = "Razón Social";
            RazonClienteColumna.Width = 160;
            // 
            // TransportistaColumna
            // 
            TransportistaColumna.Text = "Transportista";
            TransportistaColumna.Width = 160;
            // 
            // fechaOPColumna
            // 
            fechaOPColumna.Text = "Fecha Orden de Preparación";
            fechaOPColumna.Width = 160;
            // 
            // fechaOEColumna
            // 
            fechaOEColumna.Text = "Fecha Orden de Entrega";
            fechaOEColumna.Width = 160;
            // 
            // OPColumna
            // 
            OPColumna.Text = "Orden Preparación asociada";
            OPColumna.Width = 160;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(groupBox3);
            Controls.Add(GenerarOrdenEntregabtn);
            Controls.Add(label2);
            Controls.Add(Salirbtn);
            Margin = new Padding(2, 3, 2, 3);
            Name = "GenerarOrdenEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += OrdenEntregaForm_Load;
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Salirbtn;
        private Button GenerarOrdenEntregabtn;
        private Label label2;
        private GroupBox groupBox3;
        private ListView Orden_Entrega;
        private ColumnHeader CodOrdenColumna;
        private ColumnHeader RazonClienteColumna;
        private ColumnHeader TransportistaColumna;
        private ColumnHeader fechaOPColumna;
        private ColumnHeader fechaOEColumna;
        private ColumnHeader OPColumna;
    }
}