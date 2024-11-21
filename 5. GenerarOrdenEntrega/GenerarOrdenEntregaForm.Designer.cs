namespace Pampazon.OrdenEntrega
{
    partial class GenerarOrdenEntregaForm
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
            SalirGenerarOEbtn = new Button();
            GenerarOrdenEntregabtn = new Button();
            label2 = new Label();
            OrdenDespachoCMB = new GroupBox();
            Orden_EntregaLST = new ListView();
            OrdenDespachoCMB.SuspendLayout();
            SuspendLayout();
            // 
            // SalirGenerarOEbtn
            // 
            SalirGenerarOEbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirGenerarOEbtn.Location = new Point(608, 605);
            SalirGenerarOEbtn.Margin = new Padding(2);
            SalirGenerarOEbtn.Name = "SalirGenerarOEbtn";
            SalirGenerarOEbtn.Size = new Size(240, 40);
            SalirGenerarOEbtn.TabIndex = 17;
            SalirGenerarOEbtn.Text = "&Salir";
            SalirGenerarOEbtn.UseVisualStyleBackColor = true;
            SalirGenerarOEbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GenerarOrdenEntregabtn.BackColor = Color.FromArgb(192, 255, 192);
            GenerarOrdenEntregabtn.Location = new Point(10, 606);
            GenerarOrdenEntregabtn.Margin = new Padding(2);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(594, 40);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "&Generar/ Confirmar Orden de Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = false;
            GenerarOrdenEntregabtn.Click += GenerarOrdenEntregabtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 167);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // OrdenDespachoCMB
            // 
            OrdenDespachoCMB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdenDespachoCMB.Controls.Add(Orden_EntregaLST);
            OrdenDespachoCMB.Location = new Point(0, 6);
            OrdenDespachoCMB.Name = "OrdenDespachoCMB";
            OrdenDespachoCMB.Size = new Size(854, 600);
            OrdenDespachoCMB.TabIndex = 26;
            OrdenDespachoCMB.TabStop = false;
            OrdenDespachoCMB.Text = "Ordenes a despacho:";
            // 
            // Orden_EntregaLST
            // 
            Orden_EntregaLST.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Orden_EntregaLST.Location = new Point(10, 21);
            Orden_EntregaLST.Name = "Orden_EntregaLST";
            Orden_EntregaLST.Size = new Size(838, 573);
            Orden_EntregaLST.TabIndex = 22;
            Orden_EntregaLST.UseCompatibleStateImageBehavior = false;
            Orden_EntregaLST.View = View.Details;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 651);
            Controls.Add(OrdenDespachoCMB);
            Controls.Add(GenerarOrdenEntregabtn);
            Controls.Add(label2);
            Controls.Add(SalirGenerarOEbtn);
            Margin = new Padding(2);
            Name = "GenerarOrdenEntregaForm";
            Padding = new Padding(3);
            Text = "Generar Orden de Entrega";
            OrdenDespachoCMB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SalirGenerarOEbtn;
        private Button GenerarOrdenEntregabtn;
        private Label label2;
        private GroupBox OrdenDespachoCMB;
        private ListView Orden_EntregaLST;
    }
}