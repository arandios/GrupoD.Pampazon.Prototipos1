
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
            OrdenesGRP.SuspendLayout();
            SuspendLayout();
            // 
            // CodigoCLienteLBL
            // 
            CodigoCLienteLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CodigoCLienteLBL.AutoSize = true;
            CodigoCLienteLBL.Location = new Point(8, 18);
            CodigoCLienteLBL.Margin = new Padding(2, 0, 2, 0);
            CodigoCLienteLBL.Name = "CodigoCLienteLBL";
            CodigoCLienteLBL.Size = new Size(58, 15);
            CodigoCLienteLBL.TabIndex = 2;
            CodigoCLienteLBL.Text = "ID Cliente";
            CodigoCLienteLBL.Click += CodigoCLienteLBL_Click;
            // 
            // FechaInicioLBL
            // 
            FechaInicioLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            FechaInicioLBL.AutoSize = true;
            FechaInicioLBL.Location = new Point(313, 69);
            FechaInicioLBL.Margin = new Padding(2, 0, 2, 0);
            FechaInicioLBL.Name = "FechaInicioLBL";
            FechaInicioLBL.Size = new Size(70, 15);
            FechaInicioLBL.TabIndex = 5;
            FechaInicioLBL.Text = "Fecha inicio";
            // 
            // EstadoCMB
            // 
            EstadoCMB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EstadoCMB.FormattingEnabled = true;
            EstadoCMB.Items.AddRange(new object[] { "Pendiente", "Procesamiento", "Procesada", "Preparada", "Lista", "Entregada" });
            EstadoCMB.Location = new Point(12, 84);
            EstadoCMB.Margin = new Padding(2);
            EstadoCMB.Name = "EstadoCMB";
            EstadoCMB.Size = new Size(282, 23);
            EstadoCMB.TabIndex = 4;
            // 
            // EstadoLBL
            // 
            EstadoLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EstadoLBL.AutoSize = true;
            EstadoLBL.Location = new Point(10, 66);
            EstadoLBL.Margin = new Padding(2, 0, 2, 0);
            EstadoLBL.Name = "EstadoLBL";
            EstadoLBL.Size = new Size(42, 15);
            EstadoLBL.TabIndex = 7;
            EstadoLBL.Text = "Estado";
            // 
            // BuscarOrdenBTN
            // 
            BuscarOrdenBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BuscarOrdenBTN.BackColor = Color.FromArgb(192, 255, 192);
            BuscarOrdenBTN.Location = new Point(623, 67);
            BuscarOrdenBTN.Margin = new Padding(2);
            BuscarOrdenBTN.Name = "BuscarOrdenBTN";
            BuscarOrdenBTN.Size = new Size(281, 40);
            BuscarOrdenBTN.TabIndex = 8;
            BuscarOrdenBTN.Text = "&Buscar orden";
            BuscarOrdenBTN.UseVisualStyleBackColor = false;
            BuscarOrdenBTN.Click += BuscarOrdenes_Click;
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BorrarFiltrosBTN.BackColor = Color.FromArgb(255, 192, 192);
            BorrarFiltrosBTN.Location = new Point(623, 117);
            BorrarFiltrosBTN.Margin = new Padding(2);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.RightToLeft = RightToLeft.No;
            BorrarFiltrosBTN.Size = new Size(281, 40);
            BorrarFiltrosBTN.TabIndex = 9;
            BorrarFiltrosBTN.Text = "&Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = false;
            BorrarFiltrosBTN.Click += BorrarFiltrosBtn_Click;
            // 
            // SalirBTN
            // 
            SalirBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirBTN.Location = new Point(720, 604);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 12;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += SalirBtn_Click;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CodigoClienteTxt.Location = new Point(12, 35);
            CodigoClienteTxt.Margin = new Padding(2);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.PlaceholderText = "Ingrese un ID Cliente";
            CodigoClienteTxt.Size = new Size(282, 23);
            CodigoClienteTxt.TabIndex = 1;
            CodigoClienteTxt.TextChanged += CodigoClienteTxt_TextChanged;
            // 
            // OrdenesLTV
            // 
            OrdenesLTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenesLTV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, FechaOPColumna, EstadoColumna, PrioridadColumna });
            OrdenesLTV.Location = new Point(6, 21);
            OrdenesLTV.Name = "OrdenesLTV";
            OrdenesLTV.Size = new Size(898, 148);
            OrdenesLTV.TabIndex = 10;
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
            FiltrosGRP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            FiltrosGRP.Size = new Size(911, 175);
            FiltrosGRP.TabIndex = 20;
            FiltrosGRP.TabStop = false;
            FiltrosGRP.Text = "Seleccione filtros de búsqueda para Clientes: ";
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            FechaFinDTP.Location = new Point(313, 134);
            FechaFinDTP.Margin = new Padding(3, 2, 3, 2);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(282, 23);
            FechaFinDTP.TabIndex = 6;
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            FechaInicioDTP.Location = new Point(313, 87);
            FechaInicioDTP.Margin = new Padding(3, 2, 3, 2);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(282, 23);
            FechaInicioDTP.TabIndex = 5;
            // 
            // FechaFinLBL
            // 
            FechaFinLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            FechaFinLBL.AutoSize = true;
            FechaFinLBL.Location = new Point(313, 116);
            FechaFinLBL.Margin = new Padding(2, 0, 2, 0);
            FechaFinLBL.Name = "FechaFinLBL";
            FechaFinLBL.Size = new Size(55, 15);
            FechaFinLBL.TabIndex = 22;
            FechaFinLBL.Text = "Fecha fin";
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(11, 117);
            PrioridadLBL.Margin = new Padding(2, 0, 2, 0);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(55, 15);
            PrioridadLBL.TabIndex = 21;
            PrioridadLBL.Text = "Prioridad";
            // 
            // PrioridadCMB
            // 
            PrioridadCMB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PrioridadCMB.FormattingEnabled = true;
            PrioridadCMB.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            PrioridadCMB.Location = new Point(11, 134);
            PrioridadCMB.Margin = new Padding(2);
            PrioridadCMB.Name = "PrioridadCMB";
            PrioridadCMB.Size = new Size(282, 23);
            PrioridadCMB.TabIndex = 7;
            // 
            // CuitTXT
            // 
            CuitTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CuitTXT.Location = new Point(623, 35);
            CuitTXT.Margin = new Padding(2);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.PlaceholderText = "Ingrese un CUIT";
            CuitTXT.Size = new Size(282, 23);
            CuitTXT.TabIndex = 3;
            CuitTXT.TextChanged += CuitTxt_TextChanged;
            // 
            // CuitLBL
            // 
            CuitLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CuitLBL.AutoSize = true;
            CuitLBL.Location = new Point(623, 18);
            CuitLBL.Margin = new Padding(2, 0, 2, 0);
            CuitLBL.Name = "CuitLBL";
            CuitLBL.Size = new Size(29, 15);
            CuitLBL.TabIndex = 17;
            CuitLBL.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RazonSocialTxt.Location = new Point(313, 38);
            RazonSocialTxt.Margin = new Padding(2);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.PlaceholderText = "Ingrese una Razon Social";
            RazonSocialTxt.Size = new Size(282, 23);
            RazonSocialTxt.TabIndex = 2;
            RazonSocialTxt.TextChanged += RazonSocialTxt_TextChanged;
            // 
            // RazonSocialLBL
            // 
            RazonSocialLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RazonSocialLBL.AutoSize = true;
            RazonSocialLBL.Location = new Point(313, 21);
            RazonSocialLBL.Margin = new Padding(2, 0, 2, 0);
            RazonSocialLBL.Name = "RazonSocialLBL";
            RazonSocialLBL.Size = new Size(73, 15);
            RazonSocialLBL.TabIndex = 15;
            RazonSocialLBL.Text = "Razón Social";
            // 
            // DetallesGRP
            // 
            DetallesGRP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetallesGRP.Controls.Add(ProductoLTV);
            DetallesGRP.Location = new Point(9, 377);
            DetallesGRP.Margin = new Padding(3, 2, 3, 2);
            DetallesGRP.Name = "DetallesGRP";
            DetallesGRP.Padding = new Padding(3, 2, 3, 2);
            DetallesGRP.Size = new Size(911, 223);
            DetallesGRP.TabIndex = 21;
            DetallesGRP.TabStop = false;
            DetallesGRP.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // ProductoLTV
            // 
            ProductoLTV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductoLTV.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna });
            ProductoLTV.Location = new Point(6, 18);
            ProductoLTV.Name = "ProductoLTV";
            ProductoLTV.Size = new Size(898, 200);
            ProductoLTV.TabIndex = 11;
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
            OrdenesGRP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenesGRP.Controls.Add(OrdenesLTV);
            OrdenesGRP.Location = new Point(9, 188);
            OrdenesGRP.Margin = new Padding(3, 2, 3, 2);
            OrdenesGRP.Name = "OrdenesGRP";
            OrdenesGRP.Padding = new Padding(3, 2, 3, 2);
            OrdenesGRP.Size = new Size(911, 185);
            OrdenesGRP.TabIndex = 22;
            OrdenesGRP.TabStop = false;
            OrdenesGRP.Text = "Ordenes encontradas";
            OrdenesGRP.Enter += OrdenesGRP_Enter;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(932, 651);
            Controls.Add(SalirBTN);
            Controls.Add(FiltrosGRP);
            Controls.Add(DetallesGRP);
            Controls.Add(OrdenesGRP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ConsultarOrdenesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Ordenes de Preparación";
            Load += ListarOrdenes_Load;
            FiltrosGRP.ResumeLayout(false);
            FiltrosGRP.PerformLayout();
            DetallesGRP.ResumeLayout(false);
            OrdenesGRP.ResumeLayout(false);
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