
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
            ConfirmarBtn = new Button();
            ReportarBtn = new Button();
            GenerarBtn = new Button();
            BuscarBtn = new Button();
            label1 = new Label();
            BuscarClienteTxt = new TextBox();
            label2 = new Label();
            TransportistasLTB = new ListBox();
            label3 = new Label();
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
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(503, 148);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(86, 40);
            ConfirmarBtn.TabIndex = 0;
            ConfirmarBtn.Text = "Confirmar transportista";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // ReportarBtn
            // 
            ReportarBtn.Location = new Point(591, 148);
            ReportarBtn.Name = "ReportarBtn";
            ReportarBtn.Size = new Size(75, 40);
            ReportarBtn.TabIndex = 1;
            ReportarBtn.Text = "Reportar";
            ReportarBtn.UseVisualStyleBackColor = true;
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(503, 194);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(163, 24);
            GenerarBtn.TabIndex = 2;
            GenerarBtn.Text = "Generar nuevo remito";
            GenerarBtn.UseVisualStyleBackColor = true;
            GenerarBtn.Click += GenerarBtn_Click;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(397, 77);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(100, 23);
            BuscarBtn.TabIndex = 3;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 30);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 5;
            label1.Text = "Transportistas designados";
            // 
            // BuscarClienteTxt
            // 
            BuscarClienteTxt.Location = new Point(397, 48);
            BuscarClienteTxt.Name = "BuscarClienteTxt";
            BuscarClienteTxt.Size = new Size(100, 23);
            BuscarClienteTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Codigo cliente";
            // 
            // TransportistasLTB
            // 
            TransportistasLTB.FormattingEnabled = true;
            TransportistasLTB.ItemHeight = 15;
            TransportistasLTB.Location = new Point(503, 48);
            TransportistasLTB.Name = "TransportistasLTB";
            TransportistasLTB.Size = new Size(163, 94);
            TransportistasLTB.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 22);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 10;
            label3.Text = "Ordenes de entrega";
            // 
            // OrdenesListV
            // 
            OrdenesListV.Columns.AddRange(new ColumnHeader[] { NroOrdenColumna, ClienteColumna, CodigoClienteColumna });
            OrdenesListV.Location = new Point(26, 40);
            OrdenesListV.Name = "OrdenesListV";
            OrdenesListV.Size = new Size(353, 97);
            OrdenesListV.TabIndex = 11;
            OrdenesListV.UseCompatibleStateImageBehavior = false;
            OrdenesListV.View = View.Details;
            OrdenesListV.SelectedIndexChanged += OrdenesListV_SelectedIndexChanged;
            // 
            // NroOrdenColumna
            // 
            NroOrdenColumna.Text = "Nro. Orden";
            NroOrdenColumna.Width = 100;
            // 
            // ClienteColumna
            // 
            ClienteColumna.DisplayIndex = 2;
            ClienteColumna.Text = "Cliente";
            ClienteColumna.Width = 250;
            // 
            // CodigoClienteColumna
            // 
            CodigoClienteColumna.DisplayIndex = 1;
            CodigoClienteColumna.Text = "Codigo";
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, ClienteConfirmadoColumna, TransportistaConfirmadoColumna });
            DetalleRemitoLTV.Location = new Point(26, 159);
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(456, 119);
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
            SalisBtn.Location = new Point(503, 252);
            SalisBtn.Name = "SalisBtn";
            SalisBtn.Size = new Size(163, 26);
            SalisBtn.TabIndex = 13;
            SalisBtn.Text = "Salir";
            SalisBtn.UseVisualStyleBackColor = true;
            SalisBtn.Click += SalisBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 141);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(503, 223);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(163, 23);
            CancelarBtn.TabIndex = 15;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // Generar_RemitoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 290);
            Controls.Add(CancelarBtn);
            Controls.Add(label4);
            Controls.Add(SalisBtn);
            Controls.Add(DetalleRemitoLTV);
            Controls.Add(OrdenesListV);
            Controls.Add(label3);
            Controls.Add(TransportistasLTB);
            Controls.Add(label2);
            Controls.Add(BuscarClienteTxt);
            Controls.Add(label1);
            Controls.Add(BuscarBtn);
            Controls.Add(GenerarBtn);
            Controls.Add(ReportarBtn);
            Controls.Add(ConfirmarBtn);
            Name = "Generar_RemitoForms";
            Text = "Remito";
            Load += Generar_RemitoForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Generar_RemitoForms_Load(object sender, EventArgs e)
        {
           

            

        }

      

        #endregion

        private Button ConfirmarBtn;
        private Button ReportarBtn;
        private Button GenerarBtn;
        private Button BuscarBtn;
        private Label label1;
        private TextBox BuscarClienteTxt;
        private Label label2;
        private ListBox TransportistasLTB;
        private Label label3;
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
        private Button CancelarBtn;
    }
}
