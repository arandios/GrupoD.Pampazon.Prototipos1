namespace Pampazon.ConfirmarOrdenSeleccion
{
    partial class ConfirmarOrdenSeleccion
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
            LimpiarBTN = new Button();
            BuscarBTN = new Button();
            label1 = new Label();
            IdOrdentxt = new TextBox();
            FechaCMB = new ComboBox();
            LstOrdenesSeleccion = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            DetallesOrdenBTN = new Button();
            LSTDetalleOrden = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SalirBTN = new Button();
            GenerarOrdenEntregaBTN = new Button();
            SuspendLayout();
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(712, 71);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(126, 43);
            LimpiarBTN.TabIndex = 16;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(580, 71);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(126, 43);
            BuscarBTN.TabIndex = 15;
            BuscarBTN.Text = "Buscar:";
            BuscarBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 82);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 14;
            label1.Text = "ID de Orden ";
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(180, 77);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(150, 31);
            IdOrdentxt.TabIndex = 13;
            // 
            // FechaCMB
            // 
            FechaCMB.FormattingEnabled = true;
            FechaCMB.Location = new Point(369, 75);
            FechaCMB.Name = "FechaCMB";
            FechaCMB.Size = new Size(183, 33);
            FechaCMB.TabIndex = 12;
            FechaCMB.Text = "Fecha de Entrega";
            // 
            // LstOrdenesSeleccion
            // 
            LstOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            LstOrdenesSeleccion.Location = new Point(36, 133);
            LstOrdenesSeleccion.Margin = new Padding(4, 5, 4, 5);
            LstOrdenesSeleccion.Name = "LstOrdenesSeleccion";
            LstOrdenesSeleccion.Size = new Size(817, 354);
            LstOrdenesSeleccion.TabIndex = 26;
            LstOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            LstOrdenesSeleccion.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro orden";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha Entrega";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "OP asociada";
            columnHeader4.Width = 120;
            // 
            // DetallesOrdenBTN
            // 
            DetallesOrdenBTN.Location = new Point(41, 500);
            DetallesOrdenBTN.Name = "DetallesOrdenBTN";
            DetallesOrdenBTN.Size = new Size(221, 63);
            DetallesOrdenBTN.TabIndex = 25;
            DetallesOrdenBTN.Text = "Detalles de Orden";
            DetallesOrdenBTN.UseVisualStyleBackColor = true;
            // 
            // LSTDetalleOrden
            // 
            LSTDetalleOrden.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            LSTDetalleOrden.Location = new Point(886, 133);
            LSTDetalleOrden.Name = "LSTDetalleOrden";
            LSTDetalleOrden.Size = new Size(341, 357);
            LSTDetalleOrden.TabIndex = 24;
            LSTDetalleOrden.UseCompatibleStateImageBehavior = false;
            LSTDetalleOrden.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Id Prod";
            columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Producto";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cantidad";
            columnHeader7.Width = 75;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(954, 595);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(178, 58);
            SalirBTN.TabIndex = 27;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // GenerarOrdenEntregaBTN
            // 
            GenerarOrdenEntregaBTN.Location = new Point(940, 500);
            GenerarOrdenEntregaBTN.Name = "GenerarOrdenEntregaBTN";
            GenerarOrdenEntregaBTN.Size = new Size(221, 78);
            GenerarOrdenEntregaBTN.TabIndex = 22;
            GenerarOrdenEntregaBTN.Text = "Generar Orden Entrega";
            GenerarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            // 
            // ConfirmarOrdenSeleccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 715);
            Controls.Add(LstOrdenesSeleccion);
            Controls.Add(DetallesOrdenBTN);
            Controls.Add(LSTDetalleOrden);
            Controls.Add(SalirBTN);
            Controls.Add(GenerarOrdenEntregaBTN);
            Controls.Add(LimpiarBTN);
            Controls.Add(BuscarBTN);
            Controls.Add(label1);
            Controls.Add(IdOrdentxt);
            Controls.Add(FechaCMB);
            Name = "ConfirmarOrdenSeleccion";
            Text = "Confirmar orden de seleccion";
            Load += ConfirmarOrdenSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LimpiarBTN;
        private Button BuscarBTN;
        private Label label1;
        private TextBox IdOrdentxt;
        private ComboBox FechaCMB;
        private ListView LstOrdenesSeleccion;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button DetallesOrdenBTN;
        private ListView LSTDetalleOrden;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button SalirBTN;
        private Button GenerarOrdenEntregaBTN;
    }
}