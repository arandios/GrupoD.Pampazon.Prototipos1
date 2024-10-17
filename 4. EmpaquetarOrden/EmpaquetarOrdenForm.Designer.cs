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
            Ordenesgrb = new GroupBox();
            OrdenesParaPrepararlst = new ListView();
            SKUProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            Confirmarbtn = new Button();
            Salirbtn = new Button();
            Ordenesgrb.SuspendLayout();
            SuspendLayout();
            // 
            // Ordenesgrb
            // 
            Ordenesgrb.Controls.Add(OrdenesParaPrepararlst);
            Ordenesgrb.Location = new Point(38, 24);
            Ordenesgrb.Margin = new Padding(2, 2, 2, 2);
            Ordenesgrb.Name = "Ordenesgrb";
            Ordenesgrb.Padding = new Padding(2, 2, 2, 2);
            Ordenesgrb.Size = new Size(873, 803);
            Ordenesgrb.TabIndex = 0;
            Ordenesgrb.TabStop = false;
            Ordenesgrb.Text = "Detalle productos a empaquetar";
            // 
            // OrdenesParaPrepararlst
            // 
            OrdenesParaPrepararlst.Columns.AddRange(new ColumnHeader[] { SKUProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesParaPrepararlst.Location = new Point(28, 35);
            OrdenesParaPrepararlst.Margin = new Padding(2, 2, 2, 2);
            OrdenesParaPrepararlst.Name = "OrdenesParaPrepararlst";
            OrdenesParaPrepararlst.Size = new Size(825, 733);
            OrdenesParaPrepararlst.TabIndex = 0;
            OrdenesParaPrepararlst.UseCompatibleStateImageBehavior = false;
            OrdenesParaPrepararlst.View = View.Details;
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
            // Confirmarbtn
            // 
            Confirmarbtn.BackColor = Color.FromArgb(192, 255, 192);
            Confirmarbtn.ForeColor = Color.Black;
            Confirmarbtn.Location = new Point(343, 845);
            Confirmarbtn.Margin = new Padding(2, 2, 2, 2);
            Confirmarbtn.Name = "Confirmarbtn";
            Confirmarbtn.Size = new Size(280, 53);
            Confirmarbtn.TabIndex = 1;
            Confirmarbtn.Text = "&Confirmar orden como preparada";
            Confirmarbtn.UseVisualStyleBackColor = false;
            Confirmarbtn.Click += Confirmarbtn_Click;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(642, 845);
            Salirbtn.Margin = new Padding(2, 2, 2, 2);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(280, 53);
            Salirbtn.TabIndex = 2;
            Salirbtn.Text = "&Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // EmpaquetarOrdenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(Salirbtn);
            Controls.Add(Confirmarbtn);
            Controls.Add(Ordenesgrb);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EmpaquetarOrdenForm";
            Text = "Empaquetar Ordenes de Preparación";
            Ordenesgrb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Ordenesgrb;
        private ListView OrdenesParaPrepararlst;
        private ColumnHeader SKUProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader CantidadColumna;
        private Button Confirmarbtn;
        private Button Salirbtn;
    }
}