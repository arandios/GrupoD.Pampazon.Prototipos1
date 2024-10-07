namespace Pampazon.MenuPrincipal
{
    partial class MenuPrincipalForm
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
            label1 = new Label();
            ConfirmarOrdenSeleccionBTN = new Button();
            GenerarOrdenDeSeleccionBTN = new Button();
            GenerarOrdenDeEntregabtn = new Button();
            GenerarRemitoBTN = new Button();
            Menu_ConsultarOrdenesBTN = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 20);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Menú inicial Pampazón S.A.";
            // 
            // ConfirmarOrdenSeleccionBTN
            // 
            ConfirmarOrdenSeleccionBTN.Location = new Point(223, 166);
            ConfirmarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenSeleccionBTN.Name = "ConfirmarOrdenSeleccionBTN";
            ConfirmarOrdenSeleccionBTN.Size = new Size(237, 28);
            ConfirmarOrdenSeleccionBTN.TabIndex = 2;
            ConfirmarOrdenSeleccionBTN.Text = "Confirmar Órden de Selección";
            ConfirmarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenSeleccionBTN.Click += ConfirmarOrdenSeleccionBTN_Click;
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Location = new Point(223, 134);
            GenerarOrdenDeSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(237, 28);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Órden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // GenerarOrdenDeEntregabtn
            // 
            GenerarOrdenDeEntregabtn.Location = new Point(223, 199);
            GenerarOrdenDeEntregabtn.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeEntregabtn.Name = "GenerarOrdenDeEntregabtn";
            GenerarOrdenDeEntregabtn.Size = new Size(237, 28);
            GenerarOrdenDeEntregabtn.TabIndex = 5;
            GenerarOrdenDeEntregabtn.Text = "Generar Órden de Entrega";
            GenerarOrdenDeEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeEntregabtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(223, 232);
            GenerarRemitoBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(237, 30);
            GenerarRemitoBTN.TabIndex = 6;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // Menu_ConsultarOrdenesBTN
            // 
            Menu_ConsultarOrdenesBTN.Location = new Point(223, 102);
            Menu_ConsultarOrdenesBTN.Margin = new Padding(3, 2, 3, 2);
            Menu_ConsultarOrdenesBTN.Name = "Menu_ConsultarOrdenesBTN";
            Menu_ConsultarOrdenesBTN.Size = new Size(237, 28);
            Menu_ConsultarOrdenesBTN.TabIndex = 1;
            Menu_ConsultarOrdenesBTN.Text = "Consultar ordenes";
            Menu_ConsultarOrdenesBTN.UseVisualStyleBackColor = true;
            Menu_ConsultarOrdenesBTN.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(223, 70);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(237, 28);
            button1.TabIndex = 7;
            button1.Text = "Generar Order Preparacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerarOrderPreparacionBtn;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 321);
            Controls.Add(button1);
            Controls.Add(GenerarRemitoBTN);
            Controls.Add(GenerarOrdenDeEntregabtn);
            Controls.Add(GenerarOrdenDeSeleccionBTN);
            Controls.Add(ConfirmarOrdenSeleccionBTN);
            Controls.Add(Menu_ConsultarOrdenesBTN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ConfirmarOrdenSeleccionBTN;
        private Button GenerarOrdenDeSeleccionBTN;
        private Button GenerarOrdenDeEntregabtn;
        private Button GenerarRemitoBTN;
        private Button Menu_ConsultarOrdenesBTN;
        private Button button1;
    }
}