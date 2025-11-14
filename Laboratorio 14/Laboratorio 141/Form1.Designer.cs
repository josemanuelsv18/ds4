namespace Laboratorio_141
{
    partial class frmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.PictureBox();
            this.tsbGuardar = new System.Windows.Forms.PictureBox();
            this.tsbCancelar = new System.Windows.Forms.PictureBox();
            this.tsbEliminar = new System.Windows.Forms.PictureBox();
            this.tsbBuscar = new System.Windows.Forms.PictureBox();
            this.tsbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(21, 121);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(163, 121);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(114, 20);
            this.txtStock.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 38);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.Location = new System.Drawing.Point(0, 1);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(20, 20);
            this.tsbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbNuevo.TabIndex = 9;
            this.tsbNuevo.TabStop = false;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.Location = new System.Drawing.Point(26, 1);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(20, 20);
            this.tsbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbGuardar.TabIndex = 10;
            this.tsbGuardar.TabStop = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.Location = new System.Drawing.Point(52, 1);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(20, 20);
            this.tsbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbCancelar.TabIndex = 11;
            this.tsbCancelar.TabStop = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.Location = new System.Drawing.Point(78, 1);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(20, 20);
            this.tsbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbEliminar.TabIndex = 12;
            this.tsbEliminar.TabStop = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Location = new System.Drawing.Point(315, 1);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(20, 20);
            this.tsbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbBuscar.TabIndex = 13;
            this.tsbBuscar.TabStop = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbId
            // 
            this.tsbId.Location = new System.Drawing.Point(182, 1);
            this.tsbId.Name = "tsbId";
            this.tsbId.Size = new System.Drawing.Size(127, 20);
            this.tsbId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar por id:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 247);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tsbId);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox tsbNuevo;
        private System.Windows.Forms.PictureBox tsbGuardar;
        private System.Windows.Forms.PictureBox tsbCancelar;
        private System.Windows.Forms.PictureBox tsbEliminar;
        private System.Windows.Forms.PictureBox tsbBuscar;
        private System.Windows.Forms.TextBox tsbId;
        private System.Windows.Forms.Label label5;
    }
}

