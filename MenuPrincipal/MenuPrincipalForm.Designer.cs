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
            button5 = new Button();
            GenerarRemitoBTN = new Button();
            button1 = new Button();
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
            ConfirmarOrdenSeleccionBTN.Location = new Point(320, 230);
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
            GenerarOrdenDeSeleccionBTN.Location = new Point(320, 177);
            GenerarOrdenDeSeleccionBTN.Margin = new Padding(4, 3, 4, 3);
            GenerarOrdenDeSeleccionBTN.Name = "GenerarOrdenDeSeleccionBTN";
            GenerarOrdenDeSeleccionBTN.Size = new Size(339, 47);
            GenerarOrdenDeSeleccionBTN.TabIndex = 3;
            GenerarOrdenDeSeleccionBTN.Text = "Generar Órden de Selección";
            GenerarOrdenDeSeleccionBTN.UseVisualStyleBackColor = true;
            GenerarOrdenDeSeleccionBTN.Click += GenerarOrdenDeSeleccionBTN_Click;
            // 
            // button5
            // 
            button5.Location = new Point(320, 285);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(339, 47);
            button5.TabIndex = 5;
            button5.Text = "Generar Órden de Entrega";
            button5.UseVisualStyleBackColor = true;
            // 
            // GenerarRemitoBTN
            // 
            GenerarRemitoBTN.Location = new Point(320, 340);
            GenerarRemitoBTN.Margin = new Padding(4, 3, 4, 3);
            GenerarRemitoBTN.Name = "GenerarRemitoBTN";
            GenerarRemitoBTN.Size = new Size(339, 50);
            GenerarRemitoBTN.TabIndex = 6;
            GenerarRemitoBTN.Text = "Generar Remito";
            GenerarRemitoBTN.UseVisualStyleBackColor = true;
            GenerarRemitoBTN.Click += GenerarRemitoBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(320, 122);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(339, 47);
            button1.TabIndex = 1;
            button1.Text = "Consultar ordenes";
            button1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 535);
            Controls.Add(GenerarRemitoBTN);
            Controls.Add(button5);
            Controls.Add(GenerarOrdenDeSeleccionBTN);
            Controls.Add(ConfirmarOrdenSeleccionBTN);
            Controls.Add(button1);
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
        private Button button5;
        private Button GenerarRemitoBTN;
        private Button button1;
    }
}