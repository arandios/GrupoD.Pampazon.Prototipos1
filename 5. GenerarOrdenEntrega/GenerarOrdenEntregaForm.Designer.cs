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
            SalirGenerarOEbtn.Location = new Point(757, 816);
            SalirGenerarOEbtn.Margin = new Padding(2, 3, 2, 3);
            SalirGenerarOEbtn.Name = "SalirGenerarOEbtn";
            SalirGenerarOEbtn.Size = new Size(214, 53);
            SalirGenerarOEbtn.TabIndex = 17;
            SalirGenerarOEbtn.Text = "&Salir";
            SalirGenerarOEbtn.UseVisualStyleBackColor = true;
            SalirGenerarOEbtn.Click += Salirbtn_Click;
            // 
            // GenerarOrdenEntregabtn
            // 
            GenerarOrdenEntregabtn.BackColor = Color.FromArgb(192, 255, 192);
            GenerarOrdenEntregabtn.Location = new Point(455, 816);
            GenerarOrdenEntregabtn.Margin = new Padding(2, 3, 2, 3);
            GenerarOrdenEntregabtn.Name = "GenerarOrdenEntregabtn";
            GenerarOrdenEntregabtn.Size = new Size(280, 53);
            GenerarOrdenEntregabtn.TabIndex = 16;
            GenerarOrdenEntregabtn.Text = "&Generar/ Confirmar Orden de Entrega";
            GenerarOrdenEntregabtn.UseVisualStyleBackColor = false;
            GenerarOrdenEntregabtn.Click += GenerarOrdenEntregabtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 219);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 23;
            // 
            // OrdenDespachoCMB
            // 
            OrdenDespachoCMB.Controls.Add(Orden_EntregaLST);
            OrdenDespachoCMB.Location = new Point(0, 35);
            OrdenDespachoCMB.Margin = new Padding(3, 4, 3, 4);
            OrdenDespachoCMB.Name = "OrdenDespachoCMB";
            OrdenDespachoCMB.Padding = new Padding(3, 4, 3, 4);
            OrdenDespachoCMB.Size = new Size(971, 774);
            OrdenDespachoCMB.TabIndex = 26;
            OrdenDespachoCMB.TabStop = false;
            OrdenDespachoCMB.Text = "Ordenes a despacho:";
            OrdenDespachoCMB.Enter += OrdenDespachoCMB_Enter;
            // 
            // Orden_EntregaLST
            // 
            Orden_EntregaLST.Location = new Point(12, 28);
            Orden_EntregaLST.Margin = new Padding(3, 4, 3, 4);
            Orden_EntregaLST.Name = "Orden_EntregaLST";
            Orden_EntregaLST.Size = new Size(956, 738);
            Orden_EntregaLST.TabIndex = 22;
            Orden_EntregaLST.UseCompatibleStateImageBehavior = false;
            Orden_EntregaLST.View = View.Details;
            Orden_EntregaLST.SelectedIndexChanged += Orden_Entrega_SelectedIndexChanged;
            // 
            // GenerarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(OrdenDespachoCMB);
            Controls.Add(GenerarOrdenEntregabtn);
            Controls.Add(label2);
            Controls.Add(SalirGenerarOEbtn);
            Margin = new Padding(2, 3, 2, 3);
            Name = "GenerarOrdenEntregaForm";
            Text = "Generar Orden de Entrega";
            Load += OrdenEntregaForm_Load;
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