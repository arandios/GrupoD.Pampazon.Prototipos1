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
            OrdenesPreparacionlst = new ListView();
            SKUProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarOrdenPreparadabtn = new Button();
            VolverMenubtn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesPreparacionlst
            // 
            OrdenesPreparacionlst.Columns.AddRange(new ColumnHeader[] { SKUProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesPreparacionlst.Enabled = false;
            OrdenesPreparacionlst.Location = new Point(10, 27);
            OrdenesPreparacionlst.Margin = new Padding(2, 3, 2, 3);
            OrdenesPreparacionlst.MultiSelect = false;
            OrdenesPreparacionlst.Name = "OrdenesPreparacionlst";
            OrdenesPreparacionlst.Size = new Size(802, 695);
            OrdenesPreparacionlst.TabIndex = 1;
            OrdenesPreparacionlst.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionlst.View = View.Details;
            // 
            // SKUProductoColumna
            // 
            SKUProductoColumna.Text = "SKU Producto";
            SKUProductoColumna.Width = 120;
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
            ConfirmarOrdenPreparadabtn.BackColor = Color.FromArgb(192, 255, 192);
            ConfirmarOrdenPreparadabtn.Location = new Point(365, 820);
            ConfirmarOrdenPreparadabtn.Margin = new Padding(2, 3, 2, 3);
            ConfirmarOrdenPreparadabtn.Name = "ConfirmarOrdenPreparadabtn";
            ConfirmarOrdenPreparadabtn.Size = new Size(280, 53);
            ConfirmarOrdenPreparadabtn.TabIndex = 2;
            ConfirmarOrdenPreparadabtn.Text = "&Confirmar orden como preparada";
            ConfirmarOrdenPreparadabtn.UseVisualStyleBackColor = false;
            ConfirmarOrdenPreparadabtn.Click += ConfirmarOrdenPreparadabtn_Click;
            // 
            // VolverMenubtn
            // 
            VolverMenubtn.Location = new Point(667, 820);
            VolverMenubtn.Margin = new Padding(2, 3, 2, 3);
            VolverMenubtn.Name = "VolverMenubtn";
            VolverMenubtn.Size = new Size(214, 53);
            VolverMenubtn.TabIndex = 3;
            VolverMenubtn.Text = "&Salir";
            VolverMenubtn.UseVisualStyleBackColor = true;
            VolverMenubtn.Click += VolverMenubtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenesPreparacionlst);
            groupBox1.Location = new Point(75, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 734);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle productos a empaquetar";
            // 
            // EmpaquetarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(VolverMenubtn);
            Controls.Add(ConfirmarOrdenPreparadabtn);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "EmpaquetarOrdenesForm";
            Text = "Empaquetar Ordenes de Preparación";
            Load += EmpaquetarOrdenesForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Codigogrb;
        private ListView OrdenesParaPrepararlst;
        private ColumnHeader CodigoOrdenColumna;
        private ColumnHeader PrioridadColumna;
        private ListView OrdenesPreparacionlst;
        private ColumnHeader SKUProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Button ConfirmarOrdenPreparadabtn;
        private Button VolverMenubtn;
        private GroupBox groupBox1;
    }
}