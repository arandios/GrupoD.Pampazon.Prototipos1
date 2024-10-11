
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
            DetalleRemitoLTV = new ListView();
            OrdenConfirmadaColumna = new ColumnHeader();
            FechaRemitoColumna = new ColumnHeader();
            TransportistaConfirmadoColumna = new ColumnHeader();
            label4 = new Label();
            AgregarOrdenBtn = new Button();
            QuitarOrdenBtn = new Button();
            TransportistasListV = new ListView();
            IdOrdenColumna = new ColumnHeader();
            DNITColumna = new ColumnHeader();
            NombreTransportistaColumna = new ColumnHeader();
            ApellidoTransportistaColumna = new ColumnHeader();
            BuscarTransportistaGBX = new GroupBox();
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
            DetalleRemitoLTV.CheckBoxes = true;
            DetalleRemitoLTV.Columns.AddRange(new ColumnHeader[] { OrdenConfirmadaColumna, FechaRemitoColumna, TransportistaConfirmadoColumna });
            DetalleRemitoLTV.Location = new Point(5, 28);
            DetalleRemitoLTV.Margin = new Padding(3, 4, 3, 4);
            DetalleRemitoLTV.MultiSelect = false;
            DetalleRemitoLTV.Name = "DetalleRemitoLTV";
            DetalleRemitoLTV.Size = new Size(705, 309);
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
            AgregarOrdenBtn.Location = new Point(428, 248);
            AgregarOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarOrdenBtn.Name = "AgregarOrdenBtn";
            AgregarOrdenBtn.Size = new Size(286, 32);
            AgregarOrdenBtn.TabIndex = 16;
            AgregarOrdenBtn.Text = "&Agregar Orden de Preparacion al remito";
            AgregarOrdenBtn.UseVisualStyleBackColor = true;
            AgregarOrdenBtn.Click += AgregarOrdenBtn_Click;
            // 
            // QuitarOrdenBtn
            // 
            QuitarOrdenBtn.Location = new Point(348, 798);
            QuitarOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            QuitarOrdenBtn.Name = "QuitarOrdenBtn";
            QuitarOrdenBtn.Size = new Size(295, 27);
            QuitarOrdenBtn.TabIndex = 17;
            QuitarOrdenBtn.Text = "&Quitar Orden de Preparacion del Remito";
            QuitarOrdenBtn.UseVisualStyleBackColor = true;
            QuitarOrdenBtn.Click += QuitarOrdenBtn_Click;
            // 
            // TransportistasListV
            // 
            TransportistasListV.Alignment = ListViewAlignment.Default;
            TransportistasListV.AutoArrange = false;
            TransportistasListV.CheckBoxes = true;
            TransportistasListV.Columns.AddRange(new ColumnHeader[] { IdOrdenColumna, DNITColumna, NombreTransportistaColumna, ApellidoTransportistaColumna });
            TransportistasListV.FullRowSelect = true;
            TransportistasListV.Location = new Point(7, 21);
            TransportistasListV.Margin = new Padding(3, 4, 3, 4);
            TransportistasListV.Name = "TransportistasListV";
            TransportistasListV.Size = new Size(707, 219);
            TransportistasListV.TabIndex = 20;
            TransportistasListV.UseCompatibleStateImageBehavior = false;
            TransportistasListV.View = View.Details;
            TransportistasListV.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // IdOrdenColumna
            // 
            IdOrdenColumna.Text = "Id Orden de Preparacion";
            IdOrdenColumna.Width = 150;
            // 
            // DNITColumna
            // 
            DNITColumna.Text = "DNI";
            DNITColumna.TextAlign = HorizontalAlignment.Center;
            DNITColumna.Width = 100;
            // 
            // NombreTransportistaColumna
            // 
            NombreTransportistaColumna.Text = "Nombre";
            NombreTransportistaColumna.Width = 120;
            // 
            // ApellidoTransportistaColumna
            // 
            ApellidoTransportistaColumna.Text = "Apellido";
            ApellidoTransportistaColumna.Width = 120;
            // 
            // BuscarTransportistaGBX
            // 
            BuscarTransportistaGBX.Controls.Add(BuscarTransportistaBtn);
            BuscarTransportistaGBX.Controls.Add(label3);
            BuscarTransportistaGBX.Controls.Add(DNITtxt);
            BuscarTransportistaGBX.Location = new Point(19, 16);
            BuscarTransportistaGBX.Margin = new Padding(3, 4, 3, 4);
            BuscarTransportistaGBX.Name = "BuscarTransportistaGBX";
            BuscarTransportistaGBX.Padding = new Padding(3, 4, 3, 4);
            BuscarTransportistaGBX.Size = new Size(720, 136);
            BuscarTransportistaGBX.TabIndex = 21;
            BuscarTransportistaGBX.TabStop = false;
            BuscarTransportistaGBX.Text = "Seleccione filtros de búsqueda para Transportista: ";
            // 
            // BuscarTransportistaBtn
            // 
            BuscarTransportistaBtn.Location = new Point(564, 92);
            BuscarTransportistaBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarTransportistaBtn.Name = "BuscarTransportistaBtn";
            BuscarTransportistaBtn.Size = new Size(150, 36);
            BuscarTransportistaBtn.TabIndex = 8;
            BuscarTransportistaBtn.Text = "&Buscar Transportista";
            BuscarTransportistaBtn.UseVisualStyleBackColor = true;
            BuscarTransportistaBtn.Click += BuscarTransportistaBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 31);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 7;
            label3.Text = "DNI transportista";
            // 
            // DNITtxt
            // 
            DNITtxt.Location = new Point(2, 57);
            DNITtxt.Margin = new Padding(3, 4, 3, 4);
            DNITtxt.Name = "DNITtxt";
            DNITtxt.Size = new Size(712, 27);
            DNITtxt.TabIndex = 6;
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(168, 798);
            GenerarRemitoBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(174, 27);
            GenerarRemitoBtn.TabIndex = 23;
            GenerarRemitoBtn.Text = "&Generar Remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // OrdenesDelTransportistaGBX
            // 
            OrdenesDelTransportistaGBX.Controls.Add(AgregarOrdenBtn);
            OrdenesDelTransportistaGBX.Controls.Add(TransportistasListV);
            OrdenesDelTransportistaGBX.Location = new Point(19, 160);
            OrdenesDelTransportistaGBX.Margin = new Padding(3, 4, 3, 4);
            OrdenesDelTransportistaGBX.Name = "OrdenesDelTransportistaGBX";
            OrdenesDelTransportistaGBX.Padding = new Padding(3, 4, 3, 4);
            OrdenesDelTransportistaGBX.Size = new Size(720, 285);
            OrdenesDelTransportistaGBX.TabIndex = 25;
            OrdenesDelTransportistaGBX.TabStop = false;
            OrdenesDelTransportistaGBX.Text = "Ordenes del Transportista";
            // 
            // DetalleRemitoGBX
            // 
            DetalleRemitoGBX.Controls.Add(DetalleRemitoLTV);
            DetalleRemitoGBX.Controls.Add(label4);
            DetalleRemitoGBX.Location = new Point(21, 453);
            DetalleRemitoGBX.Margin = new Padding(3, 4, 3, 4);
            DetalleRemitoGBX.Name = "DetalleRemitoGBX";
            DetalleRemitoGBX.Padding = new Padding(3, 4, 3, 4);
            DetalleRemitoGBX.Size = new Size(718, 389);
            DetalleRemitoGBX.TabIndex = 26;
            DetalleRemitoGBX.TabStop = false;
            DetalleRemitoGBX.Text = "Detalle del remito";
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(649, 798);
            SalirBtn.Margin = new Padding(3, 4, 3, 4);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(82, 27);
            SalirBtn.TabIndex = 27;
            SalirBtn.Text = "&Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // Generar_RemitoForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 855);
            Controls.Add(SalirBtn);
            Controls.Add(QuitarOrdenBtn);
            Controls.Add(GenerarRemitoBtn);
            Controls.Add(DetalleRemitoGBX);
            Controls.Add(OrdenesDelTransportistaGBX);
            Controls.Add(BuscarTransportistaGBX);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Generar_RemitoForms";
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
        private ColumnHeader TransportistaConfirmadoColumna;
        private Label label4;
        private Button AgregarOrdenBtn;
        private Button QuitarOrdenBtn;
        private GroupBox BuscarTransportistaGBX;
        private Label label3;
        private TextBox DNITtxt;
        private ColumnHeader NombreTransportistaColumna;
        private ColumnHeader DNITColumna;
        private ColumnHeader ApellidoTransportistaColumna;
        private Button BuscarTransportistaBtn;
        private Label label5;
        private Button GenerarRemitoBtn;
        private ColumnHeader IdOrdenColumna;
        internal ListView TransportistasListV;
        private GroupBox OrdenesDelTransportistaGBX;
        private GroupBox DetalleRemitoGBX;
        private Button SalirBtn;
    }
}
