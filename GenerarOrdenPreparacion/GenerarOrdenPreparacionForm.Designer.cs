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
            BuscarDepositoBtn = new Button();
            DepositoBuscarTextBox = new TextBox();
            button5 = new Button();
            ProductoSeleccionadoTxt = new TextBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            DepositoTxt = new TextBox();
            label3 = new Label();
            AgregarCantidadTextBox = new TextBox();
            MaxCantidadTxt = new TextBox();
            label4 = new Label();
            OrdenNdepo = new Label();
            TransportistasComboBox = new ListView();
            NombreTranspor = new ColumnHeader();
            ApellidoTranspor = new ColumnHeader();
            DniTranspor = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            TransportistaSeleccionadoTxt = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // ProductosStockLista
            // 
            ProductosStockLista.Columns.AddRange(new ColumnHeader[] { ProductosCliente, Stock, DepositoID, DepositoDir, columnHeader1 });
            ProductosStockLista.Location = new Point(49, 227);
            ProductosStockLista.Margin = new Padding(3, 4, 3, 4);
            ProductosStockLista.Name = "ProductosStockLista";
            ProductosStockLista.Size = new Size(492, 329);
            ProductosStockLista.TabIndex = 32;
            ProductosStockLista.UseCompatibleStateImageBehavior = false;
            ProductosStockLista.View = View.Details;
            ProductosStockLista.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
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
            OrdenTempLista.Location = new Point(39, 623);
            OrdenTempLista.Margin = new Padding(2, 3, 2, 3);
            OrdenTempLista.Name = "OrdenTempLista";
            OrdenTempLista.Size = new Size(635, 220);
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
            ProductoBuscar.Location = new Point(318, 76);
            ProductoBuscar.Margin = new Padding(2, 3, 2, 3);
            ProductoBuscar.Name = "ProductoBuscar";
            ProductoBuscar.Size = new Size(214, 31);
            ProductoBuscar.TabIndex = 29;
            ProductoBuscar.Text = "Buscar Producto";
            ProductoBuscar.UseVisualStyleBackColor = true;
            ProductoBuscar.Click += BuscarProductoBtn;
            // 
            // button3
            // 
            button3.Location = new Point(997, 833);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(177, 57);
            button3.TabIndex = 28;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += VolverBtn;
            // 
            // Generar
            // 
            Generar.BackColor = Color.FromArgb(128, 255, 128);
            Generar.Location = new Point(39, 849);
            Generar.Margin = new Padding(2, 3, 2, 3);
            Generar.Name = "Generar";
            Generar.Size = new Size(427, 53);
            Generar.TabIndex = 27;
            Generar.Text = "Generar Orden Preparacion";
            Generar.UseVisualStyleBackColor = false;
            Generar.Click += GenerarOrderPreparacionBtn;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(482, 849);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(192, 53);
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
            // BuscarDepositoBtn
            // 
            BuscarDepositoBtn.Location = new Point(318, 125);
            BuscarDepositoBtn.Margin = new Padding(2, 3, 2, 3);
            BuscarDepositoBtn.Name = "BuscarDepositoBtn";
            BuscarDepositoBtn.Size = new Size(214, 31);
            BuscarDepositoBtn.TabIndex = 33;
            BuscarDepositoBtn.Text = "Buscar Deposito";
            BuscarDepositoBtn.UseVisualStyleBackColor = true;
            BuscarDepositoBtn.Click += BuscarProductoBtn;
            // 
            // DepositoBuscarTextBox
            // 
            DepositoBuscarTextBox.Location = new Point(39, 125);
            DepositoBuscarTextBox.Margin = new Padding(2, 3, 2, 3);
            DepositoBuscarTextBox.Name = "DepositoBuscarTextBox";
            DepositoBuscarTextBox.Size = new Size(252, 27);
            DepositoBuscarTextBox.TabIndex = 34;
            // 
            // button5
            // 
            button5.Location = new Point(368, 189);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(163, 31);
            button5.TabIndex = 36;
            button5.Text = "Limpiar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += LimpiarFiltros;
            // 
            // ProductoSeleccionadoTxt
            // 
            ProductoSeleccionadoTxt.Location = new Point(551, 261);
            ProductoSeleccionadoTxt.Margin = new Padding(2, 3, 2, 3);
            ProductoSeleccionadoTxt.Name = "ProductoSeleccionadoTxt";
            ProductoSeleccionadoTxt.ReadOnly = true;
            ProductoSeleccionadoTxt.Size = new Size(213, 27);
            ProductoSeleccionadoTxt.TabIndex = 38;
            ProductoSeleccionadoTxt.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(551, 519);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(214, 39);
            button4.TabIndex = 39;
            button4.Text = "Agregar Productos a la Orden";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AgregarProductosOrdenBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 240);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 40;
            label1.Text = "Producto Seleccionado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(595, 316);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 41;
            label2.Text = "N° de Deposito";
            // 
            // DepositoTxt
            // 
            DepositoTxt.Location = new Point(547, 339);
            DepositoTxt.Margin = new Padding(2, 3, 2, 3);
            DepositoTxt.Name = "DepositoTxt";
            DepositoTxt.ReadOnly = true;
            DepositoTxt.Size = new Size(217, 27);
            DepositoTxt.TabIndex = 42;
            DepositoTxt.TextChanged += DepositoTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 460);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 43;
            label3.Text = "Indique Cantidad a Retirar";
            // 
            // AgregarCantidadTextBox
            // 
            AgregarCantidadTextBox.Enabled = false;
            AgregarCantidadTextBox.Location = new Point(551, 483);
            AgregarCantidadTextBox.Margin = new Padding(2, 3, 2, 3);
            AgregarCantidadTextBox.MaxLength = 50;
            AgregarCantidadTextBox.Name = "AgregarCantidadTextBox";
            AgregarCantidadTextBox.Size = new Size(213, 27);
            AgregarCantidadTextBox.TabIndex = 44;
            // 
            // MaxCantidadTxt
            // 
            MaxCantidadTxt.Location = new Point(551, 411);
            MaxCantidadTxt.Margin = new Padding(2, 3, 2, 3);
            MaxCantidadTxt.Name = "MaxCantidadTxt";
            MaxCantidadTxt.ReadOnly = true;
            MaxCantidadTxt.Size = new Size(213, 27);
            MaxCantidadTxt.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 388);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 46;
            label4.Text = "Cantidad Depositada";
            // 
            // OrdenNdepo
            // 
            OrdenNdepo.AutoSize = true;
            OrdenNdepo.Location = new Point(246, 599);
            OrdenNdepo.Name = "OrdenNdepo";
            OrdenNdepo.Size = new Size(50, 20);
            OrdenNdepo.TabIndex = 47;
            OrdenNdepo.Text = "Orden";
            // 
            // TransportistasComboBox
            // 
            TransportistasComboBox.Columns.AddRange(new ColumnHeader[] { NombreTranspor, ApellidoTranspor, DniTranspor });
            TransportistasComboBox.Location = new Point(800, 227);
            TransportistasComboBox.Margin = new Padding(2, 3, 2, 3);
            TransportistasComboBox.Name = "TransportistasComboBox";
            TransportistasComboBox.Size = new Size(379, 253);
            TransportistasComboBox.TabIndex = 48;
            TransportistasComboBox.UseCompatibleStateImageBehavior = false;
            TransportistasComboBox.View = View.Details;
            TransportistasComboBox.SelectedIndexChanged += ProductosStockLista_SelectedIndexChanged;
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
            label5.Location = new Point(920, 189);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 49;
            label5.Text = "Transportistas";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 189);
            label6.Name = "label6";
            label6.Size = new Size(169, 20);
            label6.TabIndex = 50;
            label6.Text = "Mercaderia en Deposito";
            // 
            // TransportistaSeleccionadoTxt
            // 
            TransportistaSeleccionadoTxt.Location = new Point(833, 560);
            TransportistaSeleccionadoTxt.Margin = new Padding(2, 3, 2, 3);
            TransportistaSeleccionadoTxt.Name = "TransportistaSeleccionadoTxt";
            TransportistaSeleccionadoTxt.ReadOnly = true;
            TransportistaSeleccionadoTxt.Size = new Size(293, 27);
            TransportistaSeleccionadoTxt.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(903, 519);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 52;
            label7.Text = "Transportista Selecionado";
            // 
            // GenerarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 940);
            Controls.Add(label7);
            Controls.Add(TransportistaSeleccionadoTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TransportistasComboBox);
            Controls.Add(OrdenNdepo);
            Controls.Add(label4);
            Controls.Add(MaxCantidadTxt);
            Controls.Add(AgregarCantidadTextBox);
            Controls.Add(label3);
            Controls.Add(DepositoTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(ProductoSeleccionadoTxt);
            Controls.Add(button5);
            Controls.Add(DepositoBuscarTextBox);
            Controls.Add(BuscarDepositoBtn);
            Controls.Add(ProductosStockLista);
            Controls.Add(OrdenTempLista);
            Controls.Add(ProductoBuscar);
            Controls.Add(button3);
            Controls.Add(Generar);
            Controls.Add(ProdNombreBox);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenPreparacionForm";
            Text = "GenerarOrdenPreparacion";
            Load += TransportistasComboBox_SelectedIndexChanged;
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
        private Button BuscarDepositoBtn;
        private TextBox DepositoBuscarTextBox;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AgregarCantidadTextBox;
        protected TextBox ProductoSeleccionadoTxt;
        protected TextBox DepositoTxt;
        protected TextBox MaxCantidadTxt;
        private Label label4;
        private Label OrdenNdepo;
        private ListView TransportistasComboBox;
        private ColumnHeader NombreTranspor;
        private ColumnHeader ApellidoTranspor;
        private ColumnHeader DniTranspor;
        private Label label5;
        private Label label6;
        protected TextBox TransportistaSeleccionadoTxt;
        private Label label7;
        private ColumnHeader columnHeader1;
    }
}