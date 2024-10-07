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
            LstOrdenesEntrega = new ListView();
            IDOrdenEntregaCOLUMNA = new ColumnHeader();
            EstadoCOLUMNA = new ColumnHeader();
            CantidadClolumna = new ColumnHeader();
            DetallesOrdenBTN = new Button();
            LSTDetalle = new ListView();
            IdOrdenPreparacionCOLUMNA = new ColumnHeader();
            SalirBTN = new Button();
            ConfirmarOrdenEntregaBTN = new Button();
            LimpiarBTN = new Button();
            BuscarBTN = new Button();
            label1 = new Label();
            IdOrdentxt = new TextBox();
            ListadoOrdenesEntregaGRP = new GroupBox();
            FiltrosLBL = new GroupBox();
            DetalleLBL = new GroupBox();
            ListadoOrdenesEntregaGRP.SuspendLayout();
            FiltrosLBL.SuspendLayout();
            DetalleLBL.SuspendLayout();
            SuspendLayout();
            // 
            // CMBEstado
            // 
            CMBEstado.FormattingEnabled = true;
            CMBEstado.Location = new Point(260, 41);
            CMBEstado.Name = "CMBEstado";
            CMBEstado.Size = new Size(182, 33);
            CMBEstado.TabIndex = 38;
            CMBEstado.Text = "Estado";
            CMBEstado.SelectedIndexChanged += CMBEstado_SelectedIndexChanged;
            // 
            // LstOrdenesEntrega
            // 
            LstOrdenesEntrega.Columns.AddRange(new ColumnHeader[] { IDOrdenEntregaCOLUMNA, EstadoCOLUMNA, CantidadClolumna });
            LstOrdenesEntrega.FullRowSelect = true;
            LstOrdenesEntrega.Location = new Point(48, 51);
            LstOrdenesEntrega.Margin = new Padding(4, 5, 4, 5);
            LstOrdenesEntrega.MultiSelect = false;
            LstOrdenesEntrega.Name = "LstOrdenesEntrega";
            LstOrdenesEntrega.Size = new Size(436, 373);
            LstOrdenesEntrega.TabIndex = 36;
            LstOrdenesEntrega.UseCompatibleStateImageBehavior = false;
            LstOrdenesEntrega.View = View.Details;
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
            // CantidadClolumna
            // 
            CantidadClolumna.Text = "Cantidad";
            CantidadClolumna.Width = 120;
            // 
            // DetallesOrdenBTN
            // 
            DetallesOrdenBTN.Location = new Point(161, 443);
            DetallesOrdenBTN.Name = "DetallesOrdenBTN";
            DetallesOrdenBTN.Size = new Size(221, 63);
            DetallesOrdenBTN.TabIndex = 35;
            DetallesOrdenBTN.Text = "Detalles de Orden";
            DetallesOrdenBTN.UseVisualStyleBackColor = true;
            DetallesOrdenBTN.Click += DetallesOrdenBTN_Click;
            // 
            // LSTDetalle
            // 
            LSTDetalle.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionCOLUMNA });
            LSTDetalle.FullRowSelect = true;
            LSTDetalle.Location = new Point(80, 39);
            LSTDetalle.MultiSelect = false;
            LSTDetalle.Name = "LSTDetalle";
            LSTDetalle.Size = new Size(212, 373);
            LSTDetalle.TabIndex = 34;
            LSTDetalle.UseCompatibleStateImageBehavior = false;
            LSTDetalle.View = View.Details;
            // 
            // IdOrdenPreparacionCOLUMNA
            // 
            IdOrdenPreparacionCOLUMNA.Text = "Id Orden Preparacion";
            IdOrdenPreparacionCOLUMNA.Width = 190;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(685, 655);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(212, 58);
            SalirBTN.TabIndex = 37;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // ConfirmarOrdenEntregaBTN
            // 
            ConfirmarOrdenEntregaBTN.Location = new Point(80, 418);
            ConfirmarOrdenEntregaBTN.Name = "ConfirmarOrdenEntregaBTN";
            ConfirmarOrdenEntregaBTN.Size = new Size(212, 65);
            ConfirmarOrdenEntregaBTN.TabIndex = 33;
            ConfirmarOrdenEntregaBTN.Text = "Confirmar Orden de Entrega";
            ConfirmarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenEntregaBTN.Click += ConfirmarOrdenEntregaBTN_Click;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(683, 35);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(126, 43);
            LimpiarBTN.TabIndex = 32;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(525, 36);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(126, 43);
            BuscarBTN.TabIndex = 31;
            BuscarBTN.Text = "Buscar:";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 30;
            label1.Text = "ID de Orden Entrega";
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(36, 59);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(150, 31);
            IdOrdentxt.TabIndex = 29;
            // 
            // ListadoOrdenesEntregaGRP
            // 
            ListadoOrdenesEntregaGRP.Controls.Add(LstOrdenesEntrega);
            ListadoOrdenesEntregaGRP.Controls.Add(DetallesOrdenBTN);
            ListadoOrdenesEntregaGRP.Location = new Point(50, 145);
            ListadoOrdenesEntregaGRP.Name = "ListadoOrdenesEntregaGRP";
            ListadoOrdenesEntregaGRP.Size = new Size(523, 530);
            ListadoOrdenesEntregaGRP.TabIndex = 39;
            ListadoOrdenesEntregaGRP.TabStop = false;
            ListadoOrdenesEntregaGRP.Text = "Listado de Ordenes de Entrega";
            // 
            // FiltrosLBL
            // 
            FiltrosLBL.Controls.Add(CMBEstado);
            FiltrosLBL.Controls.Add(IdOrdentxt);
            FiltrosLBL.Controls.Add(label1);
            FiltrosLBL.Controls.Add(BuscarBTN);
            FiltrosLBL.Controls.Add(LimpiarBTN);
            FiltrosLBL.Location = new Point(110, 21);
            FiltrosLBL.Name = "FiltrosLBL";
            FiltrosLBL.Size = new Size(842, 109);
            FiltrosLBL.TabIndex = 40;
            FiltrosLBL.TabStop = false;
            // 
            // DetalleLBL
            // 
            DetalleLBL.Controls.Add(ConfirmarOrdenEntregaBTN);
            DetalleLBL.Controls.Add(LSTDetalle);
            DetalleLBL.Location = new Point(605, 138);
            DetalleLBL.Name = "DetalleLBL";
            DetalleLBL.Size = new Size(373, 492);
            DetalleLBL.TabIndex = 41;
            DetalleLBL.TabStop = false;
            DetalleLBL.Text = "Detalle";
            // 
            // ConfirmarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 744);
            Controls.Add(DetalleLBL);
            Controls.Add(FiltrosLBL);
            Controls.Add(ListadoOrdenesEntregaGRP);
            Controls.Add(SalirBTN);
            Name = "ConfirmarOrdenEntregaForm";
            Text = "Confirmar Orden de Entrega";
            ListadoOrdenesEntregaGRP.ResumeLayout(false);
            FiltrosLBL.ResumeLayout(false);
            FiltrosLBL.PerformLayout();
            DetalleLBL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CMBEstado;
        private ListView LstOrdenesEntrega;
        private ColumnHeader IDOrdenEntregaCOLUMNA;
        private ColumnHeader EstadoCOLUMNA;
        private Button DetallesOrdenBTN;
        private ListView LSTDetalle;
        private ColumnHeader IdOrdenPreparacionCOLUMNA;
        private Button SalirBTN;
        private Button ConfirmarOrdenEntregaBTN;
        private Button LimpiarBTN;
        private Button BuscarBTN;
        private Label label1;
        private TextBox IdOrdentxt;
        private ColumnHeader CantidadClolumna;
        private GroupBox ListadoOrdenesEntregaGRP;
        private GroupBox FiltrosLBL;
        private GroupBox DetalleLBL;
    }
}