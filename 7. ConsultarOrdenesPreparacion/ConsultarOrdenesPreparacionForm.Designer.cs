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
            FechaTimePicker = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView3 = new ListView();
            SKU_Columna = new ColumnHeader();
            Producto_Columna = new ColumnHeader();
            Cantidad_Columna = new ColumnHeader();
            Ubicacion_Columna = new ColumnHeader();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Código cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Location = new Point(8, 85);
            EstadoComboBox.Margin = new Padding(2, 2, 2, 2);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(266, 23);
            EstadoComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 68);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // BuscarOrdenBtn
            // 
            BuscarOrdenBtn.Location = new Point(8, 126);
            BuscarOrdenBtn.Margin = new Padding(2, 2, 2, 2);
            BuscarOrdenBtn.Name = "BuscarOrdenBtn";
            BuscarOrdenBtn.Size = new Size(532, 40);
            BuscarOrdenBtn.TabIndex = 8;
            BuscarOrdenBtn.Text = "&Buscar orden";
            BuscarOrdenBtn.UseVisualStyleBackColor = true;
            BuscarOrdenBtn.Click += button1_Click;
            // 
            // BorrarFiltrosBtn
            // 
            BorrarFiltrosBtn.Location = new Point(544, 126);
            BorrarFiltrosBtn.Margin = new Padding(2, 2, 2, 2);
            BorrarFiltrosBtn.Name = "BorrarFiltrosBtn";
            BorrarFiltrosBtn.RightToLeft = RightToLeft.No;
            BorrarFiltrosBtn.Size = new Size(248, 40);
            BorrarFiltrosBtn.TabIndex = 9;
            BorrarFiltrosBtn.Text = "&Borrar filtros";
            BorrarFiltrosBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(649, 612);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(171, 36);
            button3.TabIndex = 11;
            button3.Text = "&Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // CodigoClienteTxt
            // 
            CodigoClienteTxt.Location = new Point(6, 37);
            CodigoClienteTxt.Margin = new Padding(2, 2, 2, 2);
            CodigoClienteTxt.Name = "CodigoClienteTxt";
            CodigoClienteTxt.Size = new Size(268, 23);
            CodigoClienteTxt.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodCliente_Columna, RazonSocial_Columna, Cuit, FechaOP_Columna, Estado_Columna, Prioridad_Columna });
            listView1.Location = new Point(17, 220);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 194);
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
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(PrioridadComboBox);
            groupBox1.Controls.Add(CuitTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RazonSocialTxt);
            groupBox1.Controls.Add(EstadoComboBox);
            groupBox1.Controls.Add(FechaTimePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CodigoClienteTxt);
            groupBox1.Controls.Add(BuscarOrdenBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BorrarFiltrosBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(802, 179);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Clientes: ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(288, 71);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 21;
            label8.Text = "Prioridad";
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Location = new Point(288, 86);
            PrioridadComboBox.Margin = new Padding(2, 2, 2, 2);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(252, 23);
            PrioridadComboBox.TabIndex = 20;
            // 
            // CuitTxt
            // 
            CuitTxt.Location = new Point(544, 37);
            CuitTxt.Margin = new Padding(2, 2, 2, 2);
            CuitTxt.Name = "CuitTxt";
            CuitTxt.Size = new Size(252, 23);
            CuitTxt.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 17;
            label7.Text = "Cuit";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(288, 37);
            RazonSocialTxt.Margin = new Padding(2, 2, 2, 2);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.Size = new Size(252, 23);
            RazonSocialTxt.TabIndex = 16;
            // 
            // FechaTimePicker
            // 
            FechaTimePicker.Location = new Point(544, 86);
            FechaTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaTimePicker.Name = "FechaTimePicker";
            FechaTimePicker.Size = new Size(252, 23);
            FechaTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Razón Social";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView3);
            groupBox2.Location = new Point(9, 419);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(811, 189);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle productos en la Orden del cliente seleccionado: ";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { SKU_Columna, Producto_Columna, Cantidad_Columna, Ubicacion_Columna });
            listView3.Location = new Point(6, 21);
            listView3.Name = "listView3";
            listView3.Size = new Size(796, 158);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 202);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 22;
            label5.Text = "Cliente encontrado";
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 659);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultarOrdenesForm";
            Text = "Consultar Ordenes de Preparación";
            Load += ListarOrdenes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private DateTimePicker FechaTimePicker;
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
        private Label label5;
    }
}