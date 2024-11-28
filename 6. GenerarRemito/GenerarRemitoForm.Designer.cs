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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarRemitoForm));
            DetalleRemitoLTV = new ListView();
            OrdenConfirmadaColumna = new ColumnHeader();
            IdClienteRColumna = new ColumnHeader();
            RazonColumna = new ColumnHeader();
            FechaRemitoColumna = new ColumnHeader();
            label4 = new Label();
            AgregarOrdenBTN = new Button();
            QuitarOrdenBTN = new Button();
            TransportistasListV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            RZColumna = new ColumnHeader();
            BuscarTransportistaGRP = new GroupBox();
            BorrarBtn = new Button();
            TransportistasCBX = new ComboBox();
            NomApellTransportistaTXT = new TextBox();
            NombreTransportistaLBL = new Label();
            BuscarTransportistaBtn = new Button();
            DNITransportistaLBL = new Label();
            GenerarRemitoBTN = new Button();
            OrdenesDelTransportistaGRP = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            RZCBX = new ComboBox();
            IdCLienteCBX = new ComboBox();
            DetalleRemitoGRP = new GroupBox();
            SalirBTN = new Button();
            FiltrarOrdenesPorClienteGBX = new GroupBox();
            BorrarFiltrosBTN = new Button();
            BuscarTransportistaGRP.SuspendLayout();
            OrdenesDelTransportistaGRP.SuspendLayout();
            DetalleRemitoGRP.SuspendLayout();
            FiltrarOrdenesPorClienteGBX.SuspendLayout();
            SuspendLayout();
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetalleRemitoLTV.BackColor = SystemColors.Window;
            DetalleRemitoLTV.BorderStyle = BorderStyle.FixedSingle;
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, IdClienteRColumna, RazonColumna, FechaRemitoColumna });
            DetalleRemitoLTV.FullRowSelect = true;
            DetalleRemitoLTV.Location = new Point(6, 32);
            DetalleRemitoLTV.MaximumSize = new Size(1500, 1000);
            DetalleRemitoLTV.MultiSelect = false;
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(1085, 197);
            DetalleRemitoLTV.Sorting = SortOrder.Ascending;
            DetalleRemitoLTV.TabIndex = 13;
            DetalleRemitoLTV.UseCompatibleStateImageBehavior = false;
            DetalleRemitoLTV.View = View.Details;
            DetalleRemitoLTV.MouseClick += DetalleRemitoLTV_MouseClick;
            // 
            // OrdenConfirmadaColumna
            // 
            OrdenConfirmadaColumna.Text = "ID Orden de Preparacion";
            OrdenConfirmadaColumna.Width = 150;
            // 
            // IdClienteRColumna
            // 
            IdClienteRColumna.Text = "Id Cliente";
            IdClienteRColumna.Width = 80;
            // 
            // RazonColumna
            // 
            RazonColumna.Text = "Razon Social";
            RazonColumna.TextAlign = HorizontalAlignment.Center;
            RazonColumna.Width = 350;
            // 
            // FechaRemitoColumna
            // 
            FechaRemitoColumna.Text = "Fecha de emisión";
            FechaRemitoColumna.TextAlign = HorizontalAlignment.Center;
            FechaRemitoColumna.Width = 250;
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
            AgregarOrdenBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AgregarOrdenBTN.BackColor = SystemColors.Window;
            AgregarOrdenBTN.Location = new Point(5, 142);
            AgregarOrdenBTN.MaximumSize = new Size(1000, 40);
            AgregarOrdenBTN.Name = "AgregarOrdenBTN";
            AgregarOrdenBTN.Size = new Size(855, 40);
            AgregarOrdenBTN.TabIndex = 7;
            AgregarOrdenBTN.Text = "&Agregar Orden de Preparacion al remito";
            AgregarOrdenBTN.UseVisualStyleBackColor = false;
            AgregarOrdenBTN.Click += AgregarOrdenBtn_Click;
            // 
            // QuitarOrdenBTN
            // 
            QuitarOrdenBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            QuitarOrdenBTN.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenBTN.Location = new Point(658, 235);
            QuitarOrdenBTN.Name = "QuitarOrdenBTN";
            QuitarOrdenBTN.Size = new Size(433, 40);
            QuitarOrdenBTN.TabIndex = 15;
            QuitarOrdenBTN.Text = "&Quitar Orden de Preparacion del Remito";
            QuitarOrdenBTN.UseVisualStyleBackColor = false;
            QuitarOrdenBTN.Click += QuitarOrdenBtn_Click;
            // 
            // TransportistasListV
            // 
            TransportistasListV.Alignment = ListViewAlignment.Default;
            TransportistasListV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransportistasListV.AutoArrange = false;
            TransportistasListV.BackColor = SystemColors.Window;
            TransportistasListV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, idClienteColumna, RZColumna });
            TransportistasListV.FullRowSelect = true;
            TransportistasListV.Location = new Point(5, 22);
            TransportistasListV.MaximumSize = new Size(1000, 1000);
            TransportistasListV.MinimumSize = new Size(10, 10);
            TransportistasListV.Name = "TransportistasListV";
            TransportistasListV.Size = new Size(855, 114);
            TransportistasListV.Sorting = SortOrder.Ascending;
            TransportistasListV.TabIndex = 6;
            TransportistasListV.UseCompatibleStateImageBehavior = false;
            TransportistasListV.View = View.Details;
            TransportistasListV.MouseClick += TransportistasListV_MouseClick;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "Id Orden de Preparacion";
            IdOrdenColumna.Width = 150;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "ID Cliente";
            idClienteColumna.Width = 80;
            // 
            // RZColumna
            // 
            RZColumna.Text = "Razon social";
            RZColumna.TextAlign = HorizontalAlignment.Center;
            RZColumna.Width = 350;
            // 
            // BuscarTransportistaGRP
            // 
            BuscarTransportistaGRP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BuscarTransportistaGRP.Controls.Add(BorrarBtn);
            BuscarTransportistaGRP.Controls.Add(TransportistasCBX);
            BuscarTransportistaGRP.Controls.Add(NomApellTransportistaTXT);
            BuscarTransportistaGRP.Controls.Add(NombreTransportistaLBL);
            BuscarTransportistaGRP.Controls.Add(BuscarTransportistaBtn);
            BuscarTransportistaGRP.Controls.Add(DNITransportistaLBL);
            BuscarTransportistaGRP.Location = new Point(0, 0);
            BuscarTransportistaGRP.Name = "BuscarTransportistaGRP";
            BuscarTransportistaGRP.Size = new Size(1108, 119);
            BuscarTransportistaGRP.TabIndex = 1;
            BuscarTransportistaGRP.TabStop = false;
            BuscarTransportistaGRP.Text = "Seleccione filtros de búsqueda para Transportista: ";
            // 
            // BorrarBtn
            // 
            BorrarBtn.Anchor = AnchorStyles.Right;
            BorrarBtn.Location = new Point(879, 73);
            BorrarBtn.MaximumSize = new Size(229, 40);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(217, 40);
            BorrarBtn.TabIndex = 4;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // TransportistasCBX
            // 
            TransportistasCBX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransportistasCBX.FormattingEnabled = true;
            TransportistasCBX.Location = new Point(7, 44);
            TransportistasCBX.MaximumSize = new Size(1000, 0);
            TransportistasCBX.Name = "TransportistasCBX";
            TransportistasCBX.Size = new Size(853, 23);
            TransportistasCBX.TabIndex = 2;
            // 
            // NomApellTransportistaTXT
            // 
            NomApellTransportistaTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NomApellTransportistaTXT.BackColor = SystemColors.Window;
            NomApellTransportistaTXT.ForeColor = Color.Black;
            NomApellTransportistaTXT.Location = new Point(7, 91);
            NomApellTransportistaTXT.Margin = new Padding(2);
            NomApellTransportistaTXT.MaximumSize = new Size(1000, 23);
            NomApellTransportistaTXT.Name = "NomApellTransportistaTXT";
            NomApellTransportistaTXT.ReadOnly = true;
            NomApellTransportistaTXT.Size = new Size(853, 23);
            NomApellTransportistaTXT.TabIndex = 66;
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
            BuscarTransportistaBtn.Anchor = AnchorStyles.Right;
            BuscarTransportistaBtn.BackColor = SystemColors.Window;
            BuscarTransportistaBtn.Location = new Point(879, 27);
            BuscarTransportistaBtn.MaximumSize = new Size(229, 40);
            BuscarTransportistaBtn.Name = "BuscarTransportistaBtn";
            BuscarTransportistaBtn.Size = new Size(217, 40);
            BuscarTransportistaBtn.TabIndex = 3;
            BuscarTransportistaBtn.Text = "&Buscar Transportista";
            BuscarTransportistaBtn.UseVisualStyleBackColor = false;
            BuscarTransportistaBtn.Click += BuscarTransportistaBtn_Click;
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
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GenerarRemitoBTN.BackColor = Color.FromArgb(192, 255, 192);
            GenerarRemitoBTN.Location = new Point(6, 235);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(632, 40);
            GenerarRemitoBTN.TabIndex = 14;
            GenerarRemitoBTN.Text = "&Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = false;
            GenerarRemitoBTN.Click += GenerarRemitoBtn_Click;
            // 
            // OrdenesDelTransportistaGRP
            // 
            OrdenesDelTransportistaGRP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenesDelTransportistaGRP.BackColor = SystemColors.ButtonFace;
            OrdenesDelTransportistaGRP.Controls.Add(AgregarOrdenBTN);
            OrdenesDelTransportistaGRP.Controls.Add(TransportistasListV);
            OrdenesDelTransportistaGRP.Location = new Point(0, 127);
            OrdenesDelTransportistaGRP.Name = "OrdenesDelTransportistaGRP";
            OrdenesDelTransportistaGRP.Size = new Size(866, 188);
            OrdenesDelTransportistaGRP.TabIndex = 5;
            OrdenesDelTransportistaGRP.TabStop = false;
            OrdenesDelTransportistaGRP.Text = "Ordenes del Transportista";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 77);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 12;
            label2.Text = "Razon Social";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Id Cliente";
            // 
            // RZCBX
            // 
            RZCBX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RZCBX.BackColor = SystemColors.Window;
            RZCBX.FormattingEnabled = true;
            RZCBX.Location = new Point(7, 95);
            RZCBX.MaximumSize = new Size(1000, 0);
            RZCBX.Name = "RZCBX";
            RZCBX.Size = new Size(217, 23);
            RZCBX.TabIndex = 10;
            // 
            // IdCLienteCBX
            // 
            IdCLienteCBX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdCLienteCBX.BackColor = SystemColors.Window;
            IdCLienteCBX.FormattingEnabled = true;
            IdCLienteCBX.Location = new Point(6, 46);
            IdCLienteCBX.MaximumSize = new Size(1000, 0);
            IdCLienteCBX.Name = "IdCLienteCBX";
            IdCLienteCBX.Size = new Size(216, 23);
            IdCLienteCBX.TabIndex = 9;
            // 
            // DetalleRemitoGRP
            // 
            DetalleRemitoGRP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DetalleRemitoGRP.Controls.Add(DetalleRemitoLTV);
            DetalleRemitoGRP.Controls.Add(QuitarOrdenBTN);
            DetalleRemitoGRP.Controls.Add(label4);
            DetalleRemitoGRP.Controls.Add(GenerarRemitoBTN);
            DetalleRemitoGRP.Location = new Point(3, 321);
            DetalleRemitoGRP.MaximumSize = new Size(1500, 1000);
            DetalleRemitoGRP.Name = "DetalleRemitoGRP";
            DetalleRemitoGRP.Size = new Size(1105, 292);
            DetalleRemitoGRP.TabIndex = 12;
            DetalleRemitoGRP.TabStop = false;
            DetalleRemitoGRP.Text = "Detalle del remito";
            // 
            // SalirBTN
            // 
            SalirBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirBTN.BackColor = SystemColors.Window;
            SalirBTN.Location = new Point(878, 619);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(216, 40);
            SalirBTN.TabIndex = 16;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = false;
            SalirBTN.Click += SalirBtn_Click;
            // 
            // FiltrarOrdenesPorClienteGBX
            // 
            FiltrarOrdenesPorClienteGBX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FiltrarOrdenesPorClienteGBX.Controls.Add(BorrarFiltrosBTN);
            FiltrarOrdenesPorClienteGBX.Controls.Add(label2);
            FiltrarOrdenesPorClienteGBX.Controls.Add(label1);
            FiltrarOrdenesPorClienteGBX.Controls.Add(IdCLienteCBX);
            FiltrarOrdenesPorClienteGBX.Controls.Add(RZCBX);
            FiltrarOrdenesPorClienteGBX.Location = new Point(872, 127);
            FiltrarOrdenesPorClienteGBX.MaximumSize = new Size(600, 600);
            FiltrarOrdenesPorClienteGBX.Name = "FiltrarOrdenesPorClienteGBX";
            FiltrarOrdenesPorClienteGBX.Size = new Size(236, 188);
            FiltrarOrdenesPorClienteGBX.TabIndex = 8;
            FiltrarOrdenesPorClienteGBX.TabStop = false;
            FiltrarOrdenesPorClienteGBX.Text = "Filtrar ordenes por cliente";
            // 
            // BorrarFiltrosBTN
            // 
            BorrarFiltrosBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BorrarFiltrosBTN.BackColor = SystemColors.Window;
            BorrarFiltrosBTN.Location = new Point(7, 142);
            BorrarFiltrosBTN.Name = "BorrarFiltrosBTN";
            BorrarFiltrosBTN.Size = new Size(217, 40);
            BorrarFiltrosBTN.TabIndex = 11;
            BorrarFiltrosBTN.Text = "Borrar filtros";
            BorrarFiltrosBTN.UseVisualStyleBackColor = false;
            BorrarFiltrosBTN.Click += BorrarFiltrosBTN_Click;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1120, 663);
            Controls.Add(FiltrarOrdenesPorClienteGBX);
            Controls.Add(SalirBTN);
            Controls.Add(DetalleRemitoGRP);
            Controls.Add(OrdenesDelTransportistaGRP);
            Controls.Add(BuscarTransportistaGRP);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GenerarRemitoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar remito";
            Load += Generar_RemitoForms_Load;
            BuscarTransportistaGRP.ResumeLayout(false);
            BuscarTransportistaGRP.PerformLayout();
            OrdenesDelTransportistaGRP.ResumeLayout(false);
            DetalleRemitoGRP.ResumeLayout(false);
            DetalleRemitoGRP.PerformLayout();
            FiltrarOrdenesPorClienteGBX.ResumeLayout(false);
            FiltrarOrdenesPorClienteGBX.PerformLayout();
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
        private ColumnHeader idClienteColumna;
        private ColumnHeader RZColumna;
        private Label label2;
        private Label label1;
        private ComboBox RZCBX;
        private ComboBox IdCLienteCBX;
        private ColumnHeader IdClienteRColumna;
        private ColumnHeader RazonColumna;
        private GroupBox FiltrarOrdenesPorClienteGBX;
        private Button BorrarFiltrosBTN;
        private ComboBox TransportistasCBX;
        private Button BorrarBtn;
    }

}