namespace Pampazon.ConfirmarOrdenSeleccion
{
    partial class ConfirmarOrdenSeleccion
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
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            Orden_Seleccion = new ListBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(613, 492);
            button4.Name = "button4";
            button4.Size = new Size(167, 52);
            button4.TabIndex = 17;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(836, 110);
            button3.Name = "button3";
            button3.Size = new Size(126, 34);
            button3.TabIndex = 16;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(836, 56);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 15;
            button2.Text = "Buscar:";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 90);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 14;
            label1.Text = "ID de Orden ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(598, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(388, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(288, 492);
            button1.Name = "button1";
            button1.Size = new Size(167, 52);
            button1.TabIndex = 10;
            button1.Text = "Confirmar Orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // Orden_Seleccion
            // 
            Orden_Seleccion.FormattingEnabled = true;
            Orden_Seleccion.ItemHeight = 25;
            Orden_Seleccion.Location = new Point(93, 171);
            Orden_Seleccion.Name = "Orden_Seleccion";
            Orden_Seleccion.Size = new Size(869, 279);
            Orden_Seleccion.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 600);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(Orden_Seleccion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox Orden_Seleccion;
    }
}