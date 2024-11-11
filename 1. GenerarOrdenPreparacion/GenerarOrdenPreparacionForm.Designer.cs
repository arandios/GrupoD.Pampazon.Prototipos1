namespace Pampazon
{
    partial class GenerarOrdenPreparacionForm
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
            components = new System.ComponentModel.Container();
            ProductosStockLST = new ListView();
            SKUColumna = new ColumnHeader();
            ProductosClienteColumna = new ColumnHeader();
            CantColumna = new ColumnHeader();
            OrdenTempLista = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ProductoBuscarBTN = new Button();
            SalirBTN = new Button();
            Generar = new Button();
            button2 = new Button();
            NombreProductoTXT = new TextBox();
            BorrarFiltrosBTN = new Button();
            AgregarProductoBTN = new Button();
            label1 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            CodigoClienteTXT = new TextBox();
            label11 = new Label();
            label10 = new Label();
            RazonSocialClienteTXT = new TextBox();
            SKUProductoLBL = new Label();
            SKUProductoTXT = new TextBox();
            OPMercaderiaGRP = new GroupBox();
            CantidadDisponibleLBL = new Label();
            MaxCantidadTxt = new TextBox();
            AgregarCantidadTXT = new TextBox();
            CantidadRetirarLBL = new Label();
            ProductoSeleccionadoTxt = new TextBox();
            ProductoSelecionadoLBL = new Label();
            label14 = new Label();
            label12 = new Label();
            PrioridadCMB = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            OPDetalleMercaderiaGroupBox = new GroupBox();
            HorarioTextBox = new TextBox();
            label2 = new Label();
            FechaSelecter = new DateTimePicker();
            DniTransportistaCMB = new ComboBox();
            NombreTransportistaCMB = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            OPMercaderiaGRP.SuspendLayout();
            OPDetalleMercaderiaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosStockLST
            // 
            ProductosStockLST.Columns.AddRange(new ColumnHeader[] { SKUColumna, ProductosClienteColumna, CantColumna });
            ProductosStockLST.Location = new Point(10, 20);
            ProductosStockLST.Name = "ProductosStockLST";
            ProductosStockLST.Size = new Size(503, 212);
            ProductosStockLST.TabIndex = 32;
            ProductosStockLST.UseCompatibleStateImageBehavior = false;
            ProductosStockLST.View = View.Details;
            ProductosStockLST.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
            // 
            // SKUColumna
            // 
            SKUColumna.Text = "SKU Producto";
            SKUColumna.Width = 150;
            // 
            // ProductosClienteColumna
            // 
            ProductosClienteColumna.Text = "Producto";
            ProductosClienteColumna.TextAlign = HorizontalAlignment.Center;
            ProductosClienteColumna.Width = 180;
            // 
            // CantColumna
            // 
            CantColumna.Text = "Cantidad disponible";
            CantColumna.TextAlign = HorizontalAlignment.Center;
            CantColumna.Width = 200;
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna });
            OrdenTempLista.Location = new Point(10, 30);
            OrdenTempLista.Margin = new Padding(2);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(487, 152);
            OrdenTempLista.TabIndex = 30;
            OrdenTempLista.UseCompatibleStateImageBehavior = false;
            OrdenTempLista.View = View.Details;
            OrdenTempLista.SelectedIndexChanged += OrdenTempLista_SelectedIndexChanged;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Productos";
            ProductoColumna.Width = 180;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.TextAlign = HorizontalAlignment.Center;
            CantidadColumna.Width = 120;
            // 
            // ProductoBuscarBTN
            // 
            ProductoBuscarBTN.Location = new Point(433, 140);
            ProductoBuscarBTN.Margin = new Padding(2);
            ProductoBuscarBTN.Name = "ProductoBuscarBTN";
            ProductoBuscarBTN.Size = new Size(187, 30);
            ProductoBuscarBTN.TabIndex = 29;
            ProductoBuscarBTN.Text = "&Buscar Productos";
            ProductoBuscarBTN.UseVisualStyleBackColor = true;
            ProductoBuscarBTN.Click += BuscarProductoBtn;
            // 
            // SalirBTN
            // 
            SalirBTN.BackColor = Color.White;
            SalirBTN.Location = new Point(730, 708);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 28;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = false;
            SalirBTN.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = Color.FromArgb(192, 255, 192);
            Generar.Location = new Point(10, 186);
            Generar.Margin = new Padding(2);
            Generar.Name = "Generar";
            Generar.Size = new Size(279, 44);
            Generar.TabIndex = 27;
            Generar.Text = "&Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(293, 186);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(204, 44);
            button2.TabIndex = 22;
            button2.Text = "&Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // NombreProductoTXT
            // 
            NombreProductoTXT.Location = new Point(414, 104);
            NombreProductoTXT.Margin = new Padding(2);
            NombreProductoTXT.Name = "NombreProductoTXT";
            NombreProductoTXT.Size = new Size(413, 23);
            NombreProductoTXT.TabIndex = 23;
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Location = new Point(640, 140);
            BorrarFiltrosBTN.Margin = new Padding(2);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.Size = new Size(187, 30);
            BorrarFiltrosBTN.TabIndex = 36;
            BorrarFiltrosBTN.Text = "&Borrar Filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = true;
            BorrarFiltrosBTN.Click += LimpiarFiltros;
            // 
            // AgregarProductoBTN
            // 
            AgregarProductoBTN.Location = new Point(574, 194);
            AgregarProductoBTN.Margin = new Padding(2);
            AgregarProductoBTN.Name = "AgregarProductoBTN";
            AgregarProductoBTN.Size = new Size(237, 34);
            AgregarProductoBTN.TabIndex = 39;
            AgregarProductoBTN.Text = "&Agregar Productos a la Orden";
            AgregarProductoBTN.UseVisualStyleBackColor = true;
            AgregarProductoBTN.Click += AgregarProductoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 40;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 86);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 53;
            label8.Text = "Nombre Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CodigoClienteTXT);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(NombreProductoTXT);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(RazonSocialClienteTXT);
            groupBox1.Controls.Add(SKUProductoLBL);
            groupBox1.Controls.Add(SKUProductoTXT);
            groupBox1.Controls.Add(ProductoBuscarBTN);
            groupBox1.Controls.Add(BorrarFiltrosBTN);
            groupBox1.Location = new Point(56, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(861, 174);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // CodigoClienteTXT
            // 
            CodigoClienteTXT.Location = new Point(10, 48);
            CodigoClienteTXT.Margin = new Padding(2);
            CodigoClienteTXT.Name = "CodigoClienteTXT";
            CodigoClienteTXT.Size = new Size(369, 23);
            CodigoClienteTXT.TabIndex = 63;
            CodigoClienteTXT.TextChanged += CodigoClienteInput_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 26);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 62;
            label11.Text = "ID cliente";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 26);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 60;
            label10.Text = "Razón Social cliente";
            // 
            // RazonSocialClienteTXT
            // 
            RazonSocialClienteTXT.Location = new Point(414, 48);
            RazonSocialClienteTXT.Margin = new Padding(2);
            RazonSocialClienteTXT.Name = "RazonSocialClienteTXT";
            RazonSocialClienteTXT.Size = new Size(413, 23);
            RazonSocialClienteTXT.TabIndex = 59;
            // 
            // SKUProductoLBL
            // 
            SKUProductoLBL.AutoSize = true;
            SKUProductoLBL.Location = new Point(10, 86);
            SKUProductoLBL.Name = "SKUProductoLBL";
            SKUProductoLBL.Size = new Size(80, 15);
            SKUProductoLBL.TabIndex = 60;
            SKUProductoLBL.Text = "SKU Producto";
            SKUProductoLBL.Click += label7_Click;
            // 
            // SKUProductoTXT
            // 
            SKUProductoTXT.Location = new Point(10, 104);
            SKUProductoTXT.Margin = new Padding(2);
            SKUProductoTXT.Name = "SKUProductoTXT";
            SKUProductoTXT.Size = new Size(369, 23);
            SKUProductoTXT.TabIndex = 59;
            SKUProductoTXT.TextChanged += SKUProductoTXT_TextChanged;
            // 
            // OPMercaderiaGRP
            // 
            OPMercaderiaGRP.Controls.Add(CantidadDisponibleLBL);
            OPMercaderiaGRP.Controls.Add(label1);
            OPMercaderiaGRP.Controls.Add(AgregarProductoBTN);
            OPMercaderiaGRP.Controls.Add(MaxCantidadTxt);
            OPMercaderiaGRP.Controls.Add(AgregarCantidadTXT);
            OPMercaderiaGRP.Controls.Add(ProductosStockLST);
            OPMercaderiaGRP.Controls.Add(CantidadRetirarLBL);
            OPMercaderiaGRP.Controls.Add(ProductoSeleccionadoTxt);
            OPMercaderiaGRP.Controls.Add(ProductoSelecionadoLBL);
            OPMercaderiaGRP.Location = new Point(48, 198);
            OPMercaderiaGRP.Margin = new Padding(3, 2, 3, 2);
            OPMercaderiaGRP.Name = "OPMercaderiaGRP";
            OPMercaderiaGRP.Padding = new Padding(3, 2, 3, 2);
            OPMercaderiaGRP.Size = new Size(867, 234);
            OPMercaderiaGRP.TabIndex = 57;
            OPMercaderiaGRP.TabStop = false;
            OPMercaderiaGRP.Text = "Productos en deposito";
            // 
            // CantidadDisponibleLBL
            // 
            CantidadDisponibleLBL.AutoSize = true;
            CantidadDisponibleLBL.Location = new Point(579, 74);
            CantidadDisponibleLBL.Name = "CantidadDisponibleLBL";
            CantidadDisponibleLBL.Size = new Size(113, 15);
            CantidadDisponibleLBL.TabIndex = 71;
            CantidadDisponibleLBL.Text = "Cantidad disponible";
            // 
            // MaxCantidadTxt
            // 
            MaxCantidadTxt.Location = new Point(574, 92);
            MaxCantidadTxt.Margin = new Padding(2);
            MaxCantidadTxt.Name = "MaxCantidadTxt";
            MaxCantidadTxt.ReadOnly = true;
            MaxCantidadTxt.Size = new Size(237, 23);
            MaxCantidadTxt.TabIndex = 70;
            // 
            // AgregarCantidadTXT
            // 
            AgregarCantidadTXT.Enabled = false;
            AgregarCantidadTXT.Location = new Point(574, 152);
            AgregarCantidadTXT.Margin = new Padding(2);
            AgregarCantidadTXT.MaxLength = 50;
            AgregarCantidadTXT.Name = "AgregarCantidadTXT";
            AgregarCantidadTXT.Size = new Size(237, 23);
            AgregarCantidadTXT.TabIndex = 69;
            // 
            // CantidadRetirarLBL
            // 
            CantidadRetirarLBL.AutoSize = true;
            CantidadRetirarLBL.Location = new Point(574, 134);
            CantidadRetirarLBL.Name = "CantidadRetirarLBL";
            CantidadRetirarLBL.Size = new Size(144, 15);
            CantidadRetirarLBL.TabIndex = 68;
            CantidadRetirarLBL.Text = "Indique Cantidad a Retirar";
            // 
            // ProductoSeleccionadoTxt
            // 
            ProductoSeleccionadoTxt.Location = new Point(573, 38);
            ProductoSeleccionadoTxt.Margin = new Padding(2);
            ProductoSeleccionadoTxt.Name = "ProductoSeleccionadoTxt";
            ProductoSeleccionadoTxt.ReadOnly = true;
            ProductoSeleccionadoTxt.Size = new Size(238, 23);
            ProductoSeleccionadoTxt.TabIndex = 63;
            // 
            // ProductoSelecionadoLBL
            // 
            ProductoSelecionadoLBL.AutoSize = true;
            ProductoSelecionadoLBL.Location = new Point(585, 20);
            ProductoSelecionadoLBL.Name = "ProductoSelecionadoLBL";
            ProductoSelecionadoLBL.Size = new Size(129, 15);
            ProductoSelecionadoLBL.TabIndex = 65;
            ProductoSelecionadoLBL.Text = "Producto Seleccionado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(543, 129);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 66;
            label14.Text = "DNI Transportista:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(543, 188);
            label12.Name = "label12";
            label12.Size = new Size(124, 15);
            label12.TabIndex = 62;
            label12.Text = "Nombre Transportista:";
            // 
            // PrioridadCMB
            // 
            PrioridadCMB.FormattingEnabled = true;
            PrioridadCMB.Location = new Point(543, 100);
            PrioridadCMB.Margin = new Padding(3, 2, 3, 2);
            PrioridadCMB.Name = "PrioridadCMB";
            PrioridadCMB.Size = new Size(307, 23);
            PrioridadCMB.TabIndex = 61;
            PrioridadCMB.SelectedIndexChanged += PrioridadComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 84);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 58;
            label3.Text = "Fecha a retirar:";
            // 
            // OPDetalleMercaderiaGroupBox
            // 
            OPDetalleMercaderiaGroupBox.Controls.Add(HorarioTextBox);
            OPDetalleMercaderiaGroupBox.Controls.Add(label2);
            OPDetalleMercaderiaGroupBox.Controls.Add(FechaSelecter);
            OPDetalleMercaderiaGroupBox.Controls.Add(button2);
            OPDetalleMercaderiaGroupBox.Controls.Add(Generar);
            OPDetalleMercaderiaGroupBox.Controls.Add(DniTransportistaCMB);
            OPDetalleMercaderiaGroupBox.Controls.Add(OrdenTempLista);
            OPDetalleMercaderiaGroupBox.Controls.Add(label3);
            OPDetalleMercaderiaGroupBox.Controls.Add(PrioridadCMB);
            OPDetalleMercaderiaGroupBox.Controls.Add(label4);
            OPDetalleMercaderiaGroupBox.Controls.Add(NombreTransportistaCMB);
            OPDetalleMercaderiaGroupBox.Controls.Add(label14);
            OPDetalleMercaderiaGroupBox.Controls.Add(label12);
            OPDetalleMercaderiaGroupBox.Location = new Point(48, 454);
            OPDetalleMercaderiaGroupBox.Margin = new Padding(3, 2, 3, 2);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Padding = new Padding(3, 2, 3, 2);
            OPDetalleMercaderiaGroupBox.Size = new Size(869, 237);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Orden:";
            // 
            // HorarioTextBox
            // 
            HorarioTextBox.Location = new Point(756, 40);
            HorarioTextBox.Margin = new Padding(2);
            HorarioTextBox.MaxLength = 2;
            HorarioTextBox.Name = "HorarioTextBox";
            HorarioTextBox.Size = new Size(94, 23);
            HorarioTextBox.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(756, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 70;
            label2.Text = "Horario a Retirar:";
            // 
            // FechaSelecter
            // 
            FechaSelecter.AllowDrop = true;
            FechaSelecter.Location = new Point(543, 40);
            FechaSelecter.Margin = new Padding(3, 2, 3, 2);
            FechaSelecter.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            FechaSelecter.MinDate = new DateTime(2024, 10, 17, 0, 16, 31, 0);
            FechaSelecter.Name = "FechaSelecter";
            FechaSelecter.Size = new Size(208, 23);
            FechaSelecter.TabIndex = 59;
            FechaSelecter.Value = new DateTime(2024, 10, 18, 0, 0, 0, 0);
            FechaSelecter.ValueChanged += FechaSelecter_ValueChanged;
            // 
            // DniTransportistaCMB
            // 
            DniTransportistaCMB.FormattingEnabled = true;
            DniTransportistaCMB.Location = new Point(543, 148);
            DniTransportistaCMB.Margin = new Padding(3, 2, 3, 2);
            DniTransportistaCMB.Name = "DniTransportistaCMB";
            DniTransportistaCMB.Size = new Size(307, 23);
            DniTransportistaCMB.TabIndex = 69;
            DniTransportistaCMB.SelectedIndexChanged += DniTransportistaComboBox_SelectedIndexChanged;
            // 
            // NombreTransportistaCMB
            // 
            NombreTransportistaCMB.FormattingEnabled = true;
            NombreTransportistaCMB.Location = new Point(543, 204);
            NombreTransportistaCMB.Margin = new Padding(3, 2, 3, 2);
            NombreTransportistaCMB.Name = "NombreTransportistaCMB";
            NombreTransportistaCMB.Size = new Size(307, 23);
            NombreTransportistaCMB.TabIndex = 68;
            NombreTransportistaCMB.SelectedIndexChanged += NombreTransportistaComboBox_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1004, 796);
            Controls.Add(SalirBTN);
            Controls.Add(OPMercaderiaGRP);
            Controls.Add(groupBox1);
            Controls.Add(OPDetalleMercaderiaGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GenerarOrdenPreparacionForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Orden Preparacion";
            Load += GenerarOrdenPreparacionForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            OPMercaderiaGRP.ResumeLayout(false);
            OPMercaderiaGRP.PerformLayout();
            OPDetalleMercaderiaGroupBox.ResumeLayout(false);
            OPDetalleMercaderiaGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView ProductosStockLST;
        private ColumnHeader ProductosClienteColumna;
        private ColumnHeader CantColumna;
        private ListView OrdenTempLista;
        private ColumnHeader ProductoColumna;
        private Button ProductoBuscarBTN;
        private Button SalirBTN;
        private Button Generar;
        private Button button2;
        private ColumnHeader CantidadColumna;
        private TextBox NombreProductoTXT;
        private Button BorrarFiltrosBTN;
        private Button AgregarProductoBTN;
        private Label label1;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox OPMercaderiaGRP;
        private GroupBox OPDetalleMercaderiaGroupBox;
        private ComboBox PrioridadCMB;
        private Label label4;
        private Label label3;
        private Label SKUProductoLBL;
        private TextBox SKUProductoTXT;
        private Label label10;
        private TextBox RazonSocialClienteTXT;
        private Label label11;
        private TextBox CodigoClienteInput2;
        private ColumnHeader SKUColumna;
        private Label label14;
        private Label label12;
        private ComboBox DniTransportistaCMB;
        private Label CantidadDisponibleLBL;
        protected TextBox MaxCantidadTxt;
        private TextBox AgregarCantidadTXT;
        private Label CantidadRetirarLBL;
        protected TextBox ProductoSeleccionadoTxt;
        private Label ProductoSelecionadoLBL;
        private TextBox CodigoClienteTXT;
        private DateTimePicker FechaSelecter;
        private ComboBox NombreTransportistaCMB;
        private TextBox HorarioTextBox;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
    }
}