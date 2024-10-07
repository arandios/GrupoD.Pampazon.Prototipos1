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
            LstOrdenesSeleccion = new ListView();
            CLNroOrden = new ColumnHeader();
            CLEstado = new ColumnHeader();
            DetallesOrdenBTN = new Button();
            LSTDetalleOrden = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SalirBTN = new Button();
            GenerarOrdenEntregaBTN = new Button();
            CMBEstado = new ComboBox();
            SuspendLayout();
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(725, 76);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(126, 43);
            LimpiarBTN.TabIndex = 16;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(567, 76);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(126, 43);
            BuscarBTN.TabIndex = 15;
            BuscarBTN.Text = "Buscar:";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 44);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 14;
            label1.Text = "ID de Orden Seleccion";
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(78, 82);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(150, 31);
            IdOrdentxt.TabIndex = 13;
            // 
            // LstOrdenesSeleccion
            // 
            LstOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { CLNroOrden, CLEstado });
            LstOrdenesSeleccion.FullRowSelect = true;
            LstOrdenesSeleccion.Location = new Point(99, 140);
            LstOrdenesSeleccion.Margin = new Padding(4, 5, 4, 5);
            LstOrdenesSeleccion.MultiSelect = false;
            LstOrdenesSeleccion.Name = "LstOrdenesSeleccion";
            LstOrdenesSeleccion.Size = new Size(289, 373);
            LstOrdenesSeleccion.TabIndex = 26;
            LstOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            LstOrdenesSeleccion.View = View.Details;
            // 
            // CLNroOrden
            // 
            CLNroOrden.Text = "ID Orden Seleccion";
            CLNroOrden.Width = 175;
            // 
            // CLEstado
            // 
            CLEstado.Text = "Estado";
            CLEstado.Width = 110;
            // 
            // DetallesOrdenBTN
            // 
            DetallesOrdenBTN.Location = new Point(136, 543);
            DetallesOrdenBTN.Name = "DetallesOrdenBTN";
            DetallesOrdenBTN.Size = new Size(221, 63);
            DetallesOrdenBTN.TabIndex = 25;
            DetallesOrdenBTN.Text = "Detalles de Orden";
            DetallesOrdenBTN.UseVisualStyleBackColor = true;
            DetallesOrdenBTN.Click += DetallesOrdenBTN_Click;
            // 
            // LSTDetalleOrden
            // 
            LSTDetalleOrden.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            LSTDetalleOrden.FullRowSelect = true;
            LSTDetalleOrden.Location = new Point(543, 140);
            LSTDetalleOrden.MultiSelect = false;
            LSTDetalleOrden.Name = "LSTDetalleOrden";
            LSTDetalleOrden.Size = new Size(326, 373);
            LSTDetalleOrden.TabIndex = 24;
            LSTDetalleOrden.UseCompatibleStateImageBehavior = false;
            LSTDetalleOrden.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Id Producto";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Producto";
            columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cantidad";
            columnHeader7.Width = 100;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(639, 635);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(178, 58);
            SalirBTN.TabIndex = 27;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // GenerarOrdenEntregaBTN
            // 
            GenerarOrdenEntregaBTN.Location = new Point(612, 535);
            GenerarOrdenEntregaBTN.Name = "GenerarOrdenEntregaBTN";
            GenerarOrdenEntregaBTN.Size = new Size(221, 78);
            GenerarOrdenEntregaBTN.TabIndex = 22;
            GenerarOrdenEntregaBTN.Text = "Confirmar Orden de Seleccion";
            GenerarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            GenerarOrdenEntregaBTN.Click += ConfirmarOrdenSeleccionBTN_Click;
            // 
            // CMBEstado
            // 
            CMBEstado.FormattingEnabled = true;
            CMBEstado.Location = new Point(261, 82);
            CMBEstado.Name = "CMBEstado";
            CMBEstado.Size = new Size(182, 33);
            CMBEstado.TabIndex = 28;
            CMBEstado.Text = "Estado";
            CMBEstado.SelectedIndexChanged += CMBEstado_SelectedIndexChanged;
            // 
            // ConfirmarOrdenSeleccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 718);
            Controls.Add(CMBEstado);
            Controls.Add(LstOrdenesSeleccion);
            Controls.Add(DetallesOrdenBTN);
            Controls.Add(LSTDetalleOrden);
            Controls.Add(SalirBTN);
            Controls.Add(GenerarOrdenEntregaBTN);
            Controls.Add(LimpiarBTN);
            Controls.Add(BuscarBTN);
            Controls.Add(label1);
            Controls.Add(IdOrdentxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private ListView LstOrdenesSeleccion;
        private ColumnHeader CLNroOrden;
        private ColumnHeader CLEstado;
        private Button DetallesOrdenBTN;
        private ListView LSTDetalleOrden;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button SalirBTN;
        private Button GenerarOrdenEntregaBTN;
        private ComboBox CMBEstado;
    }
}