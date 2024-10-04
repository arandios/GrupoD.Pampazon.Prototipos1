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
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button5 = new Button();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button6 = new Button();
            Generar = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(608, 46);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 26);
            button3.TabIndex = 16;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(516, 46);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 26);
            button2.TabIndex = 15;
            button2.Text = "Buscar:";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 14;
            label1.Text = "ID de Orden ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 46);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(383, 46);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 47);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Categoria";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Location = new Point(25, 80);
            listView2.Name = "listView2";
            listView2.Size = new Size(573, 214);
            listView2.TabIndex = 26;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro orden";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de entrega";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "OP asociada";
            columnHeader4.Width = 120;
            // 
            // button5
            // 
            button5.Location = new Point(29, 300);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(155, 38);
            button5.TabIndex = 25;
            button5.Text = "Detalles de Orden";
            button5.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(620, 80);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 216);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // button6
            // 
            button6.Location = new Point(658, 353);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(155, 43);
            button6.TabIndex = 23;
            button6.Text = "salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // Generar
            // 
            Generar.Location = new Point(658, 300);
            Generar.Margin = new Padding(2);
            Generar.Name = "Generar";
            Generar.Size = new Size(155, 47);
            Generar.TabIndex = 22;
            Generar.Text = "Generar Orden Entrega";
            Generar.UseVisualStyleBackColor = true;
            // 
            // ConfirmarOrdenSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 429);
            Controls.Add(listView2);
            Controls.Add(button5);
            Controls.Add(listView1);
            Controls.Add(button6);
            Controls.Add(Generar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConfirmarOrdenSeleccion";
            Text = "Confirmar orden de seleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button5;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button6;
        private Button Generar;
    }
}