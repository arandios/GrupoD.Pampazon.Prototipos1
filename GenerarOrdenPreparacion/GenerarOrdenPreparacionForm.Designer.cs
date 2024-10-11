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
            Stock = new ColumnHeader();
            DepositoID = new ColumnHeader();
            DepositoDir = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
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
            TransportistasComboBox = new ListView();
            NombreTranspor = new ColumnHeader();
            ApellidoTranspor = new ColumnHeader();
            DniTranspor = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            SkuProducto_Columna = new ColumnHeader();
            DetalleProducto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            Deposito_Columna = new ColumnHeader();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosStockLista
            // 
            ProductosStockLista.Columns.AddRange(new ColumnHeader[] { ProductosCliente, Stock, DepositoID, DepositoDir, columnHeader1 });
            ProductosStockLista.Location = new Point(11, 27);
            ProductosStockLista.Margin = new Padding(3, 4, 3, 4);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(563, 282);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
            //ProductosStockLista.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
            // 
            // ProductosCliente
            // 
            ProductosCliente.Text = "Productos";
            ProductosCliente.Width = 100;
            // 
            // Stock
            // 
            Stock.Text = "Cantidad";
            Stock.Width = 100;
            // 
            // DepositoID
            // 
            DepositoID.Text = "Deposito";
            // 
            // DepositoDir
            // 
            DepositoDir.Text = "Direccion Deposito";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Localidad";
            // 
            // OrdenTempLista
            // 
            OrdenTempLista.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad, Deposito });
            OrdenTempLista.Location = new Point(27, 612);
            OrdenTempLista.Margin = new Padding(2, 3, 2, 3);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(563, 220);
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
            ProductoBuscar.Location = new Point(645, 118);
            ProductoBuscar.Margin = new Padding(2, 3, 2, 3);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(150, 31);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "Buscar Producto";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(851, 856);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 31);
            button3.TabIndex = 28;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = SystemColors.ButtonHighlight;
            Generar.Location = new Point(512, 856);
            Generar.Margin = new Padding(2, 3, 2, 3);
            Generar.Name = "Generar";
            Generar.Size = new Size(204, 31);
            Generar.TabIndex = 27;
            Generar.Text = "Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(720, 856);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(127, 31);
            button2.TabIndex = 22;
            button2.Text = "Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // ProdNombreBox
            // 
            ProdNombreBox.Location = new Point(39, 77);
            ProdNombreBox.Margin = new Padding(2, 3, 2, 3);
            ProdNombreBox.Name = "ProdNombreBox";
            ProdNombreBox.Size = new Size(252, 27);
            ProdNombreBox.TabIndex = 23;
            // 
            // DepositoBuscarTextBox
            // 
            DepositoBuscarTextBox.Location = new Point(307, 77);
            DepositoBuscarTextBox.Margin = new Padding(2, 3, 2, 3);
            DepositoBuscarTextBox.Name = "DepositoBuscarTextBox";
            DepositoBuscarTextBox.Size = new Size(252, 27);
            DepositoBuscarTextBox.TabIndex = 34;
            // 
            // button5
            // 
            button5.Location = new Point(799, 118);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(118, 31);
            button5.TabIndex = 36;
            button5.Text = "Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // button4
            // 
            button4.Location = new Point(580, 327);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(321, 27);
            button4.TabIndex = 39;
            button4.Text = "Agregar Productos a la Orden de Preparación";
            button4.UseVisualStyleBackColor = true;
            //button4.Click += AgregarProductosOrdenBtn_Click;
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
            // TransportistasComboBox
            // 
            TransportistasComboBox.Columns.AddRange(new ColumnHeader[] { NombreTranspor, ApellidoTranspor, DniTranspor });
            TransportistasComboBox.Location = new Point(618, 612);
            TransportistasComboBox.Margin = new Padding(2, 3, 2, 3);
            TransportistasComboBox.Name = "TransportistasComboBox";
            TransportistasComboBox.Size = new Size(321, 220);
            TransportistasComboBox.TabIndex = 48;
            TransportistasComboBox.UseCompatibleStateImageBehavior = false;
            TransportistasComboBox.View = View.Details;
            //TransportistasComboBox.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
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
            label5.Location = new Point(596, 6);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 49;
            label5.Text = "Seleccion un Transportista:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 313);
            label6.Name = "label6";
            label6.Size = new Size(217, 20);
            label6.TabIndex = 50;
            label6.Text = "Seleccione la cantidad a retirar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 59);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 53;
            label8.Text = "Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(307, 54);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 54;
            label9.Text = "Deposito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(27, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(922, 155);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 57;
            label2.Text = "Localidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(536, 46);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 57;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { SkuProducto_Columna, DetalleProducto_Columna, Cantidad_Columna, Deposito_Columna });
            listView1.Location = new Point(580, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(321, 282);
            listView1.TabIndex = 56;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // SkuProducto_Columna
            // 
            SkuProducto_Columna.Text = "SKUProducto";
            // 
            // DetalleProducto_Columna
            // 
            DetalleProducto_Columna.Text = "DetalleProducto";
            // 
            // Cantidad_Columna
            // 
            Cantidad_Columna.Text = "Cantidad";
            // 
            // Deposito_Columna
            // 
            Deposito_Columna.Text = "Deposito";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(ProductosStockLista);
            groupBox2.Location = new Point(16, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(933, 378);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mercaderia en deposito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 57;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(22, 583);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(927, 325);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle Orden de Preparación";
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 895);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TransportistasComboBox);
            Controls.Add(DepositoBuscarTextBox);
            Controls.Add(OrdenTempLista);
            Controls.Add(button3);
            Controls.Add(Generar);
            Controls.Add(ProdNombreBox);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenPreparacionForm";
            Text = "GenerarOrdenPreparacion";
           // Load += TransportistasComboBox_SelectedIndexChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ProductosStockLista;
        private ColumnHeader ProductosCliente;
        private ColumnHeader Stock;
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
        private ListView TransportistasComboBox;
        private ColumnHeader NombreTranspor;
        private ColumnHeader ApellidoTranspor;
        private ColumnHeader DniTranspor;
        private Label label5;
        private Label label6;
        private ColumnHeader columnHeader1;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader SkuProducto_Columna;
        private ColumnHeader DetalleProducto_Columna;
        private ColumnHeader Cantidad_Columna;
        private ColumnHeader Deposito_Columna;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private GroupBox groupBox3;
    }
}