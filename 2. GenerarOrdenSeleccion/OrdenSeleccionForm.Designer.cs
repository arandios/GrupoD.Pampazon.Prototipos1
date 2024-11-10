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
            FechaMinimaLBL = new Label();
            PrioridadLBL = new Label();
            RazonSocialClienteLBL = new Label();
            IdOrdenLBL = new Label();
            ClienteOrdenSeleccionTXT = new TextBox();
            NumeroOrdenPreparacionOrdenSeleccionTXT = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CrearOrdenSeleccionBTN = new Button();
            CancelarOrdenSeleccionBTN = new Button();
            FiltrosOPGRP = new GroupBox();
            FechaMaximaLBL = new Label();
            FechaFinalOrdenSeleccionDTP = new DateTimePicker();
            FechaInicioOrdenSeleccionDTP = new DateTimePicker();
            PrioridadOrdenSeleccionCMB = new ComboBox();
            OPGRP = new GroupBox();
            OrdenesDePrepracionAOrdenSeleccionLST = new ListView();
            IDOrdenPreparacionColumna = new ColumnHeader();
            RSCliente_Columna = new ColumnHeader();
            FechaOrdenPreparacionColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            OSGRP = new GroupBox();
            DetalleOrdenesDePreparacionPendientesLST = new ListView();
            OPaOS_IdOPColumna = new ColumnHeader();
            OPaOS_RazonSocialClienteColumna = new ColumnHeader();
            OPaOS_FechaOPColumna = new ColumnHeader();
            OPaOS_PrioridadColumna = new ColumnHeader();
            FiltrosOPGRP.SuspendLayout();
            OPGRP.SuspendLayout();
            OSGRP.SuspendLayout();
            SuspendLayout();
            // 
            // QuitarOrdenPreparacionASeleccionBTN
            // 
            QuitarOrdenPreparacionASeleccionBTN.BackColor = Color.FromArgb(255, 192, 192);
            QuitarOrdenPreparacionASeleccionBTN.Location = new Point(728, 276);
            QuitarOrdenPreparacionASeleccionBTN.Name = "QuitarOrdenPreparacionASeleccionBTN";
            QuitarOrdenPreparacionASeleccionBTN.Size = new Size(225, 55);
            QuitarOrdenPreparacionASeleccionBTN.TabIndex = 0;
            QuitarOrdenPreparacionASeleccionBTN.Text = "&Quitar Orden de Preparación";
            QuitarOrdenPreparacionASeleccionBTN.UseVisualStyleBackColor = false;
            QuitarOrdenPreparacionASeleccionBTN.Click += QuitarOrdenPreparacionASeleccionBTN_Click;
            // 
            // AgregarOrdenSeleccionADetalleBTN
            // 
            AgregarOrdenSeleccionADetalleBTN.Location = new Point(714, 253);
            AgregarOrdenSeleccionADetalleBTN.Name = "AgregarOrdenSeleccionADetalleBTN";
            AgregarOrdenSeleccionADetalleBTN.Size = new Size(234, 53);
            AgregarOrdenSeleccionADetalleBTN.TabIndex = 1;
            AgregarOrdenSeleccionADetalleBTN.Text = "&Agregar al detalle de seleccion";
            AgregarOrdenSeleccionADetalleBTN.UseVisualStyleBackColor = true;
            AgregarOrdenSeleccionADetalleBTN.Click += AgregarAOrdenSeleccionBTN_Click_1;
            // 
            // BuscarOrdenSeleccionBTN
            // 
            BuscarOrdenSeleccionBTN.Location = new Point(512, 111);
            BuscarOrdenSeleccionBTN.Name = "BuscarOrdenSeleccionBTN";
            BuscarOrdenSeleccionBTN.Size = new Size(224, 53);
            BuscarOrdenSeleccionBTN.TabIndex = 3;
            BuscarOrdenSeleccionBTN.Text = "&Buscar Ordenes de Preparación";
            BuscarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            BuscarOrdenSeleccionBTN.Click += BuscarOrdenSeleccionBTN_Click;
            // 
            // BorrarFiltrosOrdenSeleccionBTN
            // 
            BorrarFiltrosOrdenSeleccionBTN.Location = new Point(742, 111);
            BorrarFiltrosOrdenSeleccionBTN.Name = "BorrarFiltrosOrdenSeleccionBTN";
            BorrarFiltrosOrdenSeleccionBTN.Size = new Size(214, 53);
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
            // FechaMinimaLBL
            // 
            FechaMinimaLBL.AutoSize = true;
            FechaMinimaLBL.Location = new Point(233, 40);
            FechaMinimaLBL.Name = "FechaMinimaLBL";
            FechaMinimaLBL.Size = new Size(101, 20);
            FechaMinimaLBL.TabIndex = 6;
            FechaMinimaLBL.Text = "Fecha Mínima";
            // 
            // PrioridadLBL
            // 
            PrioridadLBL.AutoSize = true;
            PrioridadLBL.Location = new Point(233, 107);
            PrioridadLBL.Name = "PrioridadLBL";
            PrioridadLBL.Size = new Size(70, 20);
            PrioridadLBL.TabIndex = 7;
            PrioridadLBL.Text = "Prioridad";
            // 
            // RazonSocialClienteLBL
            // 
            RazonSocialClienteLBL.AutoSize = true;
            RazonSocialClienteLBL.Location = new Point(15, 60);
            RazonSocialClienteLBL.Name = "RazonSocialClienteLBL";
            RazonSocialClienteLBL.Size = new Size(142, 20);
            RazonSocialClienteLBL.TabIndex = 8;
            RazonSocialClienteLBL.Text = "Razón social Cliente";
            // 
            // IdOrdenLBL
            // 
            IdOrdenLBL.AutoSize = true;
            IdOrdenLBL.Location = new Point(0, 107);
            IdOrdenLBL.Name = "IdOrdenLBL";
            IdOrdenLBL.Size = new Size(173, 20);
            IdOrdenLBL.TabIndex = 9;
            IdOrdenLBL.Text = "ID de Orden Preparación";
            // 
            // ClienteOrdenSeleccionTXT
            // 
            ClienteOrdenSeleccionTXT.Location = new Point(15, 83);
            ClienteOrdenSeleccionTXT.Name = "ClienteOrdenSeleccionTXT";
            ClienteOrdenSeleccionTXT.Size = new Size(223, 27);
            ClienteOrdenSeleccionTXT.TabIndex = 10;
            // 
            // NumeroOrdenPreparacionOrdenSeleccionTXT
            // 
            NumeroOrdenPreparacionOrdenSeleccionTXT.Location = new Point(0, 131);
            NumeroOrdenPreparacionOrdenSeleccionTXT.Name = "NumeroOrdenPreparacionOrdenSeleccionTXT";
            NumeroOrdenPreparacionOrdenSeleccionTXT.Size = new Size(227, 27);
            NumeroOrdenPreparacionOrdenSeleccionTXT.TabIndex = 12;
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
            CrearOrdenSeleccionBTN.Location = new Point(459, 888);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(280, 53);
            CrearOrdenSeleccionBTN.TabIndex = 17;
            CrearOrdenSeleccionBTN.Text = "&Generar Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            CrearOrdenSeleccionBTN.Click += CrearOrdenSeleccionBTN_Click_1;
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(745, 888);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(214, 53);
            CancelarOrdenSeleccionBTN.TabIndex = 18;
            CancelarOrdenSeleccionBTN.Text = "&Salir";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CancelarOrdenSeleccionBTN.Click += CancelarOrdenSeleccionBTN_Click;
            // 
            // FiltrosOPGRP
            // 
            FiltrosOPGRP.Controls.Add(FechaMaximaLBL);
            FiltrosOPGRP.Controls.Add(FechaFinalOrdenSeleccionDTP);
            FiltrosOPGRP.Controls.Add(FechaInicioOrdenSeleccionDTP);
            FiltrosOPGRP.Controls.Add(NumeroOrdenPreparacionOrdenSeleccionTXT);
            FiltrosOPGRP.Controls.Add(FechaMinimaLBL);
            FiltrosOPGRP.Controls.Add(IdOrdenLBL);
            FiltrosOPGRP.Controls.Add(PrioridadLBL);
            FiltrosOPGRP.Controls.Add(PrioridadOrdenSeleccionCMB);
            FiltrosOPGRP.Controls.Add(BuscarOrdenSeleccionBTN);
            FiltrosOPGRP.Controls.Add(BorrarFiltrosOrdenSeleccionBTN);
            FiltrosOPGRP.Location = new Point(11, 20);
            FiltrosOPGRP.Name = "FiltrosOPGRP";
            FiltrosOPGRP.Size = new Size(959, 169);
            FiltrosOPGRP.TabIndex = 19;
            FiltrosOPGRP.TabStop = false;
            FiltrosOPGRP.Text = "Seleccione filtros de búsqueda para Ordenes de Preparación: ";
            // 
            // FechaMaximaLBL
            // 
            FechaMaximaLBL.AutoSize = true;
            FechaMaximaLBL.Location = new Point(593, 40);
            FechaMaximaLBL.Name = "FechaMaximaLBL";
            FechaMaximaLBL.Size = new Size(104, 20);
            FechaMaximaLBL.TabIndex = 25;
            FechaMaximaLBL.Text = "Fecha Máxima";
            // 
            // FechaFinalOrdenSeleccionDTP
            // 
            FechaFinalOrdenSeleccionDTP.Location = new Point(593, 63);
            FechaFinalOrdenSeleccionDTP.Name = "FechaFinalOrdenSeleccionDTP";
            FechaFinalOrdenSeleccionDTP.Size = new Size(354, 27);
            FechaFinalOrdenSeleccionDTP.TabIndex = 24;
            // 
            // FechaInicioOrdenSeleccionDTP
            // 
            FechaInicioOrdenSeleccionDTP.Location = new Point(233, 63);
            FechaInicioOrdenSeleccionDTP.Name = "FechaInicioOrdenSeleccionDTP";
            FechaInicioOrdenSeleccionDTP.Size = new Size(354, 27);
            FechaInicioOrdenSeleccionDTP.TabIndex = 1;
            // 
            // PrioridadOrdenSeleccionCMB
            // 
            PrioridadOrdenSeleccionCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioridadOrdenSeleccionCMB.FormattingEnabled = true;
            PrioridadOrdenSeleccionCMB.Location = new Point(233, 131);
            PrioridadOrdenSeleccionCMB.Name = "PrioridadOrdenSeleccionCMB";
            PrioridadOrdenSeleccionCMB.Size = new Size(270, 28);
            PrioridadOrdenSeleccionCMB.TabIndex = 0;
            PrioridadOrdenSeleccionCMB.SelectedIndexChanged += PrioridadOrdenSeleccionCMB_SelectedIndexChanged;
            // 
            // OPGRP
            // 
            OPGRP.Controls.Add(OrdenesDePrepracionAOrdenSeleccionLST);
            OPGRP.Controls.Add(AgregarOrdenSeleccionADetalleBTN);
            OPGRP.Location = new Point(11, 216);
            OPGRP.Name = "OPGRP";
            OPGRP.Size = new Size(959, 320);
            OPGRP.TabIndex = 20;
            OPGRP.TabStop = false;
            OPGRP.Text = "Ordenes de Preparación en estado Pendiente: ";
            // 
            // OrdenesDePrepracionAOrdenSeleccionLST
            // 
            OrdenesDePrepracionAOrdenSeleccionLST.Columns.AddRange(new ColumnHeader[] { IDOrdenPreparacionColumna, RSCliente_Columna, FechaOrdenPreparacionColumna, PrioridadColumna });
            OrdenesDePrepracionAOrdenSeleccionLST.Location = new Point(5, 27);
            OrdenesDePrepracionAOrdenSeleccionLST.Name = "OrdenesDePrepracionAOrdenSeleccionLST";
            OrdenesDePrepracionAOrdenSeleccionLST.Size = new Size(947, 221);
            OrdenesDePrepracionAOrdenSeleccionLST.TabIndex = 2;
            OrdenesDePrepracionAOrdenSeleccionLST.UseCompatibleStateImageBehavior = false;
            OrdenesDePrepracionAOrdenSeleccionLST.View = View.Details;
            // 
            // IDOrdenPreparacionColumna
            // 
            IDOrdenPreparacionColumna.Text = "ID Orden Preparación";
            IDOrdenPreparacionColumna.Width = 100;
            // 
            // RSCliente_Columna
            // 
            RSCliente_Columna.Text = "Razón Social Cliente";
            RSCliente_Columna.Width = 100;
            // 
            // FechaOrdenPreparacionColumna
            // 
            FechaOrdenPreparacionColumna.Text = "Fecha ";
            FechaOrdenPreparacionColumna.Width = 100;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 100;
            // 
            // OSGRP
            // 
            OSGRP.Controls.Add(DetalleOrdenesDePreparacionPendientesLST);
            OSGRP.Controls.Add(QuitarOrdenPreparacionASeleccionBTN);
            OSGRP.Enabled = false;
            OSGRP.Location = new Point(11, 541);
            OSGRP.Name = "OSGRP";
            OSGRP.Size = new Size(959, 339);
            OSGRP.TabIndex = 21;
            OSGRP.TabStop = false;
            OSGRP.Text = "Detalle de Ordenes de Preparación a insertar: ";
            // 
            // DetalleOrdenesDePreparacionPendientesLST
            // 
            DetalleOrdenesDePreparacionPendientesLST.Columns.AddRange(new ColumnHeader[] { OPaOS_IdOPColumna, OPaOS_RazonSocialClienteColumna, OPaOS_FechaOPColumna, OPaOS_PrioridadColumna });
            DetalleOrdenesDePreparacionPendientesLST.Location = new Point(6, 43);
            DetalleOrdenesDePreparacionPendientesLST.Name = "DetalleOrdenesDePreparacionPendientesLST";
            DetalleOrdenesDePreparacionPendientesLST.Size = new Size(947, 216);
            DetalleOrdenesDePreparacionPendientesLST.TabIndex = 4;
            DetalleOrdenesDePreparacionPendientesLST.UseCompatibleStateImageBehavior = false;
            DetalleOrdenesDePreparacionPendientesLST.View = View.Details;
            // 
            // OPaOS_IdOPColumna
            // 
            OPaOS_IdOPColumna.Text = "ID Orden Preparación";
            OPaOS_IdOPColumna.Width = 100;
            // 
            // OPaOS_RazonSocialClienteColumna
            // 
            OPaOS_RazonSocialClienteColumna.Text = "Razón Social Cliente";
            OPaOS_RazonSocialClienteColumna.Width = 100;
            // 
            // OPaOS_FechaOPColumna
            // 
            OPaOS_FechaOPColumna.Text = "Fecha";
            OPaOS_FechaOPColumna.Width = 120;
            // 
            // OPaOS_PrioridadColumna
            // 
            OPaOS_PrioridadColumna.Text = "Prioridad";
            OPaOS_PrioridadColumna.Width = 100;
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(CrearOrdenSeleccionBTN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ClienteOrdenSeleccionTXT);
            Controls.Add(RazonSocialClienteLBL);
            Controls.Add(label1);
            Controls.Add(FiltrosOPGRP);
            Controls.Add(OPGRP);
            Controls.Add(OSGRP);
            Name = "OrdenSeleccionForm";
            Text = "Generar Orden Seleccion";
            Load += OrdenSeleccionForm_Load_1;
            FiltrosOPGRP.ResumeLayout(false);
            FiltrosOPGRP.PerformLayout();
            OPGRP.ResumeLayout(false);
            OSGRP.ResumeLayout(false);
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
        private Label FechaMinimaLBL;
        private Label PrioridadLBL;
        private Label RazonSocialClienteLBL;
        private Label IdOrdenLBL;
        private TextBox ClienteOrdenSeleccionTXT;
        private TextBox NumeroOrdenPreparacionOrdenSeleccionTXT;
        private Label label6;
        //private ListBox DetalleOrdenesDePrepracionAOrdenSeleccionListView;
        private Label label7;
        private Button CrearOrdenSeleccionBTN;
        private Button CancelarOrdenSeleccionBTN;
        private GroupBox FiltrosOPGRP;
        private GroupBox OPGRP;
        private GroupBox OSGRP;
        private ComboBox PrioridadOrdenSeleccionCMB;
        private ListView OrdenesDePrepracionAOrdenSeleccionLST;
        private ColumnHeader IDOrdenPreparacionColumna;
        private ColumnHeader RSCliente_Columna;
        private ColumnHeader FechaOrdenPreparacionColumna;
        private ColumnHeader PrioridadColumna;
        private ListView DetalleOrdenesDePreparacionPendientesLST;
        private ColumnHeader OPaOS_IdOPColumna;
        private ColumnHeader OPaOS_RazonSocialClienteColumna;
        private ColumnHeader OPaOS_FechaOPColumna;
        private ColumnHeader OPaOS_PrioridadColumna;
        private DateTimePicker FechaInicioOrdenSeleccionDTP;
        private Label FechaMaximaLBL;
        private DateTimePicker FechaFinalOrdenSeleccionDTP;
    }
}