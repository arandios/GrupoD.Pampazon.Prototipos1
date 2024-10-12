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
            ProdNombreBox = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
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
            ProductosStockLista.Location = new Point(11, 27);
            ProductosStockLista.Margin = new Padding(3, 4, 3, 4);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(556, 281);
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
            OrdenTempLista.Location = new Point(11, 40);
            OrdenTempLista.Margin = new Padding(2, 3, 2, 3);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(556, 201);
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
            ProductoBuscar.Location = new Point(605, 139);
            ProductoBuscar.Margin = new Padding(2, 3, 2, 3);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(150, 48);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "&Buscar Productos";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(776, 881);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(146, 52);
            button3.TabIndex = 28;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = Color.FromArgb(192, 255, 192);
            Generar.Location = new Point(11, 248);
            Generar.Margin = new Padding(2, 3, 2, 3);
            Generar.Name = "Generar";
            Generar.Size = new Size(319, 59);
            Generar.TabIndex = 27;
            Generar.Text = "&Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(335, 248);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(233, 59);
            button2.TabIndex = 22;
            button2.Text = "&Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // ProdNombreBox
            // 
            ProdNombreBox.Location = new Point(409, 101);
            ProdNombreBox.Margin = new Padding(2, 3, 2, 3);
            ProdNombreBox.Name = "ProdNombreBox";
            ProdNombreBox.Size = new Size(471, 27);
            ProdNombreBox.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(759, 139);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(118, 48);
            button5.TabIndex = 36;
            button5.Text = "&Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // button4
            // 
            button4.Location = new Point(613, 241);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(271, 68);
            button4.TabIndex = 39;
            button4.Text = "&Agregar Productos a la Orden de Preparación";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 40;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 83);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 53;
            label8.Text = "Nombre Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(ProdNombreBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 199);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 28);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 62;
            label11.Text = "Código cliente";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 49);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(393, 27);
            textBox6.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(410, 28);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 60;
            label10.Text = "Razón Social cliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(407, 47);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(474, 27);
            textBox5.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 83);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 60;
            label7.Text = "SKU Producto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(7, 101);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(394, 27);
            textBox4.TabIndex = 59;
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
            OPMercaderiaGroupBox.Location = new Point(21, 232);
            OPMercaderiaGroupBox.Name = "OPMercaderiaGroupBox";
            OPMercaderiaGroupBox.Size = new Size(902, 317);
            OPMercaderiaGroupBox.TabIndex = 57;
            OPMercaderiaGroupBox.TabStop = false;
            OPMercaderiaGroupBox.Text = "Productos en deposito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 103);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 71;
            label5.Text = "Cantidad Depositada";
            // 
            // MaxCantidadTxt
            // 
            MaxCantidadTxt.Location = new Point(613, 125);
            MaxCantidadTxt.Margin = new Padding(2, 3, 2, 3);
            MaxCantidadTxt.Name = "MaxCantidadTxt";
            MaxCantidadTxt.ReadOnly = true;
            MaxCantidadTxt.Size = new Size(270, 27);
            MaxCantidadTxt.TabIndex = 70;
            // 
            // AgregarCantidadTextBox
            // 
            AgregarCantidadTextBox.Enabled = false;
            AgregarCantidadTextBox.Location = new Point(613, 205);
            AgregarCantidadTextBox.Margin = new Padding(2, 3, 2, 3);
            AgregarCantidadTextBox.MaxLength = 50;
            AgregarCantidadTextBox.Name = "AgregarCantidadTextBox";
            AgregarCantidadTextBox.Size = new Size(270, 27);
            AgregarCantidadTextBox.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(613, 183);
            label9.Name = "label9";
            label9.Size = new Size(183, 20);
            label9.TabIndex = 68;
            label9.Text = "Indique Cantidad a Retirar";
            // 
            // ProductoSeleccionadoTxt
            // 
            ProductoSeleccionadoTxt.Location = new Point(611, 53);
            ProductoSeleccionadoTxt.Margin = new Padding(2, 3, 2, 3);
            ProductoSeleccionadoTxt.Name = "ProductoSeleccionadoTxt";
            ProductoSeleccionadoTxt.ReadOnly = true;
            ProductoSeleccionadoTxt.Size = new Size(271, 27);
            ProductoSeleccionadoTxt.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(625, 31);
            label15.Name = "label15";
            label15.Size = new Size(162, 20);
            label15.TabIndex = 65;
            label15.Text = "Producto Seleccionado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(603, 133);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 66;
            label14.Text = "DNI Transportista:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(603, 188);
            label12.Name = "label12";
            label12.Size = new Size(165, 20);
            label12.TabIndex = 62;
            label12.Text = "Transportista que retira:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(603, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 28);
            comboBox1.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(603, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 27);
            textBox3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 69);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 17);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
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
            OPDetalleMercaderiaGroupBox.Location = new Point(21, 555);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Size = new Size(902, 321);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Orden:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(603, 156);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 28);
            comboBox3.TabIndex = 69;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(603, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(279, 28);
            comboBox2.TabIndex = 68;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(button3);
            Controls.Add(OPMercaderiaGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(OPDetalleMercaderiaGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox ProdNombreBox;
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
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
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
    }
}