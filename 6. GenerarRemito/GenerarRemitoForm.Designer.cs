namespace Pampazon._6._GenerarRemito
{
    partial class GenerarRemitoForm
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
            DetalleRemitoLTV = new ListView();
            OrdenConfirmadaColumna = new ColumnHeader();
            FechaRemitoColumna = new ColumnHeader();
            label4 = new Label();
            AgregarOrdenBTN = new Button();
            QuitarOrdenBTN = new Button();
            TransportistasListV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            BuscarTransportistaGRP = new GroupBox();
            NomApellTransportistaTXT = new TextBox();
            NombreTransportistaLBL = new Label();
            BuscarTransportistaBtn = new Button();
            DNITransportistaLBL = new Label();
            DNITXT = new TextBox();
            GenerarRemitoBTN = new Button();
            OrdenesDelTransportistaGRP = new GroupBox();
            DetalleRemitoGRP = new GroupBox();
            SalirBTN = new Button();
            BuscarTransportistaGRP.SuspendLayout();
            OrdenesDelTransportistaGRP.SuspendLayout();
            DetalleRemitoGRP.SuspendLayout();
            SuspendLayout();
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.BorderStyle = BorderStyle.FixedSingle;
            DetalleRemitoLTV.CheckBoxes = true;
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, FechaRemitoColumna });
            DetalleRemitoLTV.FullRowSelect = true;
            DetalleRemitoLTV.Location = new Point(23, 32);
            DetalleRemitoLTV.MultiSelect = false;
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(778, 186);
            DetalleRemitoLTV.Sorting = SortOrder.Ascending;
            DetalleRemitoLTV.TabIndex = 12;
            DetalleRemitoLTV.UseCompatibleStateImageBehavior = false;
            DetalleRemitoLTV.View = View.Details;
            DetalleRemitoLTV.MouseClick += DetalleRemitoLTV_MouseClick;
            // 
            // OrdenConfirmadaColumna
            // 
            OrdenConfirmadaColumna.Text = "ID Orden de Preparacion";
            OrdenConfirmadaColumna.Width = 450;
            // 
            // FechaRemitoColumna
            // 
            FechaRemitoColumna.Text = "Fecha de emisión";
            FechaRemitoColumna.TextAlign = HorizontalAlignment.Center;
            FechaRemitoColumna.Width = 450;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, -18);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // AgregarOrdenBTN
            // 
            AgregarOrdenBTN.Location = new Point(400, 190);
            AgregarOrdenBTN.Name = "AgregarOrdenBTN";
            AgregarOrdenBTN.Size = new Size(401, 40);
            AgregarOrdenBTN.TabIndex = 16;
            AgregarOrdenBTN.Text = "&Agregar Orden de Preparacion al remito";
            AgregarOrdenBTN.UseVisualStyleBackColor = true;
            AgregarOrdenBTN.Click += AgregarOrdenBtn_Click;
            // 
            // QuitarOrdenBTN
            // 
            QuitarOrdenBTN.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenBTN.Location = new Point(544, 224);
            QuitarOrdenBTN.Name = "QuitarOrdenBTN";
            QuitarOrdenBTN.Size = new Size(256, 44);
            QuitarOrdenBTN.TabIndex = 17;
            QuitarOrdenBTN.Text = "&Quitar Orden de Preparacion del Remito";
            QuitarOrdenBTN.UseVisualStyleBackColor = false;
            QuitarOrdenBTN.Click += QuitarOrdenBtn_Click;
            // 
            // TransportistasListV
            // 
            TransportistasListV.Alignment = ListViewAlignment.Default;
            TransportistasListV.AutoArrange = false;
            TransportistasListV.CheckBoxes = true;
            TransportistasListV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna });
            TransportistasListV.FullRowSelect = true;
            TransportistasListV.Location = new Point(23, 22);
            TransportistasListV.Name = "TransportistasListV";
            TransportistasListV.Size = new Size(778, 162);
            TransportistasListV.Sorting = SortOrder.Ascending;
            TransportistasListV.TabIndex = 20;
            TransportistasListV.UseCompatibleStateImageBehavior = false;
            TransportistasListV.View = View.Details;
            TransportistasListV.MouseClick += TransportistasListV_MouseClick;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "Id Orden de Preparacion";
            IdOrdenColumna.Width = 900;
            // 
            // BuscarTransportistaGRP
            // 
            BuscarTransportistaGRP.Controls.Add(NomApellTransportistaTXT);
            BuscarTransportistaGRP.Controls.Add(NombreTransportistaLBL);
            BuscarTransportistaGRP.Controls.Add(BuscarTransportistaBtn);
            BuscarTransportistaGRP.Controls.Add(DNITransportistaLBL);
            BuscarTransportistaGRP.Controls.Add(DNITXT);
            BuscarTransportistaGRP.Location = new Point(30, 12);
            BuscarTransportistaGRP.Name = "BuscarTransportistaGRP";
            BuscarTransportistaGRP.Size = new Size(816, 119);
            BuscarTransportistaGRP.TabIndex = 21;
            BuscarTransportistaGRP.TabStop = false;
            BuscarTransportistaGRP.Text = "Seleccione filtros de búsqueda para Transportista: ";
            // 
            // NomApellTransportistaTXT
            // 
            NomApellTransportistaTXT.Location = new Point(4, 91);
            NomApellTransportistaTXT.Margin = new Padding(2, 2, 2, 2);
            NomApellTransportistaTXT.Name = "NomApellTransportistaTXT";
            NomApellTransportistaTXT.ReadOnly = true;
            NomApellTransportistaTXT.Size = new Size(650, 23);
            NomApellTransportistaTXT.TabIndex = 66;
            NomApellTransportistaTXT.TextChanged += NomApellTransportistaTxt_TextChanged;
            // 
            // NombreTransportistaLBL
            // 
            NombreTransportistaLBL.AutoSize = true;
            NombreTransportistaLBL.Location = new Point(6, 74);
            NombreTransportistaLBL.Name = "NombreTransportistaLBL";
            NombreTransportistaLBL.Size = new Size(121, 15);
            NombreTransportistaLBL.TabIndex = 67;
            NombreTransportistaLBL.Text = "Nombre Transportista";
            // 
            // BuscarTransportistaBtn
            // 
            BuscarTransportistaBtn.Location = new Point(659, 26);
            BuscarTransportistaBtn.Name = "BuscarTransportistaBtn";
            BuscarTransportistaBtn.Size = new Size(130, 40);
            BuscarTransportistaBtn.TabIndex = 8;
            BuscarTransportistaBtn.Text = "&Buscar Transportista";
            BuscarTransportistaBtn.UseVisualStyleBackColor = true;
            BuscarTransportistaBtn.Click += BuscarTransportistaBtn_Click;
            BuscarTransportistaBtn.Enter += BuscarTransportistaBtn_Click;
            // 
            // DNITransportistaLBL
            // 
            DNITransportistaLBL.AutoSize = true;
            DNITransportistaLBL.Location = new Point(7, 26);
            DNITransportistaLBL.Name = "DNITransportistaLBL";
            DNITransportistaLBL.Size = new Size(96, 15);
            DNITransportistaLBL.TabIndex = 7;
            DNITransportistaLBL.Text = "DNI transportista";
            // 
            // DNITXT
            // 
            DNITXT.Location = new Point(7, 45);
            DNITXT.Name = "DNITXT";
            DNITXT.Size = new Size(647, 23);
            DNITXT.TabIndex = 6;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.BackColor = Color.FromArgb(192, 255, 192);
            GenerarRemitoBTN.Location = new Point(260, 224);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(279, 44);
            GenerarRemitoBTN.TabIndex = 23;
            GenerarRemitoBTN.Text = "&Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = false;
            GenerarRemitoBTN.Click += GenerarRemitoBtn_Click;
            // 
            // OrdenesDelTransportistaGRP
            // 
            OrdenesDelTransportistaGRP.Controls.Add(AgregarOrdenBTN);
            OrdenesDelTransportistaGRP.Controls.Add(TransportistasListV);
            OrdenesDelTransportistaGRP.Location = new Point(30, 137);
            OrdenesDelTransportistaGRP.Name = "OrdenesDelTransportistaGRP";
            OrdenesDelTransportistaGRP.Size = new Size(816, 236);
            OrdenesDelTransportistaGRP.TabIndex = 25;
            OrdenesDelTransportistaGRP.TabStop = false;
            OrdenesDelTransportistaGRP.Text = "Ordenes del Transportista";
            // 
            // DetalleRemitoGRP
            // 
            DetalleRemitoGRP.Controls.Add(DetalleRemitoLTV);
            DetalleRemitoGRP.Controls.Add(QuitarOrdenBTN);
            DetalleRemitoGRP.Controls.Add(label4);
            DetalleRemitoGRP.Controls.Add(GenerarRemitoBTN);
            DetalleRemitoGRP.Location = new Point(30, 383);
            DetalleRemitoGRP.Name = "DetalleRemitoGRP";
            DetalleRemitoGRP.Size = new Size(816, 281);
            DetalleRemitoGRP.TabIndex = 26;
            DetalleRemitoGRP.TabStop = false;
            DetalleRemitoGRP.Text = "Detalle del remito";
            DetalleRemitoGRP.Enter += DetalleRemitoGRP_Enter;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(643, 670);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 27;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += SalirBtn_Click;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 715);
            Controls.Add(SalirBTN);
            Controls.Add(DetalleRemitoGRP);
            Controls.Add(OrdenesDelTransportistaGRP);
            Controls.Add(BuscarTransportistaGRP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GenerarRemitoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar remito";
            Load += Generar_RemitoForms_Load;
            BuscarTransportistaGRP.ResumeLayout(false);
            BuscarTransportistaGRP.PerformLayout();
            OrdenesDelTransportistaGRP.ResumeLayout(false);
            DetalleRemitoGRP.ResumeLayout(false);
            DetalleRemitoGRP.PerformLayout();
            ResumeLayout(false);
        }

        private void Generar_RemitoForms_Load(object sender, EventArgs e)
        {




        }

        #endregion
        private ListView DetalleRemitoLTV;
        private ColumnHeader OrdenConfirmadaColumna;
        private ColumnHeader FechaRemitoColumna;
        private Label label4;
        private Button AgregarOrdenBTN;
        private Button QuitarOrdenBTN;
        private GroupBox BuscarTransportistaGRP;
        private Label DNITransportistaLBL;
        private TextBox DNITXT;
        private Button BuscarTransportistaBtn;
        private Label label5;
        private Button GenerarRemitoBTN;
        private ColumnHeader IdOrdenColumna;
        internal ListView TransportistasListV;
        private GroupBox OrdenesDelTransportistaGRP;
        private GroupBox DetalleRemitoGRP;
        private Button SalirBTN;
        protected TextBox NomApellTransportistaTXT;
        private Label NombreTransportistaLBL;

    }

}