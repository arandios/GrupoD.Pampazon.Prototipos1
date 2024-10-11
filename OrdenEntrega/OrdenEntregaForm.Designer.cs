namespace Pampazon.OrdenEntrega
{
    partial class OrdenEntregaForm
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
            Ordenes_Preparacion = new ListView();
            Orden_Entrega = new ListView();
            label2 = new Label();
            label3 = new Label();
            Seleccionar = new Button();
            Eliminar = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(102, 81);
            Buscarbtn.Margin = new Padding(2);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(95, 23);
            Buscarbtn.TabIndex = 18;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(274, 228);
            Salirbtn.Margin = new Padding(2);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(89, 35);
            Salirbtn.TabIndex = 17;
            Salirbtn.Text = "Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.Location = new Point(99, 228);
            GenerarOrdenEntregabtn.Margin = new Padding(2);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(171, 35);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "Generar Orden Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenEntregabtn.Click += GenerarOrdenEntregabtn_Click;
            // 
            // FechaEntregacmb
            // 
            FechaEntregacmb.FormattingEnabled = true;
            FechaEntregacmb.Items.AddRange(new object[] { "2024-10-01", "2024-10-02", "2024-10-03" });
            FechaEntregacmb.Location = new Point(102, 48);
            FechaEntregacmb.Margin = new Padding(2);
            FechaEntregacmb.Name = "FechaEntregacmb";
            FechaEntregacmb.Size = new Size(207, 23);
            FechaEntregacmb.TabIndex = 15;
            FechaEntregacmb.Text = "Fecha entrega";
            FechaEntregacmb.SelectedIndexChanged += FechaEntregacmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "ID Orden";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(102, 21);
            txtIdOrden.Margin = new Padding(2);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(207, 23);
            txtIdOrden.TabIndex = 12;
            txtIdOrden.TextChanged += txtIdOrden_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(214, 81);
            limpiarbtn.Margin = new Padding(2);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(95, 23);
            limpiarbtn.TabIndex = 11;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // Ordenes_Preparacion
            // 
            Ordenes_Preparacion.Location = new Point(3, 22);
            Ordenes_Preparacion.Name = "Ordenes_Preparacion";
            Ordenes_Preparacion.Size = new Size(358, 169);
            Ordenes_Preparacion.TabIndex = 21;
            Ordenes_Preparacion.UseCompatibleStateImageBehavior = false;
            Ordenes_Preparacion.View = View.Details;
            // 
            // Orden_Entrega
            // 
            Orden_Entrega.Location = new Point(6, 26);
            Orden_Entrega.Name = "Orden_Entrega";
            Orden_Entrega.Size = new Size(357, 196);
            Orden_Entrega.TabIndex = 22;
            Orden_Entrega.UseCompatibleStateImageBehavior = false;
            //Orden_Entrega.SelectedIndexChanged += Orden_Entrega_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 394);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 24;
            label3.Text = "A la orden de entrega";
            // 
            // Seleccionar
            // 
            Seleccionar.Location = new Point(175, 197);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(186, 35);
            Seleccionar.TabIndex = 25;
            Seleccionar.Text = "Seleccionar";
            Seleccionar.UseVisualStyleBackColor = true;
            Seleccionar.Click += Seleccionar_Click_1;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(5, 228);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(89, 35);
            Eliminar.TabIndex = 26;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 27;
            label4.Text = "Fecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdOrden);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(limpiarbtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaEntregacmb);
            groupBox1.Controls.Add(Buscarbtn);
            groupBox1.Location = new Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 126);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de ordenes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Ordenes_Preparacion);
            groupBox2.Controls.Add(Seleccionar);
            groupBox2.Location = new Point(8, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 239);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenes de Preparación";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Orden_Entrega);
            groupBox3.Controls.Add(GenerarOrdenEntregabtn);
            groupBox3.Controls.Add(Eliminar);
            groupBox3.Controls.Add(Salirbtn);
            groupBox3.Location = new Point(8, 384);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(369, 265);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de Entrega";
            // 
            // OrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "OrdenEntregaForm";
            Text = "Orden de entrega";
            Load += OrdenEntregaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private ListView Ordenes_Preparacion;
        private ListView Orden_Entrega;
        private Label label2;
        private Label label3;
        private Button Seleccionar;
        private Button Eliminar;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}