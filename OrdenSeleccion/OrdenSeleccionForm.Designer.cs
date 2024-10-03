namespace Pampazon.OrdenSeleccion
{
    partial class OrdenSeleccionForm
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
            button1 = new Button();
            CrearOrdenSeleccionBTN = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(685, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenSeleccionBTN
            // 
            CrearOrdenSeleccionBTN.Location = new Point(476, 397);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(190, 29);
            CrearOrdenSeleccionBTN.TabIndex = 1;
            CrearOrdenSeleccionBTN.Text = "Crear Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CrearOrdenSeleccionBTN.Click += this.CrearOrdenSeleccionBTN_Click;
            // 
            // button3
            // 
            button3.Location = new Point(441, 128);
            button3.Name = "button3";
            button3.Size = new Size(238, 29);
            button3.TabIndex = 3;
            button3.Text = "Buscar Ordenes de Preparación";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(685, 128);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Borrar";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 204);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(767, 184);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(416, 20);
            label1.TabIndex = 5;
            label1.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 60);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Transportista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 60);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 8;
            label4.Text = "Razón social Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 60);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 9;
            label5.Text = "Número de Orden Preparación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(424, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(646, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 27);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 169);
            label6.Name = "label6";
            label6.Size = new Size(313, 20);
            label6.TabIndex = 14;
            label6.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(CrearOrdenSeleccionBTN);
            Controls.Add(button1);
            Name = "OrdenSeleccionForm";
            Text = "OrdenSeleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button CrearOrdenSeleccionBTN;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
    }
}