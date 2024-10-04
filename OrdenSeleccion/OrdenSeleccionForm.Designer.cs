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
            groupBox1 = new GroupBox();
            PrioridadComboBoxOrdenSeleccion = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            DetalleOrdenesDePrepracionAOrdenSeleccionListView = new ListView();
            OrdenesDePreparacionPendientesListView = new ListView();
            OrdenDePreparacionNumero = new ColumnHeader();
            FechaEmision = new ColumnHeader();
            RazonSocialCliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            Prioridad = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // QuitarOrdenPreparacionASeleccionBTN
            // 
            QuitarOrdenPreparacionASeleccionBTN.Location = new Point(434, 213);
            QuitarOrdenPreparacionASeleccionBTN.Name = "QuitarOrdenPreparacionASeleccionBTN";
            QuitarOrdenPreparacionASeleccionBTN.Size = new Size(233, 29);
            QuitarOrdenPreparacionASeleccionBTN.TabIndex = 0;
            QuitarOrdenPreparacionASeleccionBTN.Text = "&Quitar Orden de Preparación";
            QuitarOrdenPreparacionASeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // AgregarOrdenSeleccionADetalleBTN
            // 
            AgregarOrdenSeleccionADetalleBTN.Location = new Point(537, 222);
            AgregarOrdenSeleccionADetalleBTN.Name = "AgregarOrdenSeleccionADetalleBTN";
            AgregarOrdenSeleccionADetalleBTN.Size = new Size(225, 29);
            AgregarOrdenSeleccionADetalleBTN.TabIndex = 1;
            AgregarOrdenSeleccionADetalleBTN.Text = "&Agregar al detalle de seleccion";
            AgregarOrdenSeleccionADetalleBTN.UseVisualStyleBackColor = true;
            AgregarOrdenSeleccionADetalleBTN.Click += CrearOrdenSeleccionBTN_Click;
            // 
            // BuscarOrdenSeleccionBTN
            // 
            BuscarOrdenSeleccionBTN.Location = new Point(425, 128);
            BuscarOrdenSeleccionBTN.Name = "BuscarOrdenSeleccionBTN";
            BuscarOrdenSeleccionBTN.Size = new Size(238, 29);
            BuscarOrdenSeleccionBTN.TabIndex = 3;
            BuscarOrdenSeleccionBTN.Text = "&Buscar Ordenes de Preparación";
            BuscarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // BorrarFiltrosOrdenSeleccionBTN
            // 
            BorrarFiltrosOrdenSeleccionBTN.Location = new Point(669, 128);
            BorrarFiltrosOrdenSeleccionBTN.Name = "BorrarFiltrosOrdenSeleccionBTN";
            BorrarFiltrosOrdenSeleccionBTN.Size = new Size(110, 29);
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
            label2.Location = new Point(244, 60);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Transportista";
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
            label5.Location = new Point(428, 60);
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
            // TransportistaTextBoxOrdenSeleccion
            // 
            TransportistaTextBoxOrdenSeleccion.Location = new Point(244, 83);
            TransportistaTextBoxOrdenSeleccion.Name = "TransportistaTextBoxOrdenSeleccion";
            TransportistaTextBoxOrdenSeleccion.Size = new Size(174, 27);
            TransportistaTextBoxOrdenSeleccion.TabIndex = 11;
            // 
            // NumeroOrdenPreparacionTextBoxOrdenSeleccion
            // 
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Location = new Point(424, 83);
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Name = "NumeroOrdenPreparacionTextBoxOrdenSeleccion";
            NumeroOrdenPreparacionTextBoxOrdenSeleccion.Size = new Size(216, 27);
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
            label7.Location = new Point(15, 442);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            // 
            // CrearOrdenSeleccionBTN
            // 
            CrearOrdenSeleccionBTN.Location = new Point(203, 213);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(225, 29);
            CrearOrdenSeleccionBTN.TabIndex = 17;
            CrearOrdenSeleccionBTN.Text = "&Crear Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(685, 655);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(94, 29);
            CancelarOrdenSeleccionBTN.TabIndex = 18;
            CancelarOrdenSeleccionBTN.Text = "&Cancelar";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CancelarOrdenSeleccionBTN.Click += CancelarOrdenSeleccionBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PrioridadComboBoxOrdenSeleccion);
            groupBox1.Location = new Point(11, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 146);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // PrioridadComboBoxOrdenSeleccion
            // 
            PrioridadComboBoxOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadComboBoxOrdenSeleccion.FormattingEnabled = true;
            PrioridadComboBoxOrdenSeleccion.Items.AddRange(new object[] { "1", "2", "3" });
            PrioridadComboBoxOrdenSeleccion.Location = new Point(635, 63);
            PrioridadComboBoxOrdenSeleccion.Name = "PrioridadComboBoxOrdenSeleccion";
            PrioridadComboBoxOrdenSeleccion.Size = new Size(127, 28);
            PrioridadComboBoxOrdenSeleccion.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DetalleOrdenesDePrepracionAOrdenSeleccionListView);
            groupBox2.Controls.Add(AgregarOrdenSeleccionADetalleBTN);
            groupBox2.Location = new Point(11, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(768, 254);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(OrdenesDePreparacionPendientesListView);
            groupBox3.Controls.Add(CrearOrdenSeleccionBTN);
            groupBox3.Controls.Add(QuitarOrdenPreparacionASeleccionBTN);
            groupBox3.Location = new Point(12, 442);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(768, 254);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de Ordenes de Preparación a insertar: ";
            // 
            // DetalleOrdenesDePrepracionAOrdenSeleccionListView
            // 
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Columns.AddRange(new ColumnHeader[] { OrdenDePreparacionNumero, FechaEmision, RazonSocialCliente, Transportista, Prioridad });
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Location = new Point(6, 26);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Name = "DetalleOrdenesDePrepracionAOrdenSeleccionListView";
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.Size = new Size(756, 190);
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.TabIndex = 2;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesDePrepracionAOrdenSeleccionListView.View = View.Details;
            // 
            // OrdenesDePreparacionPendientesListView
            // 
            OrdenesDePreparacionPendientesListView.Location = new Point(6, 26);
            OrdenesDePreparacionPendientesListView.Name = "OrdenesDePreparacionPendientesListView";
            OrdenesDePreparacionPendientesListView.Size = new Size(755, 181);
            OrdenesDePreparacionPendientesListView.TabIndex = 18;
            OrdenesDePreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacionPendientesListView.View = View.Details;
            // 
            // OrdenDePreparacionNumero
            // 
            OrdenDePreparacionNumero.Text = "Orden De Preparacion Numero";
            // 
            // FechaEmision
            // 
            FechaEmision.Text = "Fecha Emision";
            // 
            // RazonSocialCliente
            // 
            RazonSocialCliente.Text = "Razon Social Cliente";
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 722);
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
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "OrdenSeleccionForm";
            Text = "OrdenSeleccion";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private ListBox DetalleOrdenesDePrepracionAOrdenSeleccionListView;
        private Label label7;
        private Button CrearOrdenSeleccionBTN;
        private Button CancelarOrdenSeleccionBTN;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox PrioridadComboBoxOrdenSeleccion;
        private ListView DetalleOrdenesDePrepracionAOrdenSeleccionListView;
        private ListView OrdenesDePreparacionPendientesListView;
        private ColumnHeader OrdenDePreparacionNumero;
        private ColumnHeader FechaEmision;
        private ColumnHeader RazonSocialCliente;
        private ColumnHeader Transportista;
        private ColumnHeader Prioridad;
    }
}