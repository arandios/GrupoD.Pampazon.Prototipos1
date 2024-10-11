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
            Confirmar_Orden_EntregaBTN = new Button();
            EmpaquetarOrdenbtn = new Button();
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
            ConfirmarOrdenSeleccionBTN.Location = new Point(223, 137);
            ConfirmarOrdenSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenSeleccionBTN.Name = "ConfirmarOrdenSeleccionBTN";
            ConfirmarOrdenSeleccionBTN.Size = new Size(237, 28);
            ConfirmarOrdenSeleccionBTN.TabIndex = 4;
            ConfirmarOrdenSeleccionBTN.Text = "Confirmar Orden de Selección";
            ConfirmarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenSeleccionBTN.Click += ConfirmarOrdenSeleccionBTN_Click;
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Location = new Point(223, 106);
            GenerarOrdenDeSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(237, 28);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Orden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // GenerarOrdenDeEntregabtn
            // 
            GenerarOrdenDeEntregabtn.Location = new Point(223, 200);
            GenerarOrdenDeEntregabtn.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeEntregabtn.Name = "GenerarOrdenDeEntregabtn";
            GenerarOrdenDeEntregabtn.Size = new Size(237, 28);
            GenerarOrdenDeEntregabtn.TabIndex = 6;
            GenerarOrdenDeEntregabtn.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeEntregabtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(223, 262);
            GenerarRemitoBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(237, 30);
            GenerarRemitoBTN.TabIndex = 8;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // Menu_ConsultarOrdenesBTN
            // 
            Menu_ConsultarOrdenesBTN.Location = new Point(223, 74);
            Menu_ConsultarOrdenesBTN.Margin = new Padding(3, 2, 3, 2);
            Menu_ConsultarOrdenesBTN.Name = "Menu_ConsultarOrdenesBTN";
            Menu_ConsultarOrdenesBTN.Size = new Size(237, 28);
            Menu_ConsultarOrdenesBTN.TabIndex = 2;
            Menu_ConsultarOrdenesBTN.Text = "Consultar ordenes";
            Menu_ConsultarOrdenesBTN.UseVisualStyleBackColor = true;
            Menu_ConsultarOrdenesBTN.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(223, 42);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(237, 28);
            button1.TabIndex = 1;
            button1.Text = "Generar Orden Preparacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerarOrderPreparacionBtn;
            // 
            // Confirmar_Orden_EntregaBTN
            // 
            Confirmar_Orden_EntregaBTN.Location = new Point(223, 231);
            Confirmar_Orden_EntregaBTN.Margin = new Padding(2);
            Confirmar_Orden_EntregaBTN.Name = "Confirmar_Orden_EntregaBTN";
            Confirmar_Orden_EntregaBTN.Size = new Size(237, 28);
            Confirmar_Orden_EntregaBTN.TabIndex = 7;
            Confirmar_Orden_EntregaBTN.Text = "Confirmar Orden Entrega";
            Confirmar_Orden_EntregaBTN.UseVisualStyleBackColor = true;
            Confirmar_Orden_EntregaBTN.Click += Confirmar_Orden_EntregaBTN_Click;
            // 
            // EmpaquetarOrdenbtn
            // 
            EmpaquetarOrdenbtn.Location = new Point(223, 170);
            EmpaquetarOrdenbtn.Margin = new Padding(2);
            EmpaquetarOrdenbtn.Name = "EmpaquetarOrdenbtn";
            EmpaquetarOrdenbtn.Size = new Size(237, 26);
            EmpaquetarOrdenbtn.TabIndex = 5;
            EmpaquetarOrdenbtn.Text = "Empaquetar Orden de Preparación";
            EmpaquetarOrdenbtn.UseVisualStyleBackColor = true;
            EmpaquetarOrdenbtn.Click += EmpaquetarOrdenbtn_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 321);
            Controls.Add(EmpaquetarOrdenbtn);
            Controls.Add(Confirmar_Orden_EntregaBTN);
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
        private Button Confirmar_Orden_EntregaBTN;
        private Button EmpaquetarOrdenbtn;
    }
}