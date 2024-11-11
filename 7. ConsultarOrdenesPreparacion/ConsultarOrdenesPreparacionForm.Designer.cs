
namespace Pampazon.ListarOrdenes
{
    partial class ConsultarOrdenesForm
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
            CodigoCLienteLBL = new Label();
            FechaInicioLBL = new Label();
            EstadoCMB = new ComboBox();
            EstadoLBL = new Label();
            BuscarOrdenBTN = new Button();
            BorrarFiltrosBTN = new Button();
            SalirBTN = new Button();
            CodigoClienteTxt = new TextBox();
            OrdenesLTV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            FechaOPColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            FiltrosGRP = new GroupBox();
            FechaFinDTP = new DateTimePicker();
            FechaInicioDTP = new DateTimePicker();
            FechaFinLBL = new Label();
            PrioridadLBL = new Label();
            PrioridadCMB = new ComboBox();
            CuitTXT = new TextBox();
            CuitLBL = new Label();
            RazonSocialTxt = new TextBox();
            RazonSocialLBL = new Label();
            DetallesGRP = new GroupBox();
            ProductoLTV = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            OrdenesGRP = new GroupBox();
            FiltrosGRP.SuspendLayout();
            DetallesGRP.SuspendLayout();
            SuspendLayout();
            // 
            // CodigoCLienteLBL
            // 
            CodigoCLienteLBL.AutoSize = true;
            CodigoCLienteLBL.Location = new Point(4, 20);
            CodigoCLienteLBL.Margin = new Padding(2, 0, 2, 0);
            CodigoCLienteLBL.Name = "CodigoCLienteLBL";
            CodigoCLienteLBL.Size = new Size(84, 15);
            CodigoCLienteLBL.TabIndex = 2;
            CodigoCLienteLBL.Text = "Código cliente";
            // 
            // FechaInicioLBL
            // 
            FechaInicioLBL.AutoSize = true;
            FechaInicioLBL.Location = new Point(399, 68);
            FechaInicioLBL.Margin = new Padding(2, 0, 2, 0);
            FechaInicioLBL.Name = "FechaInicioLBL";
            FechaInicioLBL.Size = new Size(70, 15);
            FechaInicioLBL.TabIndex = 5;
            FechaInicioLBL.Text = "Fecha inicio";
            // 
            // EstadoCMB
            // 
            EstadoCMB.FormattingEnabled = true;
            EstadoCMB.Items.AddRange(new object[] { "Pendiente", "Procesamiento", "Procesada", "Preparada", "Lista", "Entregada" });
            EstadoCMB.Location = new Point(8, 85);
            EstadoCMB.Margin = new Padding(2, 2, 2, 2);
            EstadoCMB.Name = "EstadoCMB";
            EstadoCMB.Size = new Size(174, 23);
            EstadoCMB.TabIndex = 6;
            // 
            // EstadoLBL
            // 
            EstadoLBL.AutoSize = true;
            EstadoLBL.Location = new Point(6, 68);
            EstadoLBL.Margin = new Padding(2, 0, 2, 0);
            EstadoLBL.Name = "EstadoLBL";
            EstadoLBL.Size = new Size(42, 15);
            EstadoLBL.TabIndex = 7;
            EstadoLBL.Text = "Estado";
            // 
            // BuscarOrdenBTN
            // 
            BuscarOrdenBTN.Location = new Point(444, 135);
            BuscarOrdenBTN.Margin = new Padding(2, 2, 2, 2);
            BuscarOrdenBTN.Name = "BuscarOrdenBTN";
            BuscarOrdenBTN.Size = new Size(196, 40);
            BuscarOrdenBTN.TabIndex = 8;
            BuscarOrdenBTN.Text = "&Buscar orden";
            BuscarOrdenBTN.UseVisualStyleBackColor = true;
            BuscarOrdenBTN.Click += BuscarOrdenes_Click;
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Location = new Point(648, 135);
            BorrarFiltrosBTN.Margin = new Padding(2, 2, 2, 2);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.RightToLeft = RightToLeft.No;
            BorrarFiltrosBTN.Size = new Size(187, 40);
            BorrarFiltrosBTN.TabIndex = 9;
            BorrarFiltrosBTN.Text = "&Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = true;
            BorrarFiltrosBTN.Click += BorrarFiltrosBtn_Click;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(656, 656);
            SalirBTN.Margin = new Padding(2, 2, 2, 2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 11;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += SalirBtn_Click;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(6, 37);
            CodigoClienteTxt.Margin = new Padding(2, 2, 2, 2);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(268, 23);
            CodigoClienteTxt.TabIndex = 14;
            CodigoClienteTxt.TextChanged += CodigoClienteTxt_TextChanged;
            // 
            // OrdenesLTV
            // 
            OrdenesLTV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, FechaOPColumna, EstadoColumna, PrioridadColumna });
            OrdenesLTV.Location = new Point(17, 220);
            OrdenesLTV.Name = "OrdenesLTV";
            OrdenesLTV.Size = new Size(827, 215);
            OrdenesLTV.TabIndex = 19;
            OrdenesLTV.UseCompatibleStateImageBehavior = false;
            OrdenesLTV.View = View.Details;
            OrdenesLTV.SelectedIndexChanged += OrdenesLTV_SelectedIndexChanged_1;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "ID Orden";
            IdOrdenColumna.Width = 199;
            // 
            // FechaOPColumna
            // 
            FechaOPColumna.Text = "Fecha generación Orden Preparación";
            FechaOPColumna.TextAlign = HorizontalAlignment.Center;
            FechaOPColumna.Width = 220;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.TextAlign = HorizontalAlignment.Center;
            EstadoColumna.Width = 199;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.TextAlign = HorizontalAlignment.Center;
            PrioridadColumna.Width = 200;
            // 
            // FiltrosGRP
            // 
            FiltrosGRP.Controls.Add(FechaFinDTP);
            FiltrosGRP.Controls.Add(FechaInicioDTP);
            FiltrosGRP.Controls.Add(FechaFinLBL);
            FiltrosGRP.Controls.Add(PrioridadLBL);
            FiltrosGRP.Controls.Add(PrioridadCMB);
            FiltrosGRP.Controls.Add(CuitTXT);
            FiltrosGRP.Controls.Add(CuitLBL);
            FiltrosGRP.Controls.Add(EstadoLBL);
            FiltrosGRP.Controls.Add(RazonSocialTxt);
            FiltrosGRP.Controls.Add(EstadoCMB);
            FiltrosGRP.Controls.Add(RazonSocialLBL);
            FiltrosGRP.Controls.Add(CodigoClienteTxt);
            FiltrosGRP.Controls.Add(BuscarOrdenBTN);
            FiltrosGRP.Controls.Add(FechaInicioLBL);
            FiltrosGRP.Controls.Add(BorrarFiltrosBTN);
            FiltrosGRP.Controls.Add(CodigoCLienteLBL);
            FiltrosGRP.Location = new Point(9, 9);
            FiltrosGRP.Margin = new Padding(3, 2, 3, 2);
            FiltrosGRP.Name = "FiltrosGRP";
            FiltrosGRP.Padding = new Padding(3, 2, 3, 2);
            FiltrosGRP.Size = new Size(840, 179);
            FiltrosGRP.TabIndex = 20;
            FiltrosGRP.TabStop = false;
            FiltrosGRP.Text = "Seleccione filtros de búsqueda para Clientes: ";
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Location = new Point(618, 85);
            FechaFinDTP.Margin = new Padding(3, 2, 3, 2);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(209, 23);
            FechaFinDTP.TabIndex = 25;
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Location = new Point(399, 86);
            FechaInicioDTP.Margin = new Padding(3, 2, 3, 2);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(209, 23);
            FechaInicioDTP.TabIndex = 24;
            // 
            // FechaFinLBL
            // 
            FechaFinLBL.AutoSize = true;
            FechaFinLBL.Location = new Point(618, 66);
            FechaFinLBL.Margin = new Padding(2, 0, 2, 0);
            FechaFinLBL.Name = "FechaFinLBL";
            FechaFinLBL.Size = new Size(55, 15);
            FechaFinLBL.TabIndex = 22;
            FechaFinLBL.Text = "Fecha fin";
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(194, 70);
            PrioridadLBL.Margin = new Padding(2, 0, 2, 0);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(55, 15);
            PrioridadLBL.TabIndex = 21;
            PrioridadLBL.Text = "Prioridad";
            // 
            // PrioridadCMB
            // 
            PrioridadCMB.FormattingEnabled = true;
            PrioridadCMB.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            PrioridadCMB.Location = new Point(194, 85);
            PrioridadCMB.Margin = new Padding(2, 2, 2, 2);
            PrioridadCMB.Name = "PrioridadCMB";
            PrioridadCMB.Size = new Size(201, 23);
            PrioridadCMB.TabIndex = 20;
            // 
            // CuitTXT
            // 
            CuitTXT.Location = new Point(572, 37);
            CuitTXT.Margin = new Padding(2, 2, 2, 2);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.Size = new Size(252, 23);
            CuitTXT.TabIndex = 18;
            CuitTXT.TextChanged += CuitTxt_TextChanged;
            // 
            // CuitLBL
            // 
            CuitLBL.AutoSize = true;
            CuitLBL.Location = new Point(581, 20);
            CuitLBL.Margin = new Padding(2, 0, 2, 0);
            CuitLBL.Name = "CuitLBL";
            CuitLBL.Size = new Size(29, 15);
            CuitLBL.TabIndex = 17;
            CuitLBL.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(288, 37);
            RazonSocialTxt.Margin = new Padding(2, 2, 2, 2);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(281, 23);
            RazonSocialTxt.TabIndex = 16;
            RazonSocialTxt.TextChanged += RazonSocialTxt_TextChanged;
            // 
            // RazonSocialLBL
            // 
            RazonSocialLBL.AutoSize = true;
            RazonSocialLBL.Location = new Point(288, 20);
            RazonSocialLBL.Margin = new Padding(2, 0, 2, 0);
            RazonSocialLBL.Name = "RazonSocialLBL";
            RazonSocialLBL.Size = new Size(73, 15);
            RazonSocialLBL.TabIndex = 15;
            RazonSocialLBL.Text = "Razón Social";
            // 
            // DetallesGRP
            // 
            DetallesGRP.Controls.Add(ProductoLTV);
            DetallesGRP.Location = new Point(16, 451);
            DetallesGRP.Margin = new Padding(3, 2, 3, 2);
            DetallesGRP.Name = "DetallesGRP";
            DetallesGRP.Padding = new Padding(3, 2, 3, 2);
            DetallesGRP.Size = new Size(833, 201);
            DetallesGRP.TabIndex = 21;
            DetallesGRP.TabStop = false;
            DetallesGRP.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // ProductoLTV
            // 
            ProductoLTV.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna });
            ProductoLTV.Location = new Point(6, 21);
            ProductoLTV.Name = "ProductoLTV";
            ProductoLTV.Size = new Size(822, 176);
            ProductoLTV.TabIndex = 23;
            ProductoLTV.UseCompatibleStateImageBehavior = false;
            ProductoLTV.View = View.Details;
            // 
            // SKU_Columna
            // 
            SKU_Columna.Text = "SKU Producto";
            SKU_Columna.Width = 199;
            // 
            // Producto_Columna
            // 
            Producto_Columna.Text = "Producto";
            Producto_Columna.TextAlign = HorizontalAlignment.Center;
            Producto_Columna.Width = 199;
            // 
            // Cantidad_Columna
            // 
            Cantidad_Columna.Text = "Cantidad";
            Cantidad_Columna.TextAlign = HorizontalAlignment.Center;
            Cantidad_Columna.Width = 199;
            // 
            // OrdenesGRP
            // 
            OrdenesGRP.Location = new Point(9, 202);
            OrdenesGRP.Margin = new Padding(3, 2, 3, 2);
            OrdenesGRP.Name = "OrdenesGRP";
            OrdenesGRP.Padding = new Padding(3, 2, 3, 2);
            OrdenesGRP.Size = new Size(840, 237);
            OrdenesGRP.TabIndex = 22;
            OrdenesGRP.TabStop = false;
            OrdenesGRP.Text = "Ordenes encontradas";
            OrdenesGRP.Enter += OrdenesGRP_Enter;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 562);
            Controls.Add(OrdenesLTV);
            Controls.Add(SalirBTN);
            Controls.Add(FiltrosGRP);
            Controls.Add(DetallesGRP);
            Controls.Add(OrdenesGRP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultarOrdenesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Ordenes de Preparación";
            Load += ListarOrdenes_Load;
            FiltrosGRP.ResumeLayout(false);
            FiltrosGRP.PerformLayout();
            DetallesGRP.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private System.Windows.Forms.Label CodigoCLienteLBL;
        private System.Windows.Forms.Label FechaInicioLBL;
        private System.Windows.Forms.ComboBox EstadoCMB;
        private System.Windows.Forms.Label EstadoLBL;
        private System.Windows.Forms.Button BuscarOrdenBTN;
        private System.Windows.Forms.Button BorrarFiltrosBTN;
        private System.Windows.Forms.Button SalirBTN;
        private System.Windows.Forms.TextBox CodigoClienteTxt;
        private ListView OrdenesLTV;
        private ColumnHeader IdOrdenColumna;
        private GroupBox FiltrosGRP;
        private TextBox CuitTXT;
        private Label CuitLBL;
        private TextBox RazonSocialTxt;
        private Label RazonSocialLBL;
        private GroupBox DetallesGRP;
        private ListView ProductoLTV;
        private ColumnHeader SKU_Columna;
        private ColumnHeader Producto_Columna;
        private ColumnHeader Cantidad_Columna;
        private ColumnHeader FechaOPColumna;
        private ColumnHeader EstadoColumna;
        private ColumnHeader PrioridadColumna;
        private Label PrioridadLBL;
        private ComboBox PrioridadCMB;
        private GroupBox OrdenesGRP;
        private Label FechaFinLBL;
        private DateTimePicker FechaFinDTP;
        private DateTimePicker FechaInicioDTP;
    }
}