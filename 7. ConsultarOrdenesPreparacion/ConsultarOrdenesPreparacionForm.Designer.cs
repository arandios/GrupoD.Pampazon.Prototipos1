﻿
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
            CodigoCLienteLBL.Location = new Point(5, 27);
            CodigoCLienteLBL.Margin = new Padding(2, 0, 2, 0);
            CodigoCLienteLBL.Name = "CodigoCLienteLBL";
            CodigoCLienteLBL.Size = new Size(74, 20);
            CodigoCLienteLBL.TabIndex = 2;
            CodigoCLienteLBL.Text = "ID Cliente";
            CodigoCLienteLBL.Click += CodigoCLienteLBL_Click;
            // 
            // FechaInicioLBL
            // 
            FechaInicioLBL.AutoSize = true;
            FechaInicioLBL.Location = new Point(456, 91);
            FechaInicioLBL.Margin = new Padding(2, 0, 2, 0);
            FechaInicioLBL.Name = "FechaInicioLBL";
            FechaInicioLBL.Size = new Size(87, 20);
            FechaInicioLBL.TabIndex = 5;
            FechaInicioLBL.Text = "Fecha inicio";
            // 
            // EstadoCMB
            // 
            EstadoCMB.FormattingEnabled = true;
            EstadoCMB.Items.AddRange(new object[] { "Pendiente", "Procesamiento", "Procesada", "Preparada", "Lista", "Entregada" });
            EstadoCMB.Location = new Point(9, 113);
            EstadoCMB.Margin = new Padding(2, 3, 2, 3);
            EstadoCMB.Name = "EstadoCMB";
            EstadoCMB.Size = new Size(198, 28);
            EstadoCMB.TabIndex = 6;
            // 
            // EstadoLBL
            // 
            EstadoLBL.AutoSize = true;
            EstadoLBL.Location = new Point(7, 91);
            EstadoLBL.Margin = new Padding(2, 0, 2, 0);
            EstadoLBL.Name = "EstadoLBL";
            EstadoLBL.Size = new Size(54, 20);
            EstadoLBL.TabIndex = 7;
            EstadoLBL.Text = "Estado";
            // 
            // BuscarOrdenBTN
            // 
            BuscarOrdenBTN.Location = new Point(507, 180);
            BuscarOrdenBTN.Margin = new Padding(2, 3, 2, 3);
            BuscarOrdenBTN.Name = "BuscarOrdenBTN";
            BuscarOrdenBTN.Size = new Size(224, 53);
            BuscarOrdenBTN.TabIndex = 8;
            BuscarOrdenBTN.Text = "&Buscar orden";
            BuscarOrdenBTN.UseVisualStyleBackColor = true;
            BuscarOrdenBTN.Click += BuscarOrdenes_Click;
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Location = new Point(741, 180);
            BorrarFiltrosBTN.Margin = new Padding(2, 3, 2, 3);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.RightToLeft = RightToLeft.No;
            BorrarFiltrosBTN.Size = new Size(214, 53);
            BorrarFiltrosBTN.TabIndex = 9;
            BorrarFiltrosBTN.Text = "&Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = true;
            BorrarFiltrosBTN.Click += BorrarFiltrosBtn_Click;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(750, 875);
            SalirBTN.Margin = new Padding(2, 3, 2, 3);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(214, 53);
            SalirBTN.TabIndex = 11;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += SalirBtn_Click;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(7, 49);
            CodigoClienteTxt.Margin = new Padding(2, 3, 2, 3);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(306, 27);
            CodigoClienteTxt.TabIndex = 14;
            CodigoClienteTxt.TextChanged += CodigoClienteTxt_TextChanged;
            // 
            // OrdenesLTV
            // 
            OrdenesLTV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, FechaOPColumna, EstadoColumna, PrioridadColumna });
            OrdenesLTV.Location = new Point(19, 293);
            OrdenesLTV.Margin = new Padding(3, 4, 3, 4);
            OrdenesLTV.Name = "OrdenesLTV";
            OrdenesLTV.Size = new Size(945, 285);
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
            FiltrosGRP.Location = new Point(10, 12);
            FiltrosGRP.Name = "FiltrosGRP";
            FiltrosGRP.Size = new Size(960, 239);
            FiltrosGRP.TabIndex = 20;
            FiltrosGRP.TabStop = false;
            FiltrosGRP.Text = "Seleccione filtros de búsqueda para Clientes: ";
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Location = new Point(706, 113);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(238, 27);
            FechaFinDTP.TabIndex = 25;
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Location = new Point(456, 115);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(238, 27);
            FechaInicioDTP.TabIndex = 24;
            // 
            // FechaFinLBL
            // 
            FechaFinLBL.AutoSize = true;
            FechaFinLBL.Location = new Point(706, 88);
            FechaFinLBL.Margin = new Padding(2, 0, 2, 0);
            FechaFinLBL.Name = "FechaFinLBL";
            FechaFinLBL.Size = new Size(68, 20);
            FechaFinLBL.TabIndex = 22;
            FechaFinLBL.Text = "Fecha fin";
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(222, 93);
            PrioridadLBL.Margin = new Padding(2, 0, 2, 0);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(70, 20);
            PrioridadLBL.TabIndex = 21;
            PrioridadLBL.Text = "Prioridad";
            // 
            // PrioridadCMB
            // 
            PrioridadCMB.FormattingEnabled = true;
            PrioridadCMB.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            PrioridadCMB.Location = new Point(222, 113);
            PrioridadCMB.Margin = new Padding(2, 3, 2, 3);
            PrioridadCMB.Name = "PrioridadCMB";
            PrioridadCMB.Size = new Size(229, 28);
            PrioridadCMB.TabIndex = 20;
            // 
            // CuitTXT
            // 
            CuitTXT.Location = new Point(654, 49);
            CuitTXT.Margin = new Padding(2, 3, 2, 3);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.Size = new Size(287, 27);
            CuitTXT.TabIndex = 18;
            CuitTXT.TextChanged += CuitTxt_TextChanged;
            // 
            // CuitLBL
            // 
            CuitLBL.AutoSize = true;
            CuitLBL.Location = new Point(664, 27);
            CuitLBL.Margin = new Padding(2, 0, 2, 0);
            CuitLBL.Name = "CuitLBL";
            CuitLBL.Size = new Size(35, 20);
            CuitLBL.TabIndex = 17;
            CuitLBL.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(329, 49);
            RazonSocialTxt.Margin = new Padding(2, 3, 2, 3);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(321, 27);
            RazonSocialTxt.TabIndex = 16;
            RazonSocialTxt.TextChanged += RazonSocialTxt_TextChanged;
            // 
            // RazonSocialLBL
            // 
            RazonSocialLBL.AutoSize = true;
            RazonSocialLBL.Location = new Point(329, 27);
            RazonSocialLBL.Margin = new Padding(2, 0, 2, 0);
            RazonSocialLBL.Name = "RazonSocialLBL";
            RazonSocialLBL.Size = new Size(94, 20);
            RazonSocialLBL.TabIndex = 15;
            RazonSocialLBL.Text = "Razón Social";
            // 
            // DetallesGRP
            // 
            DetallesGRP.Controls.Add(ProductoLTV);
            DetallesGRP.Location = new Point(18, 601);
            DetallesGRP.Name = "DetallesGRP";
            DetallesGRP.Size = new Size(952, 268);
            DetallesGRP.TabIndex = 21;
            DetallesGRP.TabStop = false;
            DetallesGRP.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // ProductoLTV
            // 
            ProductoLTV.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna });
            ProductoLTV.Location = new Point(7, 28);
            ProductoLTV.Margin = new Padding(3, 4, 3, 4);
            ProductoLTV.Name = "ProductoLTV";
            ProductoLTV.Size = new Size(939, 233);
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
            OrdenesGRP.Location = new Point(10, 269);
            OrdenesGRP.Name = "OrdenesGRP";
            OrdenesGRP.Size = new Size(960, 316);
            OrdenesGRP.TabIndex = 22;
            OrdenesGRP.TabStop = false;
            OrdenesGRP.Text = "Ordenes encontradas";
            OrdenesGRP.Enter += OrdenesGRP_Enter;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 749);
            Controls.Add(OrdenesLTV);
            Controls.Add(SalirBTN);
            Controls.Add(FiltrosGRP);
            Controls.Add(DetallesGRP);
            Controls.Add(OrdenesGRP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
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