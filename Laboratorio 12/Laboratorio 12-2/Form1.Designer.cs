namespace Laboratorio_12_2
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
            this.lbl_NotaPromedio = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.btn_promedio = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_notafinal = new System.Windows.Forms.Label();
            this.txt_notaFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_NotaPromedio
            // 
            this.lbl_NotaPromedio.AutoSize = true;
            this.lbl_NotaPromedio.Location = new System.Drawing.Point(145, 9);
            this.lbl_NotaPromedio.Name = "lbl_NotaPromedio";
            this.lbl_NotaPromedio.Size = new System.Drawing.Size(98, 16);
            this.lbl_NotaPromedio.TabIndex = 0;
            this.lbl_NotaPromedio.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(28, 59);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(52, 16);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1 :";
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Location = new System.Drawing.Point(28, 108);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(52, 16);
            this.lbl_nota2.TabIndex = 2;
            this.lbl_nota2.Text = "Nota 2 :";
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.Location = new System.Drawing.Point(28, 159);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(52, 16);
            this.lbl_nota3.TabIndex = 3;
            this.lbl_nota3.Text = "Nota 3 :";
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(102, 53);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(63, 22);
            this.txt_Nota1.TabIndex = 4;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(102, 102);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(63, 22);
            this.txt_Nota2.TabIndex = 5;
            this.txt_Nota2.TextChanged += new System.EventHandler(this.txt_Nota2_TextChanged);
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(102, 153);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(63, 22);
            this.txt_nota3.TabIndex = 6;
            // 
            // btn_promedio
            // 
            this.btn_promedio.Location = new System.Drawing.Point(42, 214);
            this.btn_promedio.Name = "btn_promedio";
            this.btn_promedio.Size = new System.Drawing.Size(87, 36);
            this.btn_promedio.TabIndex = 7;
            this.btn_promedio.Text = "Promedio";
            this.btn_promedio.UseVisualStyleBackColor = true;
            this.btn_promedio.Click += new System.EventHandler(this.btn_promedio_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(168, 214);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 36);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 214);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(79, 36);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_notafinal
            // 
            this.lbl_notafinal.AutoSize = true;
            this.lbl_notafinal.Location = new System.Drawing.Point(145, 269);
            this.lbl_notafinal.Name = "lbl_notafinal";
            this.lbl_notafinal.Size = new System.Drawing.Size(98, 16);
            this.lbl_notafinal.TabIndex = 10;
            this.lbl_notafinal.Text = "Promedio Final";
            // 
            // txt_notaFinal
            // 
            this.txt_notaFinal.Location = new System.Drawing.Point(31, 308);
            this.txt_notaFinal.Name = "txt_notaFinal";
            this.txt_notaFinal.Size = new System.Drawing.Size(327, 22);
            this.txt_notaFinal.TabIndex = 11;
            this.txt_notaFinal.TextChanged += new System.EventHandler(this.txt_notaFinal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 345);
            this.Controls.Add(this.txt_notaFinal);
            this.Controls.Add(this.lbl_notafinal);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_promedio);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.txt_Nota2);
            this.Controls.Add(this.txt_Nota1);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lbl_NotaPromedio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbl_NotaPromedio;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Button btn_promedio;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_notafinal;
        private System.Windows.Forms.TextBox txt_notaFinal;
    }
}

