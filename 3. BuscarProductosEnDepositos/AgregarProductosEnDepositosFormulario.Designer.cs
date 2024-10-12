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
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            Ubicacion_Columna = new ColumnHeader();
            Sku_Columna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            label1 = new Label();
            CancelarOrdenSeleccionBTN = new Button();
            CrearOrdenSeleccionBTN = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 39);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(488, 23);
            comboBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Ubicacion_Columna, Sku_Columna, CantidadColumna });
            listView1.Location = new Point(12, 82);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(488, 314);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Ubicacion_Columna
            // 
            Ubicacion_Columna.Text = "Ubicacición";
            Ubicacion_Columna.Width = 150;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Orden de Selección:";
            // 
            // CancelarOrdenSeleccionBTN
            // 
            CancelarOrdenSeleccionBTN.Location = new Point(393, 400);
            CancelarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CancelarOrdenSeleccionBTN.Name = "CancelarOrdenSeleccionBTN";
            CancelarOrdenSeleccionBTN.Size = new Size(107, 43);
            CancelarOrdenSeleccionBTN.TabIndex = 21;
            CancelarOrdenSeleccionBTN.Text = "&Salir";
            CancelarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenSeleccionBTN
            // 
            CrearOrdenSeleccionBTN.BackColor = Color.FromArgb(192, 255, 192);
            CrearOrdenSeleccionBTN.Location = new Point(190, 400);
            CrearOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            CrearOrdenSeleccionBTN.Name = "CrearOrdenSeleccionBTN";
            CrearOrdenSeleccionBTN.Size = new Size(197, 43);
            CrearOrdenSeleccionBTN.TabIndex = 20;
            CrearOrdenSeleccionBTN.Text = "&Confirmar Orden de Selección";
            CrearOrdenSeleccionBTN.UseVisualStyleBackColor = false;
            // 
            // AgregarProductosEnDepositosFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 454);
            Controls.Add(CancelarOrdenSeleccionBTN);
            Controls.Add(CrearOrdenSeleccionBTN);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarProductosEnDepositosFormulario";
            Text = "Buscar productos en depósito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader Ubicacion_Columna;
        private ColumnHeader Sku_Columna;
        private ColumnHeader CantidadColumna;
        private Label label1;
        private Button CancelarOrdenSeleccionBTN;
        private Button CrearOrdenSeleccionBTN;
    }
}