namespace Pampazon.BuscarProductosEnDepositos
{
    partial class AgregarProductosEnDepositosFormulario
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
            OrdenSeleccionCMB = new ComboBox();
            ProductosLST = new ListView();
            UbicacionColumna = new ColumnHeader();
            SkuColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            OrdenSeleccionLBL = new Label();
            CancelarOrdenSeleccionBTN = new Button();
            ConfirmarOrdenSeleccionBTN = new Button();
            SuspendLayout();
            // 
            // OrdenSeleccionCMB
            // 
            OrdenSeleccionCMB.FormattingEnabled = true;
            OrdenSeleccionCMB.Location = new Point(192, 41);
            OrdenSeleccionCMB.Margin = new Padding(3, 2, 3, 2);
            OrdenSeleccionCMB.Name = "OrdenSeleccionCMB";
            OrdenSeleccionCMB.Size = new Size(488, 23);
            OrdenSeleccionCMB.TabIndex = 1;
            OrdenSeleccionCMB.SelectedIndexChanged += CMBOrdenSeleccion_SelectedIndexChanged;
            // 
            // ProductosLST
            // 
            ProductosLST.Columns.AddRange(new ColumnHeader[] { UbicacionColumna, SkuColumna, CantidadColumna });
            ProductosLST.Location = new Point(74, 90);
            ProductosLST.Margin = new Padding(3, 2, 3, 2);
            ProductosLST.Name = "ProductosLST";
            ProductosLST.Size = new Size(703, 522);
            ProductosLST.TabIndex = 2;
            ProductosLST.UseCompatibleStateImageBehavior = false;
            ProductosLST.View = View.Details;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 151;
            // 
            // SkuColumna
            // 
            SkuColumna.Text = "SKU Producto";
            SkuColumna.TextAlign = HorizontalAlignment.Center;
            SkuColumna.Width = 190;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.TextAlign = HorizontalAlignment.Center;
            CantidadColumna.Width = 140;
            // 
            // OrdenSeleccionLBL
            // 
            OrdenSeleccionLBL.AutoSize = true;
            OrdenSeleccionLBL.Location = new Point(192, 24);
            OrdenSeleccionLBL.Name = "OrdenSeleccionLBL";
            OrdenSeleccionLBL.Size = new Size(112, 15);
            OrdenSeleccionLBL.TabIndex = 3;
            OrdenSeleccionLBL.Text = "Orden de Selección:";
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(589, 623);
            CancelarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(188, 40);
            CancelarOrdenSeleccionBTN.TabIndex = 21;
            CancelarOrdenSeleccionBTN.Text = "&Salir";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            CancelarOrdenSeleccionBTN.Click += CancelarOrdenSeleccionBTN_Click;
            // 
            // ConfirmarOrdenSeleccionBTN
            // 
            ConfirmarOrdenSeleccionBTN.BackColor = Color.FromArgb(192, 255, 192);
            ConfirmarOrdenSeleccionBTN.Location = new Point(325, 623);
            ConfirmarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenSeleccionBTN.Name = "ConfirmarOrdenSeleccionBTN";
            ConfirmarOrdenSeleccionBTN.Size = new Size(245, 40);
            ConfirmarOrdenSeleccionBTN.TabIndex = 20;
            ConfirmarOrdenSeleccionBTN.Text = "&Confirmar Orden de Selección";
            ConfirmarOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            ConfirmarOrdenSeleccionBTN.Click += BTNConfirmarOrdenSeleccion_Click;
            // 
            // AgregarProductosEnDepositosFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 694);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(ConfirmarOrdenSeleccionBTN);
            Controls.Add(OrdenSeleccionLBL);
            Controls.Add(ProductosLST);
            Controls.Add(OrdenSeleccionCMB);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarProductosEnDepositosFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar productos en depósito";
            Load += AgregarProductosEnDepositosFormulario_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox OrdenSeleccionCMB;
        private ListView ProductosLST;
        private ColumnHeader UbicacionColumna;
        private ColumnHeader SkuColumna;
        private ColumnHeader CantidadColumna;
        private Label OrdenSeleccionLBL;
        private Button CancelarOrdenSeleccionBTN;
        private Button ConfirmarOrdenSeleccionBTN;
    }
}