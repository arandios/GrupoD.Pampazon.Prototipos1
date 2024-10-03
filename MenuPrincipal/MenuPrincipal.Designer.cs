namespace Pampazon.MenuPrincipal
{
    partial class MenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            GenerarOrdenDeSeleccionBTN = new Button();
            button4 = new Button();
            button5 = new Button();
            GenerarRemitoBTN = new Button();
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
            // button1
            // 
            button1.Location = new Point(256, 97);
            button1.Name = "button1";
            button1.Size = new Size(271, 38);
            button1.TabIndex = 1;
            button1.Text = "1. Registrar Órden de Preparación";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(256, 229);
            button2.Name = "button2";
            button2.Size = new Size(271, 38);
            button2.TabIndex = 2;
            button2.Text = "Confirmar Órden de Selección";
            button2.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenDeSeleccionBTN
            // 
            GenerarOrdenDeSeleccionBTN.Location = new Point(256, 141);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(271, 38);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "2. Generar Órden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // button4
            // 
            button4.Location = new Point(256, 185);
            button4.Name = "button4";
            button4.Size = new Size(271, 38);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(256, 273);
            button5.Name = "button5";
            button5.Size = new Size(271, 38);
            button5.TabIndex = 5;
            button5.Text = "Generar Órden de Entrega";
            button5.UseVisualStyleBackColor = true;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(256, 317);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(271, 38);
            GenerarRemitoBTN.TabIndex = 6;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenerarRemitoBTN);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(GenerarOrdenDeSeleccionBTN);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button GenerarOrdenDeSeleccionBTN;
        private Button button4;
        private Button button5;
        private Button GenerarRemitoBTN;
    }
}