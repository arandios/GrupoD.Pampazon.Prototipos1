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
            ProductosStockLista.Location = new Point(10, 20);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(493, 212);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
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
            OrdenTempLista.Location = new Point(24, 459);
            OrdenTempLista.Margin = new Padding(2, 2, 2, 2);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(493, 166);
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
            ProductoBuscar.Location = new Point(564, 88);
            ProductoBuscar.Margin = new Padding(2, 2, 2, 2);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(131, 23);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "Buscar Producto";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(745, 642);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(77, 23);
            button3.TabIndex = 28;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = SystemColors.ButtonHighlight;
            Generar.Location = new Point(448, 642);
            Generar.Margin = new Padding(2, 2, 2, 2);
            Generar.Name = "Generar";
            Generar.Size = new Size(178, 23);
            Generar.TabIndex = 27;
            Generar.Text = "Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(630, 642);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 22;
            button2.Text = "Cancelar Orden";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CancelarOrderBtn;
            // 
            // ProdNombreBox
            // 
            ProdNombreBox.Location = new Point(34, 58);
            ProdNombreBox.Margin = new Padding(2, 2, 2, 2);
            ProdNombreBox.Name = "ProdNombreBox";
            ProdNombreBox.Size = new Size(221, 23);
            ProdNombreBox.TabIndex = 23;
            // 
            // DepositoBuscarTextBox
            // 
            DepositoBuscarTextBox.Location = new Point(269, 58);
            DepositoBuscarTextBox.Margin = new Padding(2, 2, 2, 2);
            DepositoBuscarTextBox.Name = "DepositoBuscarTextBox";
            DepositoBuscarTextBox.Size = new Size(221, 23);
            DepositoBuscarTextBox.TabIndex = 34;
            // 
            // button5
            // 
            button5.Location = new Point(699, 88);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(103, 23);
            button5.TabIndex = 36;
            button5.Text = "Borrar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // button4
            // 
            button4.Location = new Point(508, 245);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(281, 20);
            button4.TabIndex = 39;
            button4.Text = "Agregar Productos a la Orden de Preparación";
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
            // TransportistasComboBox
            // 
            TransportistasComboBox.Columns.AddRange(new ColumnHeader[] { NombreTranspor, ApellidoTranspor, DniTranspor });
            TransportistasComboBox.Location = new Point(541, 459);
            TransportistasComboBox.Margin = new Padding(2, 2, 2, 2);
            TransportistasComboBox.Name = "TransportistasComboBox";
            TransportistasComboBox.Size = new Size(281, 166);
            TransportistasComboBox.TabIndex = 48;
            TransportistasComboBox.UseCompatibleStateImageBehavior = false;
            TransportistasComboBox.View = View.Details;
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
            label5.Location = new Point(522, 4);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 49;
            label5.Text = "Seleccion un Transportista:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 235);
            label6.Name = "label6";
            label6.Size = new Size(170, 15);
            label6.TabIndex = 50;
            label6.Text = "Seleccione la cantidad a retirar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 44);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 53;
            label8.Text = "Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 40);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 54;
            label9.Text = "Deposito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ProductoBuscar);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(807, 116);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para sus productos en los depositos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 17);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 57;
            label2.Text = "Localidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(469, 34);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 57;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { SkuProducto_Columna, DetalleProducto_Columna, Cantidad_Columna, Deposito_Columna });
            listView1.Location = new Point(508, 20);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(281, 212);
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
            groupBox2.Location = new Point(14, 147);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(816, 284);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mercaderia en deposito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 252);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 57;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(19, 437);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(811, 244);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle Orden de Preparación";
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 562);
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
            Name = "GenerarOrdenPreparacionForm";
            Text = "Generar Orden Preparacion";
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