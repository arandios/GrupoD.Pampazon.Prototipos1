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
            ProductosStockLista = new ListView();
            SKU_columna = new ColumnHeader();
            ProductosCliente = new ColumnHeader();
            Cant_Columna = new ColumnHeader();
            OrdenTempLista = new ListView();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            DepositoColumna = new ColumnHeader();
            ProductoBuscar = new Button();
            button3 = new Button();
            Generar = new Button();
            button2 = new Button();
            NombreProductoInput = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            CodigoClienteInput = new TextBox();
            label11 = new Label();
            label10 = new Label();
            RazonSocialClienteInput = new TextBox();
            label7 = new Label();
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
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            OPDetalleMercaderiaGroupBox = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            OPMercaderiaGroupBox.SuspendLayout();
            OPDetalleMercaderiaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosStockLista
            // 
            ProductosStockLista.Columns.AddRange(new ColumnHeader[] { SKU_columna, ProductosCliente, Cant_Columna });
            ProductosStockLista.Location = new Point(10, 20);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(487, 212);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
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
            Cant_Columna.Width = 150;
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { ProductoColumna, CantidadColumna, DepositoColumna });
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
            // DepositoColumna
            // 
            DepositoColumna.Text = "Deposito";
            DepositoColumna.TextAlign = HorizontalAlignment.Center;
            DepositoColumna.Width = 180;
            // 
            // ProductoBuscar
            // 
            ProductoBuscar.Location = new Point(393, 100);
            ProductoBuscar.Margin = new Padding(2);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(187, 40);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "&Buscar Productos";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(642, 662);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(187, 40);
            button3.TabIndex = 28;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
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
            // NombreProductoInput
            // 
            NombreProductoInput.Location = new Point(358, 76);
            NombreProductoInput.Margin = new Padding(2);
            NombreProductoInput.Name = "NombreProductoInput";
            NombreProductoInput.Size = new Size(413, 23);
            NombreProductoInput.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(584, 100);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(187, 40);
            button5.TabIndex = 36;
            button5.Text = "&Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // button4
            // 
            button4.Location = new Point(536, 181);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(237, 51);
            button4.TabIndex = 39;
            button4.Text = "&Agregar Productos a la Orden de Preparación";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 40;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 62);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
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
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SKUProductoInput);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(40, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(789, 149);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // CodigoClienteInput
            // 
            CodigoClienteInput.Location = new Point(5, 38);
            CodigoClienteInput.Margin = new Padding(2);
            CodigoClienteInput.Name = "CodigoClienteInput";
            CodigoClienteInput.Size = new Size(346, 23);
            CodigoClienteInput.TabIndex = 63;
            CodigoClienteInput.TextChanged += CodigoClienteInput_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 21);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 62;
            label11.Text = "Código cliente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 21);
            label10.Name = "label10";
            label10.Size = new Size(111, 15);
            label10.TabIndex = 60;
            label10.Text = "Razón Social cliente";
            // 
            // RazonSocialClienteInput
            // 
            RazonSocialClienteInput.Location = new Point(358, 37);
            RazonSocialClienteInput.Margin = new Padding(2);
            RazonSocialClienteInput.Name = "RazonSocialClienteInput";
            RazonSocialClienteInput.Size = new Size(413, 23);
            RazonSocialClienteInput.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 62);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 60;
            label7.Text = "SKU Producto";
            // 
            // SKUProductoInput
            // 
            SKUProductoInput.Location = new Point(6, 76);
            SKUProductoInput.Margin = new Padding(2);
            SKUProductoInput.Name = "SKUProductoInput";
            SKUProductoInput.Size = new Size(345, 23);
            SKUProductoInput.TabIndex = 59;
            // 
            // OPMercaderiaGroupBox
            // 
            OPMercaderiaGroupBox.Controls.Add(label5);
            OPMercaderiaGroupBox.Controls.Add(label1);
            OPMercaderiaGroupBox.Controls.Add(button4);
            OPMercaderiaGroupBox.Controls.Add(MaxCantidadTxt);
            OPMercaderiaGroupBox.Controls.Add(AgregarCantidadTextBox);
            OPMercaderiaGroupBox.Controls.Add(ProductosStockLista);
            OPMercaderiaGroupBox.Controls.Add(label9);
            OPMercaderiaGroupBox.Controls.Add(ProductoSeleccionadoTxt);
            OPMercaderiaGroupBox.Controls.Add(label15);
            OPMercaderiaGroupBox.Location = new Point(40, 174);
            OPMercaderiaGroupBox.Margin = new Padding(3, 2, 3, 2);
            OPMercaderiaGroupBox.Name = "OPMercaderiaGroupBox";
            OPMercaderiaGroupBox.Padding = new Padding(3, 2, 3, 2);
            OPMercaderiaGroupBox.Size = new Size(789, 238);
            OPMercaderiaGroupBox.TabIndex = 57;
            OPMercaderiaGroupBox.TabStop = false;
            OPMercaderiaGroupBox.Text = "Productos en deposito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 77);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 71;
            label5.Text = "Cantidad Depositada";
            // 
            // MaxCantidadTxt
            // 
            MaxCantidadTxt.Location = new Point(536, 94);
            MaxCantidadTxt.Margin = new Padding(2);
            MaxCantidadTxt.Name = "MaxCantidadTxt";
            MaxCantidadTxt.ReadOnly = true;
            MaxCantidadTxt.Size = new Size(237, 23);
            MaxCantidadTxt.TabIndex = 70;
            // 
            // AgregarCantidadTextBox
            // 
            AgregarCantidadTextBox.Enabled = false;
            AgregarCantidadTextBox.Location = new Point(536, 154);
            AgregarCantidadTextBox.Margin = new Padding(2);
            AgregarCantidadTextBox.MaxLength = 50;
            AgregarCantidadTextBox.Name = "AgregarCantidadTextBox";
            AgregarCantidadTextBox.Size = new Size(237, 23);
            AgregarCantidadTextBox.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(536, 137);
            label9.Name = "label9";
            label9.Size = new Size(144, 15);
            label9.TabIndex = 68;
            label9.Text = "Indique Cantidad a Retirar";
            // 
            // ProductoSeleccionadoTxt
            // 
            ProductoSeleccionadoTxt.Location = new Point(535, 40);
            ProductoSeleccionadoTxt.Margin = new Padding(2);
            ProductoSeleccionadoTxt.Name = "ProductoSeleccionadoTxt";
            ProductoSeleccionadoTxt.ReadOnly = true;
            ProductoSeleccionadoTxt.Size = new Size(238, 23);
            ProductoSeleccionadoTxt.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(547, 23);
            label15.Name = "label15";
            label15.Size = new Size(129, 15);
            label15.TabIndex = 65;
            label15.Text = "Producto Seleccionado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(528, 100);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 66;
            label14.Text = "DNI Transportista:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(528, 141);
            label12.Name = "label12";
            label12.Size = new Size(130, 15);
            label12.TabIndex = 62;
            label12.Text = "Transportista que retira:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 67);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(528, 29);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 52);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 13);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 58;
            label3.Text = "Fecha a retirar:";
            // 
            // OPDetalleMercaderiaGroupBox
            // 
            OPDetalleMercaderiaGroupBox.Controls.Add(button2);
            OPDetalleMercaderiaGroupBox.Controls.Add(Generar);
            OPDetalleMercaderiaGroupBox.Controls.Add(comboBox3);
            OPDetalleMercaderiaGroupBox.Controls.Add(OrdenTempLista);
            OPDetalleMercaderiaGroupBox.Controls.Add(textBox3);
            OPDetalleMercaderiaGroupBox.Controls.Add(label3);
            OPDetalleMercaderiaGroupBox.Controls.Add(comboBox1);
            OPDetalleMercaderiaGroupBox.Controls.Add(label4);
            OPDetalleMercaderiaGroupBox.Controls.Add(comboBox2);
            OPDetalleMercaderiaGroupBox.Controls.Add(label14);
            OPDetalleMercaderiaGroupBox.Controls.Add(label12);
            OPDetalleMercaderiaGroupBox.Location = new Point(38, 416);
            OPDetalleMercaderiaGroupBox.Margin = new Padding(3, 2, 3, 2);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Padding = new Padding(3, 2, 3, 2);
            OPDetalleMercaderiaGroupBox.Size = new Size(792, 241);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Orden:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(528, 117);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(245, 23);
            comboBox3.TabIndex = 69;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(528, 159);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 23);
            comboBox2.TabIndex = 68;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 715);
            Controls.Add(button3);
            Controls.Add(OPMercaderiaGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(OPDetalleMercaderiaGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GenerarOrdenPreparacionForm";
            Text = "Generar Orden Preparacion";
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
        private ColumnHeader DepositoColumna;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox OPMercaderiaGroupBox;
        private GroupBox OPDetalleMercaderiaGroupBox;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox SKUProductoInput;
        private Label label10;
        private TextBox RazonSocialClienteInput;
        private Label label11;
        private TextBox CodigoClienteInput2;
        private ColumnHeader SKU_columna;
        private Label label14;
        private Label label12;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label5;
        protected TextBox MaxCantidadTxt;
        private TextBox AgregarCantidadTextBox;
        private Label label9;
        protected TextBox ProductoSeleccionadoTxt;
        private Label label15;
        private TextBox CodigoClienteInput;
    }
}