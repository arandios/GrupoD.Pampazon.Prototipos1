namespace Pampazon._4._EmpaquetarOrden
{
    partial class EmpaquetarOrdenForm
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
            OrdenesGRP = new GroupBox();
            OrdenesParaPrepararLST = new ListView();
            SKUProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarBTN = new Button();
            SalirBTN = new Button();
            OrdenesGRP.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesGRP
            // 
            OrdenesGRP.Controls.Add(OrdenesParaPrepararLST);
            OrdenesGRP.Location = new Point(33, 18);
            OrdenesGRP.Margin = new Padding(2);
            OrdenesGRP.Name = "OrdenesGRP";
            OrdenesGRP.Padding = new Padding(2);
            OrdenesGRP.Size = new Size(764, 625);
            OrdenesGRP.TabIndex = 0;
            OrdenesGRP.TabStop = false;
            OrdenesGRP.Text = "Detalle productos a empaquetar";
            // 
            // OrdenesParaPrepararLST
            // 
            OrdenesParaPrepararLST.Columns.AddRange(new ColumnHeader[] { SKUProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesParaPrepararLST.Location = new Point(24, 26);
            OrdenesParaPrepararLST.Margin = new Padding(2);
            OrdenesParaPrepararLST.Name = "OrdenesParaPrepararLST";
            OrdenesParaPrepararLST.Size = new Size(702, 588);
            OrdenesParaPrepararLST.TabIndex = 0;
            OrdenesParaPrepararLST.UseCompatibleStateImageBehavior = false;
            OrdenesParaPrepararLST.View = View.Details;
            // 
            // SKUProductoColumna
            // 
            SKUProductoColumna.Text = "SKU Producto";
            SKUProductoColumna.Width = 150;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 300;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 350;
            // 
            // ConfirmarBTN
            // 
            ConfirmarBTN.BackColor = Color.FromArgb(192, 255, 192);
            ConfirmarBTN.ForeColor = Color.Black;
            ConfirmarBTN.Location = new Point(315, 656);
            ConfirmarBTN.Margin = new Padding(2);
            ConfirmarBTN.Name = "ConfirmarBTN";
            ConfirmarBTN.Size = new Size(245, 40);
            ConfirmarBTN.TabIndex = 1;
            ConfirmarBTN.Text = "&Confirmar orden como preparada";
            ConfirmarBTN.UseVisualStyleBackColor = false;
            ConfirmarBTN.Click += Confirmarbtn_Click;
            // 
            // SalirBTN
            // 
            SalirBTN.Location = new Point(572, 656);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 2;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += Salirbtn_Click;
            // 
            // EmpaquetarOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 715);
            Controls.Add(SalirBTN);
            Controls.Add(ConfirmarBTN);
            Controls.Add(OrdenesGRP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "EmpaquetarOrdenForm";
            Text = "Empaquetar Ordenes de Preparación";
            OrdenesGRP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OrdenesGRP;
        private ListView OrdenesParaPrepararLST;
        private ColumnHeader SKUProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Button ConfirmarBTN;
        private Button SalirBTN;
    }
}