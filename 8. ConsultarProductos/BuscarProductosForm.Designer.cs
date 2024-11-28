
namespace Pampazon._8._ConsultarProductos
{
    partial class BuscarProductosForm
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
            ProductosLTV = new ListView();
            SKUColumna = new ColumnHeader();
            NombrePrdoColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            ClienteRZColumna = new ColumnHeader();
            UbicacionColumna = new ColumnHeader();
            stockColumna = new ColumnHeader();
            FiltrosGRP = new GroupBox();
            CuitLBL = new Label();
            label2 = new Label();
            RazonSocialLBL = new Label();
            CuitTXT = new TextBox();
            label1 = new Label();
            SKUTxt = new TextBox();
            BuscarBtn = new Button();
            PrioridadLBL = new Label();
            BorrarFiltrosBTN = new Button();
            StockMinimoTxt = new TextBox();
            CodigoCLienteLBL = new Label();
            RazonSocialTxt = new TextBox();
            SKULBL = new Label();
            StockMaximoTxt = new TextBox();
            CodigoClienteTxt = new TextBox();
            NombreProdTxt = new TextBox();
            SalirBTN = new Button();
            FiltrosGRP.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosLTV
            // 
            ProductosLTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductosLTV.Columns.AddRange(new ColumnHeader[] { SKUColumna, NombrePrdoColumna, idClienteColumna, ClienteRZColumna, UbicacionColumna, stockColumna });
            ProductosLTV.Location = new Point(12, 253);
            ProductosLTV.MinimumSize = new Size(826, 192);
            ProductosLTV.Name = "ProductosLTV";
            ProductosLTV.Size = new Size(878, 278);
            ProductosLTV.TabIndex = 11;
            ProductosLTV.UseCompatibleStateImageBehavior = false;
            ProductosLTV.View = View.Details;
            ProductosLTV.SelectedIndexChanged += ProductosLTV_SelectedIndexChanged;
            // 
            // SKUColumna
            // 
            SKUColumna.Text = "SKU";
            SKUColumna.Width = 120;
            // 
            // NombrePrdoColumna
            // 
            NombrePrdoColumna.Text = "Nombre Producto";
            NombrePrdoColumna.Width = 200;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "Id Cliente";
            idClienteColumna.TextAlign = HorizontalAlignment.Center;
            idClienteColumna.Width = 120;
            // 
            // ClienteRZColumna
            // 
            ClienteRZColumna.Text = "Razon Social";
            ClienteRZColumna.Width = 200;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicacion";
            UbicacionColumna.TextAlign = HorizontalAlignment.Center;
            UbicacionColumna.Width = 120;
            // 
            // stockColumna
            // 
            stockColumna.Text = "Stock";
            // 
            // FiltrosGRP
            // 
            FiltrosGRP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FiltrosGRP.Controls.Add(CuitLBL);
            FiltrosGRP.Controls.Add(label2);
            FiltrosGRP.Controls.Add(RazonSocialLBL);
            FiltrosGRP.Controls.Add(CuitTXT);
            FiltrosGRP.Controls.Add(label1);
            FiltrosGRP.Controls.Add(SKUTxt);
            FiltrosGRP.Controls.Add(BuscarBtn);
            FiltrosGRP.Controls.Add(PrioridadLBL);
            FiltrosGRP.Controls.Add(BorrarFiltrosBTN);
            FiltrosGRP.Controls.Add(StockMinimoTxt);
            FiltrosGRP.Controls.Add(CodigoCLienteLBL);
            FiltrosGRP.Controls.Add(RazonSocialTxt);
            FiltrosGRP.Controls.Add(SKULBL);
            FiltrosGRP.Controls.Add(StockMaximoTxt);
            FiltrosGRP.Controls.Add(CodigoClienteTxt);
            FiltrosGRP.Controls.Add(NombreProdTxt);
            FiltrosGRP.Location = new Point(12, 15);
            FiltrosGRP.Margin = new Padding(3, 2, 3, 2);
            FiltrosGRP.MaximumSize = new Size(1500, 250);
            FiltrosGRP.MinimumSize = new Size(826, 180);
            FiltrosGRP.Name = "FiltrosGRP";
            FiltrosGRP.Padding = new Padding(3, 2, 3, 2);
            FiltrosGRP.Size = new Size(878, 233);
            FiltrosGRP.TabIndex = 21;
            FiltrosGRP.TabStop = false;
            FiltrosGRP.Text = "Seleccione filtros de búsqueda para los productos: ";
            FiltrosGRP.Enter += FiltrosGRP_Enter;
            // 
            // CuitLBL
            // 
            CuitLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CuitLBL.AutoSize = true;
            CuitLBL.Location = new Point(615, 21);
            CuitLBL.Margin = new Padding(2, 0, 2, 0);
            CuitLBL.Name = "CuitLBL";
            CuitLBL.Size = new Size(32, 15);
            CuitLBL.TabIndex = 17;
            CuitLBL.Text = "CUIT";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(9, 123);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.MaximumSize = new Size(500, 23);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 28;
            label2.Text = "Stock minimo";
            // 
            // RazonSocialLBL
            // 
            RazonSocialLBL.Anchor = AnchorStyles.None;
            RazonSocialLBL.AutoSize = true;
            RazonSocialLBL.Location = new Point(317, 21);
            RazonSocialLBL.Margin = new Padding(2, 0, 2, 0);
            RazonSocialLBL.MaximumSize = new Size(500, 23);
            RazonSocialLBL.Name = "RazonSocialLBL";
            RazonSocialLBL.Size = new Size(73, 15);
            RazonSocialLBL.TabIndex = 15;
            RazonSocialLBL.Text = "Razón Social";
            // 
            // CuitTXT
            // 
            CuitTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CuitTXT.Location = new Point(615, 39);
            CuitTXT.Margin = new Padding(2);
            CuitTXT.MaximumSize = new Size(280, 40);
            CuitTXT.MinimumSize = new Size(200, 23);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.Size = new Size(250, 23);
            CuitTXT.TabIndex = 3;
            CuitTXT.TextChanged += CuitTXT_TextChanged_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(318, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MaximumSize = new Size(500, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 27;
            label1.Text = "Stock maximo";
            // 
            // SKUTxt
            // 
            SKUTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SKUTxt.Location = new Point(9, 86);
            SKUTxt.Margin = new Padding(2);
            SKUTxt.MaximumSize = new Size(500, 23);
            SKUTxt.MinimumSize = new Size(200, 23);
            SKUTxt.Name = "SKUTxt";
            SKUTxt.Size = new Size(250, 23);
            SKUTxt.TabIndex = 23;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Anchor = AnchorStyles.None;
            BuscarBtn.BackColor = Color.FromArgb(192, 255, 192);
            BuscarBtn.Location = new Point(314, 189);
            BuscarBtn.Margin = new Padding(2);
            BuscarBtn.MaximumSize = new Size(280, 40);
            BuscarBtn.MinimumSize = new Size(200, 40);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(250, 40);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar producto";
            BuscarBtn.UseVisualStyleBackColor = false;
            BuscarBtn.Click += BuscarProductos_Click;
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.Anchor = AnchorStyles.None;
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(317, 69);
            PrioridadLBL.Margin = new Padding(2, 0, 2, 0);
            PrioridadLBL.MaximumSize = new Size(500, 23);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(103, 15);
            PrioridadLBL.TabIndex = 21;
            PrioridadLBL.Text = "Nombre producto";
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BorrarFiltrosBTN.BackColor = Color.FromArgb(255, 192, 192);
            BorrarFiltrosBTN.Location = new Point(615, 189);
            BorrarFiltrosBTN.Margin = new Padding(2);
            BorrarFiltrosBTN.MaximumSize = new Size(280, 40);
            BorrarFiltrosBTN.MinimumSize = new Size(200, 40);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.RightToLeft = RightToLeft.No;
            BorrarFiltrosBTN.Size = new Size(250, 40);
            BorrarFiltrosBTN.TabIndex = 9;
            BorrarFiltrosBTN.Text = "&Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = false;
            BorrarFiltrosBTN.Click += BorrarFiltrosBTN_Click;
            // 
            // StockMinimoTxt
            // 
            StockMinimoTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            StockMinimoTxt.Location = new Point(9, 140);
            StockMinimoTxt.Margin = new Padding(2);
            StockMinimoTxt.MaximumSize = new Size(500, 23);
            StockMinimoTxt.MinimumSize = new Size(200, 23);
            StockMinimoTxt.Name = "StockMinimoTxt";
            StockMinimoTxt.Size = new Size(250, 23);
            StockMinimoTxt.TabIndex = 25;
            // 
            // CodigoCLienteLBL
            // 
            CodigoCLienteLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CodigoCLienteLBL.AutoSize = true;
            CodigoCLienteLBL.Location = new Point(5, 21);
            CodigoCLienteLBL.Margin = new Padding(2, 0, 2, 0);
            CodigoCLienteLBL.MaximumSize = new Size(500, 23);
            CodigoCLienteLBL.Name = "CodigoCLienteLBL";
            CodigoCLienteLBL.Size = new Size(58, 15);
            CodigoCLienteLBL.TabIndex = 2;
            CodigoCLienteLBL.Text = "ID Cliente";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Anchor = AnchorStyles.None;
            RazonSocialTxt.ImeMode = ImeMode.Off;
            RazonSocialTxt.Location = new Point(314, 39);
            RazonSocialTxt.Margin = new Padding(2);
            RazonSocialTxt.MaximumSize = new Size(500, 23);
            RazonSocialTxt.MinimumSize = new Size(200, 23);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(250, 23);
            RazonSocialTxt.TabIndex = 2;
            // 
            // SKULBL
            // 
            SKULBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SKULBL.AutoSize = true;
            SKULBL.Location = new Point(7, 69);
            SKULBL.Margin = new Padding(2, 0, 2, 0);
            SKULBL.MaximumSize = new Size(500, 23);
            SKULBL.Name = "SKULBL";
            SKULBL.Size = new Size(28, 15);
            SKULBL.TabIndex = 7;
            SKULBL.Text = "SKU";
            // 
            // StockMaximoTxt
            // 
            StockMaximoTxt.Anchor = AnchorStyles.None;
            StockMaximoTxt.Location = new Point(314, 140);
            StockMaximoTxt.Margin = new Padding(2);
            StockMaximoTxt.MaximumSize = new Size(500, 23);
            StockMaximoTxt.MinimumSize = new Size(200, 23);
            StockMaximoTxt.Name = "StockMaximoTxt";
            StockMaximoTxt.Size = new Size(250, 23);
            StockMaximoTxt.TabIndex = 26;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CodigoClienteTxt.Location = new Point(9, 39);
            CodigoClienteTxt.Margin = new Padding(2);
            CodigoClienteTxt.MaximumSize = new Size(500, 23);
            CodigoClienteTxt.MinimumSize = new Size(200, 23);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(250, 23);
            CodigoClienteTxt.TabIndex = 1;
            // 
            // NombreProdTxt
            // 
            NombreProdTxt.Anchor = AnchorStyles.None;
            NombreProdTxt.Location = new Point(314, 86);
            NombreProdTxt.Margin = new Padding(2);
            NombreProdTxt.MaximumSize = new Size(500, 23);
            NombreProdTxt.MinimumSize = new Size(200, 23);
            NombreProdTxt.Name = "NombreProdTxt";
            NombreProdTxt.Size = new Size(250, 23);
            NombreProdTxt.TabIndex = 24;
            // 
            // SalirBTN
            // 
            SalirBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirBTN.Location = new Point(640, 537);
            SalirBTN.MaximumSize = new Size(250, 40);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(250, 40);
            SalirBTN.TabIndex = 22;
            SalirBTN.Text = "Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += SalirBTN_Click;
            // 
            // BuscarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 589);
            Controls.Add(SalirBTN);
            Controls.Add(FiltrosGRP);
            Controls.Add(ProductosLTV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscarProductosForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Consultar Productos";
            FiltrosGRP.ResumeLayout(false);
            FiltrosGRP.PerformLayout();
            ResumeLayout(false);
        }

        private void FiltrosGRP_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion
        private ListView ProductosLTV;
        private ColumnHeader SKUColumna;
        private ColumnHeader idClienteColumna;
        private ColumnHeader UbicacionColumna;
        private GroupBox FiltrosGRP;
        private TextBox SKUTxt;
        private TextBox CuitTXT;
        private Label CuitLBL;
        private Label SKULBL;
        private TextBox CodigoClienteTxt;
        private Button BuscarBtn;
        private Button BorrarFiltrosBTN;
        private Label CodigoCLienteLBL;
        private ColumnHeader NombrePrdoColumna;
        private ColumnHeader ClienteRZColumna;
        private Label label2;
        private TextBox StockMinimoTxt;
        private ColumnHeader stockColumna;
        private Button SalirBTN;
        private Label RazonSocialLBL;
        private Label label1;
        private Label PrioridadLBL;
        private TextBox RazonSocialTxt;
        private TextBox StockMaximoTxt;
        private TextBox NombreProdTxt;
    }
}