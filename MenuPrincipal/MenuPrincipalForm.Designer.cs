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
            label1.Location = new Point(380, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "Menú inicial Pampazón S.A.";
            // 
            // ConfirmarOrdenSeleccionBTN
            // 
            ConfirmarOrdenSeleccionBTN.Location = new Point(319, 229);
            ConfirmarOrdenSeleccionBTN.Margin = new Padding(4, 3, 4, 3);
            ConfirmarOrdenSeleccionBTN.Name = "ConfirmarOrdenSeleccionBTN";
            ConfirmarOrdenSeleccionBTN.Size = new Size(339, 47);
            ConfirmarOrdenSeleccionBTN.TabIndex = 2;
            ConfirmarOrdenSeleccionBTN.Text = "Confirmar Órden de Selección";
            ConfirmarOrdenSeleccionBTN.UseVisualStyleBackColor = true;
            ConfirmarOrdenSeleccionBTN.Click += ConfirmarOrdenSeleccionBTN_Click;
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Location = new Point(319, 176);
            GenerarOrdenDeSeleccionBTN.Margin = new Padding(4, 3, 4, 3);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(339, 47);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Órden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // GenerarOrdenDeEntregabtn
            // 
            GenerarOrdenDeEntregabtn.Location = new Point(319, 332);
            GenerarOrdenDeEntregabtn.Margin = new Padding(4, 3, 4, 3);
            GenerarOrdenDeEntregabtn.Name = "GenerarOrdenDeEntregabtn";
            GenerarOrdenDeEntregabtn.Size = new Size(339, 47);
            GenerarOrdenDeEntregabtn.TabIndex = 5;
            GenerarOrdenDeEntregabtn.Text = "Generar Órden de Entrega";
            GenerarOrdenDeEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeEntregabtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(319, 438);
            GenerarRemitoBTN.Margin = new Padding(4, 3, 4, 3);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(339, 50);
            GenerarRemitoBTN.TabIndex = 6;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // Menu_ConsultarOrdenesBTN
            // 
            Menu_ConsultarOrdenesBTN.Location = new Point(319, 123);
            Menu_ConsultarOrdenesBTN.Margin = new Padding(4, 3, 4, 3);
            Menu_ConsultarOrdenesBTN.Name = "Menu_ConsultarOrdenesBTN";
            Menu_ConsultarOrdenesBTN.Size = new Size(339, 47);
            Menu_ConsultarOrdenesBTN.TabIndex = 1;
            Menu_ConsultarOrdenesBTN.Text = "Consultar ordenes";
            Menu_ConsultarOrdenesBTN.UseVisualStyleBackColor = true;
            Menu_ConsultarOrdenesBTN.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 70);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(339, 47);
            button1.TabIndex = 7;
            button1.Text = "Generar Order Preparacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerarOrderPreparacionBtn;
            // 
            // Confirmar_Orden_EntregaBTN
            // 
            Confirmar_Orden_EntregaBTN.Location = new Point(319, 385);
            Confirmar_Orden_EntregaBTN.Name = "Confirmar_Orden_EntregaBTN";
            Confirmar_Orden_EntregaBTN.Size = new Size(339, 47);
            Confirmar_Orden_EntregaBTN.TabIndex = 8;
            Confirmar_Orden_EntregaBTN.Text = "Confirmar Orden Entrega";
            Confirmar_Orden_EntregaBTN.UseVisualStyleBackColor = true;
            Confirmar_Orden_EntregaBTN.Click += Confirmar_Orden_EntregaBTN_Click;
            // 
            // EmpaquetarOrdenbtn
            // 
            EmpaquetarOrdenbtn.Location = new Point(319, 282);
            EmpaquetarOrdenbtn.Name = "EmpaquetarOrdenbtn";
            EmpaquetarOrdenbtn.Size = new Size(339, 44);
            EmpaquetarOrdenbtn.TabIndex = 9;
            EmpaquetarOrdenbtn.Text = "Empaquetar Órden de Preparación";
            EmpaquetarOrdenbtn.UseVisualStyleBackColor = true;
            EmpaquetarOrdenbtn.Click += EmpaquetarOrdenbtn_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 535);
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
            Margin = new Padding(4, 3, 4, 3);
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