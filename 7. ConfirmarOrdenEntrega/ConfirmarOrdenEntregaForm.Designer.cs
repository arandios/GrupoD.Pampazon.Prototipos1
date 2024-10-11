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
            label2 = new Label();
            DetalleConfirmarOEgroupBox = new GroupBox();
            ListadoOrdenesEntregaGRP.SuspendLayout();
            FiltrosLBL.SuspendLayout();
            DetalleConfirmarOEgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LstOrdenesEntrega
            // 
            LstOrdenesEntrega.Columns.AddRange(new ColumnHeader[] { IDOrdenEntregaCOLUMNA, CantidadClolumna });
            LstOrdenesEntrega.FullRowSelect = true;
            LstOrdenesEntrega.Location = new Point(5, 41);
            LstOrdenesEntrega.Margin = new Padding(3, 4, 3, 4);
            LstOrdenesEntrega.MultiSelect = false;
            LstOrdenesEntrega.Name = "LstOrdenesEntrega";
            LstOrdenesEntrega.Size = new Size(680, 255);
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
            LSTDetalle.Location = new Point(5, 20);
            LSTDetalle.Margin = new Padding(2, 3, 2, 3);
            LSTDetalle.MultiSelect = false;
            LSTDetalle.Name = "LSTDetalle";
            LSTDetalle.Size = new Size(680, 183);
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
            SalirBTN.Location = new Point(623, 686);
            SalirBTN.Margin = new Padding(2, 3, 2, 3);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(75, 29);
            SalirBTN.TabIndex = 37;
            SalirBTN.Text = "&Salir";
            SalirBTN.Click += SalirBTN_Click;
            // 
            // ConfirmarOrdenEntregaBTN
            // 
            ConfirmarOrdenEntregaBTN.Location = new Point(409, 686);
            ConfirmarOrdenEntregaBTN.Margin = new Padding(2, 3, 2, 3);
            ConfirmarOrdenEntregaBTN.Name = "ConfirmarOrdenEntregaBTN";
            ConfirmarOrdenEntregaBTN.Size = new Size(210, 29);
            ConfirmarOrdenEntregaBTN.TabIndex = 33;
            ConfirmarOrdenEntregaBTN.Text = "&Confirmar Orden de Entrega";
            ConfirmarOrdenEntregaBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenEntregaBTN.Click += ConfirmarOrdenEntregaBTN_Click;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(576, 98);
            LimpiarBTN.Margin = new Padding(2, 3, 2, 3);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(109, 29);
            LimpiarBTN.TabIndex = 32;
            LimpiarBTN.Text = "&Borrar filtros";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(381, 98);
            BuscarBTN.Margin = new Padding(2, 3, 2, 3);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(191, 29);
            BuscarBTN.TabIndex = 31;
            BuscarBTN.Text = "&Buscar Orden de Entrega";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 30;
            // 
            // IdOrdentxt
            // 
            IdOrdentxt.Location = new Point(4, 54);
            IdOrdentxt.Margin = new Padding(2, 3, 2, 3);
            IdOrdentxt.Name = "IdOrdentxt";
            IdOrdentxt.Size = new Size(681, 27);
            IdOrdentxt.TabIndex = 29;
            // 
            // ListadoOrdenesEntregaGRP
            // 
            ListadoOrdenesEntregaGRP.Controls.Add(LstOrdenesEntrega);
            ListadoOrdenesEntregaGRP.Location = new Point(11, 154);
            ListadoOrdenesEntregaGRP.Margin = new Padding(2, 3, 2, 3);
            ListadoOrdenesEntregaGRP.Name = "ListadoOrdenesEntregaGRP";
            ListadoOrdenesEntregaGRP.Padding = new Padding(2, 3, 2, 3);
            ListadoOrdenesEntregaGRP.Size = new Size(691, 311);
            ListadoOrdenesEntregaGRP.TabIndex = 39;
            ListadoOrdenesEntregaGRP.TabStop = false;
            ListadoOrdenesEntregaGRP.Text = "Listado de Ordenes de Entrega";
            // 
            // FiltrosLBL
            // 
            FiltrosLBL.Controls.Add(label2);
            FiltrosLBL.Controls.Add(IdOrdentxt);
            FiltrosLBL.Controls.Add(label1);
            FiltrosLBL.Controls.Add(BuscarBTN);
            FiltrosLBL.Controls.Add(LimpiarBTN);
            FiltrosLBL.Location = new Point(13, 15);
            FiltrosLBL.Margin = new Padding(2, 3, 2, 3);
            FiltrosLBL.Name = "FiltrosLBL";
            FiltrosLBL.Padding = new Padding(2, 3, 2, 3);
            FiltrosLBL.Size = new Size(689, 133);
            FiltrosLBL.TabIndex = 40;
            FiltrosLBL.TabStop = false;
            FiltrosLBL.Text = "Seleccione filtros de búsqueda para Ordenes de Entrega:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 33;
            label2.Text = "ID Orden de Entrega";
            // 
            // DetalleConfirmarOEgroupBox
            // 
            DetalleConfirmarOEgroupBox.Controls.Add(LSTDetalle);
            DetalleConfirmarOEgroupBox.Location = new Point(11, 471);
            DetalleConfirmarOEgroupBox.Name = "DetalleConfirmarOEgroupBox";
            DetalleConfirmarOEgroupBox.Size = new Size(691, 209);
            DetalleConfirmarOEgroupBox.TabIndex = 41;
            DetalleConfirmarOEgroupBox.TabStop = false;
            DetalleConfirmarOEgroupBox.Text = "Detalle:";
            // 
            // ConfirmarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 728);
            Controls.Add(ConfirmarOrdenEntregaBTN);
            Controls.Add(FiltrosLBL);
            Controls.Add(ListadoOrdenesEntregaGRP);
            Controls.Add(SalirBTN);
            Controls.Add(DetalleConfirmarOEgroupBox);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ConfirmarOrdenEntregaForm";
            Text = "Confirmar Orden de Entrega";
            Load += ConfirmarOrdenEntregaForm_Load_1;
            ListadoOrdenesEntregaGRP.ResumeLayout(false);
            FiltrosLBL.ResumeLayout(false);
            FiltrosLBL.PerformLayout();
            DetalleConfirmarOEgroupBox.ResumeLayout(false);
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
        private Label label2;
        private GroupBox DetalleConfirmarOEgroupBox;
    }
}