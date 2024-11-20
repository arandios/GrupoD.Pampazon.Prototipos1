
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
            label2 = new Label();
            label1 = new Label();
            StockMaximoTxt = new TextBox();
            StockMinimoTxt = new TextBox();
            NombreProdTxt = new TextBox();
            SKUTxt = new TextBox();
            PrioridadLBL = new Label();
            CuitTXT = new TextBox();
            CuitLBL = new Label();
            SKULBL = new Label();
            RazonSocialTxt = new TextBox();
            RazonSocialLBL = new Label();
            CodigoClienteTxt = new TextBox();
            BuscarBtn = new Button();
            BorrarFiltrosBTN = new Button();
            CodigoCLienteLBL = new Label();
            FiltrosGRP.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosLTV
            // 
            ProductosLTV.Columns.AddRange(new ColumnHeader[] { SKUColumna, NombrePrdoColumna, idClienteColumna, ClienteRZColumna, UbicacionColumna, stockColumna });
            ProductosLTV.Location = new Point(11, 211);
            ProductosLTV.Name = "ProductosLTV";
            ProductosLTV.Size = new Size(840, 200);
            ProductosLTV.TabIndex = 11;
            ProductosLTV.UseCompatibleStateImageBehavior = false;
            ProductosLTV.View = View.Details;
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
            FiltrosGRP.Controls.Add(label2);
            FiltrosGRP.Controls.Add(label1);
            FiltrosGRP.Controls.Add(StockMaximoTxt);
            FiltrosGRP.Controls.Add(StockMinimoTxt);
            FiltrosGRP.Controls.Add(NombreProdTxt);
            FiltrosGRP.Controls.Add(SKUTxt);
            FiltrosGRP.Controls.Add(PrioridadLBL);
            FiltrosGRP.Controls.Add(CuitTXT);
            FiltrosGRP.Controls.Add(CuitLBL);
            FiltrosGRP.Controls.Add(SKULBL);
            FiltrosGRP.Controls.Add(RazonSocialTxt);
            FiltrosGRP.Controls.Add(RazonSocialLBL);
            FiltrosGRP.Controls.Add(CodigoClienteTxt);
            FiltrosGRP.Controls.Add(BuscarBtn);
            FiltrosGRP.Controls.Add(BorrarFiltrosBTN);
            FiltrosGRP.Controls.Add(CodigoCLienteLBL);
            FiltrosGRP.Location = new Point(11, 11);
            FiltrosGRP.Margin = new Padding(3, 2, 3, 2);
            FiltrosGRP.Name = "FiltrosGRP";
            FiltrosGRP.Padding = new Padding(3, 2, 3, 2);
            FiltrosGRP.Size = new Size(840, 180);
            FiltrosGRP.TabIndex = 21;
            FiltrosGRP.TabStop = false;
            FiltrosGRP.Text = "Seleccione filtros de búsqueda para los productos: ";
            FiltrosGRP.Enter += FiltrosGRP_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 121);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 28;
            label2.Text = "Stock minimo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 27;
            label1.Text = "Stock maximo";
            // 
            // StockMaximoTxt
            // 
            StockMaximoTxt.Location = new Point(288, 138);
            StockMaximoTxt.Margin = new Padding(2);
            StockMaximoTxt.Name = "StockMaximoTxt";
            StockMaximoTxt.Size = new Size(250, 23);
            StockMaximoTxt.TabIndex = 26;
            // 
            // StockMinimoTxt
            // 
            StockMinimoTxt.Location = new Point(6, 138);
            StockMinimoTxt.Margin = new Padding(2);
            StockMinimoTxt.Name = "StockMinimoTxt";
            StockMinimoTxt.Size = new Size(250, 23);
            StockMinimoTxt.TabIndex = 25;
            // 
            // NombreProdTxt
            // 
            NombreProdTxt.Location = new Point(288, 84);
            NombreProdTxt.Margin = new Padding(2);
            NombreProdTxt.Name = "NombreProdTxt";
            NombreProdTxt.Size = new Size(250, 23);
            NombreProdTxt.TabIndex = 24;
            // 
            // SKUTxt
            // 
            SKUTxt.Location = new Point(7, 84);
            SKUTxt.Margin = new Padding(2);
            SKUTxt.Name = "SKUTxt";
            SKUTxt.Size = new Size(250, 23);
            SKUTxt.TabIndex = 23;
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(288, 67);
            PrioridadLBL.Margin = new Padding(2, 0, 2, 0);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(103, 15);
            PrioridadLBL.TabIndex = 21;
            PrioridadLBL.Text = "Nombre producto";
            // 
            // CuitTXT
            // 
            CuitTXT.Location = new Point(583, 37);
            CuitTXT.Margin = new Padding(2);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.Size = new Size(250, 23);
            CuitTXT.TabIndex = 3;
            // 
            // CuitLBL
            // 
            CuitLBL.AutoSize = true;
            CuitLBL.Location = new Point(583, 19);
            CuitLBL.Margin = new Padding(2, 0, 2, 0);
            CuitLBL.Name = "CuitLBL";
            CuitLBL.Size = new Size(29, 15);
            CuitLBL.TabIndex = 17;
            CuitLBL.Text = "Cuit";
            // 
            // SKULBL
            // 
            SKULBL.AutoSize = true;
            SKULBL.Location = new Point(6, 67);
            SKULBL.Margin = new Padding(2, 0, 2, 0);
            SKULBL.Name = "SKULBL";
            SKULBL.Size = new Size(28, 15);
            SKULBL.TabIndex = 7;
            SKULBL.Text = "SKU";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(288, 37);
            RazonSocialTxt.Margin = new Padding(2);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(250, 23);
            RazonSocialTxt.TabIndex = 2;
            // 
            // RazonSocialLBL
            // 
            RazonSocialLBL.AutoSize = true;
            RazonSocialLBL.Location = new Point(288, 19);
            RazonSocialLBL.Margin = new Padding(2, 0, 2, 0);
            RazonSocialLBL.Name = "RazonSocialLBL";
            RazonSocialLBL.Size = new Size(73, 15);
            RazonSocialLBL.TabIndex = 15;
            RazonSocialLBL.Text = "Razón Social";
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(8, 37);
            CodigoClienteTxt.Margin = new Padding(2);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(250, 23);
            CodigoClienteTxt.TabIndex = 1;
            // 
            // BuscarBtn
            // 
            BuscarBtn.BackColor = Color.FromArgb(192, 255, 192);
            BuscarBtn.Location = new Point(583, 67);
            BuscarBtn.Margin = new Padding(2);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(250, 40);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar producto";
            BuscarBtn.UseVisualStyleBackColor = false;
            BuscarBtn.Click += BuscarProductos_Click;
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.BackColor = Color.FromArgb(255, 192, 192);
            BorrarFiltrosBTN.Location = new Point(583, 121);
            BorrarFiltrosBTN.Margin = new Padding(2);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.RightToLeft = RightToLeft.No;
            BorrarFiltrosBTN.Size = new Size(250, 40);
            BorrarFiltrosBTN.TabIndex = 9;
            BorrarFiltrosBTN.Text = "&Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = false;
            BorrarFiltrosBTN.Click += BorrarFiltrosBTN_Click;
            // 
            // CodigoCLienteLBL
            // 
            CodigoCLienteLBL.AutoSize = true;
            CodigoCLienteLBL.Location = new Point(4, 19);
            CodigoCLienteLBL.Margin = new Padding(2, 0, 2, 0);
            CodigoCLienteLBL.Name = "CodigoCLienteLBL";
            CodigoCLienteLBL.Size = new Size(58, 15);
            CodigoCLienteLBL.TabIndex = 2;
            CodigoCLienteLBL.Text = "ID Cliente";
            // 
            // BuscarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(FiltrosGRP);
            Controls.Add(ProductosLTV);
            Name = "BuscarProductosForm";
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
        private TextBox NombreProdTxt;
        private TextBox SKUTxt;
        private Label PrioridadLBL;
        private TextBox CuitTXT;
        private Label CuitLBL;
        private Label SKULBL;
        private TextBox RazonSocialTxt;
        private Label RazonSocialLBL;
        private TextBox CodigoClienteTxt;
        private Button BuscarBtn;
        private Button BorrarFiltrosBTN;
        private Label CodigoCLienteLBL;
        private ColumnHeader NombrePrdoColumna;
        private ColumnHeader ClienteRZColumna;
        private Label label2;
        private Label label1;
        private TextBox StockMaximoTxt;
        private TextBox StockMinimoTxt;
        private ColumnHeader stockColumna;
    }
}