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
            TransportistaTextBoxOrdenSeleccion = new TextBox();
            NumeroOrdenPreparacionTextBoxOrdenSeleccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CrearOrdenSeleccionBTN = new Button();
            CancelarOrdenSeleccionBTN = new Button();
            FiltrosOPgroupBox = new GroupBox();
            PrioridadComboBoxOrdenSeleccion = new ComboBox();
            OPgroupBox = new GroupBox();
            DetalleOrdenesDePrepracionAOrdenSeleccionListView = new ListView();
            IDOrdenPreparacion = new ColumnHeader();
            IdCliente = new ColumnHeader();
            DescripcionCliente = new ColumnHeader();
            Mercaderias = new ColumnHeader();
            CantidadMercaderia = new ColumnHeader();
            FechaOrdenRecepcion = new ColumnHeader();
            EstadoOrdenPreparacion = new ColumnHeader();
            Prioridad = new ColumnHeader();
            TransportistaDetalle = new ColumnHeader();
            OSgroupBox = new GroupBox();
            OrdenesDePreparacionPendientesListView = new ListView();
            FiltrosOPgroupBox.SuspendLayout();
            OPgroupBox.SuspendLayout();
            OSgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // QuitarOrdenPreparacionASeleccionBTN
            // 
            QuitarOrdenPreparacionASeleccionBTN.Location = new Point(380, 160);
            QuitarOrdenPreparacionASeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            QuitarOrdenPreparacionASeleccionBTN.Name = "QuitarOrdenPreparacionASeleccionBTN";
            QuitarOrdenPreparacionASeleccionBTN.Size = new Size(204, 22);
            QuitarOrdenPreparacionASeleccionBTN.TabIndex = 0;
            QuitarOrdenPreparacionASeleccionBTN.Text = "&Quitar Orden de Preparación";
            QuitarOrdenPreparacionASeleccionBTN.UseVisualStyleBackColor = true;
            QuitarOrdenPreparacionASeleccionBTN.Click += QuitarOrdenPreparacionASeleccionBTN_Click;
            // 
            // AgregarOrdenSeleccionADetalleBTN
            // 
            AgregarOrdenSeleccionADetalleBTN.Location = new Point(470, 166);
            AgregarOrdenSeleccionADetalleBTN.Margin = new Padding(3, 2, 3, 2);
            AgregarOrdenSeleccionADetalleBTN.Name = "AgregarOrdenSeleccionADetalleBTN";
            AgregarOrdenSeleccionADetalleBTN.Size = new Size(197, 22);
            AgregarOrdenSeleccionADetalleBTN.TabIndex = 1;
            AgregarOrdenSeleccionADetalleBTN.Text = "&Agregar al detalle de seleccion";
            AgregarOrdenSeleccionADetalleBTN.UseVisualStyleBackColor = true;
            AgregarOrdenSeleccionADetalleBTN.Click += CrearOrdenSeleccionBTN_Click;
            // 
            // BuscarOrdenSeleccionBTN
            // 
            BuscarOrdenSeleccionBTN.Location = new Point(372, 96);
            BuscarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            BuscarOrdenSeleccionBTN.Name = "BuscarOrdenSeleccionBTN";
            BuscarOrdenSeleccionBTN.Size = new Size(208, 22);
            BuscarOrdenSeleccionBTN.TabIndex = 3;
            BuscarOrdenSeleccionBTN.Text = "&Buscar Ordenes de Preparación";
            BuscarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // BorrarFiltrosOrdenSeleccionBTN
            // 
            BorrarFiltrosOrdenSeleccionBTN.Location = new Point(585, 96);
            BorrarFiltrosOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            BorrarFiltrosOrdenSeleccionBTN.Name = "BorrarFiltrosOrdenSeleccionBTN";
            BorrarFiltrosOrdenSeleccionBTN.Size = new Size(96, 22);
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
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Transportista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 45);
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
            label5.Location = new Point(374, 45);
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
            // TransportistaTextBoxOrdenSeleccion
            // 
            TransportistaTextBoxOrdenSeleccion.Location = new Point(214, 62);
            TransportistaTextBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            TransportistaTextBoxOrdenSeleccion.Name = "TransportistaTextBoxOrdenSeleccion";
            TransportistaTextBoxOrdenSeleccion.Size = new Size(153, 23);
            TransportistaTextBoxOrdenSeleccion.TabIndex = 11;
            // 
            // NumeroOrdenPreparacionTextBoxOrdenSeleccion
            // 
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Location = new Point(371, 62);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Name = "NumeroOrdenPreparacionTextBoxOrdenSeleccion";
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Size = new Size(190, 23);
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
            CrearOrdenSeleccionBTN.Location = new Point(178, 160);
            CrearOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(197, 22);
            CrearOrdenSeleccionBTN.TabIndex = 17;
            CrearOrdenSeleccionBTN.Text = "&Crear Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(599, 491);
            CancelarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(82, 22);
            CancelarOrdenSeleccionBTN.TabIndex = 18;
            CancelarOrdenSeleccionBTN.Text = "&Cancelar";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CancelarOrdenSeleccionBTN.Click += CancelarOrdenSeleccionBTN_Click;
            // 
            // FiltrosOPgroupBox
            // 
            FiltrosOPgroupBox.Controls.Add(PrioridadComboBoxOrdenSeleccion);
            FiltrosOPgroupBox.Location = new Point(10, 15);
            FiltrosOPgroupBox.Margin = new Padding(3, 2, 3, 2);
            FiltrosOPgroupBox.Name = "FiltrosOPgroupBox";
            FiltrosOPgroupBox.Padding = new Padding(3, 2, 3, 2);
            FiltrosOPgroupBox.Size = new Size(672, 110);
            FiltrosOPgroupBox.TabIndex = 19;
            FiltrosOPgroupBox.TabStop = false;
            FiltrosOPgroupBox.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // PrioridadComboBoxOrdenSeleccion
            // 
            PrioridadComboBoxOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBoxOrdenSeleccion.FormattingEnabled = true;
            PrioridadComboBoxOrdenSeleccion.Location = new Point(556, 47);
            PrioridadComboBoxOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            PrioridadComboBoxOrdenSeleccion.Name = "PrioridadComboBoxOrdenSeleccion";
            PrioridadComboBoxOrdenSeleccion.Size = new Size(112, 23);
            PrioridadComboBoxOrdenSeleccion.TabIndex = 0;
            // 
            // OPgroupBox
            // 
            OPgroupBox.Controls.Add(DetalleOrdenesDePrepracionAOrdenSeleccionListView);
            OPgroupBox.Controls.Add(AgregarOrdenSeleccionADetalleBTN);
            OPgroupBox.Location = new Point(10, 129);
            OPgroupBox.Margin = new Padding(3, 2, 3, 2);
            OPgroupBox.Name = "OPgroupBox";
            OPgroupBox.Padding = new Padding(3, 2, 3, 2);
            OPgroupBox.Size = new Size(672, 190);
            OPgroupBox.TabIndex = 20;
            OPgroupBox.TabStop = false;
            OPgroupBox.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // DetalleOrdenesDePrepracionAOrdenSeleccionListView
            // 
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Columns.AddRange(new ColumnHeader[] { IDOrdenPreparacion, IdCliente, DescripcionCliente, Mercaderias, CantidadMercaderia, FechaOrdenRecepcion, EstadoOrdenPreparacion, Prioridad, TransportistaDetalle });
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Location = new Point(5, 20);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Margin = new Padding(3, 2, 3, 2);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Name = "DetalleOrdenesDePrepracionAOrdenSeleccionListView";
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Size = new Size(662, 144);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.TabIndex = 2;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.View = View.Details;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.SelectedIndexChanged += DetalleOrdenesDePrepracionAOrdenSeleccionListView_SelectedIndexChanged;
            // 
            // IDOrdenPreparacion
            // 
            IDOrdenPreparacion.Text = "IDOrdenPreparacion";
            IDOrdenPreparacion.Width = 31;
            // 
            // IdCliente
            // 
            IdCliente.Text = "IdCliente";
            IdCliente.Width = 31;
            // 
            // DescripcionCliente
            // 
            DescripcionCliente.Text = "DescripcionCliente";
            DescripcionCliente.Width = 31;
            // 
            // Mercaderias
            // 
            Mercaderias.Text = "Mercaderias";
            Mercaderias.Width = 31;
            // 
            // CantidadMercaderia
            // 
            CantidadMercaderia.Text = "CantidadMercaderia";
            CantidadMercaderia.Width = 31;
            // 
            // FechaOrdenRecepcion
            // 
            FechaOrdenRecepcion.Text = "FechaOrdenRecepcion";
            FechaOrdenRecepcion.Width = 31;
            // 
            // EstadoOrdenPreparacion
            // 
            EstadoOrdenPreparacion.Text = "EstadoOrdenPreparacion";
            EstadoOrdenPreparacion.Width = 31;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 31;
            // 
            // TransportistaDetalle
            // 
            TransportistaDetalle.Text = "TransportistaDetalle";
            TransportistaDetalle.Width = 31;
            // 
            // OSgroupBox
            // 
            OSgroupBox.Controls.Add(OrdenesDePreparacionPendientesListView);
            OSgroupBox.Controls.Add(CrearOrdenSeleccionBTN);
            OSgroupBox.Controls.Add(QuitarOrdenPreparacionASeleccionBTN);
            OSgroupBox.Enabled = false;
            OSgroupBox.Location = new Point(10, 332);
            OSgroupBox.Margin = new Padding(3, 2, 3, 2);
            OSgroupBox.Name = "OSgroupBox";
            OSgroupBox.Padding = new Padding(3, 2, 3, 2);
            OSgroupBox.Size = new Size(672, 190);
            OSgroupBox.TabIndex = 21;
            OSgroupBox.TabStop = false;
            OSgroupBox.Text = "Detalle de Ordenes de Preparación a insertar: ";
            // 
            // OrdenesDePreparacionPendientesListView
            // 
            OrdenesDePreparacionPendientesListView.Location = new Point(5, 20);
            OrdenesDePreparacionPendientesListView.Margin = new Padding(3, 2, 3, 2);
            OrdenesDePreparacionPendientesListView.Name = "OrdenesDePreparacionPendientesListView";
            OrdenesDePreparacionPendientesListView.Size = new Size(661, 137);
            OrdenesDePreparacionPendientesListView.TabIndex = 18;
            OrdenesDePreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacionPendientesListView.View = View.Details;
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 542);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(NumeroOrdenPreparacionTextBoxOrdenSeleccion);
            Controls.Add(TransportistaTextBoxOrdenSeleccion);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrdenSeleccionForm";
            Text = "OrdenSeleccion";
            Load += OrdenSeleccionForm_Load_1;
            FiltrosOPgroupBox.ResumeLayout(false);
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
        private TextBox TransportistaTextBoxOrdenSeleccion;
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
        private ListView OrdenesDePreparacionPendientesListView;
        private ColumnHeader IDOrdenPreparacion;
        private ColumnHeader IdCliente;
        private ColumnHeader DescripcionCliente;
        private ColumnHeader Mercaderias;
        private ColumnHeader CantidadMercaderia;
        private ColumnHeader FechaOrdenRecepcion;
        private ColumnHeader EstadoOrdenPreparacion;
        private ColumnHeader Prioridad;
        private ColumnHeader TransportistaDetalle;
    }
}