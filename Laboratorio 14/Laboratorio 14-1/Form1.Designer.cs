namespace Laboratorio_14_1
{
    partial class frmProductos
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
            this.labelId = new System.Windows.Forms.Label();
            this.LabelPrecios = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStocks = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.textb_ID = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(40, 85);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // LabelPrecios
            // 
            this.LabelPrecios.AutoSize = true;
            this.LabelPrecios.Location = new System.Drawing.Point(40, 150);
            this.LabelPrecios.Name = "LabelPrecios";
            this.LabelPrecios.Size = new System.Drawing.Size(46, 16);
            this.LabelPrecios.TabIndex = 1;
            this.LabelPrecios.Text = "Precio";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(43, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(43, 169);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Location = new System.Drawing.Point(205, 150);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(41, 16);
            this.lblStocks.TabIndex = 4;
            this.lblStocks.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(208, 169);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(114, 22);
            this.txtStock.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(205, 85);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Location = new System.Drawing.Point(43, 219);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 42);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackgroundImage = global::Laboratorio_14_1.Properties.Resources.eliminar;
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbEliminar.Location = new System.Drawing.Point(177, 12);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(45, 40);
            this.tsbEliminar.TabIndex = 15;
            this.tsbEliminar.UseVisualStyleBackColor = true;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.BackgroundImage = global::Laboratorio_14_1.Properties.Resources.cancelar;
            this.tsbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCancelar.Location = new System.Drawing.Point(126, 12);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(45, 40);
            this.tsbCancelar.TabIndex = 14;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackgroundImage = global::Laboratorio_14_1.Properties.Resources.nuevo;
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbNuevo.Location = new System.Drawing.Point(18, 12);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(51, 40);
            this.tsbNuevo.TabIndex = 13;
            this.tsbNuevo.UseVisualStyleBackColor = true;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // textb_ID
            // 
            this.textb_ID.AutoSize = true;
            this.textb_ID.Location = new System.Drawing.Point(228, 24);
            this.textb_ID.Name = "textb_ID";
            this.textb_ID.Size = new System.Drawing.Size(92, 16);
            this.textb_ID.TabIndex = 17;
            this.textb_ID.Text = "Buscar por id :";
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(326, 21);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(130, 22);
            this.tstId.TabIndex = 18;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.BackgroundImage = global::Laboratorio_14_1.Properties.Resources.buscar;
            this.tsbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbBuscar.Location = new System.Drawing.Point(462, 12);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(45, 40);
            this.tsbBuscar.TabIndex = 19;
            this.tsbBuscar.UseVisualStyleBackColor = true;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackgroundImage = global::Laboratorio_14_1.Properties.Resources.guardar;
            this.tsbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbGuardar.Location = new System.Drawing.Point(75, 12);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(45, 40);
            this.tsbGuardar.TabIndex = 20;
            this.tsbGuardar.UseVisualStyleBackColor = true;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 314);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.textb_ID);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStocks);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.LabelPrecios);
            this.Controls.Add(this.labelId);
            this.Name = "frmProductos";
            this.Text = "Base de Datos | Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label LabelPrecios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.Label textb_ID;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Button tsbGuardar;
    }
}

