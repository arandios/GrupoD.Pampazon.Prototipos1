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
            SKU_columna = new ColumnHeader();
            OrdenTempLista = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            ProductoBuscar = new Button();
            button3 = new Button();
            Generar = new Button();
            button2 = new Button();
            ProdNombreBox = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            OPMercaderiaGroupBox = new GroupBox();
            label14 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            OPDetalleMercaderiaGroupBox = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox4 = new ComboBox();
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
            ProductosStockLista.Size = new Size(883, 281);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
            // 
            // ProductosCliente
            // 
            ProductosCliente.Text = "Producto";
            ProductosCliente.Width = 100;
            // 
            // Cant_Columna
            // 
            Cant_Columna.Text = "Cantidad disponible";
            Cant_Columna.Width = 100;
            // 
            // SKU_columna
            // 
            SKU_columna.Text = "SKU";
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad, Deposito });
            OrdenTempLista.Location = new Point(6, 40);
            OrdenTempLista.Margin = new Padding(2, 3, 2, 3);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(883, 201);
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
            ProductoBuscar.Location = new Point(605, 130);
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
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(839, 999);
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
            Generar.Location = new Point(500, 999);
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
            button2.Location = new Point(708, 999);
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
            ProdNombreBox.Location = new Point(405, 101);
            ProdNombreBox.Margin = new Padding(2, 3, 2, 3);
            ProdNombreBox.Name = "ProdNombreBox";
            ProdNombreBox.Size = new Size(476, 27);
            ProdNombreBox.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(759, 130);
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
            button4.Location = new Point(567, 321);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(321, 51);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 50;
            label6.Text = "Cantidad a retirar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 82);
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
            groupBox1.Size = new Size(891, 187);
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
            textBox6.Location = new Point(9, 47);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(394, 27);
            textBox6.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 28);
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
            textBox5.Size = new Size(476, 27);
            textBox5.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 82);
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
            OPMercaderiaGroupBox.Controls.Add(textBox2);
            OPMercaderiaGroupBox.Controls.Add(label1);
            OPMercaderiaGroupBox.Controls.Add(button4);
            OPMercaderiaGroupBox.Controls.Add(label6);
            OPMercaderiaGroupBox.Controls.Add(ProductosStockLista);
            OPMercaderiaGroupBox.Location = new Point(16, 196);
            OPMercaderiaGroupBox.Name = "OPMercaderiaGroupBox";
            OPMercaderiaGroupBox.Size = new Size(902, 383);
            OPMercaderiaGroupBox.TabIndex = 57;
            OPMercaderiaGroupBox.TabStop = false;
            OPMercaderiaGroupBox.Text = "Productos en deposito";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 917);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 66;
            label14.Text = "DNI Transportista:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(281, 979);
            label12.Name = "label12";
            label12.Size = new Size(165, 20);
            label12.TabIndex = 62;
            label12.Text = "Transportista que retira:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(366, 948);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 928);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 59;
            label4.Text = "Prioridad:";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 237);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 58;
            label3.Text = "Fecha a retirar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 27);
            textBox2.TabIndex = 57;
            // 
            // OPDetalleMercaderiaGroupBox
            // 
            OPDetalleMercaderiaGroupBox.Controls.Add(OrdenTempLista);
            OPDetalleMercaderiaGroupBox.Controls.Add(textBox3);
            OPDetalleMercaderiaGroupBox.Controls.Add(label3);
            OPDetalleMercaderiaGroupBox.Location = new Point(21, 585);
            OPDetalleMercaderiaGroupBox.Name = "OPDetalleMercaderiaGroupBox";
            OPDetalleMercaderiaGroupBox.Size = new Size(896, 291);
            OPDetalleMercaderiaGroupBox.TabIndex = 58;
            OPDetalleMercaderiaGroupBox.TabStop = false;
            OPDetalleMercaderiaGroupBox.Text = "Detalle Orden de Preparación";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(281, 1002);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(279, 28);
            comboBox2.TabIndex = 68;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(21, 940);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(265, 28);
            comboBox3.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 979);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 66;
            label2.Text = "DNI Transportista:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(27, 1002);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(265, 28);
            comboBox4.TabIndex = 69;
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 1057);
            Controls.Add(comboBox3);
            Controls.Add(Generar);
            Controls.Add(comboBox4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(OPMercaderiaGroupBox);
            Controls.Add(label14);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(OPDetalleMercaderiaGroupBox);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(label4);
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
        private ColumnHeader Deposito;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label6;
        private Label label8;
        private GroupBox groupBox1;
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
        private Label label14;
        private Label label12;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label2;
        private ComboBox comboBox4;
    }
}