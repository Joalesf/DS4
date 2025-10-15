namespace Laboratorio_12_1
{
    partial class Form1
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_velocidad = new System.Windows.Forms.Label();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.txtbox_velocidad = new System.Windows.Forms.TextBox();
            this.txtbox_tiempo = new System.Windows.Forms.TextBox();
            this.btn_calcularDistancia = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_totalResultado = new System.Windows.Forms.Label();
            this.txtbox_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(151, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 16);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Laboratorio - Móvil";
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_velocidad
            // 
            this.lbl_velocidad.AutoSize = true;
            this.lbl_velocidad.Location = new System.Drawing.Point(33, 62);
            this.lbl_velocidad.Name = "lbl_velocidad";
            this.lbl_velocidad.Size = new System.Drawing.Size(186, 16);
            this.lbl_velocidad.TabIndex = 1;
            this.lbl_velocidad.Text = "Ingrese la velocidad del móvil";
            this.lbl_velocidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Location = new System.Drawing.Point(33, 118);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(211, 16);
            this.lbl_tiempo.TabIndex = 2;
            this.lbl_tiempo.Text = "Ingrese el tiempo de uso del móvil";
            this.lbl_tiempo.Click += new System.EventHandler(this.lbl_tiempo_Click);
            // 
            // txtbox_velocidad
            // 
            this.txtbox_velocidad.Location = new System.Drawing.Point(266, 59);
            this.txtbox_velocidad.Name = "txtbox_velocidad";
            this.txtbox_velocidad.Size = new System.Drawing.Size(100, 22);
            this.txtbox_velocidad.TabIndex = 3;
            this.txtbox_velocidad.TextChanged += new System.EventHandler(this.txtbox_velocidad_TextChanged);
            // 
            // txtbox_tiempo
            // 
            this.txtbox_tiempo.Location = new System.Drawing.Point(266, 112);
            this.txtbox_tiempo.Name = "txtbox_tiempo";
            this.txtbox_tiempo.Size = new System.Drawing.Size(100, 22);
            this.txtbox_tiempo.TabIndex = 4;
            this.txtbox_tiempo.TextChanged += new System.EventHandler(this.txtbox_tiempo_TextChanged);
            // 
            // btn_calcularDistancia
            // 
            this.btn_calcularDistancia.Location = new System.Drawing.Point(36, 176);
            this.btn_calcularDistancia.Name = "btn_calcularDistancia";
            this.btn_calcularDistancia.Size = new System.Drawing.Size(86, 43);
            this.btn_calcularDistancia.TabIndex = 5;
            this.btn_calcularDistancia.Text = "Calcular Distancia";
            this.btn_calcularDistancia.UseVisualStyleBackColor = true;
            this.btn_calcularDistancia.Click += new System.EventHandler(this.btn_calcularDistancia_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(154, 176);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 43);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(272, 176);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 43);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir de Compilación";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_totalResultado
            // 
            this.lbl_totalResultado.AutoSize = true;
            this.lbl_totalResultado.Location = new System.Drawing.Point(104, 253);
            this.lbl_totalResultado.Name = "lbl_totalResultado";
            this.lbl_totalResultado.Size = new System.Drawing.Size(187, 16);
            this.lbl_totalResultado.TabIndex = 8;
            this.lbl_totalResultado.Text = "Resultado de la distancia total";
            this.lbl_totalResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbox_resultado
            // 
            this.txtbox_resultado.Location = new System.Drawing.Point(36, 283);
            this.txtbox_resultado.Name = "txtbox_resultado";
            this.txtbox_resultado.Size = new System.Drawing.Size(330, 22);
            this.txtbox_resultado.TabIndex = 9;
            this.txtbox_resultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 334);
            this.Controls.Add(this.txtbox_resultado);
            this.Controls.Add(this.lbl_totalResultado);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcularDistancia);
            this.Controls.Add(this.txtbox_tiempo);
            this.Controls.Add(this.txtbox_velocidad);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.lbl_velocidad);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_velocidad;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.TextBox txtbox_velocidad;
        private System.Windows.Forms.TextBox txtbox_tiempo;
        private System.Windows.Forms.Button btn_calcularDistancia;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_totalResultado;
        private System.Windows.Forms.TextBox txtbox_resultado;
    }
}

