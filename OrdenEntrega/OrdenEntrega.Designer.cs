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
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(742, 24);
            button4.Name = "button4";
            button4.Size = new Size(136, 44);
            button4.TabIndex = 18;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(983, 650);
            button3.Name = "button3";
            button3.Size = new Size(133, 38);
            button3.TabIndex = 17;
            button3.Text = "salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Generar
            // 
            Generar.Location = new Point(950, 538);
            Generar.Name = "Generar";
            Generar.Size = new Size(221, 47);
            Generar.TabIndex = 16;
            Generar.Text = "Generar Orden Entrega";
            Generar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(331, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(533, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 65);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 13;
            label1.Text = "ID Orden";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(742, 79);
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
            Ordenes_Seleccion_Confirmadas.Location = new Point(97, 155);
            Ordenes_Seleccion_Confirmadas.Name = "Ordenes_Seleccion_Confirmadas";
            Ordenes_Seleccion_Confirmadas.Size = new Size(671, 354);
            Ordenes_Seleccion_Confirmadas.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.Location = new Point(911, 155);
            listView1.Name = "listView1";
            listView1.Size = new Size(298, 354);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(273, 561);
            button1.Name = "button1";
            button1.Size = new Size(221, 47);
            button1.TabIndex = 20;
            button1.Text = "Detalles de Orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrdenEntrega
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 751);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Generar);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Ordenes_Seleccion_Confirmadas);
            Name = "OrdenEntrega";
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
        private ListView listView1;
        private Button button1;
    }
}