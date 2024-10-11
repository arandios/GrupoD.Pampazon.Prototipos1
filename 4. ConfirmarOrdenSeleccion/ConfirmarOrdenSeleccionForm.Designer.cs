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
            DetallesOrdenBTN = new Button();
            LSTDetalleOrden = new ListView();
            CodCliente_Columna = new ColumnHeader();
            RazonSocialCli_Columna = new ColumnHeader();
            SKUProducto_Columna = new ColumnHeader();
            DetalleProducto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            Ubicacion_columna = new ColumnHeader();
            SalirBTN = new Button();
            GenerarOrdenEntregaBTN = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(613, 88);
            LimpiarBTN.Margin = new Padding(2);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(101, 34);
            LimpiarBTN.TabIndex = 16;
            LimpiarBTN.Text = "&Borrar filtros";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(376, 88);
            BuscarBTN.Margin = new Padding(2);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(236, 34);
            BuscarBTN.TabIndex = 15;
            BuscarBTN.Text = "&Buscar Ordenes de Selección";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 14;
            label1.Text = "ID de Orden Seleccion";
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(14, 55);
            IdOrdentxt.Margin = new Padding(2);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(700, 27);
            IdOrdentxt.TabIndex = 13;
            // 
            // LstOrdenesSeleccion
            // 
            LstOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { CLNroOrden });
            LstOrdenesSeleccion.FullRowSelect = true;
            LstOrdenesSeleccion.Location = new Point(0, 27);
            LstOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            LstOrdenesSeleccion.MultiSelect = false;
            LstOrdenesSeleccion.Name = "LstOrdenesSeleccion";
            LstOrdenesSeleccion.Size = new Size(717, 201);
            LstOrdenesSeleccion.TabIndex = 26;
            LstOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            LstOrdenesSeleccion.View = View.Details;
            // 
            // CLNroOrden
            // 
            CLNroOrden.Text = "ID Orden Seleccion";
            CLNroOrden.Width = 175;
            // 
            // DetallesOrdenBTN
            // 
            DetallesOrdenBTN.Location = new Point(450, 234);
            DetallesOrdenBTN.Margin = new Padding(2);
            DetallesOrdenBTN.Name = "DetallesOrdenBTN";
            DetallesOrdenBTN.Size = new Size(266, 32);
            DetallesOrdenBTN.TabIndex = 25;
            DetallesOrdenBTN.Text = "&Ver detalles de Orden de Selección";
            DetallesOrdenBTN.UseVisualStyleBackColor = true;
            DetallesOrdenBTN.Click += DetallesOrdenBTN_Click;
            // 
            // LSTDetalleOrden
            // 
            LSTDetalleOrden.Columns.AddRange(new ColumnHeader[] { CodCliente_Columna, RazonSocialCli_Columna, SKUProducto_Columna, DetalleProducto_Columna, Cantidad_Columna, Ubicacion_columna });
            LSTDetalleOrden.FullRowSelect = true;
            LSTDetalleOrden.Location = new Point(2, 25);
            LSTDetalleOrden.Margin = new Padding(2);
            LSTDetalleOrden.MultiSelect = false;
            LSTDetalleOrden.Name = "LSTDetalleOrden";
            LSTDetalleOrden.Size = new Size(718, 216);
            LSTDetalleOrden.TabIndex = 24;
            LSTDetalleOrden.UseCompatibleStateImageBehavior = false;
            LSTDetalleOrden.View = View.Details;
            // 
            // CodCliente_Columna
            // 
            CodCliente_Columna.Text = "Código Cliente";
            // 
            // RazonSocialCli_Columna
            // 
            RazonSocialCli_Columna.Text = "Razón Social Cliente";
            // 
            // SKUProducto_Columna
            // 
            SKUProducto_Columna.Text = "SKU Producto";
            SKUProducto_Columna.Width = 110;
            // 
            // DetalleProducto_Columna
            // 
            DetalleProducto_Columna.Text = "Producto";
            DetalleProducto_Columna.Width = 110;
            // 
            // Cantidad_Columna
            // 
            Cantidad_Columna.DisplayIndex = 5;
            Cantidad_Columna.Text = "Cantidad";
            Cantidad_Columna.Width = 100;
            // 
            // Ubicacion_columna
            // 
            Ubicacion_columna.DisplayIndex = 4;
            Ubicacion_columna.Text = "Ubicación";
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(654, 702);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(81, 31);
            SalirBTN.TabIndex = 27;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // GenerarOrdenEntregaBTN
            // 
            GenerarOrdenEntregaBTN.Location = new Point(432, 702);
            GenerarOrdenEntregaBTN.Margin = new Padding(2);
            GenerarOrdenEntregaBTN.Name = "GenerarOrdenEntregaBTN";
            GenerarOrdenEntregaBTN.Size = new Size(218, 31);
            GenerarOrdenEntregaBTN.TabIndex = 22;
            GenerarOrdenEntregaBTN.Text = "&Confirmar Orden de Selección";
            GenerarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            GenerarOrdenEntregaBTN.Click += ConfirmarOrdenSeleccionBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LimpiarBTN);
            groupBox1.Controls.Add(BuscarBTN);
            groupBox1.Controls.Add(IdOrdentxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 126);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Ordenes de Selección:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DetallesOrdenBTN);
            groupBox2.Controls.Add(LstOrdenesSeleccion);
            groupBox2.Location = new Point(9, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(724, 266);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Ordenes de Selección en estado Pendiente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LSTDetalleOrden);
            groupBox3.Location = new Point(12, 416);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(725, 266);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de Orden de Seleccion a confirmar: ";
            // 
            // ConfirmarOrdenSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 751);
            Controls.Add(SalirBTN);
            Controls.Add(GenerarOrdenEntregaBTN);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Margin = new Padding(2);
            Name = "ConfirmarOrdenSeleccion";
            Text = "Confirmar Orden de Selección";
            Load += ConfirmarOrdenSeleccion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button LimpiarBTN;
        private Button BuscarBTN;
        private Label label1;
        private TextBox IdOrdentxt;
        private ListView LstOrdenesSeleccion;
        private ColumnHeader CLNroOrden;
        private Button DetallesOrdenBTN;
        private ListView LSTDetalleOrden;
        private ColumnHeader SKUProducto_Columna;
        private ColumnHeader DetalleProducto_Columna;
        private ColumnHeader Cantidad_Columna;
        private Button SalirBTN;
        private Button GenerarOrdenEntregaBTN;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ColumnHeader CodCliente_Columna;
        private ColumnHeader RazonSocialCli_Columna;
        private ColumnHeader Ubicacion_columna;
    }
}