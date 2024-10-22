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
            CMBOrdenSeleccion = new ComboBox();
            LSTProductos = new ListView();
            Ubicacion_Columna = new ColumnHeader();
            Sku_Columna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            LBLOrdenSeleccion = new Label();
            CancelarOrdenSeleccionBTN = new Button();
            BTNConfirmarOrdenSeleccion = new Button();
            SuspendLayout();
            // 
            // CMBOrdenSeleccion
            // 
            CMBOrdenSeleccion.FormattingEnabled = true;
            CMBOrdenSeleccion.Location = new Point(192, 41);
            CMBOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            CMBOrdenSeleccion.Name = "CMBOrdenSeleccion";
            CMBOrdenSeleccion.Size = new Size(488, 23);
            CMBOrdenSeleccion.TabIndex = 1;
            CMBOrdenSeleccion.SelectedIndexChanged += CMBOrdenSeleccion_SelectedIndexChanged;
            // 
            // LSTProductos
            // 
            LSTProductos.Columns.AddRange(new ColumnHeader[] { Ubicacion_Columna, Sku_Columna, CantidadColumna });
            LSTProductos.Location = new Point(74, 90);
            LSTProductos.Margin = new Padding(3, 2, 3, 2);
            LSTProductos.Name = "LSTProductos";
            LSTProductos.Size = new Size(703, 522);
            LSTProductos.TabIndex = 2;
            LSTProductos.UseCompatibleStateImageBehavior = false;
            LSTProductos.View = View.Details;
            // 
            // Ubicacion_Columna
            // 
            Ubicacion_Columna.Text = "Ubicación";
            Ubicacion_Columna.Width = 151;
            // 
            // Sku_Columna
            // 
            Sku_Columna.Text = "SKU Producto";
            Sku_Columna.TextAlign = HorizontalAlignment.Center;
            Sku_Columna.Width = 190;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.TextAlign = HorizontalAlignment.Center;
            CantidadColumna.Width = 140;
            // 
            // LBLOrdenSeleccion
            // 
            LBLOrdenSeleccion.AutoSize = true;
            LBLOrdenSeleccion.Location = new Point(192, 24);
            LBLOrdenSeleccion.Name = "LBLOrdenSeleccion";
            LBLOrdenSeleccion.Size = new Size(112, 15);
            LBLOrdenSeleccion.TabIndex = 3;
            LBLOrdenSeleccion.Text = "Orden de Selección:";
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
            // BTNConfirmarOrdenSeleccion
            // 
            BTNConfirmarOrdenSeleccion.BackColor = Color.FromArgb(192, 255, 192);
            BTNConfirmarOrdenSeleccion.Location = new Point(325, 623);
            BTNConfirmarOrdenSeleccion.Margin = new Padding(3, 2, 3, 2);
            BTNConfirmarOrdenSeleccion.Name = "BTNConfirmarOrdenSeleccion";
            BTNConfirmarOrdenSeleccion.Size = new Size(245, 40);
            BTNConfirmarOrdenSeleccion.TabIndex = 20;
            BTNConfirmarOrdenSeleccion.Text = "&Confirmar Orden de Selección";
            BTNConfirmarOrdenSeleccion.UseVisualStyleBackColor = false;
            BTNConfirmarOrdenSeleccion.Click += BTNConfirmarOrdenSeleccion_Click;
            // 
            // AgregarProductosEnDepositosFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 694);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(BTNConfirmarOrdenSeleccion);
            Controls.Add(LBLOrdenSeleccion);
            Controls.Add(LSTProductos);
            Controls.Add(CMBOrdenSeleccion);
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

        private ComboBox CMBOrdenSeleccion;
        private ListView LSTProductos;
        private ColumnHeader Ubicacion_Columna;
        private ColumnHeader Sku_Columna;
        private ColumnHeader CantidadColumna;
        private Label LBLOrdenSeleccion;
        private Button CancelarOrdenSeleccionBTN;
        private Button BTNConfirmarOrdenSeleccion;
    }
}