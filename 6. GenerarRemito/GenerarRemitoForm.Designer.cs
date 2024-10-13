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
            AgregarOrdenBtn = new Button();
            QuitarOrdenBtn = new Button();
            TransportistasListV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            BuscarTransportistaGBX = new GroupBox();
            NomApellTransportistaTxt = new TextBox();
            label15 = new Label();
            BuscarTransportistaBtn = new Button();
            label3 = new Label();
            DNITtxt = new TextBox();
            GenerarRemitoBtn = new Button();
            OrdenesDelTransportistaGBX = new GroupBox();
            DetalleRemitoGBX = new GroupBox();
            SalirBtn = new Button();
            BuscarTransportistaGBX.SuspendLayout();
            OrdenesDelTransportistaGBX.SuspendLayout();
            DetalleRemitoGBX.SuspendLayout();
            SuspendLayout();
            // 
            // DetalleRemitoLTV
            // 
            DetalleRemitoLTV.BorderStyle = BorderStyle.FixedSingle;
            DetalleRemitoLTV.CheckBoxes = true;
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, FechaRemitoColumna });
            DetalleRemitoLTV.Location = new Point(26, 43);
            DetalleRemitoLTV.Margin = new Padding(3, 4, 3, 4);
            DetalleRemitoLTV.MultiSelect = false;
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(889, 247);
            DetalleRemitoLTV.TabIndex = 12;
            DetalleRemitoLTV.UseCompatibleStateImageBehavior = false;
            DetalleRemitoLTV.View = View.Details;
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
            label4.Location = new Point(130, -24);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 14;
            label4.Text = "Detalle remito";
            // 
            // AgregarOrdenBtn
            // 
            AgregarOrdenBtn.Location = new Point(457, 254);
            AgregarOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarOrdenBtn.Name = "AgregarOrdenBtn";
            AgregarOrdenBtn.Size = new Size(458, 53);
            AgregarOrdenBtn.TabIndex = 16;
            AgregarOrdenBtn.Text = "&Agregar Orden de Preparacion al remito";
            AgregarOrdenBtn.UseVisualStyleBackColor = true;
            AgregarOrdenBtn.Click += AgregarOrdenBtn_Click;
            // 
            // QuitarOrdenBtn
            // 
            QuitarOrdenBtn.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenBtn.Location = new Point(622, 298);
            QuitarOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            QuitarOrdenBtn.Name = "QuitarOrdenBtn";
            QuitarOrdenBtn.Size = new Size(293, 59);
            QuitarOrdenBtn.TabIndex = 17;
            QuitarOrdenBtn.Text = "&Quitar Orden de Preparacion del Remito";
            QuitarOrdenBtn.UseVisualStyleBackColor = false;
            QuitarOrdenBtn.Click += QuitarOrdenBtn_Click;
            // 
            // TransportistasListV
            // 
            TransportistasListV.Alignment = ListViewAlignment.Default;
            TransportistasListV.AutoArrange = false;
            TransportistasListV.CheckBoxes = true;
            TransportistasListV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna });
            TransportistasListV.FullRowSelect = true;
            TransportistasListV.Location = new Point(26, 29);
            TransportistasListV.Margin = new Padding(3, 4, 3, 4);
            TransportistasListV.Name = "TransportistasListV";
            TransportistasListV.Size = new Size(889, 215);
            TransportistasListV.TabIndex = 20;
            TransportistasListV.UseCompatibleStateImageBehavior = false;
            TransportistasListV.View = View.Details;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "Id Orden de Preparacion";
            IdOrdenColumna.Width = 900;
            // 
            // BuscarTransportistaGBX
            // 
            BuscarTransportistaGBX.Controls.Add(NomApellTransportistaTxt);
            BuscarTransportistaGBX.Controls.Add(label15);
            BuscarTransportistaGBX.Controls.Add(BuscarTransportistaBtn);
            BuscarTransportistaGBX.Controls.Add(label3);
            BuscarTransportistaGBX.Controls.Add(DNITtxt);
            BuscarTransportistaGBX.Location = new Point(27, 16);
            BuscarTransportistaGBX.Margin = new Padding(3, 4, 3, 4);
            BuscarTransportistaGBX.Name = "BuscarTransportistaGBX";
            BuscarTransportistaGBX.Padding = new Padding(3, 4, 3, 4);
            BuscarTransportistaGBX.Size = new Size(932, 159);
            BuscarTransportistaGBX.TabIndex = 21;
            BuscarTransportistaGBX.TabStop = false;
            BuscarTransportistaGBX.Text = "Seleccione filtros de búsqueda para Transportista: ";
            // 
            // NomApellTransportistaTxt
            // 
            NomApellTransportistaTxt.Location = new Point(5, 121);
            NomApellTransportistaTxt.Margin = new Padding(2, 3, 2, 3);
            NomApellTransportistaTxt.Name = "NomApellTransportistaTxt";
            NomApellTransportistaTxt.ReadOnly = true;
            NomApellTransportistaTxt.Size = new Size(742, 27);
            NomApellTransportistaTxt.TabIndex = 66;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 99);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 67;
            label15.Text = "Nombre Transportista";
            // 
            // BuscarTransportistaBtn
            // 
            BuscarTransportistaBtn.Location = new Point(753, 35);
            BuscarTransportistaBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarTransportistaBtn.Name = "BuscarTransportistaBtn";
            BuscarTransportistaBtn.Size = new Size(149, 53);
            BuscarTransportistaBtn.TabIndex = 8;
            BuscarTransportistaBtn.Text = "&Buscar Transportista";
            BuscarTransportistaBtn.UseVisualStyleBackColor = true;
            BuscarTransportistaBtn.Click += BuscarTransportistaBtn_Click;
            BuscarTransportistaBtn.Enter += BuscarTransportistaBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 35);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 7;
            label3.Text = "DNI transportista";
            // 
            // DNITtxt
            // 
            DNITtxt.Location = new Point(8, 60);
            DNITtxt.Margin = new Padding(3, 4, 3, 4);
            DNITtxt.Name = "DNITtxt";
            DNITtxt.Size = new Size(739, 27);
            DNITtxt.TabIndex = 6;
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.BackColor = Color.FromArgb(192, 255, 192);
            GenerarRemitoBtn.Location = new Point(297, 298);
            GenerarRemitoBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(319, 59);
            GenerarRemitoBtn.TabIndex = 23;
            GenerarRemitoBtn.Text = "&Generar Remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = false;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // OrdenesDelTransportistaGBX
            // 
            OrdenesDelTransportistaGBX.Controls.Add(AgregarOrdenBtn);
            OrdenesDelTransportistaGBX.Controls.Add(TransportistasListV);
            OrdenesDelTransportistaGBX.Location = new Point(27, 183);
            OrdenesDelTransportistaGBX.Margin = new Padding(3, 4, 3, 4);
            OrdenesDelTransportistaGBX.Name = "OrdenesDelTransportistaGBX";
            OrdenesDelTransportistaGBX.Padding = new Padding(3, 4, 3, 4);
            OrdenesDelTransportistaGBX.Size = new Size(932, 315);
            OrdenesDelTransportistaGBX.TabIndex = 25;
            OrdenesDelTransportistaGBX.TabStop = false;
            OrdenesDelTransportistaGBX.Text = "Ordenes del Transportista";
            // 
            // DetalleRemitoGBX
            // 
            DetalleRemitoGBX.Controls.Add(DetalleRemitoLTV);
            DetalleRemitoGBX.Controls.Add(QuitarOrdenBtn);
            DetalleRemitoGBX.Controls.Add(label4);
            DetalleRemitoGBX.Controls.Add(GenerarRemitoBtn);
            DetalleRemitoGBX.Location = new Point(27, 511);
            DetalleRemitoGBX.Margin = new Padding(3, 4, 3, 4);
            DetalleRemitoGBX.Name = "DetalleRemitoGBX";
            DetalleRemitoGBX.Padding = new Padding(3, 4, 3, 4);
            DetalleRemitoGBX.Size = new Size(932, 375);
            DetalleRemitoGBX.TabIndex = 26;
            DetalleRemitoGBX.TabStop = false;
            DetalleRemitoGBX.Text = "Detalle del remito";
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(728, 894);
            SalirBtn.Margin = new Padding(3, 4, 3, 4);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(214, 53);
            SalirBtn.TabIndex = 27;
            SalirBtn.Text = "&Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(SalirBtn);
            Controls.Add(DetalleRemitoGBX);
            Controls.Add(OrdenesDelTransportistaGBX);
            Controls.Add(BuscarTransportistaGBX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarRemitoForm";
            Text = "Generar remito";
            Load += Generar_RemitoForms_Load;
            BuscarTransportistaGBX.ResumeLayout(false);
            BuscarTransportistaGBX.PerformLayout();
            OrdenesDelTransportistaGBX.ResumeLayout(false);
            DetalleRemitoGBX.ResumeLayout(false);
            DetalleRemitoGBX.PerformLayout();
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
        private Button AgregarOrdenBtn;
        private Button QuitarOrdenBtn;
        private GroupBox BuscarTransportistaGBX;
        private Label label3;
        private TextBox DNITtxt;
        private Button BuscarTransportistaBtn;
        private Label label5;
        private Button GenerarRemitoBtn;
        private ColumnHeader IdOrdenColumna;
        internal ListView TransportistasListV;
        private GroupBox OrdenesDelTransportistaGBX;
        private GroupBox DetalleRemitoGBX;
        private Button SalirBtn;
        protected TextBox NomApellTransportistaTxt;
        private Label label15;

    }

}