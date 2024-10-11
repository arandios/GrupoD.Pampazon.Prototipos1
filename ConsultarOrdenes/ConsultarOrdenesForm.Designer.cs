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
            listView3 = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            listView2 = new ListView();
            FechaOrden_Columna = new ColumnHeader();
            Deposito_Columna = new ColumnHeader();
            EstadoOrden_Columna = new ColumnHeader();
            Codigo_de_OrdenColumna = new ColumnHeader();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Código cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(567, 58);
            comboBox4.Margin = new Padding(2, 3, 2, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(159, 28);
            comboBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // button1
            // 
            button1.Location = new Point(371, 109);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 28);
            button1.TabIndex = 8;
            button1.Text = "Buscar orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(524, 108);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(128, 29);
            button2.TabIndex = 9;
            button2.Text = "Borrar filtros";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(664, 722);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 28);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(388, 58);
            comboBox5.Margin = new Padding(2, 3, 2, 3);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(166, 28);
            comboBox5.TabIndex = 12;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 33);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Deposito";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 63);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 56);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 27);
            textBox4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 32);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 18;
            label6.Text = "SKU Producto";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodCliente_Columna, RazonSocial_Columna, DomicilioCli_Columna, Cuit });
            listView1.Location = new Point(10, 161);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(750, 194);
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
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 358);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Clientes: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(446, 63);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 27);
            textBox3.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 41);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 17;
            label7.Text = "Cuit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 63);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 15;
            label1.Text = "Razón Social";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(204, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
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
            groupBox2.Location = new Point(10, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 334);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccione filtros para búsqueda de Ordenes del cliente seleccionado: ";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna });
            listView3.Location = new Point(428, 133);
            listView3.Margin = new Padding(3, 4, 3, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(316, 194);
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
            listView2.Location = new Point(10, 508);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(422, 194);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(428, 109);
            label8.Name = "label8";
            label8.Size = new Size(217, 20);
            label8.TabIndex = 24;
            label8.Text = "Detalle de productos en Orden:";
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 762);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            Name = "ConsultarOrdenesForm";
            Text = "ConsultarOrdenes";
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