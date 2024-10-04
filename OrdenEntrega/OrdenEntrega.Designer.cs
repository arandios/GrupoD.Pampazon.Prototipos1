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
            listView1 = new ListView();
            button1 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(505, 50);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(95, 23);
            button4.TabIndex = 18;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(693, 363);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(155, 43);
            button3.TabIndex = 17;
            button3.Text = "salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Generar
            // 
            Generar.Location = new Point(693, 312);
            Generar.Margin = new Padding(2, 2, 2, 2);
            Generar.Name = "Generar";
            Generar.Size = new Size(155, 47);
            Generar.TabIndex = 16;
            Generar.Text = "Generar Orden Entrega";
            Generar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(231, 50);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(372, 50);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Categoria";
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
            // textBox1
            // 
            textBox1.Location = new Point(121, 50);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(604, 50);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 11;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(638, 93);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 214);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(41, 312);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(155, 38);
            button1.TabIndex = 20;
            button1.Text = "Detalles de Orden";
            button1.UseVisualStyleBackColor = true;
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrdenEntrega";
            Text = "Orden de entrega";
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
        private ListView listView1;
        private Button button1;
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