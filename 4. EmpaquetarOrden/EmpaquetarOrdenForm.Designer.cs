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
            SalirBTN = new Button();
            OrdenesParaPrepararLST = new ListView();
            SKUProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarBTN = new Button();
            OrdenesGRP.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesGRP
            // 
            OrdenesGRP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenesGRP.Controls.Add(SalirBTN);
            OrdenesGRP.Controls.Add(OrdenesParaPrepararLST);
            OrdenesGRP.Controls.Add(ConfirmarBTN);
            OrdenesGRP.Location = new Point(14, 14);
            OrdenesGRP.Margin = new Padding(2);
            OrdenesGRP.Name = "OrdenesGRP";
            OrdenesGRP.Padding = new Padding(2);
            OrdenesGRP.Size = new Size(904, 693);
            OrdenesGRP.TabIndex = 0;
            OrdenesGRP.TabStop = false;
            OrdenesGRP.Text = "Detalle productos a empaquetar";
            // 
            // SalirBTN
            // 
            SalirBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirBTN.Location = new Point(713, 649);
            SalirBTN.Margin = new Padding(2);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(187, 40);
            SalirBTN.TabIndex = 2;
            SalirBTN.Text = "&Salir";
            SalirBTN.UseVisualStyleBackColor = true;
            SalirBTN.Click += Salirbtn_Click;
            // 
            // OrdenesParaPrepararLST
            // 
            OrdenesParaPrepararLST.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenesParaPrepararLST.Columns.AddRange(new ColumnHeader[] { SKUProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesParaPrepararLST.Location = new Point(4, 26);
            OrdenesParaPrepararLST.Margin = new Padding(2);
            OrdenesParaPrepararLST.Name = "OrdenesParaPrepararLST";
            OrdenesParaPrepararLST.Size = new Size(896, 619);
            OrdenesParaPrepararLST.TabIndex = 0;
            OrdenesParaPrepararLST.UseCompatibleStateImageBehavior = false;
            OrdenesParaPrepararLST.View = View.Details;
            OrdenesParaPrepararLST.SelectedIndexChanged += OrdenesParaPrepararLST_SelectedIndexChanged;
            // 
            // SKUProductoColumna
            // 
            SKUProductoColumna.Text = "SKU Producto";
            SKUProductoColumna.Width = 300;
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
            ConfirmarBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmarBTN.BackColor = Color.FromArgb(192, 255, 192);
            ConfirmarBTN.ForeColor = Color.Black;
            ConfirmarBTN.Location = new Point(4, 649);
            ConfirmarBTN.Margin = new Padding(2);
            ConfirmarBTN.Name = "ConfirmarBTN";
            ConfirmarBTN.Size = new Size(705, 40);
            ConfirmarBTN.TabIndex = 1;
            ConfirmarBTN.Text = "&Confirmar orden como preparada";
            ConfirmarBTN.UseVisualStyleBackColor = false;
            ConfirmarBTN.Click += Confirmarbtn_Click;
            // 
            // EmpaquetarOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 721);
            Controls.Add(OrdenesGRP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "EmpaquetarOrdenForm";
            Padding = new Padding(3);
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