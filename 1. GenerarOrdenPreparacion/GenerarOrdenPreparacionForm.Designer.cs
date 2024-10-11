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
            ProductosCliente = new ColumnHeader();
            Cant_Columna = new ColumnHeader();
            DepositoID = new ColumnHeader();
            DepositoDir = new ColumnHeader();
            Localidad_Columna = new ColumnHeader();
            OrdenTempLista = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            ProductoBuscar = new Button();
            button3 = new Button();
            Generar = new Button();
            button2 = new Button();
            ProdNombreBox = new TextBox();
            DepositoBuscarTextBox = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            OPTransportistasListView = new ListView();
            NombreTranspor = new ColumnHeader();
            ApellidoTranspor = new ColumnHeader();
            DniTranspor = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            OPMercaderiaGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            OPDetalleMercaderiaGroupBox = new GroupBox();
            label11 = new Label();
            textBox6 = new TextBox();
            SKU_columna = new ColumnHeader();
            groupBox1.SuspendLayout();
            OPMercaderiaGroupBox.SuspendLayout();
            OPDetalleMercaderiaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosStockLista
            // 
            ProductosStockLista.Columns.AddRange(new ColumnHeader[] { ProductosCliente, Cant_Columna, DepositoID, DepositoDir, Localidad_Columna, SKU_columna });
            ProductosStockLista.Location = new Point(11, 27);
            ProductosStockLista.Margin = new Padding(3, 4, 3, 4);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(883, 281);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
            // 
            // ProductosCliente
            // 
            ProductosCliente.DisplayIndex = 1;
            ProductosCliente.Text = "Producto";
            ProductosCliente.Width = 100;
            // 
            // Cant_Columna
            // 
            Cant_Columna.DisplayIndex = 5;
            Cant_Columna.Text = "Cantidad disponible";
            Cant_Columna.Width = 100;
            // 
            // DepositoID
            // 
            DepositoID.Text = "Deposito";
            // 
            // DepositoDir
            // 
            DepositoDir.Text = "Direccion Deposito";
            // 
            // Localidad_Columna
            // 
            Localidad_Columna.Text = "Localidad";
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad, Deposito });
            OrdenTempLista.Location = new Point(5, 37);
            OrdenTempLista.Margin = new Padding(2, 3, 2, 3);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(563, 245);
            OrdenTempLista.TabIndex = 30;
            OrdenTempLista.UseCompatibleStateImageBehavior = false;
            OrdenTempLista.View = View.Details;
            OrdenTempLista.SelectedIndexChanged += OrdenTempLista_SelectedIndexChanged;
            // 
            // Producto
            // 
            Producto.Text = "Productos";
            Producto.Width = 55;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            // 
            // ProductoBuscar
            // 
            ProductoBuscar.Location = new Point(611, 141);
            ProductoBuscar.Margin = new Padding(2, 3, 2, 3);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(150, 31);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "&Buscar Productos";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(807, 288);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 31);
            button3.TabIndex = 28;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = SystemColors.ButtonHighlight;
            Generar.Location = new Point(468, 288);
            Generar.Margin = new Padding(2, 3, 2, 3);
            Generar.Name = "Generar";
            Generar.Size = new Size(203, 31);
            Generar.TabIndex = 27;
            Generar.Text = "&Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(676, 288);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(127, 31);
            button2.TabIndex = 22;
            button2.Text = "&Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // ProdNombreBox
            // 
            ProdNombreBox.Location = new Point(32, 123);
            ProdNombreBox.Margin = new Padding(2, 3, 2, 3);
            ProdNombreBox.Name = "ProdNombreBox";
            ProdNombreBox.Size = new Size(185, 27);
            ProdNombreBox.TabIndex = 23;
            // 
            // DepositoBuscarTextBox
            // 
            DepositoBuscarTextBox.Location = new Point(383, 111);
            DepositoBuscarTextBox.Margin = new Padding(2, 3, 2, 3);
            DepositoBuscarTextBox.Name = "DepositoBuscarTextBox";
            DepositoBuscarTextBox.Size = new Size(224, 27);
            DepositoBuscarTextBox.TabIndex = 34;
            // 
            // button5
            // 
            button5.Location = new Point(765, 141);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(118, 31);
            button5.TabIndex = 36;
            button5.Text = "&Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // button4
            // 
            button4.Location = new Point(578, 351);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(321, 28);
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
            // OPTransportistasListView
            // 
            OPTransportistasListView.Columns.AddRange(new ColumnHeader[] { NombreTranspor, ApellidoTranspor, DniTranspor });
            OPTransportistasListView.Location = new Point(572, 37);
            OPTransportistasListView.Margin = new Padding(2, 3, 2, 3);
            OPTransportistasListView.Name = "OPTransportistasListView";
            OPTransportistasListView.Size = new Size(321, 245);
            OPTransportistasListView.TabIndex = 48;
            OPTransportistasListView.UseCompatibleStateImageBehavior = false;
            OPTransportistasListView.View = View.Details;
            // 
            // NombreTranspor
            // 
            NombreTranspor.Text = "Nombre";
            NombreTranspor.Width = 55;
            // 
            // ApellidoTranspor
            // 
            ApellidoTranspor.Text = "Apellido";
            // 
            // DniTranspor
            // 
            DniTranspor.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 14);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 49;
            label5.Text = "Seleccione un Transportista:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 329);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 50;
            label6.Text = "Cantidad a retirar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 104);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 53;
            label8.Text = "Nombre Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 88);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 54;
            label9.Text = "Deposito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(DepositoBuscarTextBox);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 174);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 24);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 60;
            label10.Text = "Razón Social cliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(7, 43);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(372, 27);
            textBox5.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 92);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 60;
            label7.Text = "SKU Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(611, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 57;
            label2.Text = "Localidad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 111);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 27);
            textBox4.TabIndex = 59;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(611, 111);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 57;
            // 
            // OPMercaderiaGroupBox
            // 
            OPMercaderiaGroupBox.Controls.Add(comboBox1);
            OPMercaderiaGroupBox.Controls.Add(textBox3);
            OPMercaderiaGroupBox.Controls.Add(label4);
            OPMercaderiaGroupBox.Controls.Add(label3);
            OPMercaderiaGroupBox.Controls.Add(textBox2);
            OPMercaderiaGroupBox.Controls.Add(label1);
            OPMercaderiaGroupBox.Controls.Add(button4);
            OPMercaderiaGroupBox.Controls.Add(label6);
            OPMercaderiaGroupBox.Controls.Add(ProductosStockLista);
            OPMercaderiaGroupBox.Location = new Point(16, 196);
            OPMercaderiaGroupBox.Name = "OPMercaderiaGroupBox";
            OPMercaderiaGroupBox.Size = new Size(902, 402);
            OPMercaderiaGroupBox.TabIndex = 57;
            OPMercaderiaGroupBox.TabStop = false;
            OPMercaderiaGroupBox.Text = "Productos en deposito";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(409, 351);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 328);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 328);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 58;
            label3.Text = "Fecha a retirar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 352);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 57;
            // 
            // OPDetalleMercaderiaGroupBox
            // 
            OPDetalleMercaderiaGroupBox.Controls.Add(label5);
            OPDetalleMercaderiaGroupBox.Controls.Add(OrdenTempLista);
            OPDetalleMercaderiaGroupBox.Controls.Add(Generar);
            OPDetalleMercaderiaGroupBox.Controls.Add(OPTransportistasListView);
            OPDetalleMercaderiaGroupBox.Controls.Add(button2);
            OPDetalleMercaderiaGroupBox.Controls.Add(button3);
            OPDetalleMercaderiaGroupBox.Location = new Point(22, 604);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Size = new Size(896, 325);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Detalle Orden de Preparación";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 24);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 62;
            label11.Text = "Código cliente";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(383, 43);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(500, 27);
            textBox6.TabIndex = 61;
            // 
            // SKU_columna
            // 
            SKU_columna.DisplayIndex = 0;
            SKU_columna.Text = "SKU";
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 941);
            Controls.Add(OPMercaderiaGroupBox);
            Controls.Add(label8);
            Controls.Add(ProdNombreBox);
            Controls.Add(groupBox1);
            Controls.Add(OPDetalleMercaderiaGroupBox);
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
            PerformLayout();
        }

        #endregion

        private ListView ProductosStockLista;
        private ColumnHeader ProductosCliente;
        private ColumnHeader Cant_Columna;
        private ListView OrdenTempLista;
        private ColumnHeader Producto;
        private Button ProductoBuscar;
        private Button button3;
        private Button Generar;
        private Button button2;
        private ColumnHeader Cantidad;
        private TextBox ProdNombreBox;
        private ColumnHeader DepositoID;
        private ColumnHeader DepositoDir;
        private ColumnHeader Deposito;
        private TextBox DepositoBuscarTextBox;
        private Button button5;
        private Button button4;
        private Label label1;
        private ListView OPTransportistasListView;
        private ColumnHeader NombreTranspor;
        private ColumnHeader ApellidoTranspor;
        private ColumnHeader DniTranspor;
        private Label label5;
        private Label label6;
        private ColumnHeader Localidad_Columna;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox OPMercaderiaGroupBox;
        private TextBox textBox2;
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
    }
}