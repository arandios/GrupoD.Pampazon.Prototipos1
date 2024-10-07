namespace Pampazon.EmpaquetarOrden
{
    partial class EmpaquetarOrdenesForm
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
            Codigogrb = new GroupBox();
            btnBuscar = new Button();
            OrdenesParaPrepararlst = new ListView();
            CodigoOrdenColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            OrdenesPreparacionlst = new ListView();
            IdProductoColumna = new ColumnHeader();
            ProductoColumna = new ColumnHeader();
            DetalleColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            ConfirmarOrdenPreparadabtn = new Button();
            VolverMenubtn = new Button();
            SeleccionarOtraOrdenbtn = new Button();
            Codigogrb.SuspendLayout();
            SuspendLayout();
            // 
            // Codigogrb
            // 
            Codigogrb.Controls.Add(btnBuscar);
            Codigogrb.Controls.Add(OrdenesParaPrepararlst);
            Codigogrb.Location = new Point(12, 12);
            Codigogrb.Name = "Codigogrb";
            Codigogrb.Size = new Size(363, 419);
            Codigogrb.TabIndex = 0;
            Codigogrb.TabStop = false;
            Codigogrb.Text = "Ordenes de preparacion para empaquetar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(145, 374);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(197, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Ver detalle de la orden";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // OrdenesParaPrepararlst
            // 
            OrdenesParaPrepararlst.Columns.AddRange(new ColumnHeader[] { CodigoOrdenColumna, PrioridadColumna });
            OrdenesParaPrepararlst.FullRowSelect = true;
            OrdenesParaPrepararlst.Location = new Point(16, 30);
            OrdenesParaPrepararlst.MultiSelect = false;
            OrdenesParaPrepararlst.Name = "OrdenesParaPrepararlst";
            OrdenesParaPrepararlst.Size = new Size(327, 331);
            OrdenesParaPrepararlst.TabIndex = 0;
            OrdenesParaPrepararlst.UseCompatibleStateImageBehavior = false;
            OrdenesParaPrepararlst.View = View.Details;
            // 
            // CodigoOrdenColumna
            // 
            CodigoOrdenColumna.Text = "Codigo Orden";
            CodigoOrdenColumna.Width = 200;
            // 
            // PrioridadColumna
            // 
            PrioridadColumna.Text = "Prioridad";
            PrioridadColumna.Width = 100;
            // 
            // OrdenesPreparacionlst
            // 
            OrdenesPreparacionlst.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, ProductoColumna, DetalleColumna, CantidadColumna });
            OrdenesPreparacionlst.Location = new Point(397, 33);
            OrdenesPreparacionlst.MultiSelect = false;
            OrdenesPreparacionlst.Name = "OrdenesPreparacionlst";
            OrdenesPreparacionlst.Size = new Size(765, 258);
            OrdenesPreparacionlst.TabIndex = 1;
            OrdenesPreparacionlst.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionlst.View = View.Details;
            // 
            // IdProductoColumna
            // 
            IdProductoColumna.Text = "Id Producto";
            IdProductoColumna.Width = 130;
            // 
            // ProductoColumna
            // 
            ProductoColumna.Text = "Producto";
            ProductoColumna.Width = 150;
            // 
            // DetalleColumna
            // 
            DetalleColumna.Text = "Detalle";
            DetalleColumna.Width = 200;
            // 
            // CantidadColumna
            // 
            CantidadColumna.Text = "Cantidad";
            CantidadColumna.Width = 110;
            // 
            // ConfirmarOrdenPreparadabtn
            // 
            ConfirmarOrdenPreparadabtn.Location = new Point(859, 313);
            ConfirmarOrdenPreparadabtn.Name = "ConfirmarOrdenPreparadabtn";
            ConfirmarOrdenPreparadabtn.Size = new Size(303, 40);
            ConfirmarOrdenPreparadabtn.TabIndex = 2;
            ConfirmarOrdenPreparadabtn.Text = "Confirmar orden como preparada";
            ConfirmarOrdenPreparadabtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenPreparadabtn.Click += ConfirmarOrdenPreparadabtn_Click;
            // 
            // VolverMenubtn
            // 
            VolverMenubtn.Location = new Point(1014, 372);
            VolverMenubtn.Name = "VolverMenubtn";
            VolverMenubtn.Size = new Size(148, 32);
            VolverMenubtn.TabIndex = 3;
            VolverMenubtn.Text = "Salir";
            VolverMenubtn.UseVisualStyleBackColor = true;
            VolverMenubtn.Click += VolverMenubtn_Click;
            // 
            // SeleccionarOtraOrdenbtn
            // 
            SeleccionarOtraOrdenbtn.Location = new Point(617, 313);
            SeleccionarOtraOrdenbtn.Name = "SeleccionarOtraOrdenbtn";
            SeleccionarOtraOrdenbtn.Size = new Size(231, 40);
            SeleccionarOtraOrdenbtn.TabIndex = 4;
            SeleccionarOtraOrdenbtn.Text = "Seleccionar otra orden";
            SeleccionarOtraOrdenbtn.UseVisualStyleBackColor = true;
            SeleccionarOtraOrdenbtn.Click += SeleccionarOtraOrdenbtn_Click;
            // 
            // EmpaquetarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(SeleccionarOtraOrdenbtn);
            Controls.Add(VolverMenubtn);
            Controls.Add(ConfirmarOrdenPreparadabtn);
            Controls.Add(OrdenesPreparacionlst);
            Controls.Add(Codigogrb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EmpaquetarOrdenesForm";
            Text = "EmpaquetarOrdenesForm";
            Load += EmpaquetarOrdenesForm_Load;
            Codigogrb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Codigogrb;
        private Button btnBuscar;
        private ListView OrdenesParaPrepararlst;
        private ColumnHeader CodigoOrdenColumna;
        private ColumnHeader PrioridadColumna;
        private ListView OrdenesPreparacionlst;
        private ColumnHeader IdProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader DetalleColumna;
        private ColumnHeader CantidadColumna;
        private Button ConfirmarOrdenPreparadabtn;
        private Button VolverMenubtn;
        private Button SeleccionarOtraOrdenbtn;
    }
}