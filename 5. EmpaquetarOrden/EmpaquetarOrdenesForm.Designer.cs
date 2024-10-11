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
            label1 = new Label();
            Codigogrb.SuspendLayout();
            SuspendLayout();
            // 
            // Codigogrb
            // 
            Codigogrb.Controls.Add(OrdenesParaPrepararlst);
            Codigogrb.Enabled = false;
            Codigogrb.Location = new Point(8, 7);
            Codigogrb.Margin = new Padding(2);
            Codigogrb.Name = "Codigogrb";
            Codigogrb.Padding = new Padding(2);
            Codigogrb.Size = new Size(244, 301);
            Codigogrb.TabIndex = 0;
            Codigogrb.TabStop = false;
            Codigogrb.Text = "Ordenes de preparacion para empaquetar";
            // 
            // OrdenesParaPrepararlst
            // 
            OrdenesParaPrepararlst.Columns.AddRange(new ColumnHeader[] { CodigoOrdenColumna, PrioridadColumna });
            OrdenesParaPrepararlst.Enabled = false;
            OrdenesParaPrepararlst.FullRowSelect = true;
            OrdenesParaPrepararlst.Location = new Point(11, 18);
            OrdenesParaPrepararlst.Margin = new Padding(2);
            OrdenesParaPrepararlst.MultiSelect = false;
            OrdenesParaPrepararlst.Name = "OrdenesParaPrepararlst";
            OrdenesParaPrepararlst.Size = new Size(224, 283);
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
            OrdenesPreparacionlst.Location = new Point(256, 25);
            OrdenesPreparacionlst.Margin = new Padding(2);
            OrdenesPreparacionlst.MultiSelect = false;
            OrdenesPreparacionlst.Name = "OrdenesPreparacionlst";
            OrdenesPreparacionlst.Size = new Size(626, 241);
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
            ConfirmarOrdenPreparadabtn.Location = new Point(571, 270);
            ConfirmarOrdenPreparadabtn.Margin = new Padding(2);
            ConfirmarOrdenPreparadabtn.Name = "ConfirmarOrdenPreparadabtn";
            ConfirmarOrdenPreparadabtn.Size = new Size(311, 38);
            ConfirmarOrdenPreparadabtn.TabIndex = 2;
            ConfirmarOrdenPreparadabtn.Text = "Confirmar orden como preparada";
            ConfirmarOrdenPreparadabtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenPreparadabtn.Click += ConfirmarOrdenPreparadabtn_Click;
            // 
            // VolverMenubtn
            // 
            VolverMenubtn.Location = new Point(256, 270);
            VolverMenubtn.Margin = new Padding(2);
            VolverMenubtn.Name = "VolverMenubtn";
            VolverMenubtn.Size = new Size(311, 38);
            VolverMenubtn.TabIndex = 3;
            VolverMenubtn.Text = "Salir";
            VolverMenubtn.UseVisualStyleBackColor = true;
            VolverMenubtn.Click += VolverMenubtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 8);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Detalle";
            // 
            // EmpaquetarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 319);
            Controls.Add(label1);
            Controls.Add(VolverMenubtn);
            Controls.Add(ConfirmarOrdenPreparadabtn);
            Controls.Add(OrdenesPreparacionlst);
            Controls.Add(Codigogrb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "EmpaquetarOrdenesForm";
            Text = "Empaquetar Ordenes";
            Load += EmpaquetarOrdenesForm_Load;
            Codigogrb.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}