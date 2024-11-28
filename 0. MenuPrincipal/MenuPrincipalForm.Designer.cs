namespace Pampazon.MenuPrincipal
{
    partial class MenuPrincipalForm
    {
        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            panelMenu = new Panel();
            iconoConsultarProd = new PictureBox();
            iconoConsultarOrdenes = new PictureBox();
            iconoRemito = new PictureBox();
            iconoOE = new PictureBox();
            iconoEmpaquetar = new PictureBox();
            iconoBD = new PictureBox();
            iconoGOS = new PictureBox();
            IconoOP = new PictureBox();
            ConsultarProductosBtn = new Button();
            ConsultarOrdenesbtn = new Button();
            GenerarRemitobtn = new Button();
            GenerarOEbtn = new Button();
            Empaquetarbtn = new Button();
            BuscarProductosbtn = new Button();
            GenerarOSbtn = new Button();
            GenerarOPbtn = new Button();
            pictureLogo = new PictureBox();
            panelSuperior = new Panel();
            NombreDePantallaLBL = new Label();
            Saludolbl = new Label();
            MinimizarBtn = new PictureBox();
            RestaurarBtn = new PictureBox();
            SalirBtn = new PictureBox();
            MaximizarBtn = new PictureBox();
            pictureBotonMenu = new PictureBox();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoConsultarProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoConsultarOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoRemito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoOE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoEmpaquetar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoBD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoGOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconoOP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinimizarBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestaurarBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalirBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximizarBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBotonMenu).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 76, 109);
            panelMenu.Controls.Add(iconoConsultarProd);
            panelMenu.Controls.Add(iconoConsultarOrdenes);
            panelMenu.Controls.Add(iconoRemito);
            panelMenu.Controls.Add(iconoOE);
            panelMenu.Controls.Add(iconoEmpaquetar);
            panelMenu.Controls.Add(iconoBD);
            panelMenu.Controls.Add(iconoGOS);
            panelMenu.Controls.Add(IconoOP);
            panelMenu.Controls.Add(ConsultarProductosBtn);
            panelMenu.Controls.Add(ConsultarOrdenesbtn);
            panelMenu.Controls.Add(GenerarRemitobtn);
            panelMenu.Controls.Add(GenerarOEbtn);
            panelMenu.Controls.Add(Empaquetarbtn);
            panelMenu.Controls.Add(BuscarProductosbtn);
            panelMenu.Controls.Add(GenerarOSbtn);
            panelMenu.Controls.Add(GenerarOPbtn);
            panelMenu.Controls.Add(pictureLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 750);
            panelMenu.TabIndex = 0;
            // 
            // iconoConsultarProd
            // 
            iconoConsultarProd.BackColor = Color.Transparent;
            iconoConsultarProd.BackgroundImageLayout = ImageLayout.None;
            iconoConsultarProd.Image = (Image)resources.GetObject("iconoConsultarProd.Image");
            iconoConsultarProd.Location = new Point(0, 453);
            iconoConsultarProd.Name = "iconoConsultarProd";
            iconoConsultarProd.Size = new Size(50, 50);
            iconoConsultarProd.SizeMode = PictureBoxSizeMode.Zoom;
            iconoConsultarProd.TabIndex = 4;
            iconoConsultarProd.TabStop = false;
            iconoConsultarProd.Click += BuscarProductos_Click;
            // 
            // iconoConsultarOrdenes
            // 
            iconoConsultarOrdenes.BackColor = Color.Transparent;
            iconoConsultarOrdenes.BackgroundImageLayout = ImageLayout.None;
            iconoConsultarOrdenes.Image = (Image)resources.GetObject("iconoConsultarOrdenes.Image");
            iconoConsultarOrdenes.Location = new Point(0, 397);
            iconoConsultarOrdenes.Name = "iconoConsultarOrdenes";
            iconoConsultarOrdenes.Size = new Size(50, 50);
            iconoConsultarOrdenes.SizeMode = PictureBoxSizeMode.Zoom;
            iconoConsultarOrdenes.TabIndex = 4;
            iconoConsultarOrdenes.TabStop = false;
            iconoConsultarOrdenes.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // iconoRemito
            // 
            iconoRemito.BackColor = Color.Transparent;
            iconoRemito.BackgroundImageLayout = ImageLayout.None;
            iconoRemito.Image = (Image)resources.GetObject("iconoRemito.Image");
            iconoRemito.Location = new Point(0, 341);
            iconoRemito.Name = "iconoRemito";
            iconoRemito.Size = new Size(50, 50);
            iconoRemito.SizeMode = PictureBoxSizeMode.Zoom;
            iconoRemito.TabIndex = 4;
            iconoRemito.TabStop = false;
            iconoRemito.Click += GenerarRemitoBTN_Click;
            // 
            // iconoOE
            // 
            iconoOE.BackColor = Color.Transparent;
            iconoOE.BackgroundImageLayout = ImageLayout.None;
            iconoOE.Image = (Image)resources.GetObject("iconoOE.Image");
            iconoOE.Location = new Point(0, 285);
            iconoOE.Name = "iconoOE";
            iconoOE.Size = new Size(50, 50);
            iconoOE.SizeMode = PictureBoxSizeMode.Zoom;
            iconoOE.TabIndex = 4;
            iconoOE.TabStop = false;
            iconoOE.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // iconoEmpaquetar
            // 
            iconoEmpaquetar.BackColor = Color.Transparent;
            iconoEmpaquetar.BackgroundImageLayout = ImageLayout.None;
            iconoEmpaquetar.Image = (Image)resources.GetObject("iconoEmpaquetar.Image");
            iconoEmpaquetar.Location = new Point(0, 229);
            iconoEmpaquetar.Name = "iconoEmpaquetar";
            iconoEmpaquetar.Size = new Size(50, 50);
            iconoEmpaquetar.SizeMode = PictureBoxSizeMode.Zoom;
            iconoEmpaquetar.TabIndex = 11;
            iconoEmpaquetar.TabStop = false;
            iconoEmpaquetar.Click += EmpaquetarOrdenbtn_Click;
            // 
            // iconoBD
            // 
            iconoBD.BackColor = Color.Transparent;
            iconoBD.BackgroundImageLayout = ImageLayout.None;
            iconoBD.Image = (Image)resources.GetObject("iconoBD.Image");
            iconoBD.Location = new Point(0, 173);
            iconoBD.Name = "iconoBD";
            iconoBD.Size = new Size(50, 50);
            iconoBD.SizeMode = PictureBoxSizeMode.Zoom;
            iconoBD.TabIndex = 10;
            iconoBD.TabStop = false;
            iconoBD.Click += BuscarProductosEnDepositosBTN_Click;
            // 
            // iconoGOS
            // 
            iconoGOS.BackColor = Color.Transparent;
            iconoGOS.BackgroundImageLayout = ImageLayout.None;
            iconoGOS.Image = (Image)resources.GetObject("iconoGOS.Image");
            iconoGOS.Location = new Point(0, 117);
            iconoGOS.Name = "iconoGOS";
            iconoGOS.Size = new Size(50, 50);
            iconoGOS.SizeMode = PictureBoxSizeMode.Zoom;
            iconoGOS.TabIndex = 9;
            iconoGOS.TabStop = false;
            iconoGOS.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // IconoOP
            // 
            IconoOP.BackColor = Color.Transparent;
            IconoOP.BackgroundImageLayout = ImageLayout.None;
            IconoOP.Image = (Image)resources.GetObject("IconoOP.Image");
            IconoOP.Location = new Point(0, 63);
            IconoOP.Name = "IconoOP";
            IconoOP.Size = new Size(50, 50);
            IconoOP.SizeMode = PictureBoxSizeMode.Zoom;
            IconoOP.TabIndex = 3;
            IconoOP.TabStop = false;
            IconoOP.Click += GenerarOrderPreparacionBtn;
            // 
            // ConsultarProductosBtn
            // 
            ConsultarProductosBtn.FlatAppearance.BorderSize = 0;
            ConsultarProductosBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            ConsultarProductosBtn.FlatStyle = FlatStyle.Flat;
            ConsultarProductosBtn.ForeColor = Color.White;
            ConsultarProductosBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultarProductosBtn.Location = new Point(0, 453);
            ConsultarProductosBtn.Name = "ConsultarProductosBtn";
            ConsultarProductosBtn.RightToLeft = RightToLeft.No;
            ConsultarProductosBtn.Size = new Size(300, 50);
            ConsultarProductosBtn.TabIndex = 8;
            ConsultarProductosBtn.Text = "Consultar Producto";
            ConsultarProductosBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ConsultarProductosBtn.UseVisualStyleBackColor = true;
            ConsultarProductosBtn.Click += BuscarProductos_Click;
            // 
            // ConsultarOrdenesbtn
            // 
            ConsultarOrdenesbtn.FlatAppearance.BorderSize = 0;
            ConsultarOrdenesbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            ConsultarOrdenesbtn.FlatStyle = FlatStyle.Flat;
            ConsultarOrdenesbtn.ForeColor = Color.White;
            ConsultarOrdenesbtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultarOrdenesbtn.Location = new Point(0, 397);
            ConsultarOrdenesbtn.Name = "ConsultarOrdenesbtn";
            ConsultarOrdenesbtn.RightToLeft = RightToLeft.No;
            ConsultarOrdenesbtn.Size = new Size(300, 50);
            ConsultarOrdenesbtn.TabIndex = 7;
            ConsultarOrdenesbtn.Text = "Consultar Ordenes";
            ConsultarOrdenesbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ConsultarOrdenesbtn.UseVisualStyleBackColor = true;
            ConsultarOrdenesbtn.Click += Menu_ConsultarOrdenesBTN_Click;
            // 
            // GenerarRemitobtn
            // 
            GenerarRemitobtn.FlatAppearance.BorderSize = 0;
            GenerarRemitobtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            GenerarRemitobtn.FlatStyle = FlatStyle.Flat;
            GenerarRemitobtn.ForeColor = Color.White;
            GenerarRemitobtn.ImageAlign = ContentAlignment.MiddleLeft;
            GenerarRemitobtn.Location = new Point(0, 341);
            GenerarRemitobtn.Name = "GenerarRemitobtn";
            GenerarRemitobtn.RightToLeft = RightToLeft.No;
            GenerarRemitobtn.Size = new Size(300, 50);
            GenerarRemitobtn.TabIndex = 6;
            GenerarRemitobtn.Text = "Generar Remito";
            GenerarRemitobtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            GenerarRemitobtn.UseVisualStyleBackColor = true;
            GenerarRemitobtn.Click += GenerarRemitoBTN_Click;
            // 
            // GenerarOEbtn
            // 
            GenerarOEbtn.FlatAppearance.BorderSize = 0;
            GenerarOEbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            GenerarOEbtn.FlatStyle = FlatStyle.Flat;
            GenerarOEbtn.ForeColor = Color.White;
            GenerarOEbtn.ImageAlign = ContentAlignment.MiddleLeft;
            GenerarOEbtn.Location = new Point(0, 285);
            GenerarOEbtn.Name = "GenerarOEbtn";
            GenerarOEbtn.RightToLeft = RightToLeft.No;
            GenerarOEbtn.Size = new Size(300, 50);
            GenerarOEbtn.TabIndex = 5;
            GenerarOEbtn.Text = "Generar Orden de Entrega";
            GenerarOEbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            GenerarOEbtn.UseVisualStyleBackColor = true;
            GenerarOEbtn.Click += GenerarOrdenDeEntregabtn_Click;
            // 
            // Empaquetarbtn
            // 
            Empaquetarbtn.FlatAppearance.BorderSize = 0;
            Empaquetarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Empaquetarbtn.FlatStyle = FlatStyle.Flat;
            Empaquetarbtn.ForeColor = Color.White;
            Empaquetarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Empaquetarbtn.Location = new Point(0, 229);
            Empaquetarbtn.Name = "Empaquetarbtn";
            Empaquetarbtn.RightToLeft = RightToLeft.No;
            Empaquetarbtn.Size = new Size(300, 50);
            Empaquetarbtn.TabIndex = 4;
            Empaquetarbtn.Text = "Empaquetar Orden de Preparacion";
            Empaquetarbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            Empaquetarbtn.UseVisualStyleBackColor = true;
            Empaquetarbtn.Click += EmpaquetarOrdenbtn_Click;
            // 
            // BuscarProductosbtn
            // 
            BuscarProductosbtn.FlatAppearance.BorderSize = 0;
            BuscarProductosbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            BuscarProductosbtn.FlatStyle = FlatStyle.Flat;
            BuscarProductosbtn.ForeColor = Color.White;
            BuscarProductosbtn.ImageAlign = ContentAlignment.MiddleLeft;
            BuscarProductosbtn.Location = new Point(0, 173);
            BuscarProductosbtn.Name = "BuscarProductosbtn";
            BuscarProductosbtn.RightToLeft = RightToLeft.No;
            BuscarProductosbtn.Size = new Size(302, 50);
            BuscarProductosbtn.TabIndex = 3;
            BuscarProductosbtn.Text = "Buscar Productos en Deposito";
            BuscarProductosbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            BuscarProductosbtn.UseVisualStyleBackColor = true;
            BuscarProductosbtn.Click += BuscarProductosEnDepositosBTN_Click;
            // 
            // GenerarOSbtn
            // 
            GenerarOSbtn.FlatAppearance.BorderSize = 0;
            GenerarOSbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            GenerarOSbtn.FlatStyle = FlatStyle.Flat;
            GenerarOSbtn.ForeColor = Color.White;
            GenerarOSbtn.ImageAlign = ContentAlignment.MiddleLeft;
            GenerarOSbtn.Location = new Point(2, 117);
            GenerarOSbtn.Name = "GenerarOSbtn";
            GenerarOSbtn.RightToLeft = RightToLeft.No;
            GenerarOSbtn.Size = new Size(300, 50);
            GenerarOSbtn.TabIndex = 2;
            GenerarOSbtn.Text = "Generar Orden de Seleccion";
            GenerarOSbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            GenerarOSbtn.UseVisualStyleBackColor = true;
            GenerarOSbtn.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // GenerarOPbtn
            // 
            GenerarOPbtn.FlatAppearance.BorderSize = 0;
            GenerarOPbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            GenerarOPbtn.FlatStyle = FlatStyle.Flat;
            GenerarOPbtn.ForeColor = Color.White;
            GenerarOPbtn.ImageAlign = ContentAlignment.MiddleLeft;
            GenerarOPbtn.Location = new Point(2, 63);
            GenerarOPbtn.Name = "GenerarOPbtn";
            GenerarOPbtn.RightToLeft = RightToLeft.No;
            GenerarOPbtn.Size = new Size(300, 50);
            GenerarOPbtn.TabIndex = 1;
            GenerarOPbtn.Text = "Generar Orden de Preparacion";
            GenerarOPbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            GenerarOPbtn.UseVisualStyleBackColor = true;
            GenerarOPbtn.Click += GenerarOrderPreparacionBtn;
            // 
            // pictureLogo
            // 
            pictureLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureLogo.BackColor = Color.White;
            pictureLogo.Image = Properties.Resources.Diseño_sin_título;
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(300, 50);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(0, 76, 109);
            panelSuperior.Controls.Add(NombreDePantallaLBL);
            panelSuperior.Controls.Add(Saludolbl);
            panelSuperior.Controls.Add(MinimizarBtn);
            panelSuperior.Controls.Add(RestaurarBtn);
            panelSuperior.Controls.Add(SalirBtn);
            panelSuperior.Controls.Add(MaximizarBtn);
            panelSuperior.Controls.Add(pictureBotonMenu);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(300, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(900, 50);
            panelSuperior.TabIndex = 1;
            panelSuperior.MouseDown += panelSuperior_MouseDown;
            // 
            // NombreDePantallaLBL
            // 
            NombreDePantallaLBL.Anchor = AnchorStyles.None;
            NombreDePantallaLBL.AutoSize = true;
            NombreDePantallaLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombreDePantallaLBL.ForeColor = Color.White;
            NombreDePantallaLBL.Location = new Point(381, 9);
            NombreDePantallaLBL.Name = "NombreDePantallaLBL";
            NombreDePantallaLBL.Size = new Size(179, 30);
            NombreDePantallaLBL.TabIndex = 6;
            NombreDePantallaLBL.Text = "Nombre pantalla";
            NombreDePantallaLBL.Visible = false;
            // 
            // Saludolbl
            // 
            Saludolbl.AutoSize = true;
            Saludolbl.ForeColor = Color.White;
            Saludolbl.Location = new Point(48, 26);
            Saludolbl.Name = "Saludolbl";
            Saludolbl.Size = new Size(38, 15);
            Saludolbl.TabIndex = 5;
            Saludolbl.Text = "label1";
            // 
            // MinimizarBtn
            // 
            MinimizarBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizarBtn.Image = Properties.Resources.Minimizar;
            MinimizarBtn.Location = new Point(801, 9);
            MinimizarBtn.Name = "MinimizarBtn";
            MinimizarBtn.Size = new Size(25, 25);
            MinimizarBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizarBtn.TabIndex = 4;
            MinimizarBtn.TabStop = false;
            MinimizarBtn.Click += MinimizarBtn_Click;
            // 
            // RestaurarBtn
            // 
            RestaurarBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestaurarBtn.Image = Properties.Resources.Normailzar;
            RestaurarBtn.Location = new Point(832, 9);
            RestaurarBtn.Name = "RestaurarBtn";
            RestaurarBtn.Size = new Size(25, 25);
            RestaurarBtn.SizeMode = PictureBoxSizeMode.Zoom;
            RestaurarBtn.TabIndex = 3;
            RestaurarBtn.TabStop = false;
            RestaurarBtn.Visible = false;
            RestaurarBtn.Click += RestaurarBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalirBtn.Image = Properties.Resources.Salir;
            SalirBtn.Location = new Point(863, 9);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(25, 25);
            SalirBtn.SizeMode = PictureBoxSizeMode.Zoom;
            SalirBtn.TabIndex = 2;
            SalirBtn.TabStop = false;
            SalirBtn.Click += pictureBox1_Click;
            // 
            // MaximizarBtn
            // 
            MaximizarBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizarBtn.Image = (Image)resources.GetObject("MaximizarBtn.Image");
            MaximizarBtn.Location = new Point(832, 9);
            MaximizarBtn.Name = "MaximizarBtn";
            MaximizarBtn.Size = new Size(25, 25);
            MaximizarBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MaximizarBtn.TabIndex = 1;
            MaximizarBtn.TabStop = false;
            MaximizarBtn.Click += MaximizarBtn_Click;
            // 
            // pictureBotonMenu
            // 
            pictureBotonMenu.Image = (Image)resources.GetObject("pictureBotonMenu.Image");
            pictureBotonMenu.Location = new Point(6, 9);
            pictureBotonMenu.Name = "pictureBotonMenu";
            pictureBotonMenu.Size = new Size(35, 35);
            pictureBotonMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBotonMenu.TabIndex = 0;
            pictureBotonMenu.TabStop = false;
            pictureBotonMenu.Click += pictureBotonMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoScroll = true;
            panelContenedor.AutoSize = true;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(300, 50);
            panelContenedor.MinimumSize = new Size(900, 700);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(900, 700);
            panelContenedor.TabIndex = 2;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1200, 750);
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(2500, 2500);
            Name = "MenuPrincipalForm";
            Text = "App";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconoConsultarProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoConsultarOrdenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoRemito).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoOE).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoEmpaquetar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoBD).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoGOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconoOP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinimizarBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestaurarBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalirBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximizarBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBotonMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelSuperior;
        private Panel panelContenedor;
        private PictureBox pictureLogo;
        private PictureBox pictureBotonMenu;
        private PictureBox MinimizarBtn;
        private PictureBox RestaurarBtn;
        private PictureBox SalirBtn;
        private PictureBox MaximizarBtn;
        private Button GenerarOPbtn;
        private Button ConsultarProductosBtn;
        private Button ConsultarOrdenesbtn;
        private Button GenerarRemitobtn;
        private Button GenerarOEbtn;
        private Button Empaquetarbtn;
        private Button BuscarProductosbtn;
        private Button GenerarOSbtn;
        private Label Saludolbl;
        private PictureBox iconoBD;
        private PictureBox iconoGOS;
        private PictureBox IconoOP;
        private PictureBox iconoRemito;
        private PictureBox iconoOE;
        private PictureBox iconoEmpaquetar;
        private PictureBox iconoConsultarOrdenes;
        private PictureBox iconoConsultarProd;
        private Label NombreDePantallaLBL;
    }
}