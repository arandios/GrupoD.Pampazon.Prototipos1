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
            EstadoComboBox = new ComboBox();
            label4 = new Label();
            BuscarOrdenBtn = new Button();
            BorrarFiltrosBtn = new Button();
            button3 = new Button();
            CodigoClienteTxt = new TextBox();
            listView1 = new ListView();
            CodCliente_Columna = new ColumnHeader();
            RazonSocial_Columna = new ColumnHeader();
            Cuit = new ColumnHeader();
            FechaOP_Columna = new ColumnHeader();
            Estado_Columna = new ColumnHeader();
            Prioridad_Columna = new ColumnHeader();
            groupBox1 = new GroupBox();
            label8 = new Label();
            PrioridadComboBox = new ComboBox();
            CuitTxt = new TextBox();
            label7 = new Label();
            RazonSocialTxt = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView3 = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            Ubicacion_Columna = new ColumnHeader();
            groupBox3 = new GroupBox();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Código cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha inicio";
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Location = new Point(9, 113);
            EstadoComboBox.Margin = new Padding(2, 3, 2, 3);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(198, 28);
            EstadoComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 91);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // BuscarOrdenBtn
            // 
            BuscarOrdenBtn.Location = new Point(507, 180);
            BuscarOrdenBtn.Margin = new Padding(2, 3, 2, 3);
            BuscarOrdenBtn.Name = "BuscarOrdenBtn";
            BuscarOrdenBtn.Size = new Size(224, 53);
            BuscarOrdenBtn.TabIndex = 8;
            BuscarOrdenBtn.Text = "&Buscar orden";
            BuscarOrdenBtn.UseVisualStyleBackColor = true;
            BuscarOrdenBtn.Click += button1_Click;
            // 
            // BorrarFiltrosBtn
            // 
            BorrarFiltrosBtn.Location = new Point(740, 180);
            BorrarFiltrosBtn.Margin = new Padding(2, 3, 2, 3);
            BorrarFiltrosBtn.Name = "BorrarFiltrosBtn";
            BorrarFiltrosBtn.RightToLeft = RightToLeft.No;
            BorrarFiltrosBtn.Size = new Size(214, 53);
            BorrarFiltrosBtn.TabIndex = 9;
            BorrarFiltrosBtn.Text = "&Borrar filtros";
            BorrarFiltrosBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(750, 875);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(214, 53);
            button3.TabIndex = 11;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(7, 49);
            CodigoClienteTxt.Margin = new Padding(2, 3, 2, 3);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(306, 27);
            CodigoClienteTxt.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodCliente_Columna, RazonSocial_Columna, Cuit, FechaOP_Columna, Estado_Columna, Prioridad_Columna });
            listView1.Location = new Point(19, 293);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(945, 285);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CodCliente_Columna
            // 
            CodCliente_Columna.Text = "Código Cliente";
            CodCliente_Columna.Width = 100;
            // 
            // RazonSocial_Columna
            // 
            RazonSocial_Columna.Text = "Razón Social";
            RazonSocial_Columna.TextAlign = HorizontalAlignment.Center;
            RazonSocial_Columna.Width = 150;
            // 
            // Cuit
            // 
            Cuit.Text = "Cuit";
            Cuit.TextAlign = HorizontalAlignment.Center;
            Cuit.Width = 100;
            // 
            // FechaOP_Columna
            // 
            FechaOP_Columna.Text = "Fecha generación Orden Preparación";
            FechaOP_Columna.TextAlign = HorizontalAlignment.Center;
            FechaOP_Columna.Width = 220;
            // 
            // Estado_Columna
            // 
            Estado_Columna.Text = "Estado";
            Estado_Columna.TextAlign = HorizontalAlignment.Center;
            Estado_Columna.Width = 120;
            // 
            // Prioridad_Columna
            // 
            Prioridad_Columna.Text = "Prioridad";
            Prioridad_Columna.TextAlign = HorizontalAlignment.Center;
            Prioridad_Columna.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(PrioridadComboBox);
            groupBox1.Controls.Add(CuitTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RazonSocialTxt);
            groupBox1.Controls.Add(EstadoComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CodigoClienteTxt);
            groupBox1.Controls.Add(BuscarOrdenBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BorrarFiltrosBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 239);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Clientes: ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 93);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 21;
            label8.Text = "Prioridad";
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Location = new Point(222, 113);
            PrioridadComboBox.Margin = new Padding(2, 3, 2, 3);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(229, 28);
            PrioridadComboBox.TabIndex = 20;
            // 
            // CuitTxt
            // 
            CuitTxt.Location = new Point(654, 49);
            CuitTxt.Margin = new Padding(2, 3, 2, 3);
            CuitTxt.Name = "CuitTxt";
            CuitTxt.Size = new Size(287, 27);
            CuitTxt.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(664, 27);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 17;
            label7.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(329, 49);
            RazonSocialTxt.Margin = new Padding(2, 3, 2, 3);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(321, 27);
            RazonSocialTxt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 15;
            label1.Text = "Razón Social";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView3);
            groupBox2.Location = new Point(18, 601);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(952, 268);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna, Ubicacion_Columna });
            listView3.Location = new Point(7, 28);
            listView3.Margin = new Padding(3, 4, 3, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(939, 233);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // SKU_Columna
            // 
            SKU_Columna.Text = "SKU Producto";
            SKU_Columna.Width = 199;
            // 
            // Producto_Columna
            // 
            Producto_Columna.Text = "Producto";
            Producto_Columna.TextAlign = HorizontalAlignment.Center;
            Producto_Columna.Width = 199;
            // 
            // Cantidad_Columna
            // 
            Cantidad_Columna.Text = "Cantidad";
            Cantidad_Columna.TextAlign = HorizontalAlignment.Center;
            Cantidad_Columna.Width = 199;
            // 
            // Ubicacion_Columna
            // 
            Ubicacion_Columna.Text = "Ubicación";
            Ubicacion_Columna.TextAlign = HorizontalAlignment.Center;
            Ubicacion_Columna.Width = 199;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(10, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(960, 316);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cliente encontrado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(706, 88);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 22;
            label5.Text = "Fecha fin";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(456, 114);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(238, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(706, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ConsultarOrdenesForm";
            Text = "Consultar Ordenes de Preparación";
            Load += ListarOrdenes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarOrdenBtn;
        private System.Windows.Forms.Button BorrarFiltrosBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CodigoClienteTxt;
        private ListView listView1;
        private ColumnHeader CodCliente_Columna;
        private ColumnHeader RazonSocial_Columna;
        private ColumnHeader Cuit;
        private GroupBox groupBox1;
        private TextBox CuitTxt;
        private Label label7;
        private TextBox RazonSocialTxt;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView3;
        private ColumnHeader SKU_Columna;
        private ColumnHeader Producto_Columna;
        private ColumnHeader Cantidad_Columna;
        private ColumnHeader FechaOP_Columna;
        private ColumnHeader Estado_Columna;
        private ColumnHeader Prioridad_Columna;
        private Label label8;
        private ComboBox PrioridadComboBox;
        private ColumnHeader Ubicacion_Columna;
        private GroupBox groupBox3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}