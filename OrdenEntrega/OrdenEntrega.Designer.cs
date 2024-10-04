namespace Pampazon.OrdenEntrega
{
    partial class OrdenEntrega
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
            Buscarbtn = new Button();
            Salirbtn = new Button();
            GenerarOrdenEntregabtn = new Button();
            FechaEntregacmb = new ComboBox();
            label1 = new Label();
            txtIdOrden = new TextBox();
            limpiarbtn = new Button();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            DetalleOrdenbtn = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(505, 50);
            Buscarbtn.Margin = new Padding(2);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(95, 23);
            Buscarbtn.TabIndex = 18;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(693, 363);
            Salirbtn.Margin = new Padding(2);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(155, 43);
            Salirbtn.TabIndex = 17;
            Salirbtn.Text = "salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.Location = new Point(693, 312);
            GenerarOrdenEntregabtn.Margin = new Padding(2);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(155, 47);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "Generar Orden Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = true;
            // 
            // FechaEntregacmb
            // 
            FechaEntregacmb.FormattingEnabled = true;
            FechaEntregacmb.Location = new Point(231, 50);
            FechaEntregacmb.Margin = new Padding(2);
            FechaEntregacmb.Name = "FechaEntregacmb";
            FechaEntregacmb.Size = new Size(129, 23);
            FechaEntregacmb.TabIndex = 15;
            FechaEntregacmb.Text = "Fecha entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "ID Orden";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(121, 50);
            txtIdOrden.Margin = new Padding(2);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(106, 23);
            txtIdOrden.TabIndex = 12;
            txtIdOrden.TextChanged += textBox1_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(604, 50);
            limpiarbtn.Margin = new Padding(2);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(95, 23);
            limpiarbtn.TabIndex = 11;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(638, 93);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 214);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Id Prod";
            columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Producto";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cantidad";
            columnHeader7.Width = 75;
            // 
            // DetalleOrdenbtn
            // 
            DetalleOrdenbtn.Location = new Point(41, 312);
            DetalleOrdenbtn.Margin = new Padding(2);
            DetalleOrdenbtn.Name = "DetalleOrdenbtn";
            DetalleOrdenbtn.Size = new Size(155, 38);
            DetalleOrdenbtn.TabIndex = 20;
            DetalleOrdenbtn.Text = "Detalles de Orden";
            DetalleOrdenbtn.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader8, columnHeader9 });
            listView2.Location = new Point(41, 93);
            listView2.Name = "listView2";
            listView2.Size = new Size(573, 214);
            listView2.TabIndex = 21;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro orden";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 4;
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Fecha de entrega";
            columnHeader3.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.DisplayIndex = 2;
            columnHeader8.Text = "Id Transportista";
            columnHeader8.Width = 95;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 3;
            columnHeader9.Text = "Nombre Transportista";
            columnHeader9.Width = 140;
            // 
            // OrdenEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 451);
            Controls.Add(listView2);
            Controls.Add(DetalleOrdenbtn);
            Controls.Add(listView1);
            Controls.Add(Buscarbtn);
            Controls.Add(Salirbtn);
            Controls.Add(GenerarOrdenEntregabtn);
            Controls.Add(FechaEntregacmb);
            Controls.Add(label1);
            Controls.Add(txtIdOrden);
            Controls.Add(limpiarbtn);
            Margin = new Padding(2);
            Name = "OrdenEntrega";
            Text = "Orden de entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Buscarbtn;
        private Button Salirbtn;
        private Button GenerarOrdenEntregabtn;
        private ComboBox FechaEntregacmb;
        private Label label1;
        private TextBox txtIdOrden;
        private Button limpiarbtn;
        private ListView listView1;
        private Button DetalleOrdenbtn;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}