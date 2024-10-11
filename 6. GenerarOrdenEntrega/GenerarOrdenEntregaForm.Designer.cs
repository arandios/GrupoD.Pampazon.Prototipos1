namespace Pampazon.OrdenEntrega
{
    partial class GenerarOrdenEntregaForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(458, 108);
            Buscarbtn.Margin = new Padding(2, 3, 2, 3);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(109, 31);
            Buscarbtn.TabIndex = 18;
            Buscarbtn.Text = "&Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(604, 313);
            Salirbtn.Margin = new Padding(2, 3, 2, 3);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(80, 29);
            Salirbtn.TabIndex = 17;
            Salirbtn.Text = "&Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.Location = new Point(187, 313);
            GenerarOrdenEntregabtn.Margin = new Padding(2, 3, 2, 3);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(194, 29);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "&Generar Orden de Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenEntregabtn.Click += GenerarOrdenEntregabtn_Click;
            // 
            // FechaEntregacmb
            // 
            FechaEntregacmb.FormattingEnabled = true;
            FechaEntregacmb.Items.AddRange(new object[] { "2024-10-01", "2024-10-02", "2024-10-03" });
            FechaEntregacmb.Location = new Point(186, 53);
            FechaEntregacmb.Margin = new Padding(2, 3, 2, 3);
            FechaEntregacmb.Name = "FechaEntregacmb";
            FechaEntregacmb.Size = new Size(151, 28);
            FechaEntregacmb.TabIndex = 15;
            FechaEntregacmb.Text = "Fecha entrega";
            FechaEntregacmb.SelectedIndexChanged += FechaEntregacmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 13;
            label1.Text = "ID Orden de Preparación";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(3, 55);
            txtIdOrden.Margin = new Padding(2, 3, 2, 3);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(179, 27);
            txtIdOrden.TabIndex = 12;
            txtIdOrden.TextChanged += txtIdOrden_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(571, 108);
            limpiarbtn.Margin = new Padding(2, 3, 2, 3);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(109, 31);
            limpiarbtn.TabIndex = 11;
            limpiarbtn.Text = "&Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // Ordenes_Preparacion
            // 
            Ordenes_Preparacion.Location = new Point(3, 29);
            Ordenes_Preparacion.Margin = new Padding(3, 4, 3, 4);
            Ordenes_Preparacion.Name = "Ordenes_Preparacion";
            Ordenes_Preparacion.Size = new Size(681, 224);
            Ordenes_Preparacion.TabIndex = 21;
            Ordenes_Preparacion.UseCompatibleStateImageBehavior = false;
            Ordenes_Preparacion.View = View.Details;
            // 
            // Orden_Entrega
            // 
            Orden_Entrega.Location = new Point(7, 35);
            Orden_Entrega.Margin = new Padding(3, 4, 3, 4);
            Orden_Entrega.Name = "Orden_Entrega";
            Orden_Entrega.Size = new Size(677, 260);
            Orden_Entrega.TabIndex = 22;
            Orden_Entrega.UseCompatibleStateImageBehavior = false;
            Orden_Entrega.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 219);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 525);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 24;
            label3.Text = "A la orden de entrega";
            // 
            // Seleccionar
            // 
            Seleccionar.Location = new Point(579, 261);
            Seleccionar.Margin = new Padding(3, 4, 3, 4);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(105, 30);
            Seleccionar.TabIndex = 25;
            Seleccionar.Text = "&Seleccionar";
            Seleccionar.UseVisualStyleBackColor = true;
            Seleccionar.Click += Seleccionar_Click_1;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(386, 313);
            Eliminar.Margin = new Padding(3, 4, 3, 4);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(213, 29);
            Eliminar.TabIndex = 26;
            Eliminar.Text = "&Quitar Orden de Preparación";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 31);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 27;
            label4.Text = "Fecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtIdOrden);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(limpiarbtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FechaEntregacmb);
            groupBox1.Controls.Add(Buscarbtn);
            groupBox1.Location = new Point(13, 9);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(686, 148);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de ordenes";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 54);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(533, 54);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 29;
            label5.Text = "Prioridad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 31);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 27;
            label6.Text = "Código Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Ordenes_Preparacion);
            groupBox2.Controls.Add(Seleccionar);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(690, 301);
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
            groupBox3.Location = new Point(12, 478);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(690, 353);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de Entrega";
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 846);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "GenerarOrdenEntregaForm";
            Text = "Generar Orden de Entrega";
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
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
    }
}