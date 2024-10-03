
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
            button1 = new Button();
            button2 = new Button();
            buscarOrdenDeEntregaGroupBox = new GroupBox();
            label1 = new Label();
            buscarOrdenDeEntregaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(391, 874);
            GenerarBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(186, 32);
            GenerarBtn.TabIndex = 2;
            GenerarBtn.Text = "Generar nuevo remito";
            GenerarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(586, 61);
            BuscarBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(114, 31);
            BuscarBtn.TabIndex = 3;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarClienteTxt
            // 
            BuscarClienteTxt.Location = new Point(23, 61);
            BuscarClienteTxt.Margin = new Padding(3, 4, 3, 4);
            BuscarClienteTxt.Name = "BuscarClienteTxt";
            BuscarClienteTxt.Size = new Size(556, 27);
            BuscarClienteTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 37);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 7;
            label2.Text = "Codigo cliente";
            // 
            // OrdenesListV
            // 
            OrdenesListV.Columns.AddRange(new ColumnHeader[] { NroOrdenColumna, ClienteColumna, CodigoClienteColumna });
            OrdenesListV.Location = new Point(22, 302);
            OrdenesListV.Margin = new Padding(3, 4, 3, 4);
            OrdenesListV.Name = "OrdenesListV";
            OrdenesListV.Size = new Size(746, 207);
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
            DetalleRemitoLTV.Location = new Point(22, 595);
            DetalleRemitoLTV.Margin = new Padding(3, 4, 3, 4);
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(746, 219);
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
            SalisBtn.Location = new Point(582, 872);
            SalisBtn.Margin = new Padding(3, 4, 3, 4);
            SalisBtn.Name = "SalisBtn";
            SalisBtn.Size = new Size(186, 35);
            SalisBtn.TabIndex = 13;
            SalisBtn.Text = "Cancelar";
            SalisBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 571);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // button1
            // 
            button1.Location = new Point(487, 529);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(281, 31);
            button1.TabIndex = 16;
            button1.Text = "Agregar Orden de Entrega al remito";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(487, 823);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(282, 31);
            button2.TabIndex = 17;
            button2.Text = "Quitar Orden de Entrega del remito";
            button2.UseVisualStyleBackColor = true;
            // 
            // buscarOrdenDeEntregaGroupBox
            // 
            buscarOrdenDeEntregaGroupBox.Controls.Add(label2);
            buscarOrdenDeEntregaGroupBox.Controls.Add(BuscarBtn);
            buscarOrdenDeEntregaGroupBox.Controls.Add(BuscarClienteTxt);
            buscarOrdenDeEntregaGroupBox.Location = new Point(22, 57);
            buscarOrdenDeEntregaGroupBox.Margin = new Padding(3, 4, 3, 4);
            buscarOrdenDeEntregaGroupBox.Name = "buscarOrdenDeEntregaGroupBox";
            buscarOrdenDeEntregaGroupBox.Padding = new Padding(3, 4, 3, 4);
            buscarOrdenDeEntregaGroupBox.Size = new Size(746, 165);
            buscarOrdenDeEntregaGroupBox.TabIndex = 18;
            buscarOrdenDeEntregaGroupBox.TabStop = false;
            buscarOrdenDeEntregaGroupBox.Text = "Buscar ordenes de entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 278);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 19;
            label1.Text = "Detalle Orden de Entrega";
            // 
            // Generar_RemitoForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 936);
            Controls.Add(label1);
            Controls.Add(buscarOrdenDeEntregaGroupBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(SalisBtn);
            Controls.Add(DetalleRemitoLTV);
            Controls.Add(OrdenesListV);
            Controls.Add(GenerarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Generar_RemitoForms";
            Text = "Remito";
            Load += Generar_RemitoForms_Load;
            buscarOrdenDeEntregaGroupBox.ResumeLayout(false);
            buscarOrdenDeEntregaGroupBox.PerformLayout();
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
        private Button button1;
        private Button button2;
        private GroupBox buscarOrdenDeEntregaGroupBox;
        private Label label1;
    }
}
