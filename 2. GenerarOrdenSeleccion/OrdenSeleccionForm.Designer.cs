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
            textBox1 = new TextBox();
            label8 = new Label();
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
            FiltrosOPgroupBox.SuspendLayout();
            OPgroupBox.SuspendLayout();
            OSgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // QuitarOrdenPreparacionASeleccionBTN
            // 
            QuitarOrdenPreparacionASeleccionBTN.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenPreparacionASeleccionBTN.Location = new Point(462, 161);
            QuitarOrdenPreparacionASeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            QuitarOrdenPreparacionASeleccionBTN.Name = "QuitarOrdenPreparacionASeleccionBTN";
            QuitarOrdenPreparacionASeleccionBTN.Size = new Size(204, 40);
            QuitarOrdenPreparacionASeleccionBTN.TabIndex = 0;
            QuitarOrdenPreparacionASeleccionBTN.Text = "&Quitar Orden de Preparación";
            QuitarOrdenPreparacionASeleccionBTN.UseVisualStyleBackColor = false;
            QuitarOrdenPreparacionASeleccionBTN.Click += QuitarOrdenPreparacionASeleccionBTN_Click;
            // 
            // AgregarOrdenSeleccionADetalleBTN
            // 
            AgregarOrdenSeleccionADetalleBTN.Location = new Point(470, 166);
            AgregarOrdenSeleccionADetalleBTN.Margin = new Padding(3, 2, 3, 2);
            AgregarOrdenSeleccionADetalleBTN.Name = "AgregarOrdenSeleccionADetalleBTN";
            AgregarOrdenSeleccionADetalleBTN.Size = new Size(197, 40);
            AgregarOrdenSeleccionADetalleBTN.TabIndex = 1;
            AgregarOrdenSeleccionADetalleBTN.Text = "&Agregar al detalle de seleccion";
            AgregarOrdenSeleccionADetalleBTN.UseVisualStyleBackColor = true;
            AgregarOrdenSeleccionADetalleBTN.Click += AgregarAOrdenSeleccionBTN_Click_1;
            // 
            // BuscarOrdenSeleccionBTN
            // 
            BuscarOrdenSeleccionBTN.Location = new Point(300, 83);
            BuscarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            BuscarOrdenSeleccionBTN.Name = "BuscarOrdenSeleccionBTN";
            BuscarOrdenSeleccionBTN.Size = new Size(215, 40);
            BuscarOrdenSeleccionBTN.TabIndex = 3;
            BuscarOrdenSeleccionBTN.Text = "&Buscar Ordenes de Preparación";
            BuscarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            BuscarOrdenSeleccionBTN.Click += BuscarOrdenSeleccionBTN_Click;
            // 
            // BorrarFiltrosOrdenSeleccionBTN
            // 
            BorrarFiltrosOrdenSeleccionBTN.Location = new Point(521, 83);
            BorrarFiltrosOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            BorrarFiltrosOrdenSeleccionBTN.Name = "BorrarFiltrosOrdenSeleccionBTN";
            BorrarFiltrosOrdenSeleccionBTN.Size = new Size(146, 40);
            BorrarFiltrosOrdenSeleccionBTN.TabIndex = 2;
            BorrarFiltrosOrdenSeleccionBTN.Text = "&Borrar filtros";
            BorrarFiltrosOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            BorrarFiltrosOrdenSeleccionBTN.Click += BorrarFiltrosOrdenSeleccionBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 45);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 30);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 45);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 8;
            label4.Text = "Razón social Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 30);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 9;
            label5.Text = "Número de Orden Preparación";
            // 
            // ClienteTextBoxOrdenSeleccion
            // 
            ClienteTextBoxOrdenSeleccion.Location = new Point(13, 62);
            ClienteTextBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            ClienteTextBoxOrdenSeleccion.Name = "ClienteTextBoxOrdenSeleccion";
            ClienteTextBoxOrdenSeleccion.Size = new Size(196, 23);
            ClienteTextBoxOrdenSeleccion.TabIndex = 10;
            // 
            // NumeroOrdenPreparacionTextBoxOrdenSeleccion
            // 
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Location = new Point(360, 48);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Name = "NumeroOrdenPreparacionTextBoxOrdenSeleccion";
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Size = new Size(173, 23);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 127);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 332);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 16;
            // 
            // CrearOrdenSeleccionBTN
            // 
            CrearOrdenSeleccionBTN.BackColor = Color.FromArgb(192, 255, 192);
            CrearOrdenSeleccionBTN.Location = new Point(190, 161);
            CrearOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(266, 40);
            CrearOrdenSeleccionBTN.TabIndex = 17;
            CrearOrdenSeleccionBTN.Text = "&Generar Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            CrearOrdenSeleccionBTN.Click += CrearOrdenSeleccionBTN_Click_1;
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(544, 591);
            CancelarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(132, 40);
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
            FiltrosOPgroupBox.Controls.Add(NumeroOrdenPreparacionTextBoxOrdenSeleccion);
            FiltrosOPgroupBox.Controls.Add(label5);
            FiltrosOPgroupBox.Controls.Add(label3);
            FiltrosOPgroupBox.Controls.Add(PrioridadComboBoxOrdenSeleccion);
            FiltrosOPgroupBox.Controls.Add(BuscarOrdenSeleccionBTN);
            FiltrosOPgroupBox.Controls.Add(BorrarFiltrosOrdenSeleccionBTN);
            FiltrosOPgroupBox.Location = new Point(10, 15);
            FiltrosOPgroupBox.Margin = new Padding(3, 2, 3, 2);
            FiltrosOPgroupBox.Name = "FiltrosOPgroupBox";
            FiltrosOPgroupBox.Padding = new Padding(3, 2, 3, 2);
            FiltrosOPgroupBox.Size = new Size(678, 127);
            FiltrosOPgroupBox.TabIndex = 19;
            FiltrosOPgroupBox.TabStop = false;
            FiltrosOPgroupBox.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 89);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 72);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 22;
            label8.Text = "Transportista";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(204, 48);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // PrioridadComboBoxOrdenSeleccion
            // 
            PrioridadComboBoxOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBoxOrdenSeleccion.FormattingEnabled = true;
            PrioridadComboBoxOrdenSeleccion.Location = new Point(544, 48);
            PrioridadComboBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            PrioridadComboBoxOrdenSeleccion.Name = "PrioridadComboBoxOrdenSeleccion";
            PrioridadComboBoxOrdenSeleccion.Size = new Size(122, 23);
            PrioridadComboBoxOrdenSeleccion.TabIndex = 0;
            // 
            // OPgroupBox
            // 
            OPgroupBox.Controls.Add(DetalleOrdenesDePrepracionAOrdenSeleccionListView);
            OPgroupBox.Controls.Add(AgregarOrdenSeleccionADetalleBTN);
            OPgroupBox.Location = new Point(10, 150);
            OPgroupBox.Margin = new Padding(3, 2, 3, 2);
            OPgroupBox.Name = "OPgroupBox";
            OPgroupBox.Padding = new Padding(3, 2, 3, 2);
            OPgroupBox.Size = new Size(678, 218);
            OPgroupBox.TabIndex = 20;
            OPgroupBox.TabStop = false;
            OPgroupBox.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // DetalleOrdenesDePrepracionAOrdenSeleccionListView
            // 
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Columns.AddRange(new ColumnHeader[] { IDOrdenPreparacionColumna, DescripcionClienteColumna, FechaOrdenPreparacionColumna, EstadoOrdenPreparacionColumna, PrioridadColumna, TransportistaDetalleColumna });
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Location = new Point(5, 20);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Margin = new Padding(3, 2, 3, 2);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Name = "DetalleOrdenesDePrepracionAOrdenSeleccionListView";
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Size = new Size(662, 144);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.TabIndex = 2;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.View = View.Details;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedIndexChanged += DetalleOrdenesDePrepracionAOrdenSeleccionListView_SelectedIndexChanged;
            // 
            // IDOrdenPreparacionColumna
            // 
            IDOrdenPreparacionColumna.Text = "ID Orden";
            IDOrdenPreparacionColumna.Width = 100;
            // 
            // DescripcionClienteColumna
            // 
            DescripcionClienteColumna.Text = "Cliente";
            DescripcionClienteColumna.Width = 100;
            // 
            // FechaOrdenPreparacionColumna
            // 
            FechaOrdenPreparacionColumna.Text = "Fecha ";
            FechaOrdenPreparacionColumna.Width = 100;
            // 
            // EstadoOrdenPreparacionColumna
            // 
            EstadoOrdenPreparacionColumna.Text = "Estado ";
            EstadoOrdenPreparacionColumna.Width = 100;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 100;
            // 
            // TransportistaDetalleColumna
            // 
            TransportistaDetalleColumna.Text = "Transportista";
            TransportistaDetalleColumna.Width = 100;
            // 
            // OSgroupBox
            // 
            OSgroupBox.Controls.Add(OrdenesDePreparacionPendientesListView);
            OSgroupBox.Controls.Add(CrearOrdenSeleccionBTN);
            OSgroupBox.Controls.Add(QuitarOrdenPreparacionASeleccionBTN);
            OSgroupBox.Enabled = false;
            OSgroupBox.Location = new Point(10, 372);
            OSgroupBox.Margin = new Padding(3, 2, 3, 2);
            OSgroupBox.Name = "OSgroupBox";
            OSgroupBox.Padding = new Padding(3, 2, 3, 2);
            OSgroupBox.Size = new Size(678, 215);
            OSgroupBox.TabIndex = 21;
            OSgroupBox.TabStop = false;
            OSgroupBox.Text = "Detalle de Ordenes de Preparación a insertar: ";
            // 
            // OrdenesDePreparacionPendientesListView
            // 
            OrdenesDePreparacionPendientesListView.Columns.AddRange(new ColumnHeader[] { OPaOS_IdOPColumna, OPaOS_RazonSocialClienteColumna, OPaOS_FechaORColumna, OPaOS_EstadoOPColumna, OPaOS_PrioridadColumna, OPaOS_TransportistaColumna });
            OrdenesDePreparacionPendientesListView.Location = new Point(9, 20);
            OrdenesDePreparacionPendientesListView.Margin = new Padding(3, 2, 3, 2);
            OrdenesDePreparacionPendientesListView.Name = "OrdenesDePreparacionPendientesListView";
            OrdenesDePreparacionPendientesListView.Size = new Size(658, 137);
            OrdenesDePreparacionPendientesListView.TabIndex = 4;
            OrdenesDePreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacionPendientesListView.View = View.Details;
            // 
            // OPaOS_IdOPColumna
            // 
            OPaOS_IdOPColumna.Text = "ID Orden";
            OPaOS_IdOPColumna.Width = 100;
            // 
            // OPaOS_RazonSocialClienteColumna
            // 
            OPaOS_RazonSocialClienteColumna.Text = "Cliente";
            OPaOS_RazonSocialClienteColumna.Width = 100;
            // 
            // OPaOS_FechaORColumna
            // 
            OPaOS_FechaORColumna.Text = "Fecha de recepcion";
            OPaOS_FechaORColumna.Width = 120;
            // 
            // OPaOS_EstadoOPColumna
            // 
            OPaOS_EstadoOPColumna.Text = "Estado";
            OPaOS_EstadoOPColumna.Width = 100;
            // 
            // OPaOS_PrioridadColumna
            // 
            OPaOS_PrioridadColumna.Text = "Prioridad";
            OPaOS_PrioridadColumna.Width = 100;
            // 
            // OPaOS_TransportistaColumna
            // 
            OPaOS_TransportistaColumna.Text = "Transportista";
            OPaOS_TransportistaColumna.Width = 100;
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 640);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ClienteTextBoxOrdenSeleccion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FiltrosOPgroupBox);
            Controls.Add(OPgroupBox);
            Controls.Add(OSgroupBox);
            Margin = new Padding(3, 2, 3, 2);
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