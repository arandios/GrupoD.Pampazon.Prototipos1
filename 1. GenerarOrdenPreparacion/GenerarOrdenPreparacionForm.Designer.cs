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
            ProductosStockLista = new ListView();
            SKU_columna = new ColumnHeader();
            ProductosCliente = new ColumnHeader();
            Cant_Columna = new ColumnHeader();
            OrdenTempLista = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ProductoBuscar = new Button();
            button3 = new Button();
            Generar = new Button();
            button2 = new Button();
            NombreProductoInput = new TextBox();
            button5 = new Button();
            AgregarProductoBtn = new Button();
            label1 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            CodigoClienteInput = new TextBox();
            label11 = new Label();
            label10 = new Label();
            RazonSocialClienteInput = new TextBox();
            SKUProductoLBL = new Label();
            SKUProductoInput = new TextBox();
            OPMercaderiaGroupBox = new GroupBox();
            label5 = new Label();
            MaxCantidadTxt = new TextBox();
            AgregarCantidadTextBox = new TextBox();
            label9 = new Label();
            ProductoSeleccionadoTxt = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            PrioridadComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            OPDetalleMercaderiaGroupBox = new GroupBox();
            HorarioTextBox = new TextBox();
            label2 = new Label();
            FechaSelecter = new DateTimePicker();
            DniTransportistaComboBox = new ComboBox();
            NombreTransportistaComboBox = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            OPMercaderiaGroupBox.SuspendLayout();
            OPDetalleMercaderiaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosStockLista
            // 
            ProductosStockLista.Columns.AddRange(new ColumnHeader[] { SKU_columna, ProductosCliente, Cant_Columna });
            ProductosStockLista.Location = new Point(14, 33);
            ProductosStockLista.Margin = new Padding(4, 5, 4, 5);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(717, 351);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
            ProductosStockLista.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
            // 
            // SKU_columna
            // 
            SKU_columna.Text = "SKU Producto";
            SKU_columna.Width = 150;
            // 
            // ProductosCliente
            // 
            ProductosCliente.Text = "Producto";
            ProductosCliente.TextAlign = HorizontalAlignment.Center;
            ProductosCliente.Width = 180;
            // 
            // Cant_Columna
            // 
            Cant_Columna.Text = "Cantidad disponible";
            Cant_Columna.TextAlign = HorizontalAlignment.Center;
            Cant_Columna.Width = 200;
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna });
            OrdenTempLista.Location = new Point(14, 50);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(694, 251);
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
            // ProductoBuscar
            // 
            ProductoBuscar.Location = new Point(619, 233);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(267, 50);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "&Buscar Productos";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(1043, 1180);
            button3.Name = "button3";
            button3.Size = new Size(267, 67);
            button3.TabIndex = 28;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = Color.FromArgb(192, 255, 192);
            Generar.Location = new Point(14, 310);
            Generar.Name = "Generar";
            Generar.Size = new Size(399, 73);
            Generar.TabIndex = 27;
            Generar.Text = "&Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(419, 310);
            button2.Name = "button2";
            button2.Size = new Size(291, 73);
            button2.TabIndex = 22;
            button2.Text = "&Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // NombreProductoInput
            // 
            NombreProductoInput.Location = new Point(591, 172);
            NombreProductoInput.Name = "NombreProductoInput";
            NombreProductoInput.Size = new Size(588, 31);
            NombreProductoInput.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(914, 233);
            button5.Name = "button5";
            button5.Size = new Size(267, 50);
            button5.TabIndex = 36;
            button5.Text = "&Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // AgregarProductoBtn
            // 
            AgregarProductoBtn.Location = new Point(820, 323);
            AgregarProductoBtn.Name = "AgregarProductoBtn";
            AgregarProductoBtn.Size = new Size(339, 58);
            AgregarProductoBtn.TabIndex = 39;
            AgregarProductoBtn.Text = "&Agregar Productos a la Orden";
            AgregarProductoBtn.UseVisualStyleBackColor = true;
            AgregarProductoBtn.Click += AgregarProductoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 40;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 143);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 25);
            label8.TabIndex = 53;
            label8.Text = "Nombre Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CodigoClienteInput);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(NombreProductoInput);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(RazonSocialClienteInput);
            groupBox1.Controls.Add(SKUProductoLBL);
            groupBox1.Controls.Add(SKUProductoInput);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(80, 33);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1230, 290);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // CodigoClienteInput
            // 
            CodigoClienteInput.Location = new Point(14, 80);
            CodigoClienteInput.Name = "CodigoClienteInput";
            CodigoClienteInput.Size = new Size(525, 31);
            CodigoClienteInput.TabIndex = 63;
            CodigoClienteInput.TextChanged += CodigoClienteInput_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 43);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 25);
            label11.TabIndex = 62;
            label11.Text = "Código cliente";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(591, 43);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 60;
            label10.Text = "Razón Social cliente";
            // 
            // RazonSocialClienteInput
            // 
            RazonSocialClienteInput.Location = new Point(591, 80);
            RazonSocialClienteInput.Name = "RazonSocialClienteInput";
            RazonSocialClienteInput.Size = new Size(588, 31);
            RazonSocialClienteInput.TabIndex = 59;
            // 
            // SKUProductoLBL
            // 
            SKUProductoLBL.AutoSize = true;
            SKUProductoLBL.Location = new Point(14, 143);
            SKUProductoLBL.Margin = new Padding(4, 0, 4, 0);
            SKUProductoLBL.Name = "SKUProductoLBL";
            SKUProductoLBL.Size = new Size(122, 25);
            SKUProductoLBL.TabIndex = 60;
            SKUProductoLBL.Text = "SKU Producto";
            SKUProductoLBL.Click += label7_Click;
            // 
            // SKUProductoInput
            // 
            SKUProductoInput.Location = new Point(14, 172);
            SKUProductoInput.Name = "SKUProductoInput";
            SKUProductoInput.Size = new Size(525, 31);
            SKUProductoInput.TabIndex = 59;
            // 
            // OPMercaderiaGroupBox
            // 
            OPMercaderiaGroupBox.Controls.Add(label5);
            OPMercaderiaGroupBox.Controls.Add(label1);
            OPMercaderiaGroupBox.Controls.Add(AgregarProductoBtn);
            OPMercaderiaGroupBox.Controls.Add(MaxCantidadTxt);
            OPMercaderiaGroupBox.Controls.Add(AgregarCantidadTextBox);
            OPMercaderiaGroupBox.Controls.Add(ProductosStockLista);
            OPMercaderiaGroupBox.Controls.Add(label9);
            OPMercaderiaGroupBox.Controls.Add(ProductoSeleccionadoTxt);
            OPMercaderiaGroupBox.Controls.Add(label15);
            OPMercaderiaGroupBox.Location = new Point(69, 330);
            OPMercaderiaGroupBox.Margin = new Padding(4, 3, 4, 3);
            OPMercaderiaGroupBox.Name = "OPMercaderiaGroupBox";
            OPMercaderiaGroupBox.Padding = new Padding(4, 3, 4, 3);
            OPMercaderiaGroupBox.Size = new Size(1239, 390);
            OPMercaderiaGroupBox.TabIndex = 57;
            OPMercaderiaGroupBox.TabStop = false;
            OPMercaderiaGroupBox.Text = "Productos en deposito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(827, 123);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 71;
            label5.Text = "Cantidad disponible";
            // 
            // MaxCantidadTxt
            // 
            MaxCantidadTxt.Location = new Point(820, 152);
            MaxCantidadTxt.Name = "MaxCantidadTxt";
            MaxCantidadTxt.ReadOnly = true;
            MaxCantidadTxt.Size = new Size(337, 31);
            MaxCantidadTxt.TabIndex = 70;
            // 
            // AgregarCantidadTextBox
            // 
            AgregarCantidadTextBox.Enabled = false;
            AgregarCantidadTextBox.Location = new Point(820, 252);
            AgregarCantidadTextBox.MaxLength = 50;
            AgregarCantidadTextBox.Name = "AgregarCantidadTextBox";
            AgregarCantidadTextBox.Size = new Size(337, 31);
            AgregarCantidadTextBox.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(820, 223);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(217, 25);
            label9.TabIndex = 68;
            label9.Text = "Indique Cantidad a Retirar";
            // 
            // ProductoSeleccionadoTxt
            // 
            ProductoSeleccionadoTxt.Location = new Point(819, 62);
            ProductoSeleccionadoTxt.Name = "ProductoSeleccionadoTxt";
            ProductoSeleccionadoTxt.ReadOnly = true;
            ProductoSeleccionadoTxt.Size = new Size(338, 31);
            ProductoSeleccionadoTxt.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(836, 33);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(194, 25);
            label15.TabIndex = 65;
            label15.Text = "Producto Seleccionado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(776, 215);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(153, 25);
            label14.TabIndex = 66;
            label14.Text = "DNI Transportista:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(776, 312);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(188, 25);
            label12.TabIndex = 62;
            label12.Text = "Nombre Transportista:";
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Location = new Point(776, 168);
            PrioridadComboBox.Margin = new Padding(4, 3, 4, 3);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(437, 33);
            PrioridadComboBox.TabIndex = 61;
            PrioridadComboBox.SelectedIndexChanged += PrioridadComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(776, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(811, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
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
            OPDetalleMercaderiaGroupBox.Controls.Add(DniTransportistaComboBox);
            OPDetalleMercaderiaGroupBox.Controls.Add(OrdenTempLista);
            OPDetalleMercaderiaGroupBox.Controls.Add(label3);
            OPDetalleMercaderiaGroupBox.Controls.Add(PrioridadComboBox);
            OPDetalleMercaderiaGroupBox.Controls.Add(label4);
            OPDetalleMercaderiaGroupBox.Controls.Add(NombreTransportistaComboBox);
            OPDetalleMercaderiaGroupBox.Controls.Add(label14);
            OPDetalleMercaderiaGroupBox.Controls.Add(label12);
            OPDetalleMercaderiaGroupBox.Location = new Point(69, 757);
            OPDetalleMercaderiaGroupBox.Margin = new Padding(4, 3, 4, 3);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Padding = new Padding(4, 3, 4, 3);
            OPDetalleMercaderiaGroupBox.Size = new Size(1241, 395);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Orden:";
            // 
            // HorarioTextBox
            // 
            HorarioTextBox.Location = new Point(1080, 68);
            HorarioTextBox.MaxLength = 2;
            HorarioTextBox.Name = "HorarioTextBox";
            HorarioTextBox.Size = new Size(133, 31);
            HorarioTextBox.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1080, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 70;
            label2.Text = "Horario a Retirar:";
            // 
            // FechaSelecter
            // 
            FechaSelecter.AllowDrop = true;
            FechaSelecter.Location = new Point(776, 68);
            FechaSelecter.Margin = new Padding(4, 3, 4, 3);
            FechaSelecter.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            FechaSelecter.MinDate = new DateTime(2024, 10, 17, 0, 16, 31, 0);
            FechaSelecter.Name = "FechaSelecter";
            FechaSelecter.Size = new Size(295, 31);
            FechaSelecter.TabIndex = 59;
            FechaSelecter.Value = new DateTime(2024, 10, 18, 0, 0, 0, 0);
            FechaSelecter.ValueChanged += FechaSelecter_ValueChanged;
            // 
            // DniTransportistaComboBox
            // 
            DniTransportistaComboBox.FormattingEnabled = true;
            DniTransportistaComboBox.Location = new Point(776, 248);
            DniTransportistaComboBox.Margin = new Padding(4, 3, 4, 3);
            DniTransportistaComboBox.Name = "DniTransportistaComboBox";
            DniTransportistaComboBox.Size = new Size(437, 33);
            DniTransportistaComboBox.TabIndex = 69;
            DniTransportistaComboBox.SelectedIndexChanged += DniTransportistaComboBox_SelectedIndexChanged;
            // 
            // NombreTransportistaComboBox
            // 
            NombreTransportistaComboBox.FormattingEnabled = true;
            NombreTransportistaComboBox.Location = new Point(776, 340);
            NombreTransportistaComboBox.Margin = new Padding(4, 3, 4, 3);
            NombreTransportistaComboBox.Name = "NombreTransportistaComboBox";
            NombreTransportistaComboBox.Size = new Size(437, 33);
            NombreTransportistaComboBox.TabIndex = 68;
            NombreTransportistaComboBox.SelectedIndexChanged += NombreTransportistaComboBox_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 1262);
            Controls.Add(button3);
            Controls.Add(OPMercaderiaGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(OPDetalleMercaderiaGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GenerarOrdenPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Orden Preparacion";
            Load += GenerarOrdenPreparacionForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            OPMercaderiaGroupBox.ResumeLayout(false);
            OPMercaderiaGroupBox.PerformLayout();
            OPDetalleMercaderiaGroupBox.ResumeLayout(false);
            OPDetalleMercaderiaGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView ProductosStockLista;
        private ColumnHeader ProductosCliente;
        private ColumnHeader Cant_Columna;
        private ListView OrdenTempLista;
        private ColumnHeader ProductoColumna;
        private Button ProductoBuscar;
        private Button button3;
        private Button Generar;
        private Button button2;
        private ColumnHeader CantidadColumna;
        private TextBox NombreProductoInput;
        private Button button5;
        private Button AgregarProductoBtn;
        private Label label1;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox OPMercaderiaGroupBox;
        private GroupBox OPDetalleMercaderiaGroupBox;
        private ComboBox PrioridadComboBox;
        private Label label4;
        private Label label3;
        private Label SKUProductoLBL;
        private TextBox SKUProductoInput;
        private Label label10;
        private TextBox RazonSocialClienteInput;
        private Label label11;
        private TextBox CodigoClienteInput2;
        private ColumnHeader SKU_columna;
        private Label label14;
        private Label label12;
        private ComboBox DniTransportistaComboBox;
        private Label label5;
        protected TextBox MaxCantidadTxt;
        private TextBox AgregarCantidadTextBox;
        private Label label9;
        protected TextBox ProductoSeleccionadoTxt;
        private Label label15;
        private TextBox CodigoClienteInput;
        private DateTimePicker FechaSelecter;
        private ComboBox NombreTransportistaComboBox;
        private TextBox HorarioTextBox;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
    }
}