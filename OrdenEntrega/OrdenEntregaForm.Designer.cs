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
            listView2 = new ListView();
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(339, 33);
            Buscarbtn.Margin = new Padding(2);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(95, 23);
            Buscarbtn.TabIndex = 18;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(651, 380);
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
            GenerarOrdenEntregabtn.Location = new Point(651, 312);
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
            FechaEntregacmb.Location = new Point(200, 33);
            FechaEntregacmb.Margin = new Padding(2);
            FechaEntregacmb.Name = "FechaEntregacmb";
            FechaEntregacmb.Size = new Size(129, 23);
            FechaEntregacmb.TabIndex = 15;
            FechaEntregacmb.Text = "Fecha entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "ID Orden";
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(90, 33);
            txtIdOrden.Margin = new Padding(2);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(106, 23);
            txtIdOrden.TabIndex = 12;
            txtIdOrden.TextChanged += textBox1_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(339, 65);
            limpiarbtn.Margin = new Padding(2);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(95, 23);
            limpiarbtn.TabIndex = 11;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(12, 93);
            listView2.Name = "listView2";
            listView2.Size = new Size(422, 214);
            listView2.TabIndex = 21;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(470, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(364, 214);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 23;
            label2.Text = "Ordenes de Preparación";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 75);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 24;
            label3.Text = "A la orden de entrega";
            // 
            // button1
            // 
            button1.Location = new Point(349, 312);
            button1.Name = "button1";
            button1.Size = new Size(85, 47);
            button1.TabIndex = 25;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 434);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Controls.Add(Buscarbtn);
            Controls.Add(Salirbtn);
            Controls.Add(GenerarOrdenEntregabtn);
            Controls.Add(FechaEntregacmb);
            Controls.Add(label1);
            Controls.Add(txtIdOrden);
            Controls.Add(limpiarbtn);
            Margin = new Padding(2);
            Name = "OrdenEntregaForm";
            Text = "Orden de entrega";
            Load += OrdenEntregaForm_Load;
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
        private ListView listView2;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}