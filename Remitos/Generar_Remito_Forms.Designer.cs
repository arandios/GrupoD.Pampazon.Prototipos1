
namespace Pampazon
{
    partial class Generar_RemitoForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GenerarBtn = new Button();
            BuscarBtn = new Button();
            BuscarClienteTxt = new TextBox();
            label2 = new Label();
            OrdenesListV = new ListView();
            NroOrdenColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            CodigoClienteColumna = new ColumnHeader();
            DetalleRemitoLTV = new ListView();
            OrdenConfirmadaColumna = new ColumnHeader();
            ClienteConfirmadoColumna = new ColumnHeader();
            TransportistaConfirmadoColumna = new ColumnHeader();
            SalisBtn = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(342, 748);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(163, 24);
            GenerarBtn.TabIndex = 2;
            GenerarBtn.Text = "Generar nuevo remito";
            GenerarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(513, 46);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(100, 23);
            BuscarBtn.TabIndex = 3;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarClienteTxt
            // 
            BuscarClienteTxt.Location = new Point(20, 46);
            BuscarClienteTxt.Name = "BuscarClienteTxt";
            BuscarClienteTxt.Size = new Size(487, 23);
            BuscarClienteTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 28);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Codigo cliente";
            // 
            // OrdenesListV
            // 
            OrdenesListV.Columns.AddRange(new ColumnHeader[] { NroOrdenColumna, ClienteColumna, CodigoClienteColumna });
            OrdenesListV.Location = new Point(29, 300);
            OrdenesListV.Name = "OrdenesListV";
            OrdenesListV.Size = new Size(653, 156);
            OrdenesListV.TabIndex = 11;
            OrdenesListV.UseCompatibleStateImageBehavior = false;
            OrdenesListV.View = View.Details;
            // 
            // NroOrdenColumna
            // 
            NroOrdenColumna.Text = "ID Orden";
            NroOrdenColumna.Width = 100;
            // 
            // ClienteColumna
            // 
            ClienteColumna.DisplayIndex = 2;
            ClienteColumna.Text = "Fecha de emision";
            ClienteColumna.Width = 250;
            // 
            // CodigoClienteColumna
            // 
            CodigoClienteColumna.DisplayIndex = 1;
            CodigoClienteColumna.Text = "ID Cliente";
            CodigoClienteColumna.Width = 100;
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, ClienteConfirmadoColumna, TransportistaConfirmadoColumna });
            DetalleRemitoLTV.Location = new Point(29, 516);
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(653, 165);
            DetalleRemitoLTV.TabIndex = 12;
            DetalleRemitoLTV.UseCompatibleStateImageBehavior = false;
            DetalleRemitoLTV.View = View.Details;
            // 
            // OrdenConfirmadaColumna
            // 
            OrdenConfirmadaColumna.Text = "Nro. Orden";
            OrdenConfirmadaColumna.Width = 100;
            // 
            // ClienteConfirmadoColumna
            // 
            ClienteConfirmadoColumna.Text = "Cliente";
            ClienteConfirmadoColumna.Width = 250;
            // 
            // TransportistaConfirmadoColumna
            // 
            TransportistaConfirmadoColumna.Text = "Transportista";
            TransportistaConfirmadoColumna.Width = 100;
            // 
            // SalisBtn
            // 
            SalisBtn.Location = new Point(509, 746);
            SalisBtn.Name = "SalisBtn";
            SalisBtn.Size = new Size(163, 26);
            SalisBtn.TabIndex = 13;
            SalisBtn.Text = "Cancelar";
            SalisBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 498);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 126);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del transportista";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 32);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 2;
            label5.Text = "Patente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(487, 462);
            button1.Name = "button1";
            button1.Size = new Size(195, 23);
            button1.TabIndex = 16;
            button1.Text = "Agregar orden al remito";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(487, 687);
            button2.Name = "button2";
            button2.Size = new Size(195, 23);
            button2.TabIndex = 17;
            button2.Text = "Quitar orden del remito";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Controls.Add(BuscarClienteTxt);
            groupBox2.Location = new Point(29, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 124);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar ordenes de entrega";
            // 
            // Generar_RemitoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 794);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(SalisBtn);
            Controls.Add(DetalleRemitoLTV);
            Controls.Add(OrdenesListV);
            Controls.Add(GenerarBtn);
            Name = "Generar_RemitoForms";
            Text = "Remito";
            Load += Generar_RemitoForms_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Generar_RemitoForms_Load(object sender, EventArgs e)
        {
           

            

        }

#endregion
        private Button GenerarBtn;
        private Button BuscarBtn;
        private TextBox BuscarClienteTxt;
        private Label label2;
        private ListView OrdenesListV;
        private ColumnHeader NroOrdenColumna;
        private ColumnHeader ClienteColumna;
        private ListView DetalleRemitoLTV;
        private ColumnHeader OrdenConfirmadaColumna;
        private ColumnHeader ClienteConfirmadoColumna;
        private ColumnHeader TransportistaConfirmadoColumna;
        private Button SalisBtn;
        private Label label4;
        private ColumnHeader CodigoClienteColumna;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
    }
}
