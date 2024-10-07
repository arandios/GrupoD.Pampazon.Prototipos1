namespace Pampazon.ConfirmarOrdenEntrega
{
    partial class ConfirmarOrdenEntregaForm
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
            CMBEstado = new ComboBox();
            LstOrdenesSeleccion = new ListView();
            IDOrdenEntregaCOLUMNA = new ColumnHeader();
            EstadoCOLUMNA = new ColumnHeader();
            DetallesOrdenBTN = new Button();
            LSTDetalleOrden = new ListView();
            IdOrdenPreparacionCOLUMNA = new ColumnHeader();
            SalirBTN = new Button();
            ConfirmarOrdenEntregaBTN = new Button();
            LimpiarBTN = new Button();
            BuscarBTN = new Button();
            label1 = new Label();
            IdOrdentxt = new TextBox();
            CantidadClolumna = new ColumnHeader();
            SuspendLayout();
            // 
            // CMBEstado
            // 
            CMBEstado.FormattingEnabled = true;
            CMBEstado.Location = new Point(282, 65);
            CMBEstado.Name = "CMBEstado";
            CMBEstado.Size = new Size(182, 33);
            CMBEstado.TabIndex = 38;
            CMBEstado.Text = "Estado";
            // 
            // LstOrdenesSeleccion
            // 
            LstOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { IDOrdenEntregaCOLUMNA, EstadoCOLUMNA, CantidadClolumna });
            LstOrdenesSeleccion.FullRowSelect = true;
            LstOrdenesSeleccion.Location = new Point(99, 123);
            LstOrdenesSeleccion.Margin = new Padding(4, 5, 4, 5);
            LstOrdenesSeleccion.MultiSelect = false;
            LstOrdenesSeleccion.Name = "LstOrdenesSeleccion";
            LstOrdenesSeleccion.Size = new Size(434, 373);
            LstOrdenesSeleccion.TabIndex = 36;
            LstOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            LstOrdenesSeleccion.View = View.Details;
            // 
            // IDOrdenEntregaCOLUMNA
            // 
            IDOrdenEntregaCOLUMNA.Text = "ID Orden Entrega";
            IDOrdenEntregaCOLUMNA.Width = 170;
            // 
            // EstadoCOLUMNA
            // 
            EstadoCOLUMNA.Text = "Estado";
            EstadoCOLUMNA.Width = 110;
            // 
            // DetallesOrdenBTN
            // 
            DetallesOrdenBTN.Location = new Point(157, 526);
            DetallesOrdenBTN.Name = "DetallesOrdenBTN";
            DetallesOrdenBTN.Size = new Size(221, 63);
            DetallesOrdenBTN.TabIndex = 35;
            DetallesOrdenBTN.Text = "Detalles de Orden";
            DetallesOrdenBTN.UseVisualStyleBackColor = true;
            // 
            // LSTDetalleOrden
            // 
            LSTDetalleOrden.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionCOLUMNA });
            LSTDetalleOrden.FullRowSelect = true;
            LSTDetalleOrden.Location = new Point(633, 123);
            LSTDetalleOrden.MultiSelect = false;
            LSTDetalleOrden.Name = "LSTDetalleOrden";
            LSTDetalleOrden.Size = new Size(212, 373);
            LSTDetalleOrden.TabIndex = 34;
            LSTDetalleOrden.UseCompatibleStateImageBehavior = false;
            LSTDetalleOrden.View = View.Details;
            // 
            // IdOrdenPreparacionCOLUMNA
            // 
            IdOrdenPreparacionCOLUMNA.Text = "Id Orden Preparacion";
            IdOrdenPreparacionCOLUMNA.Width = 190;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(660, 618);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(178, 58);
            SalirBTN.TabIndex = 37;
            SalirBTN.Text = "&Salir";
            // 
            // ConfirmarOrdenEntregaBTN
            // 
            ConfirmarOrdenEntregaBTN.Location = new Point(633, 518);
            ConfirmarOrdenEntregaBTN.Name = "ConfirmarOrdenEntregaBTN";
            ConfirmarOrdenEntregaBTN.Size = new Size(221, 78);
            ConfirmarOrdenEntregaBTN.TabIndex = 33;
            ConfirmarOrdenEntregaBTN.Text = "Confirmar Orden de Entrega";
            ConfirmarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(746, 59);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(126, 43);
            LimpiarBTN.TabIndex = 32;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(588, 59);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(126, 43);
            BuscarBTN.TabIndex = 31;
            BuscarBTN.Text = "Buscar:";
            BuscarBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 27);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 30;
            label1.Text = "ID de Orden Entrega";
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(99, 65);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(150, 31);
            IdOrdentxt.TabIndex = 29;
            // 
            // CantidadClolumna
            // 
            CantidadClolumna.Text = "Cantidad";
            CantidadClolumna.Width = 120;
            // 
            // ConfirmarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 706);
            Controls.Add(CMBEstado);
            Controls.Add(LstOrdenesSeleccion);
            Controls.Add(DetallesOrdenBTN);
            Controls.Add(LSTDetalleOrden);
            Controls.Add(SalirBTN);
            Controls.Add(ConfirmarOrdenEntregaBTN);
            Controls.Add(LimpiarBTN);
            Controls.Add(BuscarBTN);
            Controls.Add(label1);
            Controls.Add(IdOrdentxt);
            Name = "ConfirmarOrdenEntregaForm";
            Text = "Confirmar Orden de Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CMBEstado;
        private ListView LstOrdenesSeleccion;
        private ColumnHeader IDOrdenEntregaCOLUMNA;
        private ColumnHeader EstadoCOLUMNA;
        private Button DetallesOrdenBTN;
        private ListView LSTDetalleOrden;
        private ColumnHeader IdOrdenPreparacionCOLUMNA;
        private Button SalirBTN;
        private Button ConfirmarOrdenEntregaBTN;
        private Button LimpiarBTN;
        private Button BuscarBTN;
        private Label label1;
        private TextBox IdOrdentxt;
        private ColumnHeader CantidadClolumna;
    }
}