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
            button4 = new Button();
            button3 = new Button();
            Generar = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            Ordenes_Seleccion_Confirmadas = new ListBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(867, 35);
            button4.Name = "button4";
            button4.Size = new Size(136, 44);
            button4.TabIndex = 18;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(703, 542);
            button3.Name = "button3";
            button3.Size = new Size(133, 38);
            button3.TabIndex = 17;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Generar
            // 
            Generar.Location = new Point(191, 538);
            Generar.Name = "Generar";
            Generar.Size = new Size(221, 47);
            Generar.TabIndex = 16;
            Generar.Text = "Generar Orden Entrega";
            Generar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(386, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(620, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 81);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 13;
            label1.Text = "ID Orden";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(867, 90);
            button2.Name = "button2";
            button2.Size = new Size(136, 44);
            button2.TabIndex = 11;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Ordenes_Seleccion_Confirmadas
            // 
            Ordenes_Seleccion_Confirmadas.FormattingEnabled = true;
            Ordenes_Seleccion_Confirmadas.ItemHeight = 25;
            Ordenes_Seleccion_Confirmadas.Location = new Point(53, 143);
            Ordenes_Seleccion_Confirmadas.Name = "Ordenes_Seleccion_Confirmadas";
            Ordenes_Seleccion_Confirmadas.Size = new Size(988, 354);
            Ordenes_Seleccion_Confirmadas.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 620);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Generar);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Ordenes_Seleccion_Confirmadas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button Generar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private ListBox Ordenes_Seleccion_Confirmadas;
    }
}