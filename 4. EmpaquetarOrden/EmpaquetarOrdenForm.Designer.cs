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
            Ordenesgrb.Location = new Point(47, 30);
            Ordenesgrb.Name = "Ordenesgrb";
            Ordenesgrb.Size = new Size(1091, 446);
            Ordenesgrb.TabIndex = 0;
            Ordenesgrb.TabStop = false;
            Ordenesgrb.Text = "Detalle productos a empaquetar";
            // 
            // OrdenesParaPrepararlst
            // 
            OrdenesParaPrepararlst.Columns.AddRange(new ColumnHeader[] { SKUProductoColumna, ProductoColumna, CantidadColumna });
            OrdenesParaPrepararlst.Location = new Point(35, 44);
            OrdenesParaPrepararlst.Name = "OrdenesParaPrepararlst";
            OrdenesParaPrepararlst.Size = new Size(1030, 379);
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
            Confirmarbtn.ForeColor = Color.Black;
            Confirmarbtn.Location = new Point(542, 489);
            Confirmarbtn.Name = "Confirmarbtn";
            Confirmarbtn.Size = new Size(294, 91);
            Confirmarbtn.TabIndex = 1;
            Confirmarbtn.Text = "&Confirmar orden como preparada";
            Confirmarbtn.UseVisualStyleBackColor = true;
            Confirmarbtn.Click += Confirmarbtn_Click;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(861, 490);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(255, 90);
            Salirbtn.TabIndex = 2;
            Salirbtn.Text = "&Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // EmpaquetarOrdenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 592);
            Controls.Add(Salirbtn);
            Controls.Add(Confirmarbtn);
            Controls.Add(Ordenesgrb);
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