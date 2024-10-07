
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
            DetalleRemitoLTV = new ListView();
            OrdenConfirmadaColumna = new ColumnHeader();
            FechaRemitoColumna = new ColumnHeader();
            TransportistaConfirmadoColumna = new ColumnHeader();
            SalisBtn = new Button();
            label4 = new Label();
            AgregarOrdenBtn = new Button();
            QuitarOrdenBtn = new Button();
            TransportistasListV = new ListView();
            NombreTransportistaColumna = new ColumnHeader();
            DNITColumna = new ColumnHeader();
            ApellidoTransportistaColumna = new ColumnHeader();
            IdOrdenColumna = new ColumnHeader();
            BuscarTransportistaGroupBox = new GroupBox();
            BuscarTransportistaBtn = new Button();
            label3 = new Label();
            button3 = new Button();
            DNITtxt = new TextBox();
            label5 = new Label();
            GenerarRemitoBtn = new Button();
            CancelarBtn = new Button();
            BuscarTransportistaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(342, 656);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(163, 24);
            GenerarBtn.TabIndex = 2;
            GenerarBtn.Text = "Generar nuevo remito";
            GenerarBtn.UseVisualStyleBackColor = true;
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, FechaRemitoColumna, TransportistaConfirmadoColumna });
            DetalleRemitoLTV.Location = new Point(20, 290);
            DetalleRemitoLTV.MultiSelect = false;
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(489, 95);
            DetalleRemitoLTV.TabIndex = 12;
            DetalleRemitoLTV.UseCompatibleStateImageBehavior = false;
            DetalleRemitoLTV.View = View.Details;
            // 
            // OrdenConfirmadaColumna
            // 
            OrdenConfirmadaColumna.Text = "ID Orden de Preparacion";
            OrdenConfirmadaColumna.Width = 150;
            // 
            // FechaRemitoColumna
            // 
            FechaRemitoColumna.Text = "Fecha de emisión";
            FechaRemitoColumna.Width = 120;
            // 
            // TransportistaConfirmadoColumna
            // 
            TransportistaConfirmadoColumna.Text = "Transportista";
            TransportistaConfirmadoColumna.TextAlign = HorizontalAlignment.Center;
            TransportistaConfirmadoColumna.Width = 250;
            // 
            // SalisBtn
            // 
            SalisBtn.Location = new Point(509, 654);
            SalisBtn.Name = "SalisBtn";
            SalisBtn.Size = new Size(163, 26);
            SalisBtn.TabIndex = 13;
            SalisBtn.Text = "Cancelar";
            SalisBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 272);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // AgregarOrdenBtn
            // 
            AgregarOrdenBtn.Location = new Point(18, 246);
            AgregarOrdenBtn.Name = "AgregarOrdenBtn";
            AgregarOrdenBtn.Size = new Size(491, 23);
            AgregarOrdenBtn.TabIndex = 16;
            AgregarOrdenBtn.Text = "&Agregar Orden de Entrega al remito";
            AgregarOrdenBtn.UseVisualStyleBackColor = true;
            AgregarOrdenBtn.Click += AgregarOrdenBtn_Click;
            // 
            // QuitarOrdenBtn
            // 
            QuitarOrdenBtn.Location = new Point(177, 391);
            QuitarOrdenBtn.Name = "QuitarOrdenBtn";
            QuitarOrdenBtn.Size = new Size(164, 46);
            QuitarOrdenBtn.TabIndex = 17;
            QuitarOrdenBtn.Text = "Quitar Orden de Preparacion del remito";
            QuitarOrdenBtn.UseVisualStyleBackColor = true;
            QuitarOrdenBtn.Click += QuitarOrdenBtn_Click;
            // 
            // TransportistasListV
            // 
            TransportistasListV.Columns.AddRange(new ColumnHeader[] { NombreTransportistaColumna, DNITColumna, ApellidoTransportistaColumna, IdOrdenColumna });
            TransportistasListV.Location = new Point(20, 147);
            TransportistasListV.MultiSelect = false;
            TransportistasListV.Name = "TransportistasListV";
            TransportistasListV.Size = new Size(489, 96);
            TransportistasListV.TabIndex = 20;
            TransportistasListV.UseCompatibleStateImageBehavior = false;
            TransportistasListV.View = View.Details;
            TransportistasListV.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // NombreTransportistaColumna
            // 
            NombreTransportistaColumna.DisplayIndex = 1;
            NombreTransportistaColumna.Text = "Nombre";
            NombreTransportistaColumna.Width = 120;
            // 
            // DNITColumna
            // 
            DNITColumna.DisplayIndex = 0;
            DNITColumna.Text = "DNI";
            DNITColumna.TextAlign = HorizontalAlignment.Center;
            DNITColumna.Width = 100;
            // 
            // ApellidoTransportistaColumna
            // 
            ApellidoTransportistaColumna.Text = "Apellido";
            ApellidoTransportistaColumna.Width = 120;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "Id Orden de Preparacion";
            IdOrdenColumna.Width = 150;
            // 
            // BuscarTransportistaGroupBox
            // 
            BuscarTransportistaGroupBox.Controls.Add(BuscarTransportistaBtn);
            BuscarTransportistaGroupBox.Controls.Add(label3);
            BuscarTransportistaGroupBox.Controls.Add(button3);
            BuscarTransportistaGroupBox.Controls.Add(DNITtxt);
            BuscarTransportistaGroupBox.Location = new Point(17, 12);
            BuscarTransportistaGroupBox.Name = "BuscarTransportistaGroupBox";
            BuscarTransportistaGroupBox.Size = new Size(492, 114);
            BuscarTransportistaGroupBox.TabIndex = 21;
            BuscarTransportistaGroupBox.TabStop = false;
            BuscarTransportistaGroupBox.Text = "Buscar transportista";
            // 
            // BuscarTransportistaBtn
            // 
            BuscarTransportistaBtn.Location = new Point(343, 75);
            BuscarTransportistaBtn.Name = "BuscarTransportistaBtn";
            BuscarTransportistaBtn.Size = new Size(126, 23);
            BuscarTransportistaBtn.TabIndex = 8;
            BuscarTransportistaBtn.Text = "&Buscar";
            BuscarTransportistaBtn.UseVisualStyleBackColor = true;
            BuscarTransportistaBtn.Click += BuscarTransportistaBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 28);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 7;
            label3.Text = "DNI transportista";
            // 
            // button3
            // 
            button3.Location = new Point(513, 46);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 3;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // DNITtxt
            // 
            DNITtxt.Location = new Point(20, 46);
            DNITtxt.Name = "DNITtxt";
            DNITtxt.Size = new Size(449, 23);
            DNITtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 129);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 22;
            label5.Text = "Detalle transportista";
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(17, 391);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(136, 46);
            GenerarRemitoBtn.TabIndex = 23;
            GenerarRemitoBtn.Text = "&Generar nuevo remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(364, 391);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(145, 46);
            CancelarBtn.TabIndex = 24;
            CancelarBtn.Text = "Salir";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // Generar_RemitoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 449);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarRemitoBtn);
            Controls.Add(label5);
            Controls.Add(BuscarTransportistaGroupBox);
            Controls.Add(TransportistasListV);
            Controls.Add(QuitarOrdenBtn);
            Controls.Add(AgregarOrdenBtn);
            Controls.Add(label4);
            Controls.Add(SalisBtn);
            Controls.Add(DetalleRemitoLTV);
            Controls.Add(GenerarBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Generar_RemitoForms";
            Text = "Generar remito";
            Load += Generar_RemitoForms_Load;
            BuscarTransportistaGroupBox.ResumeLayout(false);
            BuscarTransportistaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Generar_RemitoForms_Load(object sender, EventArgs e)
        {
           

            

        }

#endregion
        private Button GenerarBtn;
        private ListView DetalleRemitoLTV;
        private ColumnHeader OrdenConfirmadaColumna;
        private ColumnHeader FechaRemitoColumna;
        private ColumnHeader TransportistaConfirmadoColumna;
        private Button SalisBtn;
        private Label label4;
        private Button AgregarOrdenBtn;
        private Button QuitarOrdenBtn;
        private GroupBox BuscarTransportistaGroupBox;
        private Label label3;
        private Button button3;
        private TextBox DNITtxt;
        private ColumnHeader NombreTransportistaColumna;
        private ColumnHeader DNITColumna;
        private ColumnHeader ApellidoTransportistaColumna;
        private Button BuscarTransportistaBtn;
        private Label label5;
        private Button GenerarRemitoBtn;
        private ColumnHeader IdOrdenColumna;
        internal ListView TransportistasListV;
        private Button CancelarBtn;
    }
}
