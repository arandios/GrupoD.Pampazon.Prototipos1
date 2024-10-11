namespace Pampazon.ListarOrdenes
{
    partial class ConsultarOrdenesForm
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
            label2 = new Label();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox5 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            listView1 = new ListView();
            CodCliente_Columna = new ColumnHeader();
            RazonSocial_Columna = new ColumnHeader();
            DomicilioCli_Columna = new ColumnHeader();
            Cuit = new ColumnHeader();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            label8 = new Label();
            listView3 = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            listView2 = new ListView();
            FechaOrden_Columna = new ColumnHeader();
            Deposito_Columna = new ColumnHeader();
            EstadoOrden_Columna = new ColumnHeader();
            Codigo_de_OrdenColumna = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Código cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(496, 44);
            comboBox4.Margin = new Padding(2, 2, 2, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(140, 23);
            comboBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // button1
            // 
            button1.Location = new Point(325, 82);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 21);
            button1.TabIndex = 8;
            button1.Text = "Buscar orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(458, 81);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(112, 22);
            button2.TabIndex = 9;
            button2.Text = "Borrar filtros";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(581, 542);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(84, 21);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(340, 44);
            comboBox5.Margin = new Padding(2, 2, 2, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(146, 23);
            comboBox5.TabIndex = 12;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 25);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Deposito";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 47);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 42);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 24);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 18;
            label6.Text = "SKU Producto";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodCliente_Columna, RazonSocial_Columna, DomicilioCli_Columna, Cuit });
            listView1.Location = new Point(9, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(657, 146);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CodCliente_Columna
            // 
            CodCliente_Columna.Text = "Código Cliente";
            // 
            // RazonSocial_Columna
            // 
            RazonSocial_Columna.Text = "Razón Social";
            // 
            // DomicilioCli_Columna
            // 
            DomicilioCli_Columna.DisplayIndex = 3;
            DomicilioCli_Columna.Text = "Domicilio";
            // 
            // Cuit
            // 
            Cuit.DisplayIndex = 2;
            Cuit.Text = "Cuit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(656, 268);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Clientes: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(390, 47);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 31);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 17;
            label7.Text = "Cuit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 47);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Razón Social";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(178, 42);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(listView3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Location = new Point(9, 282);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(656, 250);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccione filtros para búsqueda de Ordenes del cliente seleccionado: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 82);
            label8.Name = "label8";
            label8.Size = new Size(171, 15);
            label8.TabIndex = 24;
            label8.Text = "Detalle de productos en Orden:";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna });
            listView3.Location = new Point(374, 100);
            listView3.Name = "listView3";
            listView3.Size = new Size(277, 146);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // SKU_Columna
            // 
            SKU_Columna.Text = "SKU Producto";
            // 
            // Producto_Columna
            // 
            Producto_Columna.Text = "Producto";
            // 
            // Cantidad_Columna
            // 
            Cantidad_Columna.Text = "Cantidad";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { FechaOrden_Columna, Deposito_Columna, EstadoOrden_Columna, Codigo_de_OrdenColumna });
            listView2.Location = new Point(9, 381);
            listView2.Name = "listView2";
            listView2.Size = new Size(370, 146);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // FechaOrden_Columna
            // 
            FechaOrden_Columna.Text = "Fecha";
            // 
            // Deposito_Columna
            // 
            Deposito_Columna.DisplayIndex = 2;
            Deposito_Columna.Text = "Deposito";
            // 
            // EstadoOrden_Columna
            // 
            EstadoOrden_Columna.DisplayIndex = 1;
            EstadoOrden_Columna.Text = "Estado";
            // 
            // Codigo_de_OrdenColumna
            // 
            Codigo_de_OrdenColumna.Text = "Código de Orden";
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 562);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultarOrdenesForm";
            Text = "Consultar Ordenes";
            Load += ListarOrdenes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private ListView listView1;
        private ColumnHeader CodCliente_Columna;
        private ColumnHeader RazonSocial_Columna;
        private ColumnHeader Cuit;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader DomicilioCli_Columna;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView2;
        private ColumnHeader FechaOrden_Columna;
        private ColumnHeader Deposito_Columna;
        private ColumnHeader EstadoOrden_Columna;
        private ListView listView3;
        private ColumnHeader SKU_Columna;
        private ColumnHeader Producto_Columna;
        private ColumnHeader Cantidad_Columna;
        private Label label8;
        private ColumnHeader Codigo_de_OrdenColumna;
    }
}