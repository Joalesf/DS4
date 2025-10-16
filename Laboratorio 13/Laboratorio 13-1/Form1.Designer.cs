namespace Laboratorio_13_1
{
    partial class Ventana
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
            this.btn_conexion = new System.Windows.Forms.Button();
            this.listBox_Nortwhid = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_conexion
            // 
            this.btn_conexion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_conexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_conexion.Location = new System.Drawing.Point(168, 39);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(190, 73);
            this.btn_conexion.TabIndex = 0;
            this.btn_conexion.Text = "Conectar y Desconectar de Sql Server";
            this.btn_conexion.UseVisualStyleBackColor = false;
            this.btn_conexion.Click += new System.EventHandler(this.btn_conexion_Click);
            // 
            // listBox_Nortwhid
            // 
            this.listBox_Nortwhid.FormattingEnabled = true;
            this.listBox_Nortwhid.ItemHeight = 16;
            this.listBox_Nortwhid.Location = new System.Drawing.Point(137, 175);
            this.listBox_Nortwhid.Name = "listBox_Nortwhid";
            this.listBox_Nortwhid.Size = new System.Drawing.Size(266, 180);
            this.listBox_Nortwhid.TabIndex = 1;
            this.listBox_Nortwhid.SelectedIndexChanged += new System.EventHandler(this.listBox_Nortwhid_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Nortwhid);
            this.Controls.Add(this.btn_conexion);
            this.Name = "Ventana";
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_conexion;
        private System.Windows.Forms.ListBox listBox_Nortwhid;
        private System.Windows.Forms.Button button1;
    }
}

