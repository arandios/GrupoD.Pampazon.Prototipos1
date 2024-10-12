﻿namespace Pampazon.MenuPrincipal
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
            GenerarOrdenDeSeleccionBTN = new Button();
            GenerarOrdenDeEntregabtn = new Button();
            GenerarRemitoBTN = new Button();
            Menu_ConsultarOrdenesBTN = new Button();
            button1 = new Button();
            EmpaquetarOrdenbtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Menú inicial Pampazón S.A.";
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Location = new Point(255, 128);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(271, 37);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Orden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // GenerarOrdenDeEntregabtn
            // 
            GenerarOrdenDeEntregabtn.Location = new Point(255, 347);
            GenerarOrdenDeEntregabtn.Name = "GenerarOrdenDeEntregabtn";
            GenerarOrdenDeEntregabtn.Size = new Size(271, 37);
            GenerarOrdenDeEntregabtn.TabIndex = 6;
            GenerarOrdenDeEntregabtn.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregabtn.UseVisualStyleBackColor = true;
            GenerarOrdenDeEntregabtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(255, 430);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(271, 40);
            GenerarRemitoBTN.TabIndex = 8;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // Menu_ConsultarOrdenesBTN
            // 
            Menu_ConsultarOrdenesBTN.Location = new Point(255, 631);
            Menu_ConsultarOrdenesBTN.Name = "Menu_ConsultarOrdenesBTN";
            Menu_ConsultarOrdenesBTN.Size = new Size(271, 37);
            Menu_ConsultarOrdenesBTN.TabIndex = 2;
            Menu_ConsultarOrdenesBTN.Text = "Consultar ordenes";
            Menu_ConsultarOrdenesBTN.UseVisualStyleBackColor = true;
            Menu_ConsultarOrdenesBTN.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(255, 56);
            button1.Name = "button1";
            button1.Size = new Size(271, 37);
            button1.TabIndex = 1;
            button1.Text = "Generar Orden Preparacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerarOrderPreparacionBtn;
            // 
            // EmpaquetarOrdenbtn
            // 
            EmpaquetarOrdenbtn.Location = new Point(255, 271);
            EmpaquetarOrdenbtn.Margin = new Padding(2, 3, 2, 3);
            EmpaquetarOrdenbtn.Name = "EmpaquetarOrdenbtn";
            EmpaquetarOrdenbtn.Size = new Size(271, 35);
            EmpaquetarOrdenbtn.TabIndex = 5;
            EmpaquetarOrdenbtn.Text = "Empaquetar Orden de Preparación";
            EmpaquetarOrdenbtn.UseVisualStyleBackColor = true;
            EmpaquetarOrdenbtn.Click += EmpaquetarOrdenbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 200);
            button2.Name = "button2";
            button2.Size = new Size(271, 37);
            button2.TabIndex = 9;
            button2.Text = "Buscar productos en depósitos";
            button2.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 693);
            Controls.Add(button2);
            Controls.Add(EmpaquetarOrdenbtn);
            Controls.Add(button1);
            Controls.Add(GenerarRemitoBTN);
            Controls.Add(GenerarOrdenDeEntregabtn);
            Controls.Add(GenerarOrdenDeSeleccionBTN);
            Controls.Add(Menu_ConsultarOrdenesBTN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GenerarOrdenDeSeleccionBTN;
        private Button GenerarOrdenDeEntregabtn;
        private Button GenerarRemitoBTN;
        private Button Menu_ConsultarOrdenesBTN;
        private Button button1;
        private Button EmpaquetarOrdenbtn;
        private Button button2;
    }
}