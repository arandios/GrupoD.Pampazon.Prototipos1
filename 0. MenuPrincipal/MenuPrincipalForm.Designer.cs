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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            panelLogo = new Panel();
            Saludolbl = new Label();
            panelContenedor = new Panel();
            panelBotones = new Panel();
            BuscarProductoBTN = new Button();
            Menu_ConsultarOrdenesBTN = new Button();
            GenerarRemitoBTN = new Button();
            GenerarOrdenDeSeleccionBTN = new Button();
            button1 = new Button();
            SalirBTN = new Button();
            button2 = new Button();
            EmpaquetarOrdenbtn = new Button();
            GenerarOrdenDeEntregabtn = new Button();
            panelForms = new Panel();
            panelSubcontenedor = new Panel();
            panelContenedor.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelLogo.BackColor = Color.White;
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Location = new Point(1, 1);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(332, 58);
            panelLogo.TabIndex = 1;
            // 
            // Saludolbl
            // 
            Saludolbl.AutoSize = true;
            Saludolbl.Location = new Point(4, 59);
            Saludolbl.Name = "Saludolbl";
            Saludolbl.Size = new Size(38, 15);
            Saludolbl.TabIndex = 0;
            Saludolbl.Text = "label1";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaptionText;
            panelContenedor.Controls.Add(panelBotones);
            panelContenedor.Controls.Add(panelForms);
            panelContenedor.Controls.Add(panelSubcontenedor);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1282, 690);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panel5_Paint;
            // 
            // panelBotones
            // 
            panelBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBotones.AutoScroll = true;
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(Saludolbl);
            panelBotones.Controls.Add(BuscarProductoBTN);
            panelBotones.Controls.Add(panelLogo);
            panelBotones.Controls.Add(Menu_ConsultarOrdenesBTN);
            panelBotones.Controls.Add(GenerarRemitoBTN);
            panelBotones.Controls.Add(GenerarOrdenDeSeleccionBTN);
            panelBotones.Controls.Add(button1);
            panelBotones.Controls.Add(SalirBTN);
            panelBotones.Controls.Add(button2);
            panelBotones.Controls.Add(EmpaquetarOrdenbtn);
            panelBotones.Controls.Add(GenerarOrdenDeEntregabtn);
            panelBotones.ForeColor = Color.Teal;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Margin = new Padding(0);
            panelBotones.MaximumSize = new Size(1000, 1000);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(1);
            panelBotones.Size = new Size(335, 690);
            panelBotones.TabIndex = 1;
            // 
            // BuscarProductoBTN
            // 
            BuscarProductoBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuscarProductoBTN.ForeColor = SystemColors.ActiveCaptionText;
            BuscarProductoBTN.Location = new Point(0, 528);
            BuscarProductoBTN.Margin = new Padding(3, 2, 3, 2);
            BuscarProductoBTN.Name = "BuscarProductoBTN";
            BuscarProductoBTN.Size = new Size(333, 57);
            BuscarProductoBTN.TabIndex = 10;
            BuscarProductoBTN.Text = "Buscar productos";
            BuscarProductoBTN.UseVisualStyleBackColor = false;
            BuscarProductoBTN.Click += button3_Click;
            // 
            // Menu_ConsultarOrdenesBTN
            // 
            Menu_ConsultarOrdenesBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Menu_ConsultarOrdenesBTN.ForeColor = SystemColors.ActiveCaptionText;
            Menu_ConsultarOrdenesBTN.Location = new Point(1, 472);
            Menu_ConsultarOrdenesBTN.Margin = new Padding(3, 2, 3, 2);
            Menu_ConsultarOrdenesBTN.Name = "Menu_ConsultarOrdenesBTN";
            Menu_ConsultarOrdenesBTN.Size = new Size(333, 57);
            Menu_ConsultarOrdenesBTN.TabIndex = 9;
            Menu_ConsultarOrdenesBTN.Text = "Consultar ordenes";
            Menu_ConsultarOrdenesBTN.UseVisualStyleBackColor = false;
            Menu_ConsultarOrdenesBTN.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenerarRemitoBTN.ForeColor = SystemColors.ActiveCaptionText;
            GenerarRemitoBTN.Location = new Point(0, 367);
            GenerarRemitoBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(334, 57);
            GenerarRemitoBTN.TabIndex = 8;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = false;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenerarOrdenDeSeleccionBTN.ForeColor = SystemColors.ActiveCaptionText;
            GenerarOrdenDeSeleccionBTN.Location = new Point(0, 139);
            GenerarOrdenDeSeleccionBTN.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(334, 57);
            GenerarOrdenDeSeleccionBTN.TabIndex = 4;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Orden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = false;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(-1, 83);
            button1.Name = "button1";
            button1.Size = new Size(334, 57);
            button1.TabIndex = 3;
            button1.Text = "Generar Orden Preparacion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += GenerarOrderPreparacionBtn;
            // 
            // SalirBTN
            // 
            SalirBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalirBTN.BackColor = Color.IndianRed;
            SalirBTN.ForeColor = SystemColors.ActiveCaptionText;
            SalirBTN.Location = new Point(1, 624);
            SalirBTN.MaximumSize = new Size(1000, 1000);
            SalirBTN.Name = "SalirBTN";
            SalirBTN.Size = new Size(333, 57);
            SalirBTN.TabIndex = 11;
            SalirBTN.Text = "Salir";
            SalirBTN.UseVisualStyleBackColor = false;
            SalirBTN.Click += SalirBTN_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(0, 196);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(334, 57);
            button2.TabIndex = 5;
            button2.Text = "Buscar productos en depósitos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BuscarProductosEnDepositosBTN_Click;
            // 
            // EmpaquetarOrdenbtn
            // 
            EmpaquetarOrdenbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmpaquetarOrdenbtn.ForeColor = SystemColors.ActiveCaptionText;
            EmpaquetarOrdenbtn.Location = new Point(0, 253);
            EmpaquetarOrdenbtn.Margin = new Padding(2);
            EmpaquetarOrdenbtn.Name = "EmpaquetarOrdenbtn";
            EmpaquetarOrdenbtn.Size = new Size(334, 57);
            EmpaquetarOrdenbtn.TabIndex = 6;
            EmpaquetarOrdenbtn.Text = "Empaquetar Orden de Preparación";
            EmpaquetarOrdenbtn.UseVisualStyleBackColor = false;
            EmpaquetarOrdenbtn.Click += EmpaquetarOrdenbtn_Click;
            // 
            // GenerarOrdenDeEntregabtn
            // 
            GenerarOrdenDeEntregabtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenerarOrdenDeEntregabtn.ForeColor = SystemColors.ActiveCaptionText;
            GenerarOrdenDeEntregabtn.Location = new Point(0, 310);
            GenerarOrdenDeEntregabtn.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenDeEntregabtn.Name = "GenerarOrdenDeEntregabtn";
            GenerarOrdenDeEntregabtn.Size = new Size(334, 57);
            GenerarOrdenDeEntregabtn.TabIndex = 7;
            GenerarOrdenDeEntregabtn.Text = "Generar Orden de Entrega";
            GenerarOrdenDeEntregabtn.UseVisualStyleBackColor = false;
            GenerarOrdenDeEntregabtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // panelForms
            // 
            panelForms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelForms.AutoScroll = true;
            panelForms.BackColor = SystemColors.ButtonHighlight;
            panelForms.BackgroundImage = (Image)resources.GetObject("panelForms.BackgroundImage");
            panelForms.BackgroundImageLayout = ImageLayout.Center;
            panelForms.Location = new Point(334, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(948, 690);
            panelForms.TabIndex = 2;
            // 
            // panelSubcontenedor
            // 
            panelSubcontenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSubcontenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSubcontenedor.BackColor = SystemColors.ActiveCaption;
            panelSubcontenedor.Location = new Point(0, 57);
            panelSubcontenedor.Name = "panelSubcontenedor";
            panelSubcontenedor.Size = new Size(1282, 633);
            panelSubcontenedor.TabIndex = 2;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1282, 690);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Inicial Pampazón S.A.";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            panelContenedor.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLogo;
        private Panel panelContenedor;
        private Panel panelBotones;
        private Button GenerarRemitoBTN;
        private Button GenerarOrdenDeSeleccionBTN;
        private Button button2;
        private Button GenerarOrdenDeEntregabtn;
        private Button EmpaquetarOrdenbtn;
        private Button button1;
        private Button SalirBTN;
        private Button BuscarProductoBTN;
        private Button Menu_ConsultarOrdenesBTN;
        private Panel panelSubcontenedor;
        private Panel panelForms;
        private Label Saludolbl;
    }
}