namespace Pampazon.ConfirmarOrdenEntrega
{
    partial class ConfirmarOrdenEntregaForm
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
            LstOrdenesEntrega = new ListView();
            IDOrdenEntregaCOLUMNA = new ColumnHeader();
            CantidadClolumna = new ColumnHeader();
            LSTDetalle = new ListView();
            IdOrdenPreparacionCOLUMNA = new ColumnHeader();
            SalirBTN = new Button();
            ConfirmarOrdenEntregaBTN = new Button();
            LimpiarBTN = new Button();
            BuscarBTN = new Button();
            label1 = new Label();
            IdOrdentxt = new TextBox();
            ListadoOrdenesEntregaGRP = new GroupBox();
            FiltrosLBL = new GroupBox();
            DetalleLBL = new GroupBox();
            ListadoOrdenesEntregaGRP.SuspendLayout();
            FiltrosLBL.SuspendLayout();
            DetalleLBL.SuspendLayout();
            SuspendLayout();
            // 
            // LstOrdenesEntrega
            // 
            LstOrdenesEntrega.Columns.AddRange(new ColumnHeader[] { IDOrdenEntregaCOLUMNA, CantidadClolumna });
            LstOrdenesEntrega.FullRowSelect = true;
            LstOrdenesEntrega.Location = new Point(34, 31);
            LstOrdenesEntrega.MultiSelect = false;
            LstOrdenesEntrega.Name = "LstOrdenesEntrega";
            LstOrdenesEntrega.Size = new Size(296, 225);
            LstOrdenesEntrega.TabIndex = 36;
            LstOrdenesEntrega.UseCompatibleStateImageBehavior = false;
            LstOrdenesEntrega.View = View.Details;
            LstOrdenesEntrega.SelectedIndexChanged += LstOrdenesEntrega_SelectedIndexChanged;
            // 
            // IDOrdenEntregaCOLUMNA
            // 
            IDOrdenEntregaCOLUMNA.Text = "ID Orden Entrega";
            IDOrdenEntregaCOLUMNA.Width = 170;
            // 
            // CantidadClolumna
            // 
            CantidadClolumna.Text = "Cantidad de OP";
            CantidadClolumna.Width = 120;
            // 
            // LSTDetalle
            // 
            LSTDetalle.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionCOLUMNA });
            LSTDetalle.Enabled = false;
            LSTDetalle.FullRowSelect = true;
            LSTDetalle.Location = new Point(20, 20);
            LSTDetalle.Margin = new Padding(2);
            LSTDetalle.MultiSelect = false;
            LSTDetalle.Name = "LSTDetalle";
            LSTDetalle.Size = new Size(196, 347);
            LSTDetalle.TabIndex = 34;
            LSTDetalle.UseCompatibleStateImageBehavior = false;
            LSTDetalle.View = View.Details;
            // 
            // IdOrdenPreparacionCOLUMNA
            // 
            IdOrdenPreparacionCOLUMNA.Text = "Id Orden Preparacion";
            IdOrdenPreparacionCOLUMNA.Width = 190;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(385, 395);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(196, 40);
            SalirBTN.TabIndex = 37;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // ConfirmarOrdenEntregaBTN
            // 
            ConfirmarOrdenEntregaBTN.Location = new Point(45, 393);
            ConfirmarOrdenEntregaBTN.Margin = new Padding(2);
            ConfirmarOrdenEntregaBTN.Name = "ConfirmarOrdenEntregaBTN";
            ConfirmarOrdenEntregaBTN.Size = new Size(296, 40);
            ConfirmarOrdenEntregaBTN.TabIndex = 33;
            ConfirmarOrdenEntregaBTN.Text = "Confirmar Orden de Entrega";
            ConfirmarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenEntregaBTN.Click += ConfirmarOrdenEntregaBTN_Click;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(180, 60);
            LimpiarBTN.Margin = new Padding(2);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(150, 26);
            LimpiarBTN.TabIndex = 32;
            LimpiarBTN.Text = "Limpiar";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(14, 60);
            BuscarBTN.Margin = new Padding(2);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(150, 26);
            BuscarBTN.TabIndex = 31;
            BuscarBTN.Text = "Buscar:";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 30;
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(14, 33);
            IdOrdentxt.Margin = new Padding(2);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(316, 23);
            IdOrdentxt.TabIndex = 29;
            // 
            // ListadoOrdenesEntregaGRP
            // 
            ListadoOrdenesEntregaGRP.Controls.Add(LstOrdenesEntrega);
            ListadoOrdenesEntregaGRP.Location = new Point(11, 122);
            ListadoOrdenesEntregaGRP.Margin = new Padding(2);
            ListadoOrdenesEntregaGRP.Name = "ListadoOrdenesEntregaGRP";
            ListadoOrdenesEntregaGRP.Padding = new Padding(2);
            ListadoOrdenesEntregaGRP.Size = new Size(350, 269);
            ListadoOrdenesEntregaGRP.TabIndex = 39;
            ListadoOrdenesEntregaGRP.TabStop = false;
            ListadoOrdenesEntregaGRP.Text = "Listado de Ordenes de Entrega";
            // 
            // FiltrosLBL
            // 
            FiltrosLBL.Controls.Add(IdOrdentxt);
            FiltrosLBL.Controls.Add(label1);
            FiltrosLBL.Controls.Add(BuscarBTN);
            FiltrosLBL.Controls.Add(LimpiarBTN);
            FiltrosLBL.Location = new Point(11, 11);
            FiltrosLBL.Margin = new Padding(2);
            FiltrosLBL.Name = "FiltrosLBL";
            FiltrosLBL.Padding = new Padding(2);
            FiltrosLBL.Size = new Size(350, 100);
            FiltrosLBL.TabIndex = 40;
            FiltrosLBL.TabStop = false;
            FiltrosLBL.Text = "ID de Orden Entrega";
            // 
            // DetalleLBL
            // 
            DetalleLBL.Controls.Add(LSTDetalle);
            DetalleLBL.Location = new Point(365, 11);
            DetalleLBL.Margin = new Padding(2);
            DetalleLBL.Name = "DetalleLBL";
            DetalleLBL.Padding = new Padding(2);
            DetalleLBL.Size = new Size(235, 380);
            DetalleLBL.TabIndex = 41;
            DetalleLBL.TabStop = false;
            DetalleLBL.Text = "Detalle";
            // 
            // ConfirmarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 446);
            Controls.Add(ConfirmarOrdenEntregaBTN);
            Controls.Add(DetalleLBL);
            Controls.Add(FiltrosLBL);
            Controls.Add(ListadoOrdenesEntregaGRP);
            Controls.Add(SalirBTN);
            Margin = new Padding(2);
            Name = "ConfirmarOrdenEntregaForm";
            Text = "Confirmar Orden de Entrega";
            Load += ConfirmarOrdenEntregaForm_Load_1;
            ListadoOrdenesEntregaGRP.ResumeLayout(false);
            FiltrosLBL.ResumeLayout(false);
            FiltrosLBL.PerformLayout();
            DetalleLBL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView LstOrdenesEntrega;
        private ColumnHeader IDOrdenEntregaCOLUMNA;
        private ListView LSTDetalle;
        private ColumnHeader IdOrdenPreparacionCOLUMNA;
        private Button SalirBTN;
        private Button ConfirmarOrdenEntregaBTN;
        private Button LimpiarBTN;
        private Button BuscarBTN;
        private Label label1;
        private TextBox IdOrdentxt;
        private ColumnHeader CantidadClolumna;
        private GroupBox ListadoOrdenesEntregaGRP;
        private GroupBox FiltrosLBL;
        private GroupBox DetalleLBL;
    }
}