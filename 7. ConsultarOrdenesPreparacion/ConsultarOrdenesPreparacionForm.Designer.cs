
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
            label2 = new Label();
            label3 = new Label();
            EstadoComboBox = new ComboBox();
            label4 = new Label();
            BuscarOrdenBtn = new Button();
            BorrarFiltrosBtn = new Button();
            SalirBtn = new Button();
            CodigoClienteTxt = new TextBox();
            OrdenesLTV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            FechaOPColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            FiltrosGBX = new GroupBox();
            FechaFinDTP = new DateTimePicker();
            FechaInicioDTP = new DateTimePicker();
            label5 = new Label();
            label8 = new Label();
            PrioridadComboBox = new ComboBox();
            CuitTxt = new TextBox();
            label7 = new Label();
            RazonSocialTxt = new TextBox();
            label1 = new Label();
            DetallesGBX = new GroupBox();
            ProductoLTV = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            Ubicacion_Columna = new ColumnHeader();
            OrdenesGBX = new GroupBox();
            FiltrosGBX.SuspendLayout();
            DetallesGBX.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Código cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha inicio";
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Items.AddRange(new object[] { "Emitida", "Selccionada", "Preparada", "Despachada" });
            EstadoComboBox.Location = new Point(8, 85);
            EstadoComboBox.Margin = new Padding(2);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(174, 23);
            EstadoComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 68);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // BuscarOrdenBtn
            // 
            BuscarOrdenBtn.Location = new Point(444, 135);
            BuscarOrdenBtn.Margin = new Padding(2);
            BuscarOrdenBtn.Name = "BuscarOrdenBtn";
            BuscarOrdenBtn.Size = new Size(196, 40);
            BuscarOrdenBtn.TabIndex = 8;
            BuscarOrdenBtn.Text = "&Buscar orden";
            BuscarOrdenBtn.UseVisualStyleBackColor = true;
            BuscarOrdenBtn.Click += BuscarOrdenes_Click;
            // 
            // BorrarFiltrosBtn
            // 
            BorrarFiltrosBtn.Location = new Point(648, 135);
            BorrarFiltrosBtn.Margin = new Padding(2);
            BorrarFiltrosBtn.Name = "BorrarFiltrosBtn";
            BorrarFiltrosBtn.RightToLeft = RightToLeft.No;
            BorrarFiltrosBtn.Size = new Size(187, 40);
            BorrarFiltrosBtn.TabIndex = 9;
            BorrarFiltrosBtn.Text = "&Borrar filtros";
            BorrarFiltrosBtn.UseVisualStyleBackColor = true;
            BorrarFiltrosBtn.Click += BorrarFiltrosBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(656, 656);
            SalirBtn.Margin = new Padding(2);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(187, 40);
            SalirBtn.TabIndex = 11;
            SalirBtn.Text = "&Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(6, 37);
            CodigoClienteTxt.Margin = new Padding(2);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(268, 23);
            CodigoClienteTxt.TabIndex = 14;
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
            // FiltrosGBX
            // 
            FiltrosGBX.Controls.Add(FechaFinDTP);
            FiltrosGBX.Controls.Add(FechaInicioDTP);
            FiltrosGBX.Controls.Add(label5);
            FiltrosGBX.Controls.Add(label8);
            FiltrosGBX.Controls.Add(PrioridadComboBox);
            FiltrosGBX.Controls.Add(CuitTxt);
            FiltrosGBX.Controls.Add(label7);
            FiltrosGBX.Controls.Add(label4);
            FiltrosGBX.Controls.Add(RazonSocialTxt);
            FiltrosGBX.Controls.Add(EstadoComboBox);
            FiltrosGBX.Controls.Add(label1);
            FiltrosGBX.Controls.Add(CodigoClienteTxt);
            FiltrosGBX.Controls.Add(BuscarOrdenBtn);
            FiltrosGBX.Controls.Add(label3);
            FiltrosGBX.Controls.Add(BorrarFiltrosBtn);
            FiltrosGBX.Controls.Add(label2);
            FiltrosGBX.Location = new Point(9, 9);
            FiltrosGBX.Margin = new Padding(3, 2, 3, 2);
            FiltrosGBX.Name = "FiltrosGBX";
            FiltrosGBX.Padding = new Padding(3, 2, 3, 2);
            FiltrosGBX.Size = new Size(840, 179);
            FiltrosGBX.TabIndex = 20;
            FiltrosGBX.TabStop = false;
            FiltrosGBX.Text = "Seleccione filtros de búsqueda para Clientes: ";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 66);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 22;
            label5.Text = "Fecha fin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 70);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 21;
            label8.Text = "Prioridad";
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            PrioridadComboBox.Location = new Point(194, 85);
            PrioridadComboBox.Margin = new Padding(2);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(201, 23);
            PrioridadComboBox.TabIndex = 20;
            // 
            // CuitTxt
            // 
            CuitTxt.Location = new Point(572, 37);
            CuitTxt.Margin = new Padding(2);
            CuitTxt.Name = "CuitTxt";
            CuitTxt.Size = new Size(252, 23);
            CuitTxt.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(581, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 17;
            label7.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(288, 37);
            RazonSocialTxt.Margin = new Padding(2);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(281, 23);
            RazonSocialTxt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Razón Social";
            // 
            // DetallesGBX
            // 
            DetallesGBX.Controls.Add(ProductoLTV);
            DetallesGBX.Location = new Point(16, 451);
            DetallesGBX.Margin = new Padding(3, 2, 3, 2);
            DetallesGBX.Name = "DetallesGBX";
            DetallesGBX.Padding = new Padding(3, 2, 3, 2);
            DetallesGBX.Size = new Size(833, 201);
            DetallesGBX.TabIndex = 21;
            DetallesGBX.TabStop = false;
            DetallesGBX.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // ProductoLTV
            // 
            ProductoLTV.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna, Ubicacion_Columna });
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
            // Ubicacion_Columna
            // 
            Ubicacion_Columna.Text = "Ubicación";
            Ubicacion_Columna.TextAlign = HorizontalAlignment.Center;
            Ubicacion_Columna.Width = 199;
            // 
            // OrdenesGBX
            // 
            OrdenesGBX.Location = new Point(9, 202);
            OrdenesGBX.Margin = new Padding(3, 2, 3, 2);
            OrdenesGBX.Name = "OrdenesGBX";
            OrdenesGBX.Padding = new Padding(3, 2, 3, 2);
            OrdenesGBX.Size = new Size(840, 237);
            OrdenesGBX.TabIndex = 22;
            OrdenesGBX.TabStop = false;
            OrdenesGBX.Text = "Ordenes encontradas";
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 706);
            Controls.Add(OrdenesLTV);
            Controls.Add(SalirBtn);
            Controls.Add(FiltrosGBX);
            Controls.Add(DetallesGBX);
            Controls.Add(OrdenesGBX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ConsultarOrdenesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Ordenes de Preparación";
            Load += ListarOrdenes_Load;
            FiltrosGBX.ResumeLayout(false);
            FiltrosGBX.PerformLayout();
            DetallesGBX.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarOrdenBtn;
        private System.Windows.Forms.Button BorrarFiltrosBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.TextBox CodigoClienteTxt;
        private ListView OrdenesLTV;
        private ColumnHeader IdOrdenColumna;
        private GroupBox FiltrosGBX;
        private TextBox CuitTxt;
        private Label label7;
        private TextBox RazonSocialTxt;
        private Label label1;
        private GroupBox DetallesGBX;
        private ListView ProductoLTV;
        private ColumnHeader SKU_Columna;
        private ColumnHeader Producto_Columna;
        private ColumnHeader Cantidad_Columna;
        private ColumnHeader FechaOPColumna;
        private ColumnHeader EstadoColumna;
        private ColumnHeader PrioridadColumna;
        private Label label8;
        private ComboBox PrioridadComboBox;
        private ColumnHeader Ubicacion_Columna;
        private GroupBox OrdenesGBX;
        private Label label5;
        private DateTimePicker FechaFinDTP;
        private DateTimePicker FechaInicioDTP;
    }
}