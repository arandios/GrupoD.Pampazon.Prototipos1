namespace Pampazon.EmpaquetarOrden
{
    partial class EmpaquetarOrdenesForm
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
            Codigogrb = new GroupBox();
            OrdenesParaPrepararlst = new ListView();
            CodigoOrdenColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            OrdenesPreparacionlst = new ListView();
            IdProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarOrdenPreparadabtn = new Button();
            VolverMenubtn = new Button();
            groupBox1 = new GroupBox();
            Codigogrb.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Codigogrb
            // 
            Codigogrb.Controls.Add(OrdenesParaPrepararlst);
            Codigogrb.Enabled = false;
            Codigogrb.Location = new Point(9, 9);
            Codigogrb.Margin = new Padding(2, 3, 2, 3);
            Codigogrb.Name = "Codigogrb";
            Codigogrb.Padding = new Padding(2, 3, 2, 3);
            Codigogrb.Size = new Size(730, 230);
            Codigogrb.TabIndex = 0;
            Codigogrb.TabStop = false;
            Codigogrb.Text = "Ordenes de preparacion para empaquetar";
            // 
            // OrdenesParaPrepararlst
            // 
            OrdenesParaPrepararlst.Columns.AddRange(new ColumnHeader[] { CodigoOrdenColumna, PrioridadColumna });
            OrdenesParaPrepararlst.Enabled = false;
            OrdenesParaPrepararlst.FullRowSelect = true;
            OrdenesParaPrepararlst.Location = new Point(4, 46);
            OrdenesParaPrepararlst.Margin = new Padding(2, 3, 2, 3);
            OrdenesParaPrepararlst.MultiSelect = false;
            OrdenesParaPrepararlst.Name = "OrdenesParaPrepararlst";
            OrdenesParaPrepararlst.Size = new Size(717, 172);
            OrdenesParaPrepararlst.TabIndex = 0;
            OrdenesParaPrepararlst.UseCompatibleStateImageBehavior = false;
            OrdenesParaPrepararlst.View = View.Details;
            // 
            // CodigoOrdenColumna
            // 
            CodigoOrdenColumna.Text = "Codigo Orden";
            CodigoOrdenColumna.Width = 120;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.TextAlign = HorizontalAlignment.Center;
            PrioridadColumna.Width = 100;
            // 
            // OrdenesPreparacionlst
            // 
            OrdenesPreparacionlst.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesPreparacionlst.Enabled = false;
            OrdenesPreparacionlst.Location = new Point(0, 26);
            OrdenesPreparacionlst.Margin = new Padding(2, 3, 2, 3);
            OrdenesPreparacionlst.MultiSelect = false;
            OrdenesPreparacionlst.Name = "OrdenesPreparacionlst";
            OrdenesPreparacionlst.Size = new Size(715, 307);
            OrdenesPreparacionlst.TabIndex = 1;
            OrdenesPreparacionlst.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionlst.View = View.Details;
            // 
            // IdProductoColumna
            // 
            IdProductoColumna.Text = "Id Producto";
            IdProductoColumna.Width = 120;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.TextAlign = HorizontalAlignment.Center;
            ProductoColumna.Width = 400;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.TextAlign = HorizontalAlignment.Center;
            CantidadColumna.Width = 100;
            // 
            // ConfirmarOrdenPreparadabtn
            // 
            ConfirmarOrdenPreparadabtn.Location = new Point(384, 595);
            ConfirmarOrdenPreparadabtn.Margin = new Padding(2, 3, 2, 3);
            ConfirmarOrdenPreparadabtn.Name = "ConfirmarOrdenPreparadabtn";
            ConfirmarOrdenPreparadabtn.Size = new Size(249, 29);
            ConfirmarOrdenPreparadabtn.TabIndex = 2;
            ConfirmarOrdenPreparadabtn.Text = "&Confirmar orden como preparada";
            ConfirmarOrdenPreparadabtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenPreparadabtn.Click += ConfirmarOrdenPreparadabtn_Click;
            // 
            // VolverMenubtn
            // 
            VolverMenubtn.Location = new Point(637, 595);
            VolverMenubtn.Margin = new Padding(2, 3, 2, 3);
            VolverMenubtn.Name = "VolverMenubtn";
            VolverMenubtn.Size = new Size(93, 29);
            VolverMenubtn.TabIndex = 3;
            VolverMenubtn.Text = "&Salir";
            VolverMenubtn.UseVisualStyleBackColor = true;
            VolverMenubtn.Click += VolverMenubtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenesPreparacionlst);
            groupBox1.Location = new Point(13, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 344);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle productos a empaquetar";
            // 
            // EmpaquetarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 649);
            Controls.Add(VolverMenubtn);
            Controls.Add(ConfirmarOrdenPreparadabtn);
            Controls.Add(Codigogrb);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "EmpaquetarOrdenesForm";
            Text = "Empaquetar Ordenes de Preparación";
            Load += EmpaquetarOrdenesForm_Load;
            Codigogrb.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Codigogrb;
        private ListView OrdenesParaPrepararlst;
        private ColumnHeader CodigoOrdenColumna;
        private ColumnHeader PrioridadColumna;
        private ListView OrdenesPreparacionlst;
        private ColumnHeader IdProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Button ConfirmarOrdenPreparadabtn;
        private Button VolverMenubtn;
        private GroupBox groupBox1;
    }
}