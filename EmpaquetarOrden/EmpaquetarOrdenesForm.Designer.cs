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
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            CodigoOrdenColumna = new ColumnHeader();
            PrioridadColumna = new ColumnHeader();
            btnBuscar = new Button();
            listView2 = new ListView();
            ProductoColumna = new ColumnHeader();
            DetalleColumna = new ColumnHeader();
            CantidadColumna = new ColumnHeader();
            IdProductoColumna = new ColumnHeader();
            ConfirmarOrdenPreparadabtn = new Button();
            VolverMenubtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de preparacion para empaquetar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodigoOrdenColumna, PrioridadColumna });
            listView1.Location = new Point(16, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 331);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(145, 374);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(197, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Ver detalle de la orden";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { IdProductoColumna, ProductoColumna, DetalleColumna, CantidadColumna });
            listView2.Location = new Point(397, 33);
            listView2.Name = "listView2";
            listView2.Size = new Size(765, 258);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
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
            // IdProductoColumna
            // 
            IdProductoColumna.Text = "Id Producto";
            IdProductoColumna.Width = 130;
            // 
            // ConfirmarOrdenPreparadabtn
            // 
            ConfirmarOrdenPreparadabtn.Location = new Point(859, 313);
            ConfirmarOrdenPreparadabtn.Name = "ConfirmarOrdenPreparadabtn";
            ConfirmarOrdenPreparadabtn.Size = new Size(303, 40);
            ConfirmarOrdenPreparadabtn.TabIndex = 2;
            ConfirmarOrdenPreparadabtn.Text = "Confirmar orden como preparada";
            ConfirmarOrdenPreparadabtn.UseVisualStyleBackColor = true;
            // 
            // VolverMenubtn
            // 
            VolverMenubtn.Location = new Point(1014, 372);
            VolverMenubtn.Name = "VolverMenubtn";
            VolverMenubtn.Size = new Size(148, 32);
            VolverMenubtn.TabIndex = 3;
            VolverMenubtn.Text = "Salir";
            VolverMenubtn.UseVisualStyleBackColor = true;
            // 
            // EmpaquetarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(VolverMenubtn);
            Controls.Add(ConfirmarOrdenPreparadabtn);
            Controls.Add(listView2);
            Controls.Add(groupBox1);
            Name = "EmpaquetarOrdenesForm";
            Text = "EmpaquetarOrdenesForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBuscar;
        private ListView listView1;
        private ColumnHeader CodigoOrdenColumna;
        private ColumnHeader PrioridadColumna;
        private ListView listView2;
        private ColumnHeader IdProductoColumna;
        private ColumnHeader ProductoColumna;
        private ColumnHeader DetalleColumna;
        private ColumnHeader CantidadColumna;
        private Button ConfirmarOrdenPreparadabtn;
        private Button VolverMenubtn;
    }
}