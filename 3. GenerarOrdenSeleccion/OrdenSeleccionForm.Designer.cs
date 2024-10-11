namespace Pampazon.OrdenSeleccion
{
    partial class OrdenSeleccionForm
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
            QuitarOrdenPreparacionASeleccionBTN = new Button();
            AgregarOrdenSeleccionADetalleBTN = new Button();
            BuscarOrdenSeleccionBTN = new Button();
            BorrarFiltrosOrdenSeleccionBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ClienteTextBoxOrdenSeleccion = new TextBox();
            NumeroOrdenPreparacionTextBoxOrdenSeleccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CrearOrdenSeleccionBTN = new Button();
            CancelarOrdenSeleccionBTN = new Button();
            FiltrosOPgroupBox = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            PrioridadComboBoxOrdenSeleccion = new ComboBox();
            OPgroupBox = new GroupBox();
            DetalleOrdenesDePrepracionAOrdenSeleccionListView = new ListView();
            IDOrdenPreparacionColumna = new ColumnHeader();
            DescripcionClienteColumna = new ColumnHeader();
            FechaOrdenPreparacionColumna = new ColumnHeader();
            EstadoOrdenPreparacionColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            TransportistaDetalleColumna = new ColumnHeader();
            OSgroupBox = new GroupBox();
            OrdenesDePreparacionPendientesListView = new ListView();
            OPaOS_IdOPColumna = new ColumnHeader();
            OPaOS_RazonSocialClienteColumna = new ColumnHeader();
            OPaOS_FechaORColumna = new ColumnHeader();
            OPaOS_EstadoOPColumna = new ColumnHeader();
            OPaOS_PrioridadColumna = new ColumnHeader();
            OPaOS_TransportistaColumna = new ColumnHeader();
            textBox1 = new TextBox();
            label8 = new Label();
            FiltrosOPgroupBox.SuspendLayout();
            OPgroupBox.SuspendLayout();
            OSgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // QuitarOrdenPreparacionASeleccionBTN
            // 
            QuitarOrdenPreparacionASeleccionBTN.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenPreparacionASeleccionBTN.Location = new Point(548, 737);
            QuitarOrdenPreparacionASeleccionBTN.Name = "QuitarOrdenPreparacionASeleccionBTN";
            QuitarOrdenPreparacionASeleccionBTN.Size = new Size(233, 41);
            QuitarOrdenPreparacionASeleccionBTN.TabIndex = 0;
            QuitarOrdenPreparacionASeleccionBTN.Text = "&Quitar Orden de Preparación";
            QuitarOrdenPreparacionASeleccionBTN.UseVisualStyleBackColor = false;
            QuitarOrdenPreparacionASeleccionBTN.Click += QuitarOrdenPreparacionASeleccionBTN_Click;
            // 
            // AgregarOrdenSeleccionADetalleBTN
            // 
            AgregarOrdenSeleccionADetalleBTN.Location = new Point(537, 221);
            AgregarOrdenSeleccionADetalleBTN.Name = "AgregarOrdenSeleccionADetalleBTN";
            AgregarOrdenSeleccionADetalleBTN.Size = new Size(225, 54);
            AgregarOrdenSeleccionADetalleBTN.TabIndex = 1;
            AgregarOrdenSeleccionADetalleBTN.Text = "&Agregar al detalle de seleccion";
            AgregarOrdenSeleccionADetalleBTN.UseVisualStyleBackColor = true;
            AgregarOrdenSeleccionADetalleBTN.Click += AgregarAOrdenSeleccionBTN_Click_1;
            // 
            // BuscarOrdenSeleccionBTN
            // 
            BuscarOrdenSeleccionBTN.Location = new Point(425, 128);
            BuscarOrdenSeleccionBTN.Name = "BuscarOrdenSeleccionBTN";
            BuscarOrdenSeleccionBTN.Size = new Size(238, 39);
            BuscarOrdenSeleccionBTN.TabIndex = 3;
            BuscarOrdenSeleccionBTN.Text = "&Buscar Ordenes de Preparación";
            BuscarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            BuscarOrdenSeleccionBTN.Click += BuscarOrdenSeleccionBTN_Click;
            // 
            // BorrarFiltrosOrdenSeleccionBTN
            // 
            BorrarFiltrosOrdenSeleccionBTN.Location = new Point(669, 128);
            BorrarFiltrosOrdenSeleccionBTN.Name = "BorrarFiltrosOrdenSeleccionBTN";
            BorrarFiltrosOrdenSeleccionBTN.Size = new Size(110, 39);
            BorrarFiltrosOrdenSeleccionBTN.TabIndex = 2;
            BorrarFiltrosOrdenSeleccionBTN.Text = "&Borrar filtros";
            BorrarFiltrosOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            BorrarFiltrosOrdenSeleccionBTN.Click += BorrarFiltrosOrdenSeleccionBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 60);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 60);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 8;
            label4.Text = "Razón social Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 60);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 9;
            label5.Text = "Número de Orden Preparación";
            // 
            // ClienteTextBoxOrdenSeleccion
            // 
            ClienteTextBoxOrdenSeleccion.Location = new Point(15, 83);
            ClienteTextBoxOrdenSeleccion.Name = "ClienteTextBoxOrdenSeleccion";
            ClienteTextBoxOrdenSeleccion.Size = new Size(223, 27);
            ClienteTextBoxOrdenSeleccion.TabIndex = 10;
            // 
            // NumeroOrdenPreparacionTextBoxOrdenSeleccion
            // 
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Location = new Point(424, 83);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Name = "NumeroOrdenPreparacionTextBoxOrdenSeleccion";
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Size = new Size(217, 27);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 169);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 443);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            // 
            // CrearOrdenSeleccionBTN
            // 
            CrearOrdenSeleccionBTN.BackColor = Color.FromArgb(192, 255, 192);
            CrearOrdenSeleccionBTN.Location = new Point(317, 737);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(225, 41);
            CrearOrdenSeleccionBTN.TabIndex = 17;
            CrearOrdenSeleccionBTN.Text = "&Generar Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            CrearOrdenSeleccionBTN.Click += CrearOrdenSeleccionBTN_Click_1;
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(679, 781);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(94, 29);
            CancelarOrdenSeleccionBTN.TabIndex = 18;
            CancelarOrdenSeleccionBTN.Text = "&Salir";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CancelarOrdenSeleccionBTN.Click += CancelarOrdenSeleccionBTN_Click;
            // 
            // FiltrosOPgroupBox
            // 
            FiltrosOPgroupBox.Controls.Add(textBox1);
            FiltrosOPgroupBox.Controls.Add(label8);
            FiltrosOPgroupBox.Controls.Add(dateTimePicker1);
            FiltrosOPgroupBox.Controls.Add(PrioridadComboBoxOrdenSeleccion);
            FiltrosOPgroupBox.Location = new Point(11, 20);
            FiltrosOPgroupBox.Name = "FiltrosOPgroupBox";
            FiltrosOPgroupBox.Size = new Size(768, 147);
            FiltrosOPgroupBox.TabIndex = 19;
            FiltrosOPgroupBox.TabStop = false;
            FiltrosOPgroupBox.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(233, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // PrioridadComboBoxOrdenSeleccion
            // 
            PrioridadComboBoxOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBoxOrdenSeleccion.FormattingEnabled = true;
            PrioridadComboBoxOrdenSeleccion.Location = new Point(635, 63);
            PrioridadComboBoxOrdenSeleccion.Name = "PrioridadComboBoxOrdenSeleccion";
            PrioridadComboBoxOrdenSeleccion.Size = new Size(127, 28);
            PrioridadComboBoxOrdenSeleccion.TabIndex = 0;
            // 
            // OPgroupBox
            // 
            OPgroupBox.Controls.Add(DetalleOrdenesDePrepracionAOrdenSeleccionListView);
            OPgroupBox.Controls.Add(AgregarOrdenSeleccionADetalleBTN);
            OPgroupBox.Location = new Point(11, 172);
            OPgroupBox.Name = "OPgroupBox";
            OPgroupBox.Size = new Size(768, 291);
            OPgroupBox.TabIndex = 20;
            OPgroupBox.TabStop = false;
            OPgroupBox.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // DetalleOrdenesDePrepracionAOrdenSeleccionListView
            // 
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Columns.AddRange(new ColumnHeader[] { IDOrdenPreparacionColumna, DescripcionClienteColumna, FechaOrdenPreparacionColumna, EstadoOrdenPreparacionColumna, PrioridadColumna, TransportistaDetalleColumna });
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Location = new Point(6, 27);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Name = "DetalleOrdenesDePrepracionAOrdenSeleccionListView";
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Size = new Size(756, 191);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.TabIndex = 2;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.View = View.Details;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedIndexChanged += DetalleOrdenesDePrepracionAOrdenSeleccionListView_SelectedIndexChanged;
            // 
            // IDOrdenPreparacionColumna
            // 
            IDOrdenPreparacionColumna.Text = "IDOrdenPreparacion";
            IDOrdenPreparacionColumna.Width = 31;
            // 
            // DescripcionClienteColumna
            // 
            DescripcionClienteColumna.Text = "DescripcionCliente";
            DescripcionClienteColumna.Width = 31;
            // 
            // FechaOrdenPreparacionColumna
            // 
            FechaOrdenPreparacionColumna.Text = "FechaOrdenPreparacion";
            FechaOrdenPreparacionColumna.Width = 31;
            // 
            // EstadoOrdenPreparacionColumna
            // 
            EstadoOrdenPreparacionColumna.Text = "EstadoOrdenPreparacion";
            EstadoOrdenPreparacionColumna.Width = 31;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 31;
            // 
            // TransportistaDetalleColumna
            // 
            TransportistaDetalleColumna.Text = "TransportistaDetalle";
            TransportistaDetalleColumna.Width = 31;
            // 
            // OSgroupBox
            // 
            OSgroupBox.Controls.Add(OrdenesDePreparacionPendientesListView);
            OSgroupBox.Enabled = false;
            OSgroupBox.Location = new Point(5, 478);
            OSgroupBox.Name = "OSgroupBox";
            OSgroupBox.Size = new Size(768, 253);
            OSgroupBox.TabIndex = 21;
            OSgroupBox.TabStop = false;
            OSgroupBox.Text = "Detalle de Ordenes de Preparación a insertar: ";
            // 
            // OrdenesDePreparacionPendientesListView
            // 
            OrdenesDePreparacionPendientesListView.Columns.AddRange(new ColumnHeader[] { OPaOS_IdOPColumna, OPaOS_RazonSocialClienteColumna, OPaOS_FechaORColumna, OPaOS_EstadoOPColumna, OPaOS_PrioridadColumna, OPaOS_TransportistaColumna });
            OrdenesDePreparacionPendientesListView.Location = new Point(10, 27);
            OrdenesDePreparacionPendientesListView.Name = "OrdenesDePreparacionPendientesListView";
            OrdenesDePreparacionPendientesListView.Size = new Size(752, 181);
            OrdenesDePreparacionPendientesListView.TabIndex = 4;
            OrdenesDePreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacionPendientesListView.View = View.Details;
            // 
            // OPaOS_IdOPColumna
            // 
            OPaOS_IdOPColumna.Text = "IDOrdenPreparacion";
            OPaOS_IdOPColumna.Width = 31;
            // 
            // OPaOS_RazonSocialClienteColumna
            // 
            OPaOS_RazonSocialClienteColumna.Text = "DescripcionCliente";
            OPaOS_RazonSocialClienteColumna.Width = 31;
            // 
            // OPaOS_FechaORColumna
            // 
            OPaOS_FechaORColumna.Text = "FechaOrdenRecepcion";
            OPaOS_FechaORColumna.Width = 31;
            // 
            // OPaOS_EstadoOPColumna
            // 
            OPaOS_EstadoOPColumna.Text = "EstadoOrdenPreparacion";
            OPaOS_EstadoOPColumna.Width = 31;
            // 
            // OPaOS_PrioridadColumna
            // 
            OPaOS_PrioridadColumna.Text = "Prioridad";
            OPaOS_PrioridadColumna.Width = 31;
            // 
            // OPaOS_TransportistaColumna
            // 
            OPaOS_TransportistaColumna.Text = "TransportistaDetalle";
            OPaOS_TransportistaColumna.Width = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 96);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 22;
            label8.Text = "Transportista";
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 822);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(CrearOrdenSeleccionBTN);
            Controls.Add(label7);
            Controls.Add(QuitarOrdenPreparacionASeleccionBTN);
            Controls.Add(label6);
            Controls.Add(NumeroOrdenPreparacionTextBoxOrdenSeleccion);
            Controls.Add(ClienteTextBoxOrdenSeleccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BuscarOrdenSeleccionBTN);
            Controls.Add(BorrarFiltrosOrdenSeleccionBTN);
            Controls.Add(FiltrosOPgroupBox);
            Controls.Add(OPgroupBox);
            Controls.Add(OSgroupBox);
            Name = "OrdenSeleccionForm";
            Text = "Generar Orden Seleccion";
            Load += OrdenSeleccionForm_Load_1;
            FiltrosOPgroupBox.ResumeLayout(false);
            FiltrosOPgroupBox.PerformLayout();
            OPgroupBox.ResumeLayout(false);
            OSgroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button QuitarOrdenPreparacionASeleccionBTN;
        private Button AgregarOrdenSeleccionADetalleBTN;
        private Button BuscarOrdenSeleccionBTN;
        private Button BorrarFiltrosOrdenSeleccionBTN;
        private ListBox OrdenesDePreparacionPendientesList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ClienteTextBoxOrdenSeleccion;
        private TextBox NumeroOrdenPreparacionTextBoxOrdenSeleccion;
        private Label label6;
        //private ListBox DetalleOrdenesDePrepracionAOrdenSeleccionListView;
        private Label label7;
        private Button CrearOrdenSeleccionBTN;
        private Button CancelarOrdenSeleccionBTN;
        private GroupBox FiltrosOPgroupBox;
        private GroupBox OPgroupBox;
        private GroupBox OSgroupBox;
        private ComboBox PrioridadComboBoxOrdenSeleccion;
        private ListView DetalleOrdenesDePrepracionAOrdenSeleccionListView;
        private ColumnHeader IDOrdenPreparacionColumna;
        private ColumnHeader DescripcionClienteColumna;
        private ColumnHeader FechaOrdenPreparacionColumna;
        private ColumnHeader EstadoOrdenPreparacionColumna;
        private ColumnHeader PrioridadColumna;
        private ColumnHeader TransportistaDetalleColumna;
        private ListView OrdenesDePreparacionPendientesListView;
        private ColumnHeader OPaOS_IdOPColumna;
        private ColumnHeader OPaOS_RazonSocialClienteColumna;
        private ColumnHeader OPaOS_FechaORColumna;
        private ColumnHeader OPaOS_EstadoOPColumna;
        private ColumnHeader OPaOS_PrioridadColumna;
        private ColumnHeader OPaOS_TransportistaColumna;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label8;
    }
}