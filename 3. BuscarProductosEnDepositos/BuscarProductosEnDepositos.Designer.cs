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
            OrdenSeleccionCMB.Location = new Point(280, 33);
            OrdenSeleccionCMB.Margin = new Padding(3, 2, 3, 2);
            OrdenSeleccionCMB.Name = "OrdenSeleccionCMB";
            OrdenSeleccionCMB.Size = new Size(488, 23);
            OrdenSeleccionCMB.TabIndex = 1;
            OrdenSeleccionCMB.SelectedIndexChanged += CMBOrdenSeleccion_SelectedIndexChanged;
            // 
            // ProductosLST
            // 
            ProductosLST.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductosLST.Columns.AddRange(new ColumnHeader[] { UbicacionColumna, SkuColumna, CantidadColumna });
            ProductosLST.Location = new Point(15, 79);
            ProductosLST.Margin = new Padding(3, 2, 3, 2);
            ProductosLST.Name = "ProductosLST";
            ProductosLST.Size = new Size(902, 514);
            ProductosLST.TabIndex = 2;
            ProductosLST.UseCompatibleStateImageBehavior = false;
            ProductosLST.View = View.Details;
            // 
            // UbicacionColumna
            // 
            UbicacionColumna.Text = "Ubicación";
            UbicacionColumna.Width = 300;
            // 
            // SkuColumna
            // 
            SkuColumna.Text = "SKU Producto";
            SkuColumna.TextAlign = HorizontalAlignment.Center;
            SkuColumna.Width = 300;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.TextAlign = HorizontalAlignment.Center;
            CantidadColumna.Width = 300;
            // 
            // OrdenSeleccionLBL
            // 
            OrdenSeleccionLBL.AutoSize = true;
            OrdenSeleccionLBL.Location = new Point(283, 19);
            OrdenSeleccionLBL.Name = "OrdenSeleccionLBL";
            OrdenSeleccionLBL.Size = new Size(112, 15);
            OrdenSeleccionLBL.TabIndex = 3;
            OrdenSeleccionLBL.Text = "Orden de Selección:";
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelarOrdenSeleccionBTN.Location = new Point(729, 597);
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
            ConfirmarOrdenSeleccionBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmarOrdenSeleccionBTN.BackColor = Color.FromArgb(192, 255, 192);
            ConfirmarOrdenSeleccionBTN.Location = new Point(15, 597);
            ConfirmarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenSeleccionBTN.Name = "ConfirmarOrdenSeleccionBTN";
            ConfirmarOrdenSeleccionBTN.Size = new Size(708, 40);
            ConfirmarOrdenSeleccionBTN.TabIndex = 20;
            ConfirmarOrdenSeleccionBTN.Text = "&Confirmar Orden de Selección";
            ConfirmarOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            ConfirmarOrdenSeleccionBTN.Click += BTNConfirmarOrdenSeleccion_Click;
            // 
            // AgregarProductosEnDepositosFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 651);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(ConfirmarOrdenSeleccionBTN);
            Controls.Add(OrdenSeleccionLBL);
            Controls.Add(ProductosLST);
            Controls.Add(OrdenSeleccionCMB);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarProductosEnDepositosFormulario";
            Padding = new Padding(3);
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